using Convey.Persistence.MongoDB;
using GameChanger.Core.Extensions;
using GameChanger.Core.GameData;
using GameChanger.Core.MediatR.Handlers.Sector;
using GameChanger.Core.MediatR.Messages.Commands.Sector;
using GameChanger.Core.MongoDB.Builders;
using GameChanger.Core.MongoDB.Documents;
using GameChanger.Core.MongoDB.Documents.Factories;
using GameChanger.Core.MongoDB.Documents.Player;
using GameChanger.Core.MongoDB.Updaters;
using GameChanger.Core.Services.Sector;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameChanger.Core.MediatR.Handlers
{
    public class ChangeCityHandler : BaseSectorHandler, INotificationHandler<ChangeCityCommand>
    {
        IMongoRepository<PlayerDocument, Guid> _playerDocuments;
        private readonly IPlayerStatusFactory _playerStatusFactory;
        private readonly MapConfiguration _mapConfiguration;
        public ChangeCityHandler(IMongoRepository<SectorDocument, Guid> sectorDocuments, IMediator mediator, ISectorService sectorService, IMongoRepository<SectorResourcesDocument, Guid> sectorResourcesDocuments, BuildingConfiguration buildingConfiguration, IMongoRepository<PlayerDocument, Guid> playerDocuments, IPlayerStatusFactory playerStatusFactory, MapConfiguration mapConfiguration) : base(sectorDocuments, mediator, sectorService, sectorResourcesDocuments, buildingConfiguration)
        {
            _playerDocuments = playerDocuments;
            _playerStatusFactory = playerStatusFactory;
            _mapConfiguration = mapConfiguration;
        }

        public async Task Handle(ChangeCityCommand notification, CancellationToken cancellationToken)
        {
            if(!notification.PlayerId.HasValue || !notification.CityCode.HasValue)
                return;

            var player = await _playerDocuments.GetAsync(notification.PlayerId.Value);
            if (player == null)
                return;

            var landInfo = _mapConfiguration.GetLandByCityCode(notification.CityCode.Value);
            var allSectors = await _sectorDocuments.FindAsync(s => player.Sectors.Contains(s.Id));
            var citySectorOwnedByPlayer = allSectors.SingleOrDefault(s => s.CityCode == notification.CityCode);
            
            PlayerStatus playerStatus = null;
            
            if (citySectorOwnedByPlayer != null)
            {
                var sectorDetails = new SectorDetails() { SectorId = citySectorOwnedByPlayer.Id, ArrivedAt = DateTime.UtcNow };
                playerStatus =
                _playerStatusFactory.Create(
                    PlayerStatuses.IDLE_WITH_SECTOR,
                    sectorDetails: sectorDetails,
                    landDetails: new LandDetails() { CityCode = notification.CityCode.Value, LandCode = landInfo.Code });
            }
            else
            {
                playerStatus =
               _playerStatusFactory.Create(
                   PlayerStatuses.IDLE_WITHOUT_SECTOR,
                   landDetails: new LandDetails() { CityCode = notification.CityCode.Value, LandCode = landInfo.Code });
            }

            var playerUpdateStatusFactory = PlayerUpdaterFactory.SetPlayerStatus(playerStatus);
            var playerFilter = PlayerFilterFactory.GetPlayerById(notification.PlayerId.Value);

            await _playerDocuments.Collection.UpdateOneAsync(playerFilter, playerUpdateStatusFactory);
        }
    }
}
