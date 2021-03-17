using Convey.Types;
using GameChanger.Core.GameData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.MongoDB.Documents
{
    public class SectorResourcesDocument : IIdentifiable<Guid>
    {
        public Guid Id { get; set; }
        public Guid SectorId { get; set; }
        public List<ResourceAmount> CurrentResourceProduction { get; set; } = new List<ResourceAmount>();
        public List<ResourceAmount> CurrentResourceConsumption { get; set; } = new List<ResourceAmount>();
        public List<ResourceAmount> CurrentResourceBalance { get; set; } = new List<ResourceAmount>();
        public List<ResourceAmount> CurrentResources { get; set; } =
          Enum.GetValues(typeof(ResourceType)).Cast<ResourceType>()
          .Select(rt => new ResourceAmount { Amount = 0.0m, Resource = rt })
          .ToList();


    }
}
