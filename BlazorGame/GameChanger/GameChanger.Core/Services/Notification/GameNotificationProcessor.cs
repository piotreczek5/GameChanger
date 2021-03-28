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

namespace GameChanger.Core.Services
{
    public class GameNotificationProcessor : IGameNotificationProcessor
    {        
        private IMediator _mediator;
        private readonly IGameLogger _logger;
        private readonly VisualLog _log;

        public GameNotificationProcessor(
            IMediator mediator, 
            IGameLogger gameLogger,
            VisualLog log)
        {
            _mediator = mediator;
            _logger = gameLogger;
            _log = log;
        }

        public async Task ProcessAsync(INotification notification)
        {
            if (notification != null)
            {
                string detailedMessage = $"[{notification.GetType().Name}] [{JsonConvert.SerializeObject(notification)}]";
                _logger.Log(notification.ToString(), detailedMessage, LogLevel.Information);

                string getColor = GetMessageColor(notification);
                _log.Messages.TryAdd(DateTime.Now, (getColor, notification.ToString()));

                await _mediator.Publish(notification);
            }
        }
        private string GetMessageColor(INotification msg)
        {
            switch (msg)
            {
                case FixBuildingCommand:
                    return "#ffbf00";
                case ChangeResourceSupplyCommand:
                    return ((ChangeResourceSupplyCommand)msg).IsAdding ? "#bfff00" : "#ff4000";
                case BuildBuildingCommand:
                    return "#00ffbf";
                case DemolishBuildingCommand:
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