using GameChanger.Core.MongoDB.Documents;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.MediatR.Messages.Queries.Sector
{
    public class GetSectorBuildingsQuery : IRequest<IEnumerable<BuildingDocument>>
    {
        public Guid SectorId { get; set; }
    }
}
