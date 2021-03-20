using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.MediatR.Messages.Commands.Sector
{
    public class RecalculateSectorBalanceCommand : INotification
    {
        public Guid? SectorId { get; set; }
        public override string ToString()
        {
            return $"RECALCULATING BALANCE FOR SECTOR: {SectorId}";
        }
    }
}
