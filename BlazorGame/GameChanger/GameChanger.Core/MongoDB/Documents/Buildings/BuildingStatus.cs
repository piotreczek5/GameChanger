using GameChanger.Core.MediatR.Messages.Commands.Buildings;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameChanger.Core.MongoDB.Documents.Buildings
{
    public class BuildingStatus :  IContinousBuildingStatus
    {
        public BuildingStatus(BuildingStatuses code)
        {
            Code = code;            
        }

        public BuildingStatuses Code { get; set; }

        [BsonDateTimeOptions(DateOnly = false, Kind = DateTimeKind.Utc)]
        public DateTime? TimeToComplete { get; set; }
    }

    public interface IContinousBuildingStatus
    {
        [BsonDateTimeOptions(DateOnly = false, Kind = DateTimeKind.Utc)]
        public DateTime? TimeToComplete { get; set; }
    }

    public class FixingBuildingStatus : BuildingStatus
{
        public FixingBuildingStatus(DateTime? timeToFix) : base(BuildingStatuses.FIXING)
        {
            TimeToComplete = timeToFix;
        }
    }

    public class BuildingBuildingStatus : BuildingStatus
{
        public BuildingBuildingStatus(DateTime? timeToBuild) : base(BuildingStatuses.BUILDING)
        {            
            TimeToComplete = timeToBuild;
        }
    }

    public class DestroyingBuildingStatus : BuildingStatus
{
        public DestroyingBuildingStatus(DateTime? timeToDestroy) : base(BuildingStatuses.DESTROYING)
        {
            TimeToComplete = timeToDestroy;
        }
    }

}
