using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Client.ViewModels
{
    interface IRegisterViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string ProfilePic { get; set; }
        public Task SaveProfile();
    }
}
