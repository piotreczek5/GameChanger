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

namespace GameChanger.Core.MediatR.Handlers.Player
{
    public class GenerateSectorHandler : INotificationHandler<GenerateSectorCommand>
    {
        private readonly IMongoRepository<PlayerDocument, Guid> _playerDocuments;
        private readonly IMongoRepository<SectorDocument, Guid> _sectorDocuments;
        private readonly MapConfiguration _mapConfiguration;
        public GenerateSectorHandler(
            IMongoRepository<PlayerDocument, Guid> playerDocuments,
            IMongoRepository<SectorDocument, Guid> sectorDocuments,
            MapConfiguration mapConfiguration,
            BuildingConfiguration buildingConfiguration)
        {
            _playerDocuments = playerDocuments;
            _sectorDocuments = sectorDocuments;
            _mapConfiguration = mapConfiguration;
        }

        public async Task Handle(GenerateSectorCommand notification, CancellationToken cancellationToken)
        {
            var player = await  _playerDocuments.GetAsync(notification.PlayerId);
            
            if(!player.WasInitialized && !player.Sectors.Any())
            {
                var landOfCity = _mapConfiguration.Lands.Where(l => l.Cities.Any(c => c.Name == notification.CityName)).SingleOrDefault();
                var sectorDocument = new SectorDocument
                {
                    City = notification.CityName,
                    PlayerOwner = player.Id,
                    Land = landOfCity?.Name      
                };
                await _sectorDocuments.AddAsync(sectorDocument);
                player.Sectors.Add(sectorDocument.Id);
                player.CurrentSector = sectorDocument.Id;
            }

            player.WasInitialized = true;
            await _playerDocuments.UpdateAsync(player);
        }
    }
}
