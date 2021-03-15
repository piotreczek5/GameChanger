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
using System.Threading.Tasks;

namespace GameChanger.Core.MediatR.Handlers.Sector
{
    public class RecalculateSectorResourcesCommandHandler : INotificationHandler<RecalculateSectorResourcesCommand>
    {
        private readonly IMongoRepository<SectorDocument, Guid> _sectorDocuments;
        private readonly ISectorService _sectorService;
        public RecalculateSectorResourcesCommandHandler(IMongoRepository<SectorDocument, Guid> sectorDocuments, ISectorService sectorService)
        {
            _sectorDocuments = sectorDocuments;
            _sectorService = sectorService;
        }

        public async Task Handle(RecalculateSectorResourcesCommand notification, CancellationToken cancellationToken)
        {
            var sector = await _sectorDocuments.GetAsync(notification.SectorId);
            
            sector = _sectorService.RecalculateSectorResources(sector);
            
            await _sectorDocuments.UpdateAsync(sector);
        }
    }
}
