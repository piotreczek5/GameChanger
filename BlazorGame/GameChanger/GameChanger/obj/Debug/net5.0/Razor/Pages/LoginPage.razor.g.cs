#pragma checksum "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\LoginPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cf2c1108a75d80cdcf926f0ac81187519c8431f"
// <auto-generated/>
#pragma warning disable 1591
namespace GameChanger.Pages
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\_Imports.razor"
using MediatR;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\_Imports.razor"
using GameChanger.Core.MediatR.Messages.Queries;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\_Imports.razor"
using GameChanger.Core.MediatR.Messages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\_Imports.razor"
using GameChanger.Core.MongoDB.Documents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\_Imports.razor"
using GameChanger.GameUser.MediatR.Messages.Queries;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\_Imports.razor"
using GameUser.EntityFramework.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\_Imports.razor"
using GameChanger;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\_Imports.razor"
using GameChanger.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\_Imports.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\_Imports.razor"
using GameChanger.GameUser.EntityFramework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\_Imports.razor"
using GameChanger.GameUser.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\_Imports.razor"
using GameChanger.Core.GameData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\_Imports.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\_Imports.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\_Imports.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\_Imports.razor"
using GameChanger.Core.EventScheduler;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\_Imports.razor"
using GameChanger.Core.MediatR.Messages.Commands.Buildings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\_Imports.razor"
using GameChanger.Core.MediatR.Messages.Commands.Sector;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\_Imports.razor"
using GameChanger.Core.MediatR.Messages.Queries.Sector;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\_Imports.razor"
using System.Threading.Channels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\_Imports.razor"
using GameChanger.Core.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\_Imports.razor"
using GameChanger.Core.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\_Imports.razor"
using GameChanger.Core.MongoDB.Documents.Buildings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\LoginPage.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\LoginPage.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\LoginPage.razor"
using GameChanger.GameUser.DataTypes;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class LoginPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "<div class=\"col-12 row\"><p>&nbsp;</p></div>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-12 row");
            __builder.AddMarkupContent(5, @"<div class=""col-6"" style=""border-right:groove""><div><br><br><br><br><br></div>
            <img src=""https://borlabs.io/wp-content/uploads/2019/09/blog-wp-login.png"" width=""600px"" height=""200px"">
            <div><br><br><br><br><br></div></div>
        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-6 justify-content-center");
            __builder.AddAttribute(8, "style", "border-left:groove");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(9);
            __builder.AddAttribute(10, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 29 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\LoginPage.razor"
                              Input

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 29 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\LoginPage.razor"
                                                     ValidateUser

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(13, "<div><br><br><br><br><br></div>\r\n                ");
                __builder2.AddMarkupContent(14, "<div style=\"margin-left:auto;margin-right:auto\"><h3> Game Changer Login</h3></div>\r\n                ");
                __builder2.AddMarkupContent(15, "<div><br></div>\r\n                ");
                __builder2.OpenElement(16, "div");
                __builder2.OpenElement(17, "input");
                __builder2.AddAttribute(18, "class", "form-control col-12");
                __builder2.AddAttribute(19, "placeholder", "Email address");
                __builder2.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\LoginPage.razor"
                                                                                          Input.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Input.Email = __value, Input.Email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n                <br>\r\n                ");
                __builder2.OpenElement(23, "div");
                __builder2.OpenElement(24, "input");
                __builder2.AddAttribute(25, "type", "password");
                __builder2.AddAttribute(26, "class", "form-control col-12");
                __builder2.AddAttribute(27, "placeholder", "Password");
                __builder2.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\LoginPage.razor"
                                                                                                     Input.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Input.Password = __value, Input.Password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                <br>\r\n                ");
                __builder2.OpenElement(31, "div");
                __builder2.OpenElement(32, "input");
                __builder2.AddAttribute(33, "type", "checkbox");
                __builder2.AddAttribute(34, "class", "form-control col-12");
                __builder2.AddAttribute(35, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 46 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\LoginPage.razor"
                                                                               Input.RememberMe

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Input.RememberMe = __value, Input.RememberMe));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n                <br>\r\n                ");
                __builder2.AddMarkupContent(38, "<div><span class=\"col-12\"></span>\r\n                    <input id=\"loginButton\" type=\"submit\" class=\"form-control col-6 btn btn-primary\" value=\"Login\"></div>\r\n                <br>\r\n                ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "hidden", 
#nullable restore
#line 54 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\LoginPage.razor"
                              _hideResult

#line default
#line hidden
#nullable disable
                );
                __builder2.OpenElement(41, "p");
                __builder2.AddAttribute(42, "class", "alert" + " alert-" + (
#nullable restore
#line 55 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\LoginPage.razor"
                                           _alertType

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(43, 
#nullable restore
#line 55 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\LoginPage.razor"
                                                        _resultText

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                ");
                __builder2.AddMarkupContent(45, "<div><br><br><br><br><br></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\LoginPage.razor"
      
    private bool _hideResult = true;
    private string _alertType = "info";
    private string _resultText = string.Empty;

    private InputModel Input = new InputModel() { Email = "pusz.piotr@wp.pl", Password = "Pusz.piotr!1"  };

    [CascadingParameter]
    private Task<AuthenticationState> AuthenticationStateTask { get; set; }

    protected async override Task OnInitializedAsync()
    {
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        if (authState?.User?.Identity?.IsAuthenticated == true)
        {
            NavigationManager.NavigateTo("/index");
        }
    }

    private async Task<bool> LoginAsync()
    {
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(@"http://localhost:50528");

        string serializedUser = JsonConvert.SerializeObject(Input);

        var requestMessage = new HttpRequestMessage(HttpMethod.Post, "api/Users/Login");
        requestMessage.Content = new StringContent(serializedUser);

        requestMessage.Content.Headers.ContentType
            = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

        var response = await client.SendAsync(requestMessage);

        var responseStatusCode = response.StatusCode;
        var responseBody = await response.Content.ReadAsStringAsync();

        var loginInResult = JsonConvert.DeserializeObject<LoginResult>(responseBody);

        return loginInResult?.Succeeded ?? false;
    }

    private async Task<bool> ValidateUser()
    {
        await JSRuntime.InvokeVoidAsync("setElementDisabledStatus", $"loginButton", true);
        var user = await UserManager.FindByNameAsync(Input.Email);

        if (user != null)
        {
            var succeded = await LoginAsync();

            if (succeded == true)
            {
                await ((GameChangerAuthenticationStateProvider)AuthenticationStateProvider).MarkUserAsAuthenticated(Input, user.PlayerId);
                NavigationManager.NavigateTo("/index");
            }
            else
            {
                _resultText = "Incorrect Password.";
                _alertType = "danger";
            }
        }
        else
        {
            _alertType = "warning";
            _resultText = "Could not find user.";
        }

        _hideResult = false;
        
        return await Task.FromResult(true);

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService UserService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<GameChangerUser> UserManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthStatePrvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignInManager<GameChangerUser> SignInManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BuildingConfiguration BuildingConfiguration { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MapConfiguration MapConfiguration { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEventScheduler EventScheduler { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGameNotificationProcessor GameNotificationProcessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMediator Mediator { get; set; }
    }
}
#pragma warning restore 1591
