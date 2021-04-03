using GameChanger.Core.GameData;
using GameChanger.Core.MongoDB.Documents.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.MongoDB.Documents.Factories
{
    public class PlayerStatusFactory : IPlayerStatusFactory
    {
        public PlayerStatus Create(
            PlayerStatuses playerStatus,
            DateTime? travelPlannedArrival = null,
            Guid? sourceSectorId = null,
            Guid? destinationSectorId = null,
            LandDetails landDetails = null,
            SectorDetails sectorDetails = null,
            CityCodes? sourceCityCode = null,
            CityCodes? destinationCityCode = null)
        {
            return playerStatus switch
            {
                PlayerStatuses.IDLE_WITHOUT_SECTOR => new IdleNoSectorPlayerStatus(landDetails),
                PlayerStatuses.IDLE_WITH_SECTOR => new IdleWithSectorPlayerStatus(sectorDetails, landDetails),
                PlayerStatuses.TRAVELING => new TravelingStatus(sourceSectorId,destinationSectorId, sourceCityCode, destinationCityCode,travelPlannedArrival),
                PlayerStatuses.ON_JOURNEY=> new JourneyPlayerStatus(),
                PlayerStatuses.BUILDING => new BuildingPlayerStatus(sectorDetails)                
            };
        }
    }
}
