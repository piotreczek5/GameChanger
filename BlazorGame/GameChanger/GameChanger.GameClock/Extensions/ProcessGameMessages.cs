using System;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;
using GameChanger.Core.Debugging;
using GameChanger.Core.EventScheduler;
using GameChanger.GameClock.Services;
using MediatR;
using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace GameChanger.GameClock.Extensions
{
    public class ProcessGameMessages : BackgroundService
    {        
        private IMediator _mediator;
        private Channel<INotification> _channel;
        private readonly ILogger<ProcessGameMessages> _logger;
        private readonly Log _log;

        public ProcessGameMessages(
            IMediator mediator, 
            Channel<INotification> channel,
            ILogger<ProcessGameMessages> logger,
            Log log)
        {
            _mediator = mediator;
            _channel = channel;
            _logger = logger;
            _log = log;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while(true)
            {
                var msg = await _channel.Reader.ReadAsync();
                if(msg != null)
                {
                    string message = $"[{msg.GetType().Name}] [{JsonConvert.SerializeObject(msg)}]";
                    _log.Messages.Add(message);
                    //_logger.LogInformation(message);
                    await _mediator.Publish(msg);
                }                
            }
        }


    }
}