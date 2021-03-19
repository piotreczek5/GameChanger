using MediatR;
using System;
using System.Threading.Tasks;

namespace GameChanger.Core.EventScheduler
{
    public interface IEventScheduler
    {
        void ScheduleEvent(TimeSpan timeToLaunch, INotification eventToRun);
        void ClearQueue();
    }
}