#pragma checksum "C:\Users\S2018-438316\source\repos\WebApplication3\WebApplication3\Client\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a1741692158f9de5a39d0078aa05817633c840f"
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
#line 1 "C:\Users\S2018-438316\source\repos\WebApplication3\WebApplication3\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\S2018-438316\source\repos\WebApplication3\WebApplication3\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\S2018-438316\source\repos\WebApplication3\WebApplication3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\S2018-438316\source\repos\WebApplication3\WebApplication3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\S2018-438316\source\repos\WebApplication3\WebApplication3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\S2018-438316\source\repos\WebApplication3\WebApplication3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\S2018-438316\source\repos\WebApplication3\WebApplication3\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\S2018-438316\source\repos\WebApplication3\WebApplication3\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\S2018-438316\source\repos\WebApplication3\WebApplication3\Client\_Imports.razor"
using WebApplication3.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\S2018-438316\source\repos\WebApplication3\WebApplication3\Client\_Imports.razor"
using WebApplication3.Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/LogIn")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2><b>Login</b></h2>\r\n<hr>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div class=\"col-6\">\r\n    <input type=\"text\" class=\"form-control\" placeholder=\"email address\">\r\n</div>\r\n<br>\r\n");
            __builder.AddMarkupContent(2, "<div class=\"col-6\">\r\n    <input type=\"password\" class=\"form-control\" placeholder=\"password\">\r\n</div>\r\n<br>\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-6");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "class", "btn btn-primary");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\S2018-438316\source\repos\WebApplication3\WebApplication3\Client\Pages\Login.razor"
                                              LoginUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(9, "Login");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n<br>\r\n<br>\r\n");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col-6");
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "class", "btn btn-primary");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\S2018-438316\source\repos\WebApplication3\WebApplication3\Client\Pages\Login.razor"
                                              FacebookSignIn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, "Facebook");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n<br>\r\n");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "col-6");
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "class", "btn btn-danger");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\S2018-438316\source\repos\WebApplication3\WebApplication3\Client\Pages\Login.razor"
                                             GoogleSignIn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(27, "Google");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\S2018-438316\source\repos\WebApplication3\WebApplication3\Client\Pages\Login.razor"
       
    public async Task LoginUser()
    {
        //await _loginViewModel.LoginUser();
        _navigationManager.NavigateTo("/", true);
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
#pragma warning restore 1591
