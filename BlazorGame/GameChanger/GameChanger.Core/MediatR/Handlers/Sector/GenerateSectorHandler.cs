using Convey.Persistence.MongoDB;
using GameChanger.Core.GameData;
using GameChanger.Core.MongoDB.Documents;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using GameChanger.Core.MediatR.Messages;
using GameChanger.Core.MediatR.Handlers.Sector;
using GameChanger.Core.Services.Sector;
using System.Threading.Channels;
using GameChanger.Core.Services;
using GameChanger.Core.MediatR.Messages.Commands.Sector;

namespace GameChanger.Core.MediatR.Handlers.Player
{
    public class GenerateSectorHandler : BaseSectorHandler, INotificationHandler<GenerateSectorCommand>
    {
        private readonly IMongoRepository<PlayerDocument, Guid> _playerDocuments;
        private readonly MapConfiguration _mapConfiguration;
        private readonly IGameNotificationProcessor _gameNotificationProcessor;

        public GenerateSectorHandler(IMongoRepository<SectorDocument, Guid> sectorDocuments, IMediator mediator, ISectorService sectorService, IMongoRepository<SectorResourcesDocument, Guid> sectorResourcesDocuments, BuildingConfiguration buildingConfiguration, IMongoRepository<PlayerDocument, Guid> playerDocuments, MapConfiguration mapConfiguration, IGameNotificationProcessor gameNotificationProcessor) : base(sectorDocuments, mediator, sectorService, sectorResourcesDocuments, buildingConfiguration)
        {
            _playerDocuments = playerDocuments;
            _mapConfiguration = mapConfiguration;
            _gameNotificationProcessor = gameNotificationProcessor;
        }

        public async Task Handle(GenerateSectorCommand notification, CancellationToken cancellationToken)
        {
            if (!notification.PlayerId.HasValue)
                return;

            var player = await  _playerDocuments.GetAsync(notification.PlayerId.Value);

            if (player == null)
                return;

            var allPlayerCities = (await _sectorDocuments.FindAsync(s => player.Sectors.Contains(s.Id))).Select(s => s.CityCode).ToList();
            if (allPlayerCities.Contains(notification.CityCode.Value))
            {
                return;
            }
            var landOfCity = _mapConfiguration.Lands.Where(l => l.Cities.Any(c => c.Code == notification.CityCode)).SingleOrDefault();

            var sectorResources = new SectorResourcesDocument();

            sectorResources.CurrentResources.ForEach(r => r.Amount += 100);

            await _sectorResourcesDocuments.AddAsync(sectorResources);

            var sectorDocument = new SectorDocument
            {                    
                CityCode = notification.CityCode.Value,
                PlayerOwner = player.Id,
                LandCode = landOfCity?.Code,
                SectorResourcesId = sectorResources.Id                
            };

            await _sectorDocuments.AddAsync(sectorDocument);
            player.Sectors.Add(sectorDocument.Id);

            sectorResources.SectorId = sectorDocument.Id;
            await _sectorResourcesDocuments.UpdateAsync(sectorResources);

            await _playerDocuments.UpdateAsync(player);

            if (player.Sectors.Count == 1)
            {
                await _gameNotificationProcessor.ProcessAsync(new ChangeSectorCommand() { PlayerId = player.Id, SectorId = sectorDocument.Id });
            }

        }
    }
}
