using GameChanger.Core.MongoDB.Documents;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.MediatR.Messages.Queries
{
    public class GetSectorInfoQuery : IRequest<SectorDocument>
    {
        public Guid? Id { get; set; }
    }
}
