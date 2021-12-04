using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Claims;
using System.Threading.Tasks;
using WebApplication3.Shared.Models;

namespace WebApplication3.Client
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly HttpClient _httpClient;

        public CustomAuthenticationStateProvider(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            User currentUser = await _httpClient.GetFromJsonAsync<User>("user/getcurrentuser");
            if (currentUser != null && currentUser.Email != null)
            {
                var claimemail = new Claim(ClaimTypes.Name, currentUser.Email);
                var claimid = new Claim(ClaimTypes.NameIdentifier, Convert.ToString(currentUser.Id));
                var claimsIdentity = new ClaimsIdentity(new[] { claimemail, claimid }, "serverAuth");
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                return new AuthenticationState(claimsPrincipal);
            }
            else
                return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
        }
    }
}
