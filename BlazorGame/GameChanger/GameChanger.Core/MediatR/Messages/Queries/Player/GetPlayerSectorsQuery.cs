using GameChanger.Core.MongoDB.Documents;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.MediatR.Messages.Queries
{
    public class GetPlayerSectorsQuery : IRequest<IReadOnlyList<SectorDocument>>
    {
        public Guid? PlayerId { get; set; }
    }
}
