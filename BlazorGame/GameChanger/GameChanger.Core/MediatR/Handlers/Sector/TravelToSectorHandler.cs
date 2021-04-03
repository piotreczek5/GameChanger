using Convey.Persistence.MongoDB;
using GameChanger.Core.EventScheduler;
using GameChanger.Core.GameData;
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

namespace GameChanger.Core.MediatR.Handlers.Sector
{
    public class TravelToSectorHandler : BaseSectorHandler, INotificationHandler<TravelSectorCommand>
    {
        IMongoRepository<PlayerDocument, Guid> _playerDocuments;
        private readonly IPlayerStatusFactory _playerStatusFactory;

        public TravelToSectorHandler(IMongoRepository<SectorDocument, Guid> sectorDocuments, IMediator mediator, ISectorService sectorService, IMongoRepository<SectorResourcesDocument, Guid> sectorResourcesDocuments, BuildingConfiguration buildingConfiguration, IEventScheduler eventScheduler, IMongoRepository<PlayerDocument, Guid> playerDocuments, IPlayerStatusFactory playerStatusFactory) : base(sectorDocuments, mediator, sectorService, sectorResourcesDocuments, buildingConfiguration, eventScheduler)
        {
            _playerDocuments = playerDocuments;
            _playerStatusFactory = playerStatusFactory;
        }

        public async Task Handle(TravelSectorCommand notification, CancellationToken cancellationToken)
        {
            if(!notification.PlayerId.HasValue || !notification.DestinationSectorId.HasValue)
                return;

            var sector = await _sectorDocuments.GetAsync(notification.DestinationSectorId.Value);
            
            if(sector == null)
                return;
            
            var player = await _playerDocuments.GetAsync(notification.PlayerId.Value);
            
            if(player.Status.Code != PlayerStatuses.IDLE_WITH_SECTOR)
                return;


            var arbitraryDelay = TimeSpan.FromSeconds(5);
            var travelingPlayerStatus = _playerStatusFactory.Create(
                PlayerStatuses.TRAVELING, 
                travelPlannedArrival: DateTime.UtcNow.Add(arbitraryDelay),
                sourceSectorId: notification.SourceSectorId,
                destinationSectorId: notification.DestinationSectorId);

            var playerUpdateStatusFactory = PlayerUpdaterFactory.SetPlayerStatus(travelingPlayerStatus);
            
            var playerFilter = PlayerFilterFactory.GetPlayerById(notification.PlayerId.Value);
            await _playerDocuments.Collection.UpdateOneAsync(playerFilter, playerUpdateStatusFactory);

            _eventScheduler.ScheduleEvent(arbitraryDelay, new ChangeSectorCommand() { PlayerId = notification.PlayerId, SectorId = notification.DestinationSectorId });
        }
    }
}
