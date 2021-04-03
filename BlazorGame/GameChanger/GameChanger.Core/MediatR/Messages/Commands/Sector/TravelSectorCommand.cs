using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.MediatR.Messages.Commands.Sector
{
    public class TravelSectorCommand : INotification
    {
        public Guid? PlayerId { get; set; }
        public Guid? SourceSectorId { get; set; }
        public Guid? DestinationSectorId { get; set; }
        public string SourceCityCode { get; set; }

        public override string ToString()
        {
            return $"Setting a travel to sector of player {PlayerId} from {SourceSectorId} to  {DestinationSectorId}";
        }
    }
}
