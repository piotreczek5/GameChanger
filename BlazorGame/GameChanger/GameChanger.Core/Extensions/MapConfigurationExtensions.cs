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
        public static Land GetLandByCode(this MapConfiguration mapConfiguration, string landCode)
        {
            return mapConfiguration.Lands.FirstOrDefault(l => l.Code == landCode);
        }

        public static City GetCityByCode(this MapConfiguration mapConfiguration, CityCodes? cityCode)
        {
            return mapConfiguration.Lands.SelectMany(l => l.Cities).FirstOrDefault(c => c.Code == cityCode);
        }

        public static Land GetLandByCityCode(this MapConfiguration mapConfiguration, CityCodes? cityCode)
        {
            return mapConfiguration.Lands.SingleOrDefault(l => l.Cities.SingleOrDefault(c => c.Code == cityCode) != null);
        }
    }
}
