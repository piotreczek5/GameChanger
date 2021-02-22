using Convey;
using Convey.Persistence.MongoDB;
using GameChanger.Map.MapData;
using GameChanger.Map.MongoDB.Documents;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Map.Extensions
{
    public static class MapExtensions
    {
        public static void AddMapModule(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            var mapConfiguration = new MapConfiguration()
            {
                Lands = new List<Land>
                {
                    new Land()
                    {
                        Name = "POLSZANDIA",
                        AreaSurface = 305123,
                        FarmLandsPercentCoverage = 52,
                        ForestPercentCoverage = 30,
                        WaterPercentCoverage = 14,
                        Cities = new List<City>
                        {
                            new City()
                            {
                                Name = "Poraj",
                                XCoordinate = 50.6765865m,
                                YCoordinate = 19.1972253m
                            },
                            new City()
                            {
                                Name = "Dupiakowo",
                                XCoordinate = 50.2344422m,
                                YCoordinate = 19.2342253m
                            }
                        }                        
                    },
                    new Land()
                    {
                        Name = "SZWABLANDIA",
                        AreaSurface = 305123,
                        FarmLandsPercentCoverage = 60,
                        ForestPercentCoverage = 12,
                        WaterPercentCoverage = 2,
                        Cities = new List<City>
                        {
                            new City()
                            {
                                Name = "Hangower",
                                XCoordinate = 52.3797505m,
                                YCoordinate = 9.6914322m
                            },
                            new City()
                            {
                                Name = "Fyrerlandia",
                                XCoordinate = 52.2397505m,
                                YCoordinate = 9.6211322m
                            },
                            new City()
                            {
                                Name = "Fartfurt",
                                XCoordinate = 52.2111505m,
                                YCoordinate = 9.6234222m
                            }
                        }
                    }
                }
            };

            serviceCollection.AddSingleton(mapConfiguration);
        }

        public static IConveyBuilder AddMapModule(this IConveyBuilder builder)
        {
            return builder
                .AddMongo()
                .AddMongoRepository<SectorDocument, Guid>("Sectors");
        }

    }
}
