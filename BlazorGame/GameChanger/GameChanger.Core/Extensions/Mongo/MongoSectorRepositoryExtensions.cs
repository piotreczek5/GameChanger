using Convey.Persistence.MongoDB;
using GameChanger.Core.GameData;
using GameChanger.Core.MongoDB.Documents;
using GameChanger.Core.MongoDB.Documents.Buildings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.Extensions.Mongo
{
    public static class MongoSectorRepositoryExtensions
    {
        public static async Task<BuildingDocument> GetBuildingFromSectorByType(this IMongoRepository<SectorDocument, Guid> repository,Guid sectorId, BuildingTypes buildingType)
        {
            var sector = await repository.GetAsync(sectorId);
            if (sector == null || sector.Buildings == null || !sector.Buildings.Any())
            {
                return null;
            }

            return sector.Buildings.SingleOrDefault(b => b.BuildingType == buildingType);
        }
    }
}
