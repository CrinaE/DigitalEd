#pragma checksum "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64046998c31f91b6965696150771e70dbca97cf3"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication3.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\_Imports.razor"
using WebApplication3.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\_Imports.razor"
using WebApplication3.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\Pages\Login.razor"
using WebApplication3.Client.ViewModels;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/LogIn")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/bootstrap-social/5.1.1/bootstrap-social.css\">\r\n<link rel=\"stylesheet\" href=\"https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css\">\r\n");
            __builder.AddMarkupContent(1, "<h2><b>Login</b></h2>\r\n<hr>\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-6");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(5);
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "col-6");
                __builder2.AddMarkupContent(10, "\r\n            ");
                __builder2.OpenElement(11, "input");
                __builder2.AddAttribute(12, "type", "text");
                __builder2.AddAttribute(13, "class", "form-control");
                __builder2.AddAttribute(14, "placeholder", "email address");
                __builder2.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\Pages\Login.razor"
                                      _loginViewModel.EmailAddress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _loginViewModel.EmailAddress = __value, _loginViewModel.EmailAddress));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "col-6");
                __builder2.AddMarkupContent(21, "\r\n            ");
                __builder2.OpenElement(22, "input");
                __builder2.AddAttribute(23, "type", "password");
                __builder2.AddAttribute(24, "class", "form-control");
                __builder2.AddAttribute(25, "placeholder", "password");
                __builder2.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\Pages\Login.razor"
                                          _loginViewModel.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _loginViewModel.Password = __value, _loginViewModel.Password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "col-6");
                __builder2.AddMarkupContent(32, "\r\n            ");
                __builder2.OpenElement(33, "button");
                __builder2.AddAttribute(34, "class", "btn btn-primary");
                __builder2.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\Pages\Login.razor"
                                                      LoginUser

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(36, "Login");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(39, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n    <br>\r\n    <br>\r\n    ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "col-6");
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "col-6");
            __builder.AddMarkupContent(46, "\r\n            ");
            __builder.OpenElement(47, "a");
            __builder.AddAttribute(48, "class", "btn btn-block btn-social btn-facebook");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\Pages\Login.razor"
                                                                       FacebookSignIn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(50, "\r\n                <span class=\"fa fa-facebook\"></span> ");
            __builder.AddMarkupContent(51, "<b>Facebook</b>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        <br>\r\n        ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "col-6");
            __builder.AddMarkupContent(56, "\r\n            ");
            __builder.OpenElement(57, "a");
            __builder.AddAttribute(58, "class", "btn btn-block btn-social btn-google");
            __builder.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\Pages\Login.razor"
                                                                     GoogleSignIn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(60, "\r\n                <span class=\"fa fa-google\"></span> ");
            __builder.AddMarkupContent(61, "<b>Google</b>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\Pages\Login.razor"
           
        public async Task LoginUser()
        {
            if ( _loginViewModel.EmailAddress != null && _loginViewModel.Password != null)
            {
                if(_loginViewModel.EmailAddress.Contains('@'))
                {
                    await _loginViewModel.LoginUser();
                    _navigationManager.NavigateTo("/", true);
                }

            }
        }

        private void FacebookSignIn()
        {
            _navigationManager.NavigateTo("user/FacebookSignIn", true);
        }

        private void GoogleSignIn()
        {
            _navigationManager.NavigateTo("user/GoogleSignIn", true);
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILoginViewModel _loginViewModel { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
#pragma warning restore 1591
