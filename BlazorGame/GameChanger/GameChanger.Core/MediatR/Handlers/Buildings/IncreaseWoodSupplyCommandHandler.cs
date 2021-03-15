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
    public class IncreaseWoodSupplyCommandHandler : INotificationHandler<IncreaseWoodSupplyCommand>
    {
        private readonly IMongoRepository<SectorDocument, Guid> _sectorDocuments;
        public IncreaseWoodSupplyCommandHandler(IMongoRepository<SectorDocument, Guid> sectorDocuments)
        {
            _sectorDocuments = sectorDocuments;
        }

        public async Task Handle(IncreaseWoodSupplyCommand notification, CancellationToken cancellationToken)
        {
            var sector = await  _sectorDocuments.GetAsync(s => s.PlayerOwner == notification.PlayerId);
            sector.CurrentResourceProduction.SingleOrDefault(r => r.Resource == ResourceType.WOOD).Amount += notification.Amount;
            await _sectorDocuments.UpdateAsync(sector);
        }
    }
}
