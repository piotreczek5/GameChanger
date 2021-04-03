using Convey.Persistence.MongoDB;
using GameChanger.Core.GameData;
using GameChanger.Core.MediatR.Messages.Commands.Buildings;
using GameChanger.Core.MongoDB.Documents;
using GameChanger.Core.MongoDB.Documents.Buildings;
using GameChanger.Core.MongoDB.Factories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace GameChanger.Core.MediatR.Handlers.Buildings
{
    public class FixBuildingHandler : INotificationHandler<FixBuildingCommand>
    {
        private readonly IMongoRepository<SectorDocument, Guid> _sectorDocuments;
        private readonly IBuildingStatusFactory _buildingStatusFactory;
        public FixBuildingHandler(IMongoRepository<SectorDocument, Guid> sectorDocuments, IBuildingStatusFactory buildingStatusFactory)
        {
            _sectorDocuments = sectorDocuments;
            _buildingStatusFactory = buildingStatusFactory;
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

            building.Status = _buildingStatusFactory.Create(BuildingStatuses.BUILT);
            
            await _sectorDocuments.UpdateAsync(sector);
        }
    }
}
