using GameChanger.Core.GameData;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.MediatR.Messages.Commands.Buildings
{
    public class PerformBuildingConsumptionCommand : INotification
    {
        public Guid SectorId { get; set; }
        public BuildingTypes BuildingType { get; set; }
        public override string ToString()
        {
            return "CONSUMPTION PROCESS OF BULDING: " + BuildingType.ToString();
        }
    }
}
