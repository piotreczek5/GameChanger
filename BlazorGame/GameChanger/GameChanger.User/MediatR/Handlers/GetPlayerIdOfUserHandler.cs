using GameChanger.GameUser.EntityFramework.Context;
using GameChanger.GameUser.MediatR.Messages.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameChanger.GameUser.MediatR.Handlers
{
    public class GetPlayerIdOfUserHandler : IRequestHandler<GetPlayerIdOfUser, Guid>
    {
        private readonly ApplicationUserContext _userContext;
        public GetPlayerIdOfUserHandler(ApplicationUserContext userContext)
        {
            _userContext = userContext;
        }

        public Task<Guid> Handle(GetPlayerIdOfUser request, CancellationToken cancellationToken)
        {
            return Task.FromResult(
                _userContext.Users
                .FirstOrDefault(u => u.UserName == request.UserName)
                .PlayerId
                );
                
        }
    }
}
