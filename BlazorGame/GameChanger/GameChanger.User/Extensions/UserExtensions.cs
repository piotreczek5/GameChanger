using GameChanger.GameUser.EntityFramework;
using GameChanger.GameUser.EntityFramework.Context;
using GameChanger.GameUser.EntityFramework.Domain;
using GameChanger.GameUser.Services;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameChanger.GameUser.Extensions
{
    public static class UserExtensions
    {
        public static void AddUserModule(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("Default");
            
            serviceCollection
                .AddDbContext<ApplicationUserContext>(options =>
                {
                    options.UseSqlServer(connectionString);
                });

            serviceCollection
                .AddDefaultIdentity<GameChangerUser>()
                .AddEntityFrameworkStores<ApplicationUserContext>();

            serviceCollection.AddScoped<AuthenticationStateProvider, GameChangerAuthenticationStateProvider>();
            serviceCollection.AddHttpClient<IUserService, UserService>();
            serviceCollection.AddMediatR(typeof(UserExtensions));
        }

        public static void UseUserModule(this IApplicationBuilder applicationBuilder)
        {
            applicationBuilder.UseAuthentication();
            applicationBuilder.UseAuthorization();
        }
    }
}
