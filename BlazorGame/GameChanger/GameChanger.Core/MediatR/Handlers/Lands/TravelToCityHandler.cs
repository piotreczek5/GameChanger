using Convey.Persistence.MongoDB;
using GameChanger.Core.EventScheduler;
using GameChanger.Core.Extensions;
using GameChanger.Core.GameData;
using GameChanger.Core.MediatR.Handlers.Sector;
using GameChanger.Core.MediatR.Messages.Commands;
using GameChanger.Core.MediatR.Messages.Commands.Sector;
using GameChanger.Core.MongoDB.Builders;
using GameChanger.Core.MongoDB.Documents;
using GameChanger.Core.MongoDB.Documents.Factories;
using GameChanger.Core.MongoDB.Documents.Player;
using GameChanger.Core.MongoDB.Updaters;
using GameChanger.Core.Services.Map;
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
    public class TravelToCityHandler : BaseSectorHandler, INotificationHandler<TravelToCityCommand>
    {
        IMongoRepository<PlayerDocument, Guid> _playerDocuments;
        private readonly IPlayerStatusFactory _playerStatusFactory;
        private readonly IDistanceService _distanceService;
        public TravelToCityHandler(IMongoRepository<SectorDocument, Guid> sectorDocuments, IMediator mediator, ISectorService sectorService, IMongoRepository<SectorResourcesDocument, Guid> sectorResourcesDocuments, BuildingConfiguration buildingConfiguration, IEventScheduler eventScheduler, IMongoRepository<PlayerDocument, Guid> playerDocuments, IPlayerStatusFactory playerStatusFactory, IDistanceService distanceService) : base(sectorDocuments, mediator, sectorService, sectorResourcesDocuments, buildingConfiguration, eventScheduler)
        {
            _playerDocuments = playerDocuments;
            _playerStatusFactory = playerStatusFactory;
            _distanceService = distanceService;
        }

        public async Task Handle(TravelToCityCommand notification, CancellationToken cancellationToken)
        {
            if(!notification.PlayerId.HasValue || !notification.DestinationCityCode.HasValue || !notification.SourceCityCode.HasValue)
                return;

            var player = await _playerDocuments.GetAsync(notification.PlayerId.Value);
            
            if(player.Status.Code != PlayerStatuses.IDLE_WITH_SECTOR && player.Status.Code != PlayerStatuses.IDLE_WITHOUT_SECTOR)
                return;

            var arbitraryDelay = _distanceService.Calculate();

            var travelingPlayerStatus = _playerStatusFactory.Create(
                PlayerStatuses.TRAVELING, 
                travelPlannedArrival: DateTime.UtcNow.Add(arbitraryDelay),
                sourceCityCode : notification.SourceCityCode,
                destinationCityCode: notification.DestinationCityCode
                );

            var playerUpdateStatusFactory = PlayerUpdaterFactory.SetPlayerStatus(travelingPlayerStatus);
            
            var playerFilter = PlayerFilterFactory.GetPlayerById(notification.PlayerId.Value);
            await _playerDocuments.Collection.UpdateOneAsync(playerFilter, playerUpdateStatusFactory);

            _eventScheduler.ScheduleEvent(arbitraryDelay, new ChangeCityCommand() { PlayerId = notification.PlayerId, CityCode = notification.DestinationCityCode });
        }
    }
}
