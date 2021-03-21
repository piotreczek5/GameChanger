using Convey.Persistence.MongoDB;
using GameChanger.Core.GameData;
using GameChanger.Core.MediatR.Handlers.Sector;
using GameChanger.Core.MediatR.Messages.Commands.Buildings;
using GameChanger.Core.MongoDB.Builders;
using GameChanger.Core.MongoDB.Documents;
using GameChanger.Core.MongoDB.Updaters;
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
    public class DestroyBuildingCommandHandler : BaseSectorHandler,INotificationHandler<DestroyBuildingCommand>
    {
        public DestroyBuildingCommandHandler(IMongoRepository<SectorDocument, Guid> sectorDocuments, IMediator mediator, ISectorService sectorService, IMongoRepository<SectorResourcesDocument, Guid> sectorResourcesDocuments, Channel<INotification> channel, BuildingConfiguration buildingConfiguration) : base(sectorDocuments, mediator, sectorService, sectorResourcesDocuments, channel, buildingConfiguration)
        {
        }

        public async Task Handle(DestroyBuildingCommand notification, CancellationToken cancellationToken)
        {
            if (!notification.SectorId.HasValue)
                return;

            var sector = await _sectorDocuments.GetAsync(notification.SectorId.Value);
            if (sector == null)
                return;

            var building = sector.Buildings.SingleOrDefault(b => b.BuildingType == notification.BuildingType && b.Status.Code != BuildingStatuses.IDLE);
            if (building == null)
                return;

            var findBuildingFilter = SectorFilterFactory.GetBuildingFromSectorByType(notification.SectorId.Value, notification.BuildingType);
            
            if (building.CurrentLvl > 0)
            {                
                var decreseLvlUpdate = SectorUpdaterFactory.DecreaseBuildingLvl();
                await _sectorDocuments.Collection.UpdateOneAsync(findBuildingFilter,decreseLvlUpdate);
            }     
            
            if(building.CurrentLvl - 1 == 0)
            {
                await _channel.Writer.WriteAsync(new SetBuildingStatusCommand()
                {
                    BuildingStatus = BuildingStatuses.NOT_BUILT,
                    BuildingType = notification.BuildingType,
                    SectorId = notification.SectorId
                });
            }
        }
    }
}
