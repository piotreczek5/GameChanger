using Convey.Persistence.MongoDB;
using GameChanger.Core.MediatR.Messages;
using GameChanger.Core.MongoDB.Documents;
using GameChanger.Core.MongoDB.Documents.Factories;
using GameChanger.Core.MongoDB.Documents.Player;
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
        private readonly IPlayerStatusFactory _playerStatusFactory;

        public CreatePlayersHandler(IMongoRepository<PlayerDocument, Guid> playerDocuments, IMediator mediator, IPlayerStatusFactory playerStatusFactory)
        {
            _playerDocuments = playerDocuments;
            _mediator = mediator;
            _playerStatusFactory = playerStatusFactory;
        }

        public Task Handle(CreatePlayersCommand notification, CancellationToken cancellationToken)
        {
            var players = notification.Nicks.Select(nick => 
                new PlayerDocument {                     
                    Id = Guid.NewGuid(), 
                    Nick = nick,
                    Status = _playerStatusFactory.Create(PlayerStatuses.IDLE_WITHOUT_SECTOR),
                    CreatedTimeStamp = DateTime.UtcNow                    
                });
            
            return _playerDocuments.Collection.InsertManyAsync(players);
        }
    }
}
