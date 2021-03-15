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
    public class DestroyBuildingCommandHandler : INotificationHandler<DestroyBuildingCommand>
    {
        private readonly IMongoRepository<SectorDocument, Guid> _sectorDocuments;
        public DestroyBuildingCommandHandler(IMongoRepository<SectorDocument, Guid> sectorDocuments)
        {
            _sectorDocuments = sectorDocuments;
        }

        public async Task Handle(DestroyBuildingCommand notification, CancellationToken cancellationToken)
        {
            var sector = await  _sectorDocuments.GetAsync(notification.SectorId);
            if (sector == null)
            {
                return;
            }

            var building = sector.Buildings.SingleOrDefault(b => b.BuildingType == notification.BuildingType);

            if(building == null)
            {
                return;
            }

            if(building.CurrentLvl == 1)
            {
                sector.Buildings.Remove(building);
            }
            else
            {
                building.CurrentLvl--;
            }
            
            await _sectorDocuments.UpdateAsync(sector);
        }
    }
}
