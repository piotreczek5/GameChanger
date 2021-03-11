using Convey;
using Convey.Persistence.MongoDB;
using GameChanger.Core.GameData;
using GameChanger.Core.MongoDB.Documents;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.Extensions
{
    public static class MapExtensions
    {
        public static void AddMapModule(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            var mapConfiguration = StaticConfiguration.GetMapConfiguration;
            var buildingConfiguration = StaticConfiguration.GetBuildingConfiguration;

            serviceCollection.AddSingleton(mapConfiguration);
            serviceCollection.AddSingleton(buildingConfiguration);
        }

        public static IConveyBuilder AddMapModule(this IConveyBuilder builder)
        {
            return builder
                .AddMongo()
                .AddMongoRepository<SectorDocument, Guid>("Sectors");
        }

    }
}
