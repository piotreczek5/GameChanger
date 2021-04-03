using GameChanger.Core.MongoDB.Documents.Player;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.Core.MediatR.Messages.Commands.Player
{
    public class ChangePlayerStatusCommand : INotification
    {
        public PlayerStatus Status { get; set; }
        public Guid? PlayerId { get; set; }

        public override string ToString()
        {
            return $"CHANGING PLAYER STATUS TO {Status.Code}";
        }
    }
}
