using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.GameUser.EntityFramework.Domain
{
    public class GameChangerUser : IdentityUser
    {      
        [PersonalData]
        public Guid PlayerId { get; set; }        
    }
}
