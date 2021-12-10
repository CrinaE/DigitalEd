using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WebApplication3.Shared.Models;

namespace WebApplication3.Client.ViewModels
{
    public class RegisterViewModel : IRegisterViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string ProfilePic { get; set; }

        public RegisterViewModel()
        {

        }
        private HttpClient _httpClient;
        public RegisterViewModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task SaveProfile()
        {
            User user = this;
            await _httpClient.PutAsJsonAsync("user/newuser/", user);
        }

        public static implicit operator RegisterViewModel(User user)
        {
            return new RegisterViewModel
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Password = user.Password,
                EmailAddress = user.Email,
                ProfilePic = user.ProfilePic
            };
        }

        public static implicit operator User(RegisterViewModel registerViewModel)
        {
            return new User
            {
                FirstName = registerViewModel.FirstName,
                LastName = registerViewModel.LastName,
                Email = registerViewModel.EmailAddress,
                ProfilePic = registerViewModel.ProfilePic,
                Password = registerViewModel.Password
            };
        }
    }
}
