using GameChanger.Core.GameData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.GameData
{
    public class BuildingConfiguration
    {
        public List<Building> Buildings { get; set; }
    }

    public class Building
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<ResourceAmount> BaseResourceProduction { get; set; }
        public List<ResourceAmount> BaseResourceConsumption { get; set; }
        public List<ResourceAmount> BuildCosts { get; set; }
        public int Lvl { get; set; }
        public decimal FailurePercentagePerDay { get; set; }

    }

}
