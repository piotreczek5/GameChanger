using Convey.Persistence.MongoDB;
using GameChanger.Core.MediatR.Messages.Commands.Player;
using GameChanger.Core.MongoDB.Builders;
using GameChanger.Core.MongoDB.Documents;
using GameChanger.Core.MongoDB.Updaters;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameChanger.Core.MediatR.Handlers.Player
{
    public class ChangePlayerStatusHandler : INotificationHandler<ChangePlayerStatusCommand>
    {
        private readonly IMongoRepository<PlayerDocument, Guid> _playerDocuments;

        public ChangePlayerStatusHandler(IMongoRepository<PlayerDocument, Guid> playerDocuments)
        {
            _playerDocuments = playerDocuments;
        }

        public async Task Handle(ChangePlayerStatusCommand notification, CancellationToken cancellationToken)
        {
            if(!notification.PlayerId.HasValue)
            {
                return;
            }

            var playerSetStatusUpdater = PlayerUpdaterFactory.SetPlayerStatus(notification.Status);
            var findPlayerByIdFilter = PlayerFilterFactory.GetPlayerById(notification.PlayerId.Value);

            await _playerDocuments.Collection.UpdateOneAsync(findPlayerByIdFilter, playerSetStatusUpdater);
        }
    }
}
