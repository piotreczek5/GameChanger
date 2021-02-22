using Convey.Persistence.MongoDB;
using GameChanger.Core.MediatR.Messages;
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

    public class CreatePlayersHandler : INotificationHandler<CreatePlayersCommand>
    {
        private readonly IMongoRepository<PlayerDocument, Guid> _playerDocuments;
        private readonly IMediator _mediator;

        public CreatePlayersHandler(IMongoRepository<PlayerDocument, Guid> playerDocuments, IMediator mediator)
        {
            _playerDocuments = playerDocuments;
            _mediator = mediator;
        }

        public Task Handle(CreatePlayersCommand notification, CancellationToken cancellationToken)
        {
            var players = notification.Nicks.Select(nick => new PlayerDocument { Id = Guid.NewGuid(), Nick = nick });
            
            return _playerDocuments.Collection.InsertManyAsync(players);
        }
    }
}
