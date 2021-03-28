using GameChanger.Core.MongoDB.Documents;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.MongoDB.Builders
{
    public static class PlayerFilterFactory
    {
        public static FilterDefinition<PlayerDocument> GetPlayerById(Guid playerId)
        {
            return Builders<PlayerDocument>.Filter.Eq(p => p.Id, playerId);
        }
    }
}
