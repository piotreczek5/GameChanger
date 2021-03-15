using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.MediatR.Messages.Commands.Buildings
{
    public class IncreaseWoodSupplyCommand :INotification
    {
        public Guid PlayerId { get; set; }
        public decimal Amount { get; set; }
    }
}
