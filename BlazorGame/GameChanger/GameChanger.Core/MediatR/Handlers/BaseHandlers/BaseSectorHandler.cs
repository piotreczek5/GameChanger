using Convey.Persistence.MongoDB;
using GameChanger.Core.EventScheduler;
using GameChanger.Core.GameData;
using GameChanger.Core.MongoDB.Documents;
using GameChanger.Core.Services.Sector;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace GameChanger.Core.MediatR.Handlers.Sector
{
    public class BaseSectorHandler
    {
        protected readonly IMongoRepository<SectorDocument, Guid> _sectorDocuments;
        protected readonly IMongoRepository<SectorResourcesDocument, Guid> _sectorResourcesDocuments;
        protected readonly IMediator _mediator;
        protected readonly ISectorService _sectorService;
        protected readonly BuildingConfiguration _buildingConfiguration;
        protected readonly IEventScheduler _eventScheduler;

        public IMongoRepository<SectorDocument, Guid> SectorDocuments { get; }
        public IMediator Mediator { get; }
        public ISectorService SectorService { get; }
        public IMongoRepository<SectorResourcesDocument, Guid> SectorResourcesDocuments { get; }

        public BaseSectorHandler(IMongoRepository<SectorDocument, Guid> sectorDocuments, IMediator mediator, ISectorService sectorService, IMongoRepository<SectorResourcesDocument, Guid> sectorResourcesDocuments, BuildingConfiguration buildingConfiguration, IEventScheduler eventScheduler)
        {
            _sectorDocuments = sectorDocuments;
            _mediator = mediator;
            _sectorService = sectorService;
            _sectorResourcesDocuments = sectorResourcesDocuments;
            _buildingConfiguration = buildingConfiguration;
            _eventScheduler = eventScheduler;
        }

        public BaseSectorHandler(IMongoRepository<SectorDocument, Guid> sectorDocuments, IMediator mediator, ISectorService sectorService, IMongoRepository<SectorResourcesDocument, Guid> sectorResourcesDocuments, BuildingConfiguration buildingConfiguration)
        {
            _sectorDocuments = sectorDocuments;
            _mediator = mediator;
            _sectorService = sectorService;
            _sectorResourcesDocuments = sectorResourcesDocuments;
            _buildingConfiguration = buildingConfiguration;
        }
    }
}
