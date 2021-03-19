using Convey.Persistence.MongoDB;
using GameChanger.Core.GameData;
using GameChanger.Core.MediatR.Messages.Commands.Buildings;
using GameChanger.Core.MongoDB.Builders;
using GameChanger.Core.MongoDB.Documents;
using GameChanger.Core.MongoDB.Updaters;
using MediatR;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameChanger.Core.MediatR.Handlers.Buildings
{
    public class DestroyBuildingCommandHandler : INotificationHandler<DestroyBuildingCommand>
    {
        private readonly IMongoRepository<SectorDocument, Guid> _sectorDocuments;
        public DestroyBuildingCommandHandler(IMongoRepository<SectorDocument, Guid> sectorDocuments)
        {
            _sectorDocuments = sectorDocuments;
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

            var findBuildingFilter = SectorBuilderFactory.GetBuildingFromSectorByType(notification.SectorId.Value, notification.BuildingType);
            if (building.CurrentLvl == 1)
            {
                var removeBuilding = SectorUpdaterFactory.RemoveBuilding(notification.BuildingType);
                await _sectorDocuments.Collection.UpdateOneAsync(findBuildingFilter, removeBuilding);
            }
            else
            {                
                var decreseLvlUpdate = SectorUpdaterFactory.DecreaseBuildingLvl();
                await _sectorDocuments.Collection.UpdateOneAsync(findBuildingFilter,decreseLvlUpdate);
            }           
        }
    }
}
