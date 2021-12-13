using System;
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
        public string ProfilePic { get; set; }
        public double points { get; set; }
        public bool busy { get; set; }

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
            busy = true;
            User user = this;
            await _httpClient.PutAsJsonAsync("user/updateprofile/" + this.UserId, user);
            this.Message = "Profile updated successfully";
            busy = false;
        }

        public async Task GetProfile()
        {
            User user = await _httpClient.GetFromJsonAsync<User>("user/getprofile/" + this.UserId);
            LoadCurrentObject(user);
            this.Message = "Profile loaded successfully";
        }

        private void LoadCurrentObject(ProfileViewModel profileViewModel)
        {
            this.FirstName = profileViewModel.FirstName;
            this.LastName = profileViewModel.LastName;
            this.EmailAddress = profileViewModel.EmailAddress;
            this.ProfilePic = profileViewModel.ProfilePic;
            this.points = profileViewModel.points;
        }


        public static implicit operator ProfileViewModel(User user)
        {
            return new ProfileViewModel
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                EmailAddress = user.Email,
                UserId = user.Id,
                ProfilePic = user.ProfilePic,
                points = (double)user.Points
            };
        }

        public static implicit operator User(ProfileViewModel profileViewModel)
        {
            return new User
            {
                FirstName = profileViewModel.FirstName,
                LastName = profileViewModel.LastName,
                Email = profileViewModel.EmailAddress,
                Id = (int)profileViewModel.UserId,
                ProfilePic = profileViewModel.ProfilePic,
                Points = (int?)profileViewModel.points
            };
        }
    }
}
