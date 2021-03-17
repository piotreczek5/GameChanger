using Convey.Persistence.MongoDB;
using GameChanger.Core.GameData;
using GameChanger.Core.MediatR.Handlers.Sector;
using GameChanger.Core.MediatR.Lockers;
using GameChanger.Core.MediatR.Messages.Commands.Buildings;
using GameChanger.Core.MongoDB.Documents;
using GameChanger.Core.Services.Sector;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameChanger.Core.MediatR.Handlers.Buildings
{
    public class DecreaseResourceSupplyCommandHandler : BaseSectorHandler,INotificationHandler<DecreaseResourceSupplyCommand>
    {
        public DecreaseResourceSupplyCommandHandler(IMongoRepository<SectorDocument, Guid> sectorDocuments, IMediator mediator, ISectorService sectorService, IMongoRepository<SectorResourcesDocument, Guid> sectorResourcesDocuments) : base(sectorDocuments, mediator, sectorService, sectorResourcesDocuments)
        {
        }

        public async Task Handle(DecreaseResourceSupplyCommand notification, CancellationToken cancellationToken)
        {
            lock(ResourceLocker.Lock)
            {
                var sectorResources = _sectorResourcesDocuments.GetAsync(notification.SectorResourcesId).Result;
                if (sectorResources == null)
                    return;

                foreach(var resource in notification.Resources)
                {
                    var sectorResource = sectorResources.CurrentResources.SingleOrDefault(res => res.Resource == resource.Resource);
                    if (sectorResource == null)
                        continue;

                    var finalAmount = sectorResource.Amount - resource.Amount < 0 ? 0 : resource.Amount;
                    sectorResource.Amount -= finalAmount;
                }

                _sectorResourcesDocuments.UpdateAsync(sectorResources).ConfigureAwait(false);
            }
           
        }
    }
}
