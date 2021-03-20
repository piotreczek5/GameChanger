using GameChanger.Core.GameData;
using GameChanger.Core.MongoDB.Documents;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.MediatR.Messages.Commands.Buildings
{
    public class SetBuildingStatusCommand : INotification
    {
        public Guid SectorId { get; set; }
        public BuildingTypes BuildingType { get; set; }
        public BuildingStatuses BuildingStatus { get; set; }
        public override string ToString()
        {
            return $"SETTING STATUS OF BULDING: {BuildingType} TO {BuildingStatus} ";
        }
    }
}
