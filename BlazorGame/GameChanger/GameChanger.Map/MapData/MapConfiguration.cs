using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Map.MapData
{
    public class MapConfiguration
    {
        public List<Land> Lands { get; set; }
    }

    public class Land
    {
        public string Name { get; set; }
        public List<City> Cities { get; set; }
        public int AreaSurface { get; set; }        
        public decimal ForestPercentCoverage { get; set; }
        public decimal WaterPercentCoverage { get; set; }
        public decimal FarmLandsPercentCoverage { get; set; }
    }

    public class City
    {
        public string Name { get; set; }
        public decimal XCoordinate { get; set; }
        public decimal YCoordinate { get; set; }
        
    }
}
