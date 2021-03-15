using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameChanger.Core.EventScheduler
{
    public class TimedAction : IDisposable
    {
        private Timer _timer;
        private Task _taskToExecute;
        public TimedAction(TimeSpan timeToExecute, Task taskToExecute)
        {            
            _timer = new Timer(Execute,null, timeToExecute, Timeout.InfiniteTimeSpan);
            _taskToExecute = taskToExecute;
        }

        private async void Execute(object state)
        {
            //await _taskToExecute;
            _taskToExecute.Start();
        }

        public void Dispose()
        {
            _timer.Dispose();
        }
    }
}
