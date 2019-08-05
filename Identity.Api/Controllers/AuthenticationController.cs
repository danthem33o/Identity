using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Identity.Api.Models;
using Identity.Models.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AuthenticationController : ControllerBase
    {
        public AuthenticationController(SignInManager<ApplicationUser> signInManager)
        {
            SignInManager = signInManager;
        }

        protected readonly SignInManager<ApplicationUser> SignInManager;

        [AllowAnonymous]
        [HttpPost("Register")]
        public IActionResult Register([FromBody]RegisterDto model)
        {
            //var result = SignInManager;
            return Ok();
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Login([FromBody]LoginDto model)
        {
            var result = SignInManager.PasswordSignInAsync(
                userName: model.Username,
                password: model.Password,
                isPersistent: true,
                lockoutOnFailure: true
            );

            if (result.IsCompletedSuccessfully)
            {
                return Ok();
            }

            return Unauthorized();
        }

        [Authorize, HttpPost("logout")]
        public IActionResult Logout()
        {
            SignInManager.SignOutAsync();

            return Ok();
        }
    }
}
