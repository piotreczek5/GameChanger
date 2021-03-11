using Convey.Persistence.MongoDB;
using GameChanger.Core.MediatR.Messages.Queries;
using GameChanger.Core.MongoDB.Documents;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameChanger.Core.MediatR.Handlers
{
    public class GetSectorInfoHandler : IRequestHandler<GetSectorInfoQuery,SectorDocument>
    {
        private readonly IMongoRepository<SectorDocument, Guid> _sectorDocuments;

        public GetSectorInfoHandler(IMongoRepository<SectorDocument, Guid> sectorDocuments)
        {
            _sectorDocuments = sectorDocuments;
        }

        public Task<SectorDocument> Handle(GetSectorInfoQuery notification, CancellationToken cancellationToken)
        {
            return _sectorDocuments.GetAsync(notification.Id);
        }
    }
}
