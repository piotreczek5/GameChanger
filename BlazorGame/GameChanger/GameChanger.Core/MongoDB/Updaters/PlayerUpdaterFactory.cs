using GameChanger.Core.MongoDB.Documents;
using GameChanger.Core.MongoDB.Documents.Player;
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
        public static UpdateDefinition<PlayerDocument> SetCurrentSector(CurrentSectorDetails sectorDetails)
        {
            return Builders<PlayerDocument>.Update.Set(c => c.CurrentSector, sectorDetails);
        }

        public static UpdateDefinition<PlayerDocument> RemoveSector(Guid sectorId)
        {
            return Builders<PlayerDocument>.Update.Pull(c => c.Sectors, sectorId);
        }

        public static UpdateDefinition<PlayerDocument> SetPlayerStatus(PlayerStatus playerStatus)
        {
            return Builders<PlayerDocument>.Update.Set(p => p.Status, playerStatus);
        }
    }
}
