using GameChanger.Core.GameData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.Extensions
{
    public static class MapConfigurationExtensions
    {
        public static Land GetLandByCode(this MapConfiguration mapConfiguration, string code)
        {
            return mapConfiguration.Lands.FirstOrDefault(l => l.Code == code);
        }

        public static City GetCityByCode(this MapConfiguration mapConfiguration, string code)
        {
            return mapConfiguration.Lands.SelectMany(l => l.Cities).FirstOrDefault(c => c.Code == code);
        }
    }
}
