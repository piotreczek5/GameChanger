using GameChanger.Core.GameData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.GameData
{    

    public class MapConfiguration
    {
        public List<Land> Lands { get; set; }       
    }

    public class Land
    {
        public List<ResourceAmount> BaseResourceProduction {get;set;}
        public string Name { get; set; }
        public string Code { get; set; }
        public List<City> Cities { get; set; }
        public int AreaSurface { get; set; }        
        public decimal ForestPercentCoverage { get; set; }
        public decimal WaterPercentCoverage { get; set; }
        public decimal FarmLandsPercentCoverage { get; set; }
    }

    public class City
    {
        public CityCodes Code { get; set; }
        public string Name { get; set; }
        public decimal XCoordinate { get; set; }
        public decimal YCoordinate { get; set; }
        
    }

    public enum CityCodes
    {
        POLS_PORA,
        POLS_DUPI,
        SZWA_HANG,
        SZWA_FYRE,
        SZWA_FART
    }
}
