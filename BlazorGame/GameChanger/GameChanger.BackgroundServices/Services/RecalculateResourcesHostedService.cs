using System;
using System.Linq;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;
using GameChanger.Core.EventScheduler;
using GameChanger.Core.MediatR.Messages.Commands.Buildings;
using GameChanger.Core.MediatR.Messages.Queries;
using GameChanger.Core.MediatR.Messages.Queries.Sector;
using GameChanger.Core.MongoDB.Documents;
using GameChanger.Core.MongoDB.Documents.Buildings;
using GameChanger.Core.Services;
using MediatR;
using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;
using Microsoft.Extensions.Hosting;

namespace GameChanger.GameClock.Extensions
{
    public class RecalculateResourcesHostedService : IHostedService, IDisposable
    {
        private Timer _timer;
        private readonly IGameNotificationProcessor _gameNotificationProcessor;
        private readonly IMediator _mediator;
        private  TimeSpan REFRESH_TIMESPAN = TimeSpan.FromSeconds(1);
        private bool _buildingsFixed = false;

        public RecalculateResourcesHostedService(
            IGameNotificationProcessor gameNotificationProcessor, IMediator mediator)
        {
            _gameNotificationProcessor = gameNotificationProcessor;
            _mediator = mediator;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _timer = new Timer(DoWork, null, REFRESH_TIMESPAN,
                REFRESH_TIMESPAN);

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
            if (_buildingsFixed != true)
            {
                await FixStuckBuildings();
            }
            _timer.Change(REFRESH_TIMESPAN, TimeSpan.FromSeconds(0));
        }

        public async Task RecalculateSectorsResources()
        {
            var allSectorIds = await _mediator.Send(new GetAllSectorIdsQuery());

            foreach (var sector in allSectorIds)
            {
                var sectorBuildings = await _mediator.Send(new GetSectorBuildingsQuery { SectorId = sector });
                if(sectorBuildings == null)
                {
                    return;
                }
                
                var buildings =
                    sectorBuildings
                    .ToList()
                    .Where(b => b.Status.Code == BuildingStatuses.BUILT || b.Status.Code == BuildingStatuses.IDLE);

                foreach (var building in buildings)
                {                    
                    await _gameNotificationProcessor.ProcessAsync(new PerformBuildingProductionCommand { SectorId = sector, BuildingType = building.BuildingType });
                }
            }
        }

        public async Task FixStuckBuildings()
        {
            var allSectorIds = await _mediator.Send(new GetAllSectorIdsQuery());

            foreach (var sector in allSectorIds)
            {
                var sectorBuildings = await _mediator.Send(new GetSectorBuildingsQuery { SectorId = sector });
                if (sectorBuildings == null)
                {
                    return;
                }

                var currentDateTimeUtc = DateTime.UtcNow;
                var b = sectorBuildings.ToList();
                var brokenBuildings =
                    sectorBuildings
                    .Where(b => 
                            (b.Status.Code == BuildingStatuses.BUILDING || b.Status.Code == BuildingStatuses.FIXING || b.Status.Code == BuildingStatuses.DESTROYING)
                            && (!(b.Status as IContinousBuildingStatus).TimeToComplete.HasValue || (b.Status as IContinousBuildingStatus).TimeToComplete.Value < currentDateTimeUtc))                                              
                    .ToList();

                foreach (var building in brokenBuildings)
                {
                    switch(building.Status.Code)
                    {
                        case BuildingStatuses.BUILDING:
                            await _gameNotificationProcessor.ProcessAsync(new SetBuildingStatusCommand { SectorId = sector, BuildingType = building.BuildingType ,BuildingStatus = BuildingStatuses.BUILT});
                            break;
                        case BuildingStatuses.DESTROYING:
                            await _gameNotificationProcessor.ProcessAsync(new RemoveBuildingFromSectorCommand { SectorId = sector, BuildingType = building.BuildingType });
                            break;
                        case BuildingStatuses.FIXING:
                            await _gameNotificationProcessor.ProcessAsync(new SetBuildingStatusCommand { SectorId = sector, BuildingType = building.BuildingType, BuildingStatus = BuildingStatuses.BUILT });
                            break;
                    }                    
                }                
            }
            _buildingsFixed = true;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}