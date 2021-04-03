using GameChanger.Core.MongoDB.Documents.Buildings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameChanger.Core.MongoDB.Factories
{
    public class BuildingStatusFactory : IBuildingStatusFactory
    {
        public BuildingStatus CreateBuildingStatus(BuildingStatuses buildingStatus, DateTime? dateToComplete = null)
        {
            return buildingStatus switch
            {
                 BuildingStatuses.BUILDING =>   new BuildingBuildingStatus(dateToComplete.Value),
                 BuildingStatuses.DESTROYING => new DestroyingBuildingStatus(dateToComplete.Value),
                 BuildingStatuses.FIXING =>     new FixingBuildingStatus(dateToComplete.Value),
                 _ => new BuildingStatus(buildingStatus)
            };
        }
    }
}
