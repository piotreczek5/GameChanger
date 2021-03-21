using GameChanger.Core.GameData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.GameData
{
    public enum BuildingTypes
    {
        STONE_MINE = 0,
        SAND_MINE,
        IRON_MINE,
        COAL_MINE,
        COPPER_MINE,
        SAWMILL,
        FOOD_PLANTATION,
        WELL
    }

    public class BuildingConfiguration
    {
        public List<Building> Buildings { get; set; } = new List<Building>();
        public Building GetBuildingByType(BuildingTypes buildingType, int lvl) 
        {
            return Buildings.SingleOrDefault(b => b.BuildingType == buildingType && b.Lvl == lvl); 
        }
    }

    public class Building
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<ResourceAmount> BaseResourceProduction { get; set; } = new List<ResourceAmount>();
        public List<ResourceAmount> BaseResourceConsumption { get; set; } = new List<ResourceAmount>();
        public List<ResourceAmount> BuildCosts { get; set; } = new List<ResourceAmount>();
        public int Lvl { get; set; }
        public decimal FailurePercentagePerDay { get; set; }
        public BuildingTypes BuildingType { get; set; }

        public TimeSpan? BuildTime { get; set; }
        public TimeSpan? DestroyTime { get; set; }

    }

}
