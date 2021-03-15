using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.GameUser.DataTypes
{
    public class LoginResult
    {
        public bool Succeeded { get; set; }
        public bool IsLockedOut { get;  set; }        
        public bool IsNotAllowed { get;  set; }
        public bool RequiresTwoFactor { get;  set; }
    }
}
