#pragma checksum "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Shared\LoginLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e28cf5e90395f9e729fcb76ab1338aeaaa1249e"
// <auto-generated/>
#pragma warning disable 1591
namespace GameChanger.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
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
#line 7 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\_Imports.razor"
using Microsoft.AspNetCore.Identity;

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
    public partial class LoginLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(3);
            __builder.AddAttribute(4, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n                ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "col-12");
                __builder2.AddMarkupContent(8, "\r\n                    <br><br>\r\n                    ");
                __builder2.AddContent(9, 
#nullable restore
#line 10 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Shared\LoginLayout.razor"
                     Body

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(10, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(11, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591