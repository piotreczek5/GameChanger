using Convey.Persistence.MongoDB;
using GameChanger.Core.MediatR.Messages.Commands.Logging;
using GameChanger.Core.MongoDB.Documents;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameChanger.Core.MediatR.Handlers.Logging
{
    public class LogCommandHandler : INotificationHandler<LogCommand>
    {
        private readonly IMongoRepository<LogDocument, Guid> _logDocuments;

        public LogCommandHandler(IMongoRepository<LogDocument, Guid> logDocuments)
        {
            _logDocuments = logDocuments;
        }

        public async Task Handle(LogCommand notification, CancellationToken cancellationToken)
        {
            var document = new LogDocument()
            {
                LogLevel = notification.LogLevel,
                Message = notification.Message,
                TimeStamp = notification.TimeStamp,
                Details = notification.Details
            };

            await _logDocuments.AddAsync(document);
        }
    }
}
