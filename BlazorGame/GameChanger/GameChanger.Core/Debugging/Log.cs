using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.Debugging
{
    public class Log
    {
        public ConcurrentBag<string> Messages = new ConcurrentBag<string>();
    }
}
