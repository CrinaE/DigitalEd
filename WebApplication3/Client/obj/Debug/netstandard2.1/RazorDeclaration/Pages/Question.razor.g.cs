// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 3 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\Pages\Question.razor"
using WebApplication3.Client.ViewModels;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/question/{QId:int}")]
    public partial class Question : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\Users\S2018-438316\Documents\GitHub\DigitalEd\WebApplication3\Client\Pages\Question.razor"
       
    [Parameter]
    public int QId { get; set; }

    public void OnClick()
    {
        _questionViewModel.Likes++;
        _questionViewModel.Like();
    }

    public void DownVote()
    {
        _questionViewModel.Likes--;
        _questionViewModel.Like();
    }
    public void OnClickAnswer()
    {
        _answerViewModel.Likes++;

    }
    public void DownVoteAnswer()
    {
        _answerViewModel.Likes--;

    }
    public async Task add()
    {
        _answerViewModel.IdQuestion = QId;
        await _answerViewModel.Add();
        _navigationManager.NavigateTo("/question/"+QId, true);
    }

    protected override async Task OnInitializedAsync()
    {
        _questionViewModel.Id = QId;
        _answerViewModel.IdQuestion = QId;
        await _questionViewModel.LoadaQeustion();
        await _answerViewModel.Load();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAnswerViewModel _answerViewModel { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IQuestionViewModel _questionViewModel { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
#pragma warning restore 1591
