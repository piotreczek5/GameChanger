using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.GameData
{
    public enum ResourceType
    {
        COAL = 0,
        WOOD,
        IRON_ORE,
        COPPER_ORE,
        STONE,
        IRON,
        COPPER,
        FOOD,
        MONEY,
        GOLD,
        OIL,
        SAND,
        STEEL,
        GLASS,
        ENERGY,
        WATER
    }

    public class Resource
    {
        public ResourceType ResourceType { get;set; }        
    }
}
