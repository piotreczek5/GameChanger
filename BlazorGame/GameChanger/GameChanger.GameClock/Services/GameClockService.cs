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
using System.Threading.Tasks;

namespace GameChanger.GameClock.Services
{
    public class GameClockService : IGameClockService
    {        
        private readonly IMediator _mediator;

        public GameClockService(ISectorService sectorService, IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task RecalculateSectorsResources()
        {
            var allSectorIds = await  _mediator.Send(new GetAllSectorIdsQuery());
            
            foreach(var sector in allSectorIds)
            {
                var buildings = await _mediator.Send(new GetSectorBuildingsQuery { SectorId = sector });
                
                foreach(var building in buildings)
                {
                    Task.Factory.StartNew(() =>
                    {
                        _mediator.Publish(new PerformBuildingConsumptionCommand { SectorId = sector, BuildingType = building.BuildingType });
                    }).ContinueWith((t) => 
                    {
                        _mediator.Publish(new PerformBuildingProductionCommand { SectorId = sector, BuildingType = building.BuildingType });
                    });
                }
            }                
        }
    }
}