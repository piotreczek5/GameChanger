using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.MediatR.Messages
{
    public class GenerateSectorCommand : INotification
    {
        public Guid PlayerId { get; set; }
        public string CityCode  { get; set; }
        public override string ToString()
        {
            return $"GENERATING SECTORS FOR PLAYER {PlayerId} IN CITY {CityCode}";
        }
    }
}
