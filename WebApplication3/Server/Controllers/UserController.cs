using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Facebook;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
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
