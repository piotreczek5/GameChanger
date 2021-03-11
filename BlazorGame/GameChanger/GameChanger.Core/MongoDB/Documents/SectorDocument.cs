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
    }

    public class BuildingDocument
    {
        public string Name { get; set; }
        public int CurrentLvl { get; set; }
        public BuildingStatus Status { get; set; }
    }

    public enum BuildingStatuses
    {
        BUILDING,
        BROKEN,
        FIXING,
        STANDARD
    }

    public class BuildingStatus
    { 
        public BuildingStatuses Code { get; set; }
    }

}
