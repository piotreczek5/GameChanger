using System;
using System.Threading;
using System.Threading.Tasks;
using GameChanger.Core.EventScheduler;
using GameChanger.GameClock.Services;
using MediatR;
using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;
using Microsoft.Extensions.Hosting;

namespace GameChanger.GameClock.Extensions
{
    public class RecalculateResourcesHostedService : IHostedService, IDisposable
    {
        private Timer _timer;
        private IGameClockService _gameClockService;

        public RecalculateResourcesHostedService(IGameClockService gameClockService)
        {
            _gameClockService = gameClockService;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _timer = new Timer(DoWork, null, TimeSpan.FromSeconds(10), 
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
            await _gameClockService.RecalculateSectorsResources();
            _timer.Change(TimeSpan.FromSeconds(0), TimeSpan.FromSeconds(5));
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}