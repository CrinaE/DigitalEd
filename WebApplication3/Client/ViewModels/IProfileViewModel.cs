﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Client.ViewModels
{
    interface IProfileViewModel
    {
        public long UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Message { get; set; }
        public string ProfilePic { get; set; }


        public Task UpdateProfile();

        public Task GetProfile();
        
    }
}
