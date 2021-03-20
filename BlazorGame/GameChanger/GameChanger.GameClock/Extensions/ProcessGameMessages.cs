using System;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;
using GameChanger.Core.Debugging;
using GameChanger.Core.EventScheduler;
using GameChanger.Core.MediatR.Messages.Commands.Buildings;
using GameChanger.Core.Services.Logging;
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
        private readonly IGameLogger _logger;
        private readonly VisualLog _log;

        public ProcessGameMessages(
            IMediator mediator, 
            Channel<INotification> channel,
            IGameLogger gameLogger,
            VisualLog log)
        {
            _mediator = mediator;
            _channel = channel;
            _logger = gameLogger;
            _log = log;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while(true)
            {
                var msg = await _channel.Reader.ReadAsync();
                if(msg != null)
                {
                    string detailedMessage = $"[{msg.GetType().Name}] [{JsonConvert.SerializeObject(msg)}]";
                     _logger.Log(msg.ToString(), detailedMessage, LogLevel.Information);

                    string getColor = GetMessageColor(msg);
                    _log.Messages.TryAdd(DateTime.Now, (getColor, msg.ToString()));

                    await _mediator.Publish(msg);
                }                
            }
        }

        private string GetMessageColor(INotification msg)
        {
            switch(msg)
            {
                case FixBuildingCommand:
                    return "#ffbf00";
                case ChangeResourceSupplyCommand:
                    return  ((ChangeResourceSupplyCommand)msg).IsAdding ? "#bfff00" : "#ff4000";
                case BuildBuildingCommand:
                    return "#00ffbf";
                case DestroyBuildingCommand:
                    return "#8000ff";
                case PerformBuildingProductionCommand:
                    return "#b0ffc4";
                case PerformBuildingConsumptionCommand:
                    return "#ff8686";
                case SetBuildingStatusCommand:
                    return "#00ffff";
                case UpgradeBuildingCommand:
                    return "#00ffbf";
                default:
                    return "#ffffff";
            }
        }
    }
}