using Convey.Persistence.MongoDB;
using GameChanger.Core.Extensions.Mongo;
using GameChanger.Core.GameData;
using GameChanger.Core.MediatR.Handlers.Sector;
using GameChanger.Core.MediatR.Messages.Commands.Buildings;
using GameChanger.Core.MongoDB.Documents;
using GameChanger.Core.Services.Sector;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace GameChanger.Core.MediatR.Handlers.Buildings
{
    public class PerformBuildingConsumptionHandler : BaseSectorHandler,INotificationHandler<PerformBuildingConsumptionCommand>
    {
        public PerformBuildingConsumptionHandler(IMongoRepository<SectorDocument, Guid> sectorDocuments, IMediator mediator, ISectorService sectorService, IMongoRepository<SectorResourcesDocument, Guid> sectorResourcesDocuments, BuildingConfiguration buildingConfiguration) : base(sectorDocuments, mediator, sectorService, sectorResourcesDocuments, buildingConfiguration)
        {
        }

        public async Task Handle(PerformBuildingConsumptionCommand notification, CancellationToken cancellationToken)
        {
            var sector = await _sectorDocuments.GetAsync(notification.SectorId);
            if (sector == null)
                return;

            var building = sector.Buildings.SingleOrDefault(b => b.BuildingType == notification.BuildingType);
            if (building == null)
                return;

            var sectorResources = await _sectorResourcesDocuments.GetAsync(sector.SectorResourcesId);
            if (sectorResources == null)
                return;

            _sectorService.PerformBuildingConsumption(sectorResources, building);
        }
    }
}
