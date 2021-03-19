using GameChanger.Core.GameData;
using GameChanger.Core.MediatR.Messages.Commands.Buildings;
using GameChanger.Core.MediatR.Messages.Commands.Sector;
using GameChanger.Core.MediatR.Messages.Queries;
using GameChanger.Core.MediatR.Messages.Queries.Sector;
using GameChanger.Core.Services.Sector;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace GameChanger.GameClock.Services
{
    public class GameClockService : IGameClockService
    {        
        private readonly IMediator _mediator;
        private Channel<INotification> _channel;

        public GameClockService(IMediator mediator, Channel<INotification> channel)
        {
            _mediator = mediator;
            _channel = channel;
        }

        public async Task RecalculateSectorsResources()
        {
            var allSectorIds = await  _mediator.Send(new GetAllSectorIdsQuery());
            
            foreach(var sector in allSectorIds)
            {
                var buildings = await _mediator.Send(new GetSectorBuildingsQuery { SectorId = sector });
                
                foreach(var building in buildings)
                {
                    await _channel.Writer.WriteAsync(new PerformBuildingConsumptionCommand { SectorId = sector, BuildingType = building.BuildingType });
                    await _channel.Writer.WriteAsync(new PerformBuildingProductionCommand { SectorId = sector, BuildingType = building.BuildingType });
                }
            }                
        }
    }
}