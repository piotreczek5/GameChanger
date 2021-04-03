using GameChanger.Core.GameData;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.MongoDB.Documents.Buildings
{
    public class BuildingDocument
    {
        public string Name { get; set; }
        public int CurrentLvl { get; set; }
        public BuildingTypes BuildingType { get; set; }
        
        [BsonElement]
        public BuildingStatus Status { get; set; }

        public BuildingDocument(Building building)
        {
            Name = building.Name;
            CurrentLvl = 1;
            BuildingType = building.BuildingType;
            Status = new BuildingStatus(BuildingStatuses.BUILT);
        }
    }

}
