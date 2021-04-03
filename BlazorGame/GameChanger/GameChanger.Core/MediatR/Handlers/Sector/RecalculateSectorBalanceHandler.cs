using Convey.Persistence.MongoDB;
using GameChanger.Core.GameData;
using GameChanger.Core.MediatR.Messages.Commands.Sector;
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

namespace GameChanger.Core.MediatR.Handlers.Sector
{
    public class RecalculateSectorBalanceHandler : BaseSectorHandler,INotificationHandler<RecalculateSectorBalanceCommand>
    {
        public RecalculateSectorBalanceHandler(IMongoRepository<SectorDocument, Guid> sectorDocuments, IMediator mediator, ISectorService sectorService, IMongoRepository<SectorResourcesDocument, Guid> sectorResourcesDocuments, BuildingConfiguration buildingConfiguration) : base(sectorDocuments, mediator, sectorService, sectorResourcesDocuments, buildingConfiguration)
        {
        }

        public async Task Handle(RecalculateSectorBalanceCommand notification, CancellationToken cancellationToken)
        {
            if (!notification.SectorId.HasValue)
                return;

            var sector = await _sectorDocuments.GetAsync(notification.SectorId.Value);
            if (sector == null)
                return;

            var sectorResources = await _sectorResourcesDocuments.GetAsync(sector.SectorResourcesId);
            if (sector == null)
                return;

            sectorResources = _sectorService.RecalculateSectorResourceBalances(sector, sectorResources);   
            
            await _sectorResourcesDocuments.UpdateAsync(sectorResources);
        }
    }
}
