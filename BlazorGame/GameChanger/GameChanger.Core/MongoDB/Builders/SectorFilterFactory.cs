using GameChanger.Core.GameData;
using GameChanger.Core.MongoDB.Documents;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.MongoDB.Builders
{
    public static class SectorFilterFactory 
    {
        public static FilterDefinition<SectorDocument> GetBuildingFromSectorByType(Guid sectorId, BuildingTypes buildingType)
        {
            return GetSectorById(sectorId) &
                Builders<SectorDocument>.Filter.ElemMatch(s => s.Buildings, 
                    Builders<BuildingDocument>.Filter.Eq(b => b.BuildingType, buildingType));
        }

        public static FilterDefinition<SectorDocument> GetSectorById(Guid sectorId)
        {
            return Builders<SectorDocument>.Filter.Eq(s => s.Id, sectorId);             
        }
    }
}
