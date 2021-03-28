using Convey.Persistence.MongoDB;
using GameChanger.Core.GameData;
using GameChanger.Core.MediatR.Handlers.Sector;
using GameChanger.Core.MediatR.Messages.Queries.Sector;
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

namespace GameChanger.Core.MediatR.Handlers.SectorResources
{
    public class GetSectorResourcesQueryHandler : BaseSectorHandler, IRequestHandler<GetSectorResourcesQuery, SectorResourcesDocument>
    {
        public GetSectorResourcesQueryHandler(IMongoRepository<SectorDocument, Guid> sectorDocuments, IMediator mediator, ISectorService sectorService, IMongoRepository<SectorResourcesDocument, Guid> sectorResourcesDocuments, BuildingConfiguration buildingConfiguration) : base(sectorDocuments, mediator, sectorService, sectorResourcesDocuments, buildingConfiguration)
        {
        }

        public async Task<SectorResourcesDocument> Handle(GetSectorResourcesQuery request, CancellationToken cancellationToken)
        {
            if(!request.SectorId.HasValue)
            {
                return null;
            }

            return await _sectorResourcesDocuments.GetAsync(sr => sr.SectorId == request.SectorId.Value);
        }
    }
}
