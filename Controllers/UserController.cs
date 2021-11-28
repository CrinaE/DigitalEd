using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authentication.Facebook;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalEdu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IWebHostEnvironment environment;
        public UserController(IWebHostEnvironment environment)
        {
            this.environment = environment;
        }
        [HttpGet("GoogleSignIn")]
        public async Task<ActionResult> GoogleSignIn()
        {
            var properties = new AuthenticationProperties
            {
                RedirectUri = "/"
        };
            return Challenge(properties, GoogleDefaults.AuthenticationScheme);
        }
        [HttpGet("FacebookSignIn")]
        public async Task<ActionResult> FacebookSignIn()
        {
            var properties = new AuthenticationProperties
            {
                RedirectUri = "/"
            };
            return Challenge(properties, FacebookDefaults.AuthenticationScheme);
        }
    }
}
