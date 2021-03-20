using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.Services.Logging
{
    public interface IGameLogger
    {
        void Log(string message, string details, LogLevel loglevel);
    }
}
