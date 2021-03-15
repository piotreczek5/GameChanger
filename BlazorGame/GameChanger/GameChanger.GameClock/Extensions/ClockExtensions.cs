using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.GameClock.Extensions
{
    public static class ClockExtensions
    {
        public static void AddCoreModule(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection
                .AddMediatR(typeof(CoreExtensions))
                .AddSingleton<IEventScheduler, EventScheduler.EventScheduler>()
                .AddTransient<ISectorService, SectorService>();
        }
    }
}
