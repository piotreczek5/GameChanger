using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.GameUser.MediatR.Messages.Queries
{
    public class GetPlayerIdOfUser : IRequest<Guid>
    {
        public string UserName { get; set; }
    }
}
