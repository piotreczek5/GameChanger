using GameChanger.Core.GameData;
using GameChanger.Core.MongoDB.Documents;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.MongoDB.Updaters
{
    public static class SectorUpdaterFactory
    {
        public static UpdateDefinition<SectorDocument> SetBuildingStatus (BuildingStatus buildingStatus)
        {
            return Builders<SectorDocument>.Update.Set(c => c.Buildings[-1].Status, buildingStatus);
        }

        public static UpdateDefinition<SectorDocument> SetBuildingLvl(int lvl)
        {
            return Builders<SectorDocument>.Update.Set(c => c.Buildings[-1].CurrentLvl, lvl);
        }
        public static UpdateDefinition<SectorDocument> RemoveBuilding(BuildingTypes buildingType)
        {
            return Builders<SectorDocument>.Update.PullFilter(c => c.Buildings, Builders<BuildingDocument>.Filter.Eq(b => b.BuildingType,buildingType));
        }

        public static UpdateDefinition<SectorDocument> AddBuilding(BuildingDocument building)
        {
            return Builders<SectorDocument>.Update.Push(c => c.Buildings, building);
        }

        public static UpdateDefinition<SectorDocument> SetBuildingLvlBuilding(int lvl)
        {
            return Builders<SectorDocument>.Update.Set(c => c.Buildings[-1].CurrentLvl, lvl);
        }
       
        public static UpdateDefinition<SectorDocument> DecreaseBuildingLvl()
        {
            return Builders<SectorDocument>.Update.Inc(c => c.Buildings[-1].CurrentLvl, -1);
        }
        public static UpdateDefinition<SectorDocument> IncreaseBuildingLvl()
        {
            return Builders<SectorDocument>.Update.Inc(c => c.Buildings[-1].CurrentLvl, 1);
        }
    }
}
