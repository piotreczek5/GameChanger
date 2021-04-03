using GameChanger.Core.GameData;
using GameChanger.Core.MongoDB.Documents.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.MongoDB.Documents.Factories
{
    public interface IPlayerStatusFactory
    {
        PlayerStatus Create(
            PlayerStatuses playerStatus,
            DateTime? travelPlannedArrival = null,
            Guid? sourceSectorId = null,
            Guid? destinationSectorId = null,
            LandDetails landDetails = null,
            SectorDetails sectorDetails = null,
            CityCodes? sourceCityCode = null,
            CityCodes? destinationCityCode = null);
    }
}
