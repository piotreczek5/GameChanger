using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.MongoDB.Documents.Player
{
    public class PlayerStatus
    {
        public PlayerStatuses Code { get; set; }
    }

    public class IdlePlayerStatus : PlayerStatus
    {
        public IdlePlayerStatus()
        {
            Code = PlayerStatuses.IDLE;
        }
    }

    public class TravelingStatus : PlayerStatus
    {
        public Guid? SourceSector { get; set; }
        public Guid? DestinationSector { get; set; }
        public DateTime? PlannedArrival { get; set; }
        public TravelingStatus()
        {
            Code = PlayerStatuses.TRAVELING;
        }
    }

    public class JourneyPlayerStatus : PlayerStatus
    {
        public JourneyPlayerStatus()
        {
            Code = PlayerStatuses.JOURNEY;
        }
    }

    public class BuildingPlayerStatus : PlayerStatus
    {
        public BuildingPlayerStatus()
        {
            Code = PlayerStatuses.BUILDING;
        }
    }

    public enum PlayerStatuses
    {
        IDLE, TRAVELING, JOURNEY, BUILDING
    }
}
