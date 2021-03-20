using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using GameChanger.GameUser.EntityFramework.Domain;
using Microsoft.AspNetCore.Components.Server;
using GameChanger.GameUser.DataTypes;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace GameChanger.GameUser.EntityFramework
{
    public class GameChangerAuthenticationStateProvider : ServerAuthenticationStateProvider
    {        
        public GameChangerAuthenticationStateProvider()
        {
        }
        
        public async Task MarkUserAsAuthenticated(InputModel user, Guid playerGuid)
        {
            var identity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, user.Email),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.IsPersistent, "true"),
                new Claim("PlayerGuid",playerGuid.ToString())
            }, CookieAuthenticationDefaults.AuthenticationScheme);

            var claimsPrincipal = new ClaimsPrincipal(identity);

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(claimsPrincipal)));
        }


    }
}
