using Convey.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.MongoDB.Documents
{
    public class PlayerDocument : IIdentifiable<Guid>
    {
        public Guid Id { get; set; }
        public string Nick { get; set; }
        public List<Guid> Sectors { get; set; } = new List<Guid>();
        public bool WasInitialized { get; set; } = false;
        public Guid CurrentSector { get; set; }
    }
}
