﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WebApplication3.Shared.Models;

namespace WebApplication3.Client.ViewModels
{
    public class ProfileViewModel : IProfileViewModel
    {
        public long UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Message { get; set; }

        private HttpClient _httpClient;

        public ProfileViewModel()
        {

        }

        public ProfileViewModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task UpdateProfile()
        {
            User user = this;
            await _httpClient.PutAsJsonAsync("user/updateprofile/1", user);
            this.Message = "Profile updated successfully";
        }

        public async Task GetProfile()
        {
            User user = await _httpClient.GetFromJsonAsync<User>("user/getprofile/1");
            LoadCurrentObject(user);
            this.Message = "Profile loaded successfully";
        }

        private void LoadCurrentObject(ProfileViewModel profileViewModel)
        {
            this.FirstName = profileViewModel.FirstName;
            this.LastName = profileViewModel.LastName;
            this.EmailAddress = profileViewModel.EmailAddress;
            //add more fields
        }

        public static implicit operator ProfileViewModel(User user)
        {
            return new ProfileViewModel
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                EmailAddress = user.Email,
                UserId = user.Id
            };
        }

        public static implicit operator User(ProfileViewModel profileViewModel)
        {
            return new User
            {
                FirstName = profileViewModel.FirstName,
                LastName = profileViewModel.LastName,
                Email = profileViewModel.EmailAddress,
                Id = (int)profileViewModel.UserId
            };
        }
    }
}