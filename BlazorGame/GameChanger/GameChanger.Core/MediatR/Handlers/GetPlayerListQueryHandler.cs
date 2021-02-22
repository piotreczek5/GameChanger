using Convey.Persistence.MongoDB;
using GameChanger.Core.MediatR.Messages.Queries;
using GameChanger.Core.MongoDB.Documents;
using MediatR;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameChanger.Core.MediatR.Handlers
{
    public class GetPlayerListQueryHandler : IRequestHandler<GetPlayerListQuery, IReadOnlyList<PlayerDocument>>
    {
        private readonly IMongoRepository<PlayerDocument, Guid> _playerDocuments;

        public GetPlayerListQueryHandler(IMongoRepository<PlayerDocument, Guid> playerDocuments)
        {
            _playerDocuments = playerDocuments;
        }

        public Task<IReadOnlyList<PlayerDocument>> Handle(GetPlayerListQuery notification, CancellationToken cancellationToken)
        {
            return _playerDocuments.FindAsync(p => true);
        }
    }
}
