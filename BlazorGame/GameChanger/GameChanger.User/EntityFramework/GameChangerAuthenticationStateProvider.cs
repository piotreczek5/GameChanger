using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using GameChanger.GameUser.EntityFramework.Domain;
using Microsoft.AspNetCore.Components.Server;

namespace GameChanger.GameUser.EntityFramework
{
    public class GameChangerAuthenticationStateProvider : ServerAuthenticationStateProvider
    {
        
        public GameChangerAuthenticationStateProvider()
        {
        }

        public async Task MarkUserAsAuthenticated(GameChangerUser user)
        {
            var identity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Email, user.Email),

            }, "apiauth_type");

            var claimsPrincipal = new ClaimsPrincipal(identity);

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(claimsPrincipal)));
        }


    }
}
