using GameChanger.Core.MediatR.Messages.Commands.Logging;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.Services.Logging
{
    public class GameLogger : IGameLogger
    {
        private readonly IMediator _mediator;

        public GameLogger(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void Log(string message,string details, LogLevel logLevel)
        {
            _mediator
                .Publish(new LogCommand() { 
                    TimeStamp = DateTime.UtcNow, 
                    LogLevel = logLevel, 
                    Message = message,
                    Details = details 
                })
                .ConfigureAwait(false);
        }
    }
}
