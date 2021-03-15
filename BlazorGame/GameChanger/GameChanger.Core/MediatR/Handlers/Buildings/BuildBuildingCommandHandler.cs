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
    public class BuildBuildingCommandHandler : INotificationHandler<BuildBuildingCommand>
    {
        private readonly IMongoRepository<SectorDocument, Guid> _sectorDocuments;
        private readonly BuildingConfiguration _buildingConfiguration;
        public BuildBuildingCommandHandler(IMongoRepository<SectorDocument, Guid> sectorDocuments, BuildingConfiguration buildingConfiguration)
        {
            _sectorDocuments = sectorDocuments;
            _buildingConfiguration = buildingConfiguration;
        }

        public async Task Handle(BuildBuildingCommand notification, CancellationToken cancellationToken)
        {
            var sector = await  _sectorDocuments.GetAsync(notification.SectorId);
            
            if(sector!= null && !sector.Buildings.Any(b => b.BuildingType == notification.BuildingType))
            {
                var buildingTemplate = _buildingConfiguration.GetBuildingByType(notification.BuildingType,1);
                sector.Buildings.Add(new BuildingDocument(buildingTemplate));
            }
            
            await _sectorDocuments.UpdateAsync(sector);
        }
    }
}
