using Convey.Types;
using GameChanger.Core.MongoDB.Documents.Interfaces;
using GameChanger.Core.MongoDB.Documents.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.MongoDB.Documents
{
    public class PlayerDocument : IIdentifiable<Guid>, IAuditedDocument
    {
        public Guid Id { get; set; }
        public string Nick { get; set; }
        public List<Guid> Sectors { get; set; } = new List<Guid>();
        public PlayerStatus Status { get; set; }
        public bool WasInitialized { get; set; } = false;
        public DateTime ModifyTimeStamp { get; set; }
        public Guid ModifiedUserId { get; set; }
        public DateTime CreatedTimeStamp { get; set; }
        public Guid CreatedUserId { get; set; }
    }

   
}
