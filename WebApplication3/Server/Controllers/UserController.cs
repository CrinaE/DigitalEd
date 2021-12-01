using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Facebook;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebApplication3.Server.Models;

namespace WebApplication3.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> logger;
        private readonly DigitalEduContext _context;

        public UserController(ILogger<UserController> logger, DigitalEduContext context)
        {
            this.logger = logger;
            this._context = context;
        }

        [HttpPost("loginuser")]
        public async Task<ActionResult<User>> LoginUser(User user)
        {
            User loggedInUser = await _context.User.Where(u => u.Email == user.Email && u.Password == user.Password).FirstOrDefaultAsync();

            if(loggedInUser != null)
            {
                var claim = new Claim(ClaimTypes.Name, loggedInUser.Email);
                var claimsIdentity = new ClaimsIdentity(new[] { claim }, "serverAuth");
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(claimsPrincipal);
            }

            return await Task.FromResult(loggedInUser);
        }

        [HttpGet("getcurrentuser")]
        public async Task<ActionResult<User>> GetCurrentUser()
        {
            User currentUser = new User();

            if (User.Identity.IsAuthenticated)
            {
                currentUser.Email = User.FindFirstValue(ClaimTypes.Name);
            }

            return await Task.FromResult(currentUser);
        }

        [HttpGet("logoutuser")]
        public async Task<ActionResult<String>> LogOutUser()
        {
            await HttpContext.SignOutAsync();
            return "Success";
        }

        [HttpGet("GoogleSignIn")]
        public async Task GoogleSignIn()
        {
            await HttpContext.ChallengeAsync(GoogleDefaults.AuthenticationScheme,
                new AuthenticationProperties { RedirectUri = "/" });
        }
        [HttpGet("FacebookSignIn")]
        public async Task FacebookSignIn()
        {
            await HttpContext.ChallengeAsync(FacebookDefaults.AuthenticationScheme,
                new AuthenticationProperties { RedirectUri = "/" });
        }
        [HttpGet]
        public List<User> Get()
        {
            return _context.User.ToList();
            
        }
        [HttpPut("updateprofile/{userId}")]
        public async Task<User> UpdateProfile(int userId, [FromBody] User user)
        {

            User userToUpdate = await _context.User.Where(u => u.Id == userId).FirstOrDefaultAsync();

            userToUpdate.FirstName = user.FirstName;
            userToUpdate.LastName = user.LastName;
            userToUpdate.Email = user.Email;

           await _context.SaveChangesAsync();

           return await Task.FromResult(user);
        }
        [HttpGet("getprofile/{userId}")]
        public async Task<User> GetProfile(int userId)
        {
            return await _context.User.Where(u => u.Id == userId).FirstOrDefaultAsync();
        }
    }
}
