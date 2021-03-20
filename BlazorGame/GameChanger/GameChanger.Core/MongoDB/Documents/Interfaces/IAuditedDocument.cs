using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.MongoDB.Documents.Interfaces
{
    public interface IAuditedDocument
    {
        public DateTime ModifyTimeStamp { get; set; }
        public Guid ModifiedUserId { get; set; }
        public DateTime CreatedTimeStamp { get; set; }
        public Guid CreatedUserId { get; set; }
    }
}
