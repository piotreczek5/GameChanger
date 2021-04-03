using Convey;
using Convey.Persistence.MongoDB;
using GameChanger.Core.Debugging;
using GameChanger.Core.EventScheduler;
using GameChanger.Core.MongoDB.Documents;
using GameChanger.Core.MongoDB.Factories;
using GameChanger.Core.Services;
using GameChanger.Core.Services.Logging;
using GameChanger.Core.Services.Sector;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameChanger.Core.Extensions
{
    public static class CoreExtensions
    {
        public static void AddCoreModule(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection
                .AddMediatR(typeof(CoreExtensions))
                .AddSingleton<IGameNotificationProcessor, GameNotificationProcessor>()
                .AddSingleton<VisualLog>()
                .AddTransient<IGameLogger, GameLogger>()
                .AddSingleton<IEventScheduler, EventScheduler.EventScheduler>()
                .AddTransient<ISectorService, SectorService>()
                .AddTransient<IBuildingStatusFactory,BuildingStatusFactory>();     
            
        }

        public static IConveyBuilder AddCoreModule(this IConveyBuilder builder)
        {
            return builder
                .AddMongo()                
                .AddMongoRepository<LogDocument, Guid>("Logs")
                .AddMongoRepository<PlayerDocument, Guid>("Players");
        }
    }
}
