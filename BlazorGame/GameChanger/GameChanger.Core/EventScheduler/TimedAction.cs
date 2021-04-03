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
        private Task _subsequentTaskToExecute;
        private bool _completed = false;
        public bool IsCompleted => _completed;
        public TimedAction(TimeSpan timeToExecute, Task taskToExecute, Task subsequentAction)
        {            
            _timer = new Timer(Execute,null, timeToExecute, Timeout.InfiniteTimeSpan);
            _subsequentTaskToExecute = subsequentAction;
            _taskToExecute = taskToExecute;
        }

        private void Execute(object state)
        {
            _taskToExecute.Start();
            if(_subsequentTaskToExecute!=null)
            {
                _subsequentTaskToExecute.Start();
            }
            
            _completed = true;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
