using GameChanger.Core.GameData;
using GameChanger.Core.MediatR.Messages.Commands.Buildings;
using GameChanger.Core.MongoDB.Documents;
using GameChanger.Core.MongoDB.Documents.Buildings;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;


namespace GameChanger.Core.Services.Sector
{
    public class SectorService : ISectorService
    {
        private BuildingConfiguration _buildingConfiguration;
        private IGameNotificationProcessor _gameNotificationProcessor;
        public SectorService(BuildingConfiguration buildingConfiguration, IGameNotificationProcessor gameNotificationProcessor)
        {
            _buildingConfiguration = buildingConfiguration;
            _gameNotificationProcessor = gameNotificationProcessor;
        }

        public SectorResourcesDocument RecalculateSectorResourceBalances(SectorDocument sector, SectorResourcesDocument sectorResourcesDocument)
        {
            var allBalanceInfluencingBuildings =
                sector
                .Buildings
                .Where(b => b.Status.Code == BuildingStatuses.BUILT)
                .Select(b => _buildingConfiguration
                    .GetBuildingByType(b.BuildingType, b.CurrentLvl));

            var allBuldingsProduction = allBalanceInfluencingBuildings
                .SelectMany(b => 
                    
                    b?.BaseResourceProduction
                    ?? new List<ResourceAmount> ())
                .GroupBy(key => key.Resource)
                .Select(group => new ResourceAmount { Resource = group.Key, Amount = group.Sum(r => r.Amount) })
                .ToList();

            var allBuldingsConsumption = allBalanceInfluencingBuildings
                .SelectMany(b =>                     
                    b?.BaseResourceConsumption ?? new List<ResourceAmount>())
                .GroupBy(key => key.Resource)
                .Select(group => new ResourceAmount { Resource = group.Key, Amount = group.Sum(r => r.Amount) })
                .ToList();

            sectorResourcesDocument.CurrentResourceProduction = allBuldingsProduction;
            sectorResourcesDocument.CurrentResourceConsumption = allBuldingsConsumption;

            sectorResourcesDocument.CurrentResourceBalance =
                Enum.GetValues(typeof(ResourceType)).Cast<ResourceType>()              
                .Select(resource => 
                new ResourceAmount { 
                    Resource = resource,
                    Amount = 
                    (allBuldingsProduction.SingleOrDefault(r => r.Resource == resource)?.Amount ?? 0) - 
                    (allBuldingsConsumption.SingleOrDefault(r => r.Resource == resource)?.Amount ?? 0)
                }).ToList();

            return sectorResourcesDocument;
        }

        public async Task<bool> PerformBuildingConsumption(SectorResourcesDocument sectorResources, BuildingDocument building)
        {
            var buildingTemplate = _buildingConfiguration.GetBuildingByType(building.BuildingType, building.CurrentLvl);

            foreach (var consumptionResource in buildingTemplate.BaseResourceConsumption)
            {
                var currentResource = sectorResources.CurrentResources.SingleOrDefault(r => r.Resource == consumptionResource.Resource);
                if (currentResource == null)
                {
                    continue;
                }

                if (currentResource.Amount - consumptionResource.Amount < 0)
                {
                    if (building.Status.Code == BuildingStatuses.BUILT)
                    {
                        await _gameNotificationProcessor.ProcessAsync(new SetBuildingStatusCommand { SectorId = sectorResources.SectorId, BuildingType = building.BuildingType, BuildingStatus = BuildingStatuses.IDLE });                      
                    }

                    return false;
                }
            }

            await _gameNotificationProcessor.ProcessAsync(new ChangeResourceSupplyCommand { SectorResourcesId = sectorResources.Id, Resources = buildingTemplate.BaseResourceConsumption, IncreaseOrDecreaseMultiplier = -1 });

            if (building.Status.Code == BuildingStatuses.IDLE)
            {
                await _gameNotificationProcessor.ProcessAsync(new SetBuildingStatusCommand { SectorId = sectorResources.SectorId, BuildingType = building.BuildingType, BuildingStatus = BuildingStatuses.BUILT });                
            }

            return true;
        }

        public Task PerformBuildingProduction(SectorResourcesDocument sectorResources, BuildingDocument building)
        {
            var buildingTemplate = _buildingConfiguration.GetBuildingByType(building.BuildingType, building.CurrentLvl);

            if (building.Status.Code != BuildingStatuses.BUILT)
            {
                return Task.CompletedTask;
            }

            return _gameNotificationProcessor.ProcessAsync(new ChangeResourceSupplyCommand { SectorResourcesId = sectorResources.Id, Resources = buildingTemplate.BaseResourceProduction });            
        }
    }
}
