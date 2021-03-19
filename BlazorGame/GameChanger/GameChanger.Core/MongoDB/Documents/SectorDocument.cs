using Convey.Types;
using GameChanger.Core.GameData;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.MongoDB.Documents
{
    public class SectorDocument : IIdentifiable<Guid>
    {
        public Guid Id { get; set; }
        public Guid PlayerOwner { get; set; }

        public string City { get; set; }
        public string Land { get; set; }

        public List<BuildingDocument> Buildings { get; set; } = new List<BuildingDocument>();
       
        public Guid SectorResourcesId { get; set; }
    }

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
            Status = new BuildingStatus() { Code = BuildingStatuses.BUILT };
        }
    }

    public enum BuildingStatuses
    {
        BUILDING,
        BROKEN,
        FIXING,
        BUILT,
        NOT_BUILT,
        IDLE
    }

    public class BuildingStatus
    { 
        public BuildingStatuses Code { get; set; }
    }

    public enum BuildActions
    {
        BUILD,
        FIX,
        DESTROY,
        UPGRADE
    }

}
