using System;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;
using GameChanger.Core.EventScheduler;
using GameChanger.Core.MediatR.Messages.Commands.Buildings;
using GameChanger.Core.MediatR.Messages.Queries;
using GameChanger.Core.MediatR.Messages.Queries.Sector;
using MediatR;
using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;
using Microsoft.Extensions.Hosting;

namespace GameChanger.GameClock.Extensions
{
    public class RecalculateResourcesHostedService : IHostedService, IDisposable
    {
        private Timer _timer;
        private readonly Channel<INotification> _channel;
        private readonly IMediator _mediator;
        public RecalculateResourcesHostedService(
            Channel<INotification> channel, IMediator mediator)
        {
            _channel = channel;
            _mediator = mediator;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _timer = new Timer(DoWork, null, TimeSpan.FromSeconds(5), 
                TimeSpan.FromSeconds(5));

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }

        private async void DoWork(object state)
        {
            _timer.Change(Timeout.Infinite, 0);
            await RecalculateSectorsResources();
            _timer.Change(TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(0));
        }

        public async Task RecalculateSectorsResources()
        {
            var allSectorIds = await _mediator.Send(new GetAllSectorIdsQuery());

            foreach (var sector in allSectorIds)
            {
                var buildings = await _mediator.Send(new GetSectorBuildingsQuery { SectorId = sector });

                foreach (var building in buildings)
                {
                    await _channel.Writer.WriteAsync(new PerformBuildingConsumptionCommand { SectorId = sector, BuildingType = building.BuildingType });
                    await _channel.Writer.WriteAsync(new PerformBuildingProductionCommand { SectorId = sector, BuildingType = building.BuildingType });
                }
            }
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}