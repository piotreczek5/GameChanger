using Convey.Persistence.MongoDB;
using GameChanger.Core.GameData;
using GameChanger.Core.MediatR.Messages.Commands.Buildings;
using GameChanger.Core.MongoDB.Documents;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameChanger.Core.MediatR.Handlers.Buildings
{
    public class FixBuildingCommandHandler : INotificationHandler<FixBuildingCommand>
    {
        private readonly IMongoRepository<SectorDocument, Guid> _sectorDocuments;
        private readonly BuildingConfiguration _buildingConfiguration;
        public FixBuildingCommandHandler(IMongoRepository<SectorDocument, Guid> sectorDocuments, BuildingConfiguration buildingConfiguration)
        {
            _sectorDocuments = sectorDocuments;
            _buildingConfiguration = buildingConfiguration;
        }

        public async Task Handle(FixBuildingCommand notification, CancellationToken cancellationToken)
        {
            if (!notification.SectorId.HasValue)
                return;

            var sector = await _sectorDocuments.GetAsync(notification.SectorId.Value);
            if (sector == null)
            {
                return;
            }

            var building = sector.Buildings.SingleOrDefault(b => b.BuildingType == notification.BuildingType);

            if (building == null)
            {
                return;
            }

            building.Status = new BuildingStatus() { Code = BuildingStatuses.BUILT, TimeToFix = null};
            
            await _sectorDocuments.UpdateAsync(sector);
        }
    }
}
