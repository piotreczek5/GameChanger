using Convey;
using Convey.Persistence.MongoDB;
using GameChanger.Core.MongoDB.Documents;
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
                .AddMediatR(typeof(CoreExtensions));
        }

        public static IConveyBuilder AddCoreModule(this IConveyBuilder builder)
        {
            return builder
                .AddMongo()
                .AddMongoRepository<PlayerDocument, Guid>("Players");
        }
    }
}
