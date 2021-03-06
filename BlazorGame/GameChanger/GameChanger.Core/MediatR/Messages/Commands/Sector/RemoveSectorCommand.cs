﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.MediatR.Messages.Commands.Sector
{
    public class RemoveSectorCommand : INotification
    {
        public Guid? SectorId { get; set; }
    }
}
