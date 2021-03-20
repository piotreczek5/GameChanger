using Convey.Persistence.MongoDB;
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
        protected Channel<INotification> _channel;
        protected readonly IMongoRepository<SectorDocument, Guid> _sectorDocuments;
        protected readonly IMongoRepository<SectorResourcesDocument, Guid> _sectorResourcesDocuments;
        protected readonly IMediator _mediator;
        protected readonly ISectorService _sectorService;
        protected readonly BuildingConfiguration _buildingConfiguration;

        public IMongoRepository<SectorDocument, Guid> SectorDocuments { get; }
        public IMediator Mediator { get; }
        public ISectorService SectorService { get; }
        public IMongoRepository<SectorResourcesDocument, Guid> SectorResourcesDocuments { get; }

        public BaseSectorHandler(IMongoRepository<SectorDocument, Guid> sectorDocuments, IMediator mediator, ISectorService sectorService, IMongoRepository<SectorResourcesDocument, Guid> sectorResourcesDocuments, Channel<INotification> channel, BuildingConfiguration buildingConfiguration)
        {
            _sectorDocuments = sectorDocuments;
            _mediator = mediator;
            _sectorService = sectorService;
            _sectorResourcesDocuments = sectorResourcesDocuments;
            _channel = channel;
            _buildingConfiguration = buildingConfiguration;
        }
    }
}
