﻿using GameChanger.Core.GameData;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.MediatR.Messages.Commands.Buildings
{
    public class ChangeResourceSupplyCommand : INotification
    {
        public Guid SectorResourcesId { get; set; }

        public List<ResourceAmount> Resources { get; set; }

        public int IncreaseOrDecreaseMultiplier { get; set; } = 1;
        
    }
}