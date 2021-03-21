using Convey.Persistence.MongoDB;
using GameChanger.Core.GameData;
using GameChanger.Core.MediatR.Handlers.Sector;
using GameChanger.Core.MediatR.Lockers;
using GameChanger.Core.MediatR.Messages.Commands.Buildings;
using GameChanger.Core.MongoDB.Documents;
using GameChanger.Core.Services.Sector;
using MediatR;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace GameChanger.Core.MediatR.Handlers.Buildings
{
    public class ChangeResourceSupplyCommandHandler : BaseSectorHandler,INotificationHandler<ChangeResourceSupplyCommand>
    {
        public ChangeResourceSupplyCommandHandler(IMongoRepository<SectorDocument, Guid> sectorDocuments, IMediator mediator, ISectorService sectorService, IMongoRepository<SectorResourcesDocument, Guid> sectorResourcesDocuments, Channel<INotification> channel, BuildingConfiguration buildingConfiguration) : base(sectorDocuments, mediator, sectorService, sectorResourcesDocuments, channel, buildingConfiguration)
        {
        }

        public async Task Handle(ChangeResourceSupplyCommand notification, CancellationToken cancellationToken)
        {
            if(!notification.SectorResourcesId.HasValue)
            {
                return;
            }
           // lock(ResourceLocker.Lock)
            {
                var sectorResources = await _sectorResourcesDocuments.GetAsync(notification.SectorResourcesId.Value);
                if (sectorResources == null)
                    return;

                foreach (var resource in notification.Resources)
                {
                    var sectorResource = sectorResources.CurrentResources.SingleOrDefault(res => res.Resource == resource.Resource);
                    if (sectorResource == null)
                        continue;

                    decimal finalAmount = resource.Amount * (notification.IncreaseOrDecreaseMultiplier);
                    if (finalAmount + sectorResource.Amount < 0)
                    {
                        finalAmount = 0;
                    }

                    var filter =
                        Builders<SectorResourcesDocument>.Filter.Eq(e => e.Id, sectorResources.Id) &
                        Builders<SectorResourcesDocument>.Filter.ElemMatch(c => c.CurrentResources, Builders<ResourceAmount>.Filter.Eq(r => r.Resource, sectorResource.Resource));

                    var increment = Builders<SectorResourcesDocument>.Update.Inc(c => c.CurrentResources[-1].Amount, finalAmount);

                    await _sectorResourcesDocuments.Collection.UpdateOneAsync(filter, increment);
                }
          
            }
          
        }
    }
}
