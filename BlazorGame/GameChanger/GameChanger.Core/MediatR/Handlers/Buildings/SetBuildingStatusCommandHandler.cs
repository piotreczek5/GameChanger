using Convey.Persistence.MongoDB;
using GameChanger.Core.Extensions.Mongo;
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
    public class SetBuildingStatusCommandHandler : INotificationHandler<SetBuildingStatusCommand>
    {
        private readonly IMongoRepository<SectorDocument, Guid> _sectorDocuments;
        public SetBuildingStatusCommandHandler(IMongoRepository<SectorDocument, Guid> sectorDocuments, BuildingConfiguration buildingConfiguration)
        {
            _sectorDocuments = sectorDocuments;
        }

        public async Task Handle(SetBuildingStatusCommand notification, CancellationToken cancellationToken)
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

            building.Status.Code = notification.BuildingStatus;
            
            await _sectorDocuments.UpdateAsync(sector);
        }
    }
}
