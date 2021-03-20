using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.MediatR.Messages
{
    public class CreatePlayersCommand : INotification
    {
        public List<string> Nicks { get; set; }
        public override string ToString()
        {
            return "CREATING PLAYERS " + string.Join("|",Nicks);
        }
    }
}
