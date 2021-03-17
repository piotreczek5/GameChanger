using Convey.Persistence.MongoDB;
using GameChanger.Core.MediatR.Messages.Queries.Sector;
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
    public class GetSectorBuildingsQueryHandler : BaseSectorHandler, IRequestHandler<GetSectorBuildingsQuery, IEnumerable<BuildingDocument>> 
    {
        public GetSectorBuildingsQueryHandler(IMongoRepository<SectorDocument, Guid> sectorDocuments, IMediator mediator, ISectorService sectorService, IMongoRepository<SectorResourcesDocument, Guid> sectorResourcesDocuments) : base(sectorDocuments, mediator, sectorService, sectorResourcesDocuments)
        {
        }

        public async Task<IEnumerable<BuildingDocument>> Handle(GetSectorBuildingsQuery request, CancellationToken cancellationToken)
        {
            var sector = await _sectorDocuments.GetAsync(request.SectorId);

            return sector.Buildings;
        }
    }
}
