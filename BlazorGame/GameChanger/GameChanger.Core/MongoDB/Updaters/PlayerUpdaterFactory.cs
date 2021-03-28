using GameChanger.Core.MongoDB.Documents;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.MongoDB.Updaters
{
    public static class PlayerUpdaterFactory
    {
        public static UpdateDefinition<PlayerDocument> SetCurrentSector(Guid sectorId)
        {
            return Builders<PlayerDocument>.Update.Set(c => c.CurrentSector, sectorId);
        }
        public static UpdateDefinition<PlayerDocument> RemoveSector(Guid sectorId)
        {
            return Builders<PlayerDocument>.Update.Pull(c => c.Sectors, sectorId);
        }
    }
}
