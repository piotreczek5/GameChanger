using GameChanger.GameUser.EntityFramework.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameChanger.GameUser.DataTypes;

namespace GameChanger.GameUser.Controllers
{
    [Route("api/Users")]
    public class UsersController : ControllerBase
    {
        private SignInManager<GameChangerUser> _signInManager;
        public UsersController(SignInManager<GameChangerUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody]InputModel userInput)
        {
            var result  = await _signInManager.PasswordSignInAsync(userInput.Email, userInput.Password, true, false);
            
            return Ok(new LoginResult { 
                Succeeded = result.Succeeded,
                IsLockedOut = result.IsLockedOut,
                IsNotAllowed = result.IsNotAllowed,
                RequiresTwoFactor = result.RequiresTwoFactor
            });
        }
    }
}
