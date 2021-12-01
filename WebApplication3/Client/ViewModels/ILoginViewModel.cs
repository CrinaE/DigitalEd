using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Client.ViewModels
{
    interface ILoginViewModel
    {
        public string EmailAddress { get; set; }
        public string Password { get; set; }

        public Task LoginUser();
    }
}
