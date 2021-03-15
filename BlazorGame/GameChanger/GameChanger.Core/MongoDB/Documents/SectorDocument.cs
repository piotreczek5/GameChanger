using Convey.Types;
using GameChanger.Core.GameData;
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
        public List<ResourceAmount> CurrentResources { get; set; } =
           Enum.GetValues(typeof(ResourceType)).Cast<ResourceType>()
           .Select(rt => new ResourceAmount { Amount = 0.0m, Resource = rt })
           .ToList();

        public List<ResourceAmount> CurrentResourceProduction { get; set; } = new List<ResourceAmount>();
        public List<ResourceAmount> CurrentResourceConsumption { get; set; } = new List<ResourceAmount>();
        public List<ResourceAmount> CurrentResourceBalance { get; set; } = new List<ResourceAmount>();
    }

    public class BuildingDocument
    {
        public string Name { get; set; }
        public int CurrentLvl { get; set; }
        public BuildingTypes BuildingType { get; set; }
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
        NOT_BUILT
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
