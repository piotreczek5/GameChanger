using GameChanger.Core.MongoDB.Documents.Buildings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.MongoDB.Factories
{
    public interface IBuildingStatusFactory
    {
        BuildingStatus Create(BuildingStatuses buildingStatus, DateTime? dateToComplete = null);
    }
}
