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
    public class GetPlayerInfoHandler : IRequestHandler<GetPlayerInfoQuery,PlayerDocument>
    {
        private readonly IMongoRepository<PlayerDocument, Guid> _playerDocuments;

        public GetPlayerInfoHandler(IMongoRepository<PlayerDocument, Guid> playerDocuments)
        {
            _playerDocuments = playerDocuments;
        }

        public Task<PlayerDocument> Handle(GetPlayerInfoQuery notification, CancellationToken cancellationToken)
        {
            if(notification.Id.HasValue)
            {
                return _playerDocuments.GetAsync(notification.Id.Value);
            }

            return _playerDocuments.GetAsync(player => player.Nick.Equals(notification.Nick));
        }
    }
}
