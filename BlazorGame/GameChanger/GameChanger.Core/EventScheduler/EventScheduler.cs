using GameChanger.Core.Services;
using MediatR;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace GameChanger.Core.EventScheduler
{
    public class EventScheduler : IEventScheduler
    {
        private readonly IGameNotificationProcessor notificationProcessor;

        protected ConcurrentDictionary<Guid,TimedAction> TasksRegistry { get; set; }
        public EventScheduler(IGameNotificationProcessor notificationProcessor)
        {
            TasksRegistry = new ConcurrentDictionary<Guid,TimedAction>();
            this.notificationProcessor = notificationProcessor;
        }

        public void ScheduleEvent(TimeSpan timeToLaunch, INotification eventToRun)
        {
            var task = new Task(async () =>
                await notificationProcessor.ProcessAsync(eventToRun)
            );

            TasksRegistry.TryAdd(Guid.NewGuid(),new TimedAction(timeToLaunch, task));            
        }

        public void ClearQueue()
        {
            var toRemove = TasksRegistry.ToArray()
                .Where(t => t.Value.IsCompleted)
                .ToList();

            foreach(var toBeRemoved in toRemove)
            {
                TasksRegistry.TryRemove(toBeRemoved.Key, out _);
            }
        }
    }
}
