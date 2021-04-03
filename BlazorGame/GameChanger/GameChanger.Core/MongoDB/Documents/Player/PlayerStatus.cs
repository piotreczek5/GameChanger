using GameChanger.Core.GameData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.MongoDB.Documents.Player
{
    public class PlayerStatus : ILocationDetails
    {
        public PlayerStatus(PlayerStatuses code)
        {
            Code = code;
        }

        public PlayerStatuses Code { get; set; }
        public SectorDetails CurrentSectorDetails { get; set; }
        public LandDetails CurrentLandDetails { get; set; }
    }

    public interface ILocationDetails
    {
        SectorDetails CurrentSectorDetails { get; set; }
        LandDetails CurrentLandDetails { get; set; }
    }

    public class SectorDetails
    {
        public Guid? SectorId { get; set; }
        public DateTime? ArrivedAt { get; set; }
    }
    
    public class LandDetails
    {
        public CityCodes CityCode { get; set; }
        public string LandCode { get; set; }
        public DateTime? ArrivedAt { get; set; }
    }

    public class IdleWithSectorPlayerStatus : PlayerStatus
    {
        public IdleWithSectorPlayerStatus(SectorDetails sectorDetails, LandDetails landDetails) : base(PlayerStatuses.IDLE_WITH_SECTOR)
        {
            CurrentSectorDetails = sectorDetails;
            CurrentLandDetails = landDetails;
        }
    }

    public class IdleNoSectorPlayerStatus : PlayerStatus
    {
        public IdleNoSectorPlayerStatus(LandDetails landDetails) : base(PlayerStatuses.IDLE_WITHOUT_SECTOR)
        {
            CurrentSectorDetails = null;
            CurrentLandDetails = landDetails;
        }
    }

    public class TravelingStatus : PlayerStatus
    {
        public Guid? SourceSector { get; set; }
        public Guid? DestinationSector { get; set; }
        public CityCodes? SourceCity { get; set; }
        public CityCodes? DestinationCity { get; set; }

        public DateTime? PlannedArrival { get; set; }
        public TravelingStatus(Guid? sourceSector, Guid? destinationSector, CityCodes? sourceCityCode, CityCodes? destinationCityCode, DateTime? plannedArrival) : base(PlayerStatuses.TRAVELING)
        {
            SourceSector = sourceSector;
            DestinationSector = destinationSector;
            SourceCity = sourceCityCode;
            DestinationCity = destinationCityCode;
            PlannedArrival = plannedArrival;
        }
    }

    public class JourneyPlayerStatus : PlayerStatus
    {
        public JourneyPlayerStatus() : base(PlayerStatuses.ON_JOURNEY)
        {
        }
    }

    public class BuildingPlayerStatus : PlayerStatus
    {
        public BuildingPlayerStatus(SectorDetails sectorDetails) : base(PlayerStatuses.BUILDING)
        {
            CurrentSectorDetails = sectorDetails;
        }
    }


    public enum PlayerStatuses
    {
        IDLE_WITH_SECTOR = 0,
        TRAVELING = 1,
        ON_JOURNEY = 2,
        BUILDING = 3,
        IDLE_WITHOUT_SECTOR = 4
    }
}
