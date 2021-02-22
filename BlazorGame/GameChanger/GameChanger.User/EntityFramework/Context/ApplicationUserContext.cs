using GameChanger.GameUser.EntityFramework.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameChanger.GameUser.EntityFramework.Context
{
    public class ApplicationUserContext : IdentityDbContext<GameChangerUser>
    {
        public ApplicationUserContext(DbContextOptions<ApplicationUserContext> options) : base(options)
        {
        }

        protected ApplicationUserContext()
        {
        }
    }
}
