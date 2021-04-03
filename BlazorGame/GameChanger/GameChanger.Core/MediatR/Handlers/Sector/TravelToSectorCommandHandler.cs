using Convey.Persistence.MongoDB;
using GameChanger.Core.EventScheduler;
using GameChanger.Core.GameData;
using GameChanger.Core.MediatR.Messages.Commands.Sector;
using GameChanger.Core.MongoDB.Builders;
using GameChanger.Core.MongoDB.Documents;
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
    public class TravelToSectorCommandHandler : BaseSectorHandler, INotificationHandler<TravelSectorCommand>
    {
        IMongoRepository<PlayerDocument, Guid> _playerDocuments;

        public TravelToSectorCommandHandler(IMongoRepository<SectorDocument, Guid> sectorDocuments, IMediator mediator, ISectorService sectorService, IMongoRepository<SectorResourcesDocument, Guid> sectorResourcesDocuments, BuildingConfiguration buildingConfiguration, IEventScheduler eventScheduler, IMongoRepository<PlayerDocument, Guid> playerDocuments) : base(sectorDocuments, mediator, sectorService, sectorResourcesDocuments, buildingConfiguration, eventScheduler)
        {
            _playerDocuments = playerDocuments;
        }

        public async Task Handle(TravelSectorCommand notification, CancellationToken cancellationToken)
        {
            if(!notification.PlayerId.HasValue || !notification.SectorId.HasValue)
                return;
            var sector = await _sectorDocuments.GetAsync(notification.SectorId.Value);
            
            if(sector == null)
                return;
            
            var player = await _playerDocuments.GetAsync(notification.PlayerId.Value);
            
            if(player.Status.Code != PlayerStatuses.IDLE)
                return;

            var travelingPlayerStatus = new TravelingStatus();
            var arbitraryDelay = TimeSpan.FromSeconds(5);
            travelingPlayerStatus.PlannedArrival = DateTime.UtcNow.Add(arbitraryDelay);

            var playerUpdateStatusFactory = PlayerUpdaterFactory.SetPlayerStatus(travelingPlayerStatus);
            
            var playerFilter = PlayerFilterFactory.GetPlayerById(notification.PlayerId.Value);
            await _playerDocuments.Collection.UpdateOneAsync(playerFilter, playerUpdateStatusFactory);

            _eventScheduler.ScheduleEvent(arbitraryDelay, new ChangeSectorCommand() { PlayerId = notification.PlayerId, SectorId = notification.SectorId });
        }
    }
}
