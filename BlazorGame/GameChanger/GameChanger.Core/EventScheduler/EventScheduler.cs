using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameChanger.Core.EventScheduler
{
    public class EventScheduler : IEventScheduler
    {
        private IMediator _mediator;
        protected List<TimedAction> TasksRegistry { get; set; }
        public EventScheduler(IMediator mediator)
        {
            _mediator = mediator;
            TasksRegistry = new List<TimedAction>();
        }

        public void ScheduleEvent(TimeSpan timeToLaunch, INotification eventToRun)
        {
            var task = new Task(() => _mediator.Publish(eventToRun));

            TasksRegistry.Add( new TimedAction(timeToLaunch, task));            
        }
    }
}
