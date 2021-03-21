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

namespace GameChanger.Core.MediatR.Handlers.Player
{
    public class GenerateSectorHandler : BaseSectorHandler, INotificationHandler<GenerateSectorCommand>
    {
        private readonly IMongoRepository<PlayerDocument, Guid> _playerDocuments;
        private readonly MapConfiguration _mapConfiguration;

        public GenerateSectorHandler(IMongoRepository<SectorDocument, Guid> sectorDocuments, IMediator mediator, ISectorService sectorService, IMongoRepository<SectorResourcesDocument, Guid> sectorResourcesDocuments, Channel<INotification> channel, BuildingConfiguration buildingConfiguration, IMongoRepository<PlayerDocument, Guid> playerDocuments, MapConfiguration mapConfiguration) : base(sectorDocuments, mediator, sectorService, sectorResourcesDocuments, channel, buildingConfiguration)
        {
            _playerDocuments = playerDocuments;
            _mapConfiguration = mapConfiguration;
        }

        public async Task Handle(GenerateSectorCommand notification, CancellationToken cancellationToken)
        {
            var player = await  _playerDocuments.GetAsync(notification.PlayerId);
            
            if(!player.WasInitialized && !player.Sectors.Any())
            {
                var landOfCity = _mapConfiguration.Lands.Where(l => l.Cities.Any(c => c.Name == notification.CityName)).SingleOrDefault();
                var sectorResources = new SectorResourcesDocument();

                sectorResources.CurrentResources.ForEach(r => r.Amount += 100);

                await _sectorResourcesDocuments.AddAsync(sectorResources);

                var zeroLvlBuildings = _buildingConfiguration
                    .Buildings
                    .Where(b => b.Lvl == 1)
                    .Select(b => new BuildingDocument(b))
                    .ToList();

                zeroLvlBuildings.ForEach(b => {
                    b.CurrentLvl = 0;
                    b.Status = new BuildingStatus() { Code = BuildingStatuses.NOT_BUILT };
                    });

                var sectorDocument = new SectorDocument
                {
                    City = notification.CityName,
                    PlayerOwner = player.Id,
                    Land = landOfCity?.Name,
                    SectorResourcesId = sectorResources.Id,
                    Buildings = zeroLvlBuildings
                };

                await _sectorDocuments.AddAsync(sectorDocument);
                player.Sectors.Add(sectorDocument.Id);
                sectorResources.SectorId = sectorDocument.Id;
                await _sectorResourcesDocuments.UpdateAsync(sectorResources);
                player.CurrentSector = sectorDocument.Id;
            }

            player.WasInitialized = true;
            await _playerDocuments.UpdateAsync(player);
        }
    }
}
