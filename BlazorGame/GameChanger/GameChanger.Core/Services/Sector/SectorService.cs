using GameChanger.Core.GameData;
using GameChanger.Core.MongoDB.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.Services.Sector
{
    public class SectorService : ISectorService
    {
        private BuildingConfiguration _buildingConfiguration;

        public SectorService(BuildingConfiguration buildingConfiguration)
        {
            _buildingConfiguration = buildingConfiguration;
        }

        public SectorDocument RecalculateSectorResources(SectorDocument sector)
        {
            var allBuldingsProduction = sector
                .Buildings
                .SelectMany(b => 
                    _buildingConfiguration
                    .GetBuildingByType(b.BuildingType, b.CurrentLvl)
                    ?.BaseResourceProduction
                    ?? new List<ResourceAmount> ())
                .GroupBy(key => key.Resource)
                .Select(group => new ResourceAmount { Resource = group.Key, Amount = group.Sum(r => r.Amount) })
                .ToList();

            var allBuldingsConsumption = sector
                .Buildings
                .SelectMany(b =>                     
                    _buildingConfiguration
                    .GetBuildingByType(b.BuildingType, b.CurrentLvl)
                    ?.BaseResourceConsumption ?? new List<ResourceAmount>())
                .GroupBy(key => key.Resource)
                .Select(group => new ResourceAmount { Resource = group.Key, Amount = group.Sum(r => r.Amount) })
                .ToList();

            sector.CurrentResourceProduction = allBuldingsProduction.ToList();
            sector.CurrentResourceConsumption = allBuldingsConsumption.ToList();
            
            sector.CurrentResourceBalance =
                Enum.GetValues(typeof(ResourceType)).Cast<ResourceType>()              
                .Select(resource => 
                new ResourceAmount { 
                    Resource = resource,
                    Amount = 
                    (allBuldingsProduction.SingleOrDefault(r => r.Resource == resource)?.Amount ?? 0) - 
                    (allBuldingsConsumption.SingleOrDefault(r => r.Resource == resource)?.Amount ?? 0)
                }).ToList();

            return sector;
        }
    }
}
