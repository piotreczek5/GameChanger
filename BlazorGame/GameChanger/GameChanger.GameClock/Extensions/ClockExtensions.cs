using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using GameChanger.Core.EventScheduler;
using GameChanger.Core.Extensions;
using GameChanger.Core.Services.Sector;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GameChanger.GameClock.Extensions
{
    public static class ClockExtensions
    {
        public static void AddGameClock(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection
                .AddSingleton(Channel.CreateUnbounded<INotification>())
                .AddHostedService<ProcessGameMessages>()
                .AddHostedService<RecalculateResourcesHostedService>();
        }
    }
}
