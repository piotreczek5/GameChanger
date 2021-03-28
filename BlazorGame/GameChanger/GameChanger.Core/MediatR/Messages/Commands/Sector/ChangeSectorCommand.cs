using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.MediatR.Messages.Commands.Sector
{
    public class ChangeSectorCommand : INotification
    {
        public Guid? PlayerId { get; set; }
        public Guid? SectorId { get; set; }

        public override string ToString()
        {
            return $"Changing current sector of player {PlayerId} to  {SectorId}";
        }

    }
}
