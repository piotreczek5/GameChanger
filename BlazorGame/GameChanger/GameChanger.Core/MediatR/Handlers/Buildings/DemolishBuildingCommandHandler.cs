using Convey.Persistence.MongoDB;
using GameChanger.Core.EventScheduler;
using GameChanger.Core.GameData;
using GameChanger.Core.MediatR.Handlers.Sector;
using GameChanger.Core.MediatR.Messages.Commands.Buildings;
using GameChanger.Core.MongoDB.Builders;
using GameChanger.Core.MongoDB.Documents;
using GameChanger.Core.MongoDB.Updaters;
using GameChanger.Core.Services;
using GameChanger.Core.Services.Sector;
using MediatR;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace GameChanger.Core.MediatR.Handlers.Buildings
{
    public class DemolishBuildingCommandHandler : BaseSectorHandler,INotificationHandler<DemolishBuildingCommand>
    {
        private IGameNotificationProcessor _gameNotificationProcessor;
        private IEventScheduler _eventScheduler;

        public DemolishBuildingCommandHandler(IMongoRepository<SectorDocument, Guid> sectorDocuments, IMediator mediator, ISectorService sectorService, IMongoRepository<SectorResourcesDocument, Guid> sectorResourcesDocuments, BuildingConfiguration buildingConfiguration, IGameNotificationProcessor gameNotificationProcessor, IEventScheduler eventScheduler) : base(sectorDocuments, mediator, sectorService, sectorResourcesDocuments, buildingConfiguration)
        {
            _gameNotificationProcessor = gameNotificationProcessor;
            _eventScheduler = eventScheduler;
        }

        public async Task Handle(DemolishBuildingCommand notification, CancellationToken cancellationToken)
        {
            if (!notification.SectorId.HasValue)
                return;

            var sector = await _sectorDocuments.GetAsync(notification.SectorId.Value);
            if (sector == null)
                return;

            var building = sector.Buildings.SingleOrDefault(b => b.BuildingType == notification.BuildingType);
            if (building == null)
                return;

            var findBuildingFilter = SectorFilterFactory.GetBuildingFromSectorByType(notification.SectorId.Value, notification.BuildingType);
            var buildingTemplate = _buildingConfiguration.GetBuildingByType(notification.BuildingType, building.CurrentLvl);

            if (buildingTemplate == null)
                return;

            var destroyDelay = buildingTemplate.DestroyTime.Value;
            
            if (building.CurrentLvl > 1)
            {                
                var decreseLvlUpdate = SectorUpdaterFactory.DecreaseBuildingLvl();
                
                await _sectorDocuments.Collection.UpdateOneAsync(findBuildingFilter,decreseLvlUpdate);

                _eventScheduler.ScheduleEvent(destroyDelay, new SetBuildingStatusCommand()
                {
                    BuildingStatus = BuildingStatuses.BUILT,
                    BuildingType = notification.BuildingType,
                    SectorId = notification.SectorId
                });
            }
            else
            if(building.CurrentLvl == 1)
            {
                _eventScheduler.ScheduleEvent(destroyDelay, new RemoveBuildingFromSectorCommand()
                {
                    BuildingType = notification.BuildingType,
                    SectorId = notification.SectorId
                });
            }

            var destroyingBuildingStatus = new BuildingStatus() { Code = BuildingStatuses.DESTROYING, TimeToDestroy = DateTime.UtcNow.Add(destroyDelay) };

            var setStatusDestroying = SectorUpdaterFactory.SetBuildingStatus(destroyingBuildingStatus);
            await _sectorDocuments.Collection.UpdateOneAsync(findBuildingFilter, setStatusDestroying);
        }
    }
}
