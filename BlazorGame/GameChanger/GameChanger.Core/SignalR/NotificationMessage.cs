using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.SignalR
{
    public class NotificationMessage
    {
        public int MsgId { get; set; } = 0;
        public string BuildingName { get; set; } = "";
        public string BuildingStatus { get; set; } = "";
    }
}
