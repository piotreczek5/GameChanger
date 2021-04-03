using GameChanger.Core.GameData;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.MediatR.Messages.Commands
{
    public class TravelToCityCommand : INotification
    {
        public Guid? PlayerId { get; set; }
        public CityCodes? DestinationCityCode { get; set; }
        public CityCodes? SourceCityCode { get; set; }
    }
}
