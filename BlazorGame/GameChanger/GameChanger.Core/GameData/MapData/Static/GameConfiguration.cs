﻿using GameChanger.Core.GameData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.GameData
{
    public static class GameConfiguration
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
                        Code = "POLSZ",
                        Name = "POLSZANDIA",
                        AreaSurface = 305123,
                        FarmLandsPercentCoverage = 52,
                        ForestPercentCoverage = 30,
                        WaterPercentCoverage = 14,
                        Cities = new List<City>
                        {
                            new City()
                            {
                                Code =  CityCodes.POLS_PORA,
                                Name = "Poraj",
                                XCoordinate = 50.6765865m,
                                YCoordinate = 19.1972253m
                            },
                            new City()
                            {
                                Code =  CityCodes.POLS_DUPI,
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
                        Code = "SZWAB",
                        Name = "SZWABLANDIA",
                        AreaSurface = 305123,
                        FarmLandsPercentCoverage = 60,
                        ForestPercentCoverage = 12,
                        WaterPercentCoverage = 2,
                        Cities = new List<City>
                        {
                            new City()
                            {
                                Code = CityCodes.SZWA_HANG,
                                Name = "Hangower",
                                XCoordinate = 52.3797505m,
                                YCoordinate = 9.6914322m
                            },
                            new City()
                            {
                                Code = CityCodes.SZWA_FYRE,
                                Name = "Fyrerlandia",
                                XCoordinate = 52.2397505m,
                                YCoordinate = 9.6211322m
                            },
                            new City()
                            {
                                Code = CityCodes.SZWA_FART,
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
                            BuildTime = TimeSpan.FromSeconds(5),
                            DestroyTime = TimeSpan.FromSeconds(5),
                            BuildingType = BuildingTypes.SAWMILL,
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
                            BuildTime = TimeSpan.FromSeconds(5),
                            DestroyTime = TimeSpan.FromSeconds(5),
                            BuildingType = BuildingTypes.FOOD_PLANTATION,
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
                            BuildTime = TimeSpan.FromSeconds(5),
                            DestroyTime = TimeSpan.FromSeconds(5),
                            BuildingType = BuildingTypes.STONE_MINE,
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
                            BuildTime = TimeSpan.FromSeconds(5),
                            DestroyTime = TimeSpan.FromSeconds(5),
                            BuildingType = BuildingTypes.COPPER_MINE,
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
                            BuildTime = TimeSpan.FromSeconds(5),
                            DestroyTime = TimeSpan.FromSeconds(5),
                            BuildingType = BuildingTypes.COAL_MINE,
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
                            BuildTime = TimeSpan.FromSeconds(5),
                            DestroyTime = TimeSpan.FromSeconds(5),
                            BuildingType = BuildingTypes.IRON_MINE,
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
                            BuildTime = TimeSpan.FromSeconds(5),
                            DestroyTime = TimeSpan.FromSeconds(5),
                            BuildingType = BuildingTypes.SAND_MINE,
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
                        },
                        new Building
                        {
                            BuildTime = TimeSpan.FromSeconds(5),
                            DestroyTime = TimeSpan.FromSeconds(5),
                            BuildingType = BuildingTypes.WELL,
                            Name = "Well",
                            Description = "You better not fall into that!",
                            Lvl = 1,
                            BaseResourceConsumption = new List<ResourceAmount>()
                            {
                               new ResourceAmount()
                               {
                                   Amount = 0.2m,
                                   Resource = ResourceType.FOOD
                               }
                            },
                            BaseResourceProduction = new List<ResourceAmount>()
                            {
                               new ResourceAmount()
                               {
                                   Amount = 5.0m,
                                   Resource = ResourceType.WATER
                               }
                            },
                            BuildCosts = new List<ResourceAmount>()
                            {
                                new ResourceAmount()
                                {
                                    Amount = 5,
                                    Resource = ResourceType.WOOD
                                },
                                new ResourceAmount()
                                {
                                    Amount = 40,
                                    Resource = ResourceType.STONE
                                },
                                new ResourceAmount()
                                {
                                    Amount = 20,
                                    Resource = ResourceType.SAND
                                },
                                new ResourceAmount()
                                {
                                    Amount = 40,
                                    Resource = ResourceType.FOOD
                                }
                            },
                            FailurePercentagePerDay = 0.08m
                        },
                        #endregion
#region LVL2
                        new Building
                        {
                            BuildTime = TimeSpan.FromSeconds(20),
                            DestroyTime = TimeSpan.FromSeconds(20),
                            BuildingType = BuildingTypes.FOOD_PLANTATION,
                            Name = "Food plantation",
                            Description = "Where else you're going to grow food than here?",
                            Lvl = 2,
                            BaseResourceConsumption = new List<ResourceAmount>()
                            {
                               new ResourceAmount()
                               {
                                   Amount = 0.6m,
                                   Resource = ResourceType.FOOD
                               },
                               new ResourceAmount()
                               {
                                   Amount = 0.4m,
                                   Resource = ResourceType.WATER
                               }
                            },
                            BaseResourceProduction = new List<ResourceAmount>()
                            {
                               new ResourceAmount()
                               {
                                   Amount = 2.8m,
                                   Resource = ResourceType.FOOD
                               }
                            },
                            BuildCosts = new List<ResourceAmount>()
                            {
                                new ResourceAmount()
                                {
                                    Amount = 13,
                                    Resource = ResourceType.WOOD
                                },
                                new ResourceAmount()
                                {
                                    Amount = 4,
                                    Resource = ResourceType.STONE
                                },
                                new ResourceAmount()
                                {
                                    Amount = 15,
                                    Resource = ResourceType.SAND
                                },
                                new ResourceAmount()
                                {
                                    Amount = 20,
                                    Resource = ResourceType.FOOD
                                }
                            },
                            FailurePercentagePerDay = 0.02m
                        }
#endregion
                    }
                };}}
    }
}
