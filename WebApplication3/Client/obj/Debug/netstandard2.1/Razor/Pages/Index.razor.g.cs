#pragma checksum "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68f8bf05bf65ed9743bdde1e06229ff2e3678457"
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
#line 3 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\Pages\Index.razor"
using WebApplication3.Client.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\Pages\Index.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Welcome to DigitalEdu!</h1>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "col-12");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(4);
            __builder.AddAttribute(5, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(6, "\r\n            ");
                __builder2.OpenElement(7, "button");
                __builder2.AddAttribute(8, "class", "btn btn-primary");
                __builder2.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\Pages\Index.razor"
                                                      go

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(10, "<span class=\"oi oi-pencil\"></span>Add a new Question");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(11, "\r\n            <br>\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n           \r\n");
#nullable restore
#line 16 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\Pages\Index.razor"
  if (_questionViewModel.Question != null && _questionViewModel.Question.Count() > 0)
  {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\Pages\Index.razor"
     foreach (var question in _questionViewModel.Question)
     {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "      ");
            __builder.OpenElement(14, "a");
            __builder.AddAttribute(15, "href", "/question/" + (
#nullable restore
#line 20 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\Pages\Index.razor"
                          question.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "class", "list-group-item list-group-item-action flex-column align-items-start bold-text");
            __builder.AddMarkupContent(17, "\r\n       Likes: ");
            __builder.AddContent(18, 
#nullable restore
#line 22 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\Pages\Index.razor"
               question.Likes

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(19, "| ");
            __builder.AddMarkupContent(20, "<span> </span> ");
            __builder.AddContent(21, 
#nullable restore
#line 22 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\Pages\Index.razor"
                                               question.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(22, " ");
            __builder.AddMarkupContent(23, "<span> </span> ");
            __builder.AddContent(24, 
#nullable restore
#line 22 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\Pages\Index.razor"
                                                                              question.Contents

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(25, "\r\n      ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 24 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\Pages\Index.razor"
     }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\Pages\Index.razor"
      
  }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\Pages\Index.razor"
 
    public void go()
    {
        _navigationManager.NavigateTo("/addQuestion", true);
    }
    protected override async Task OnInitializedAsync()
    {
        await _questionViewModel.Load();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IQuestionViewModel _questionViewModel { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
#pragma warning restore 1591
