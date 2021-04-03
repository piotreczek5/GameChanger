using GameChanger.Core.GameData;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.MediatR.Messages.Commands.Sector
{
    public class ChangeCityCommand : INotification
    {
        public Guid? PlayerId { get; set; }
        public CityCodes? CityCode { get; set; }

        public override string ToString()
        {
            return $"Changing current city of player {PlayerId} to  {CityCode}";
        }

    }
}
