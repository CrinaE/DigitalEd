using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebApplication3.Client.ViewModels;

namespace WebApplication3.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            builder.Services.AddOptions();
            builder.Services.AddAuthorizationCore();
            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddSingleton<IProfileViewModel, ProfileViewModel>();
            builder.Services.AddSingleton<ILoginViewModel, LoginViewModel>();
            builder.Services.AddSingleton<IRegisterViewModel, RegisterViewModel>();
            builder.Services.AddSingleton<IQuestionViewModel, QuestionViewModel>();
            builder.Services.AddSingleton<IAnswerViewModel, AnswerViewModel>();
            builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
            var host = builder.Build();
            await host.RunAsync();
        }
    }
}
