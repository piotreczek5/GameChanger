using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Convey.Persistence.MongoDB;
using GameChanger.Core.MediatR.Messages.Queries;
using GameChanger.Core.MongoDB.Documents;
using MediatR;
using MongoDB.Bson;

namespace GameChanger.Core.MediatR.Handlers.Sector
{
    public class GetAllSectorIdsHandler : IRequestHandler<GetAllSectorIdsQuery, IEnumerable<Guid>>
    {
        private readonly IMongoRepository<SectorDocument, Guid> _sectorDocuments;

        public GetAllSectorIdsHandler(IMongoRepository<SectorDocument, Guid> sectorDocuments)
        {
            _sectorDocuments = sectorDocuments;
        }

        public async Task<IEnumerable<Guid>> Handle(GetAllSectorIdsQuery request, CancellationToken cancellationToken)
        {
            var allSectors = await _sectorDocuments.FindAsync(_ => true);
            
            return allSectors.Select(s => s.Id).ToList();
        }
    }
}