// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace GameChanger.Shared
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
    public partial class LoginLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BuildingConfiguration BuildingConfiguration { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MapConfiguration MapConfiguration { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEventScheduler EventScheduler { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMediator Mediator { get; set; }
    }
}
#pragma warning restore 1591
