using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.Debugging
{
    public class VisualLog
    {
        public ConcurrentDictionary<DateTime,(string messageColor, string message)> Messages = new ConcurrentDictionary<DateTime,(string, string)>();
    }
}
