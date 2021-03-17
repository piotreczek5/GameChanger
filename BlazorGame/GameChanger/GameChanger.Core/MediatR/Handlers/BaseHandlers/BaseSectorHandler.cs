using Convey.Persistence.MongoDB;
using GameChanger.Core.MongoDB.Documents;
using GameChanger.Core.Services.Sector;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.MediatR.Handlers.Sector
{
    public class BaseSectorHandler
    {
        protected readonly IMongoRepository<SectorDocument, Guid> _sectorDocuments;
        protected readonly IMongoRepository<SectorResourcesDocument, Guid> _sectorResourcesDocuments;
        protected readonly IMediator _mediator;
        protected readonly ISectorService _sectorService;

        public BaseSectorHandler(IMongoRepository<SectorDocument, Guid> sectorDocuments, IMediator mediator, ISectorService sectorService, IMongoRepository<SectorResourcesDocument, Guid> sectorResourcesDocuments)
        {
            _sectorDocuments = sectorDocuments;
            _mediator = mediator;
            _sectorService = sectorService;
            _sectorResourcesDocuments = sectorResourcesDocuments;
        }
    }
}
