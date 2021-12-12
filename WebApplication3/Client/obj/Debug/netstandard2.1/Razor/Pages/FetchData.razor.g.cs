#pragma checksum "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d35b09d42f1d9e70021b9eb9fd06060232412fe"
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
#line 2 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\Pages\FetchData.razor"
using WebApplication3.Client.ViewModels;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>YourQuestions</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "col-12");
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 9 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\Pages\FetchData.razor"
     if (_answerViewModel.Answers != null && _answerViewModel.Answers.Count() > 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\Pages\FetchData.razor"
         foreach (var answer in _answerViewModel.Answers)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "            ");
            __builder.OpenElement(5, "a");
            __builder.AddAttribute(6, "href", "/question/" + (
#nullable restore
#line 13 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\Pages\FetchData.razor"
                                answer.IdQuestion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "class", "list-group-item list-group-item-action flex-column align-items-start bold-text");
            __builder.AddMarkupContent(8, "\r\n                 ");
            __builder.AddMarkupContent(9, "<span> </span> ");
            __builder.AddContent(10, 
#nullable restore
#line 15 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\Pages\FetchData.razor"
                                 answer.Contents

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 17 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\Pages\FetchData.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\Pages\FetchData.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\Pages\FetchData.razor"
       
    protected override async Task OnInitializedAsync()
    {
        await _answerViewModel.LoadYourAnswers();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAnswerViewModel _answerViewModel { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IQuestionViewModel _questionViewModel { get; set; }
    }
}
#pragma warning restore 1591
