using Convey.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Map.MongoDB.Documents
{
    public class SectorDocument : IIdentifiable<Guid>
    {
        public Guid Id { get; set; }        

        public Guid PlayerOwner { get; set; }

    }
}
