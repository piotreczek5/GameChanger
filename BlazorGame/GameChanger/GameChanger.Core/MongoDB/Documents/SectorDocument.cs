using Convey.Types;
using GameChanger.Core.GameData;
using GameChanger.Core.MediatR.Messages.Commands.Buildings;
using GameChanger.Core.MongoDB.Documents.Interfaces;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.MongoDB.Documents
{
    public class SectorDocument : IIdentifiable<Guid>, IAuditedDocument
    {
        public Guid Id { get; set; }
        public Guid PlayerOwner { get; set; }

        public string CityCode { get; set; }
        public string LandCode { get; set; }

        public List<BuildingDocument> Buildings { get; set; } = new List<BuildingDocument>();
        public Guid SectorResourcesId { get; set; }
        public DateTime ModifyTimeStamp { get; set; }
        public Guid ModifiedUserId { get; set ; }
        public DateTime CreatedTimeStamp { get; set; }
        public Guid CreatedUserId { get; set ; }
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
        DESTROYING,
        IDLE
    }

    public class BuildingStatus
    {
        public BuildingStatus()
        {
        }

        public BuildingStatus(SetBuildingStatusCommand command)
        {
            Code = command.BuildingStatus;
            TimeToBuild = command.TimeToBuild;
            TimeToFix = command.TimeToFix;
            TimeToDestroy = command.TimeToDestroy;
        }

        public BuildingStatuses Code { get; set; }

        [BsonDateTimeOptions(DateOnly =false,Kind =DateTimeKind.Utc)]
        public DateTime? TimeToBuild { get; set; }
        
        [BsonDateTimeOptions(DateOnly = false, Kind = DateTimeKind.Utc)]
        public DateTime? TimeToFix { get; set; }

        [BsonDateTimeOptions(DateOnly = false, Kind = DateTimeKind.Utc)]
        public DateTime? TimeToDestroy { get; set; }

    }

    public enum BuildActions
    {
        BUILD,
        FIX,
        DESTROY,
        UPGRADE
    }

}
