using GameChanger.Core.GameData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.GameData
{
    public static class StaticConfiguration
    {
        public static MapConfiguration GetMapConfiguration
        {
            get
            {
                return new MapConfiguration()
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
                        },
                        BaseResourceProduction = new List<ResourceAmount>()
                        {
                            new ResourceAmount
                            {
                                Amount = 2,
                                Resource = ResourceType.WATER
                            },
                            new ResourceAmount
                            {
                                Amount = 0.4m,
                                Resource = ResourceType.FOOD
                            },
                            new ResourceAmount
                            {
                                Amount = 0.1m,
                                Resource = ResourceType.WOOD
                            },
                            new ResourceAmount
                            {
                                Amount = 0.3m,
                                Resource = ResourceType.STONE
                            },
                            new ResourceAmount
                            {
                                Amount = 0.2m,
                                Resource = ResourceType.SAND
                            },
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
                        },
                        BaseResourceProduction = new List<ResourceAmount>()
                        {
                            new ResourceAmount
                            {
                                Amount = 2,
                                Resource = ResourceType.WATER
                            },
                            new ResourceAmount
                            {
                                Amount = 0.4m,
                                Resource = ResourceType.FOOD
                            },
                            new ResourceAmount
                            {
                                Amount = 0.1m,
                                Resource = ResourceType.WOOD
                            },
                            new ResourceAmount
                            {
                                Amount = 0.3m,
                                Resource = ResourceType.STONE
                            },
                            new ResourceAmount
                            {
                                Amount = 0.2m,
                                Resource = ResourceType.SAND
                            },
                        }
                    }
                }
                };
            }
        }

        public static BuildingConfiguration GetBuildingConfiguration { get {
                return new BuildingConfiguration()
                {
                    Buildings = new List<Building>
                    {
#region LVL1
                        new Building
                        {
                            Name = "Sawmill",
                            Description = "The only place where people actually do somtething",
                            Lvl = 1,
                            BaseResourceConsumption = new List<ResourceAmount>()
                            {
                               new ResourceAmount()
                               {
                                   Amount = 0.4m,
                                   Resource = ResourceType.FOOD
                               }
                            },
                            BaseResourceProduction = new List<ResourceAmount>()
                            {
                               new ResourceAmount()
                               {
                                   Amount = 1.2m,
                                   Resource = ResourceType.WOOD
                               }
                            },
                            BuildCosts = new List<ResourceAmount>()
                            {
                                new ResourceAmount()
                                {
                                    Amount = 20,
                                    Resource = ResourceType.WOOD
                                },
                                new ResourceAmount()
                                {
                                    Amount = 8,
                                    Resource = ResourceType.STONE
                                },
                                new ResourceAmount()
                                {
                                    Amount = 15,
                                    Resource = ResourceType.SAND
                                },
                                new ResourceAmount()
                                {
                                    Amount = 120,
                                    Resource = ResourceType.FOOD
                                }
                            },
                            FailurePercentagePerDay = 0.3m
                        },
                        new Building
                        {
                            Name = "Food plantation",
                            Description = "Where else you're going to grow food than here?",
                            Lvl = 1,
                            BaseResourceConsumption = new List<ResourceAmount>()
                            {
                               new ResourceAmount()
                               {
                                   Amount = 0.4m,
                                   Resource = ResourceType.FOOD
                               },
                               new ResourceAmount()
                               {
                                   Amount = 0.3m,
                                   Resource = ResourceType.WATER
                               }
                            },
                            BaseResourceProduction = new List<ResourceAmount>()
                            {
                               new ResourceAmount()
                               {
                                   Amount = 1.2m,
                                   Resource = ResourceType.FOOD
                               }
                            },
                            BuildCosts = new List<ResourceAmount>()
                            {
                                new ResourceAmount()
                                {
                                    Amount = 10,
                                    Resource = ResourceType.WOOD
                                },
                                new ResourceAmount()
                                {
                                    Amount = 2,
                                    Resource = ResourceType.STONE
                                },
                                new ResourceAmount()
                                {
                                    Amount = 12,
                                    Resource = ResourceType.SAND
                                },
                                new ResourceAmount()
                                {
                                    Amount = 12,
                                    Resource = ResourceType.FOOD
                                }
                            },
                            FailurePercentagePerDay = 0.03m
                        },
                        new Building
                        {
                            Name = "Stone Mine",
                            Description = "Hard work to get this stone in place!",
                            Lvl = 1,
                            BaseResourceConsumption = new List<ResourceAmount>()
                            {
                               new ResourceAmount()
                               {
                                   Amount = 1.2m,
                                   Resource = ResourceType.FOOD
                               }
                            },
                            BaseResourceProduction = new List<ResourceAmount>()
                            {
                               new ResourceAmount()
                               {
                                   Amount = 0.26m,
                                   Resource = ResourceType.STONE
                               }
                            },
                            BuildCosts = new List<ResourceAmount>()
                            {
                                new ResourceAmount()
                                {
                                    Amount = 26,
                                    Resource = ResourceType.WOOD
                                },
                                new ResourceAmount()
                                {
                                    Amount = 4,
                                    Resource = ResourceType.STONE
                                },
                                new ResourceAmount()
                                {
                                    Amount = 7,
                                    Resource = ResourceType.SAND
                                },
                                new ResourceAmount()
                                {
                                    Amount = 24,
                                    Resource = ResourceType.FOOD
                                }
                            },
                            FailurePercentagePerDay = 0.8m
                        },
                        new Building
                        {
                            Name = "Copper Mine",
                            Description = "Not all that glitters",
                            Lvl = 1,
                            BaseResourceConsumption = new List<ResourceAmount>()
                            {
                               new ResourceAmount()
                               {
                                   Amount = 1.2m,
                                   Resource = ResourceType.FOOD
                               }
                            },
                            BaseResourceProduction = new List<ResourceAmount>()
                            {
                               new ResourceAmount()
                               {
                                   Amount = 0.23m,
                                   Resource = ResourceType.COPPER_ORE
                               }
                            },
                            BuildCosts = new List<ResourceAmount>()
                            {
                                new ResourceAmount()
                                {
                                    Amount = 26,
                                    Resource = ResourceType.WOOD
                                },
                                new ResourceAmount()
                                {
                                    Amount = 4,
                                    Resource = ResourceType.STONE
                                },
                                new ResourceAmount()
                                {
                                    Amount = 7,
                                    Resource = ResourceType.SAND
                                },
                                new ResourceAmount()
                                {
                                    Amount = 24,
                                    Resource = ResourceType.FOOD
                                }
                            },
                            FailurePercentagePerDay = 0.8m
                        },
                        new Building
                        {
                            Name = "Coal Mine",
                            Description = "Black gold of the earth",
                            Lvl = 1,
                            BaseResourceConsumption = new List<ResourceAmount>()
                            {
                               new ResourceAmount()
                               {
                                   Amount = 1.2m,
                                   Resource = ResourceType.FOOD
                               }
                            },
                            BaseResourceProduction = new List<ResourceAmount>()
                            {
                               new ResourceAmount()
                               {
                                   Amount = 0.23m,
                                   Resource = ResourceType.COAL
                               }
                            },
                            BuildCosts = new List<ResourceAmount>()
                            {
                                new ResourceAmount()
                                {
                                    Amount = 26,
                                    Resource = ResourceType.WOOD
                                },
                                new ResourceAmount()
                                {
                                    Amount = 4,
                                    Resource = ResourceType.STONE
                                },
                                new ResourceAmount()
                                {
                                    Amount = 7,
                                    Resource = ResourceType.SAND
                                },
                                new ResourceAmount()
                                {
                                    Amount = 24,
                                    Resource = ResourceType.FOOD
                                }
                            },
                            FailurePercentagePerDay = 0.8m
                        },
                        new Building
                        {
                            Name = "Iron Mine",
                            Description = "Strong as steel, muscles of workers here are!",
                            Lvl = 1,
                            BaseResourceConsumption = new List<ResourceAmount>()
                            {
                               new ResourceAmount()
                               {
                                   Amount = 1.2m,
                                   Resource = ResourceType.FOOD
                               }
                            },
                            BaseResourceProduction = new List<ResourceAmount>()
                            {
                               new ResourceAmount()
                               {
                                   Amount = 0.23m,
                                   Resource = ResourceType.IRON_ORE
                               }
                            },
                            BuildCosts = new List<ResourceAmount>()
                            {
                                new ResourceAmount()
                                {
                                    Amount = 26,
                                    Resource = ResourceType.WOOD
                                },
                                new ResourceAmount()
                                {
                                    Amount = 4,
                                    Resource = ResourceType.STONE
                                },
                                new ResourceAmount()
                                {
                                    Amount = 7,
                                    Resource = ResourceType.SAND
                                },
                                new ResourceAmount()
                                {
                                    Amount = 24,
                                    Resource = ResourceType.FOOD
                                }
                            },
                            FailurePercentagePerDay = 0.8m
                        },
                        new Building
                        {
                            Name = "Sand Mine",
                            Description = "Is it better than a dessert?",
                            Lvl = 1,
                            BaseResourceConsumption = new List<ResourceAmount>()
                            {
                               new ResourceAmount()
                               {
                                   Amount = 1.2m,
                                   Resource = ResourceType.FOOD
                               }
                            },
                            BaseResourceProduction = new List<ResourceAmount>()
                            {
                               new ResourceAmount()
                               {
                                   Amount = 0.23m,
                                   Resource = ResourceType.SAND
                               }
                            },
                            BuildCosts = new List<ResourceAmount>()
                            {
                                new ResourceAmount()
                                {
                                    Amount = 26,
                                    Resource = ResourceType.WOOD
                                },
                                new ResourceAmount()
                                {
                                    Amount = 4,
                                    Resource = ResourceType.STONE
                                },
                                new ResourceAmount()
                                {
                                    Amount = 7,
                                    Resource = ResourceType.SAND
                                },
                                new ResourceAmount()
                                {
                                    Amount = 24,
                                    Resource = ResourceType.FOOD
                                }
                            },
                            FailurePercentagePerDay = 0.8m
                        }
#endregion 
                    }
                };}}
    }
}
