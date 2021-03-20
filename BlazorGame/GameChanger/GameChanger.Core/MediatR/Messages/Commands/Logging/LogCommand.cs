using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.MediatR.Messages.Commands.Logging
{
    public class LogCommand :INotification
    {
        public DateTime TimeStamp { get; set; }
        public string Message { get; set; }
        public string Details { get; set; }
        public LogLevel LogLevel { get; set; }
    }
}
