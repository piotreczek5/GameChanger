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
    public class UpgradeBuildingCommandHandler : INotificationHandler<UpgradeBuildingCommand>
    {
        private readonly IMongoRepository<SectorDocument, Guid> _sectorDocuments;
        private readonly BuildingConfiguration _buildingConfiguration;
        public UpgradeBuildingCommandHandler(IMongoRepository<SectorDocument, Guid> sectorDocuments, BuildingConfiguration buildingConfiguration)
        {
            _sectorDocuments = sectorDocuments;
            _buildingConfiguration = buildingConfiguration;
        }

        public async Task Handle(UpgradeBuildingCommand notification, CancellationToken cancellationToken)
        {
            var sector = await _sectorDocuments.GetAsync(notification.SectorId);
            if (sector == null)
            {
                return;
            }

            var building = sector.Buildings.SingleOrDefault(b => b.BuildingType == notification.BuildingType);
            
            if (building == null)
            {
                return;
            }

            var buildingConfiguration = _buildingConfiguration.GetBuildingByType(notification.BuildingType, building.CurrentLvl + 1);
            if(buildingConfiguration == null)
            {
                return;
            }

            building.CurrentLvl++;
            
            await _sectorDocuments.UpdateAsync(sector);
        }
    }
}
