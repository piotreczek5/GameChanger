#pragma checksum "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff0d8c5504fe0946a637b3630613e3d096e4d2d0"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/buildings")]
    public partial class Buildings : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar sticky-top");
            __builder.AddAttribute(2, "style", "background-color:white; box-shadow:0px 20px 20px 0px #7c57bbc2; top:140px;text-align:center;justify-content:space-evenly;");
            __builder.AddMarkupContent(3, "<div>\r\n            Buildings\r\n        </div>\r\n        ");
            __builder.OpenElement(4, "div");
            __builder.AddMarkupContent(5, "<div>City</div>\r\n            ");
            __builder.OpenElement(6, "div");
            __builder.AddContent(7, 
#nullable restore
#line 10 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                  CurrentPlayerSector?.City

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddMarkupContent(10, "<div>Land</div>\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddContent(12, 
#nullable restore
#line 14 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                  CurrentPlayerSector?.Land

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 17 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
         foreach (BuildingTypes buildingType in Enum.GetValues(typeof(BuildingTypes)))
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "table");
            __builder.AddAttribute(14, "class", "table table-striped");
            __builder.AddAttribute(15, "style", "margin-top:20px;margin-bottom:20px; border:groove 1px;");
            __builder.OpenElement(16, "tbody");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "style", "justify-content:left");
            __builder.OpenElement(19, "tr");
            __builder.OpenElement(20, "td");
            __builder.OpenElement(21, "p");
            __builder.AddContent(22, "Building Type: ");
            __builder.AddContent(23, 
#nullable restore
#line 23 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                                   buildingType.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                            ");
            __builder.OpenElement(25, "td");
#nullable restore
#line 25 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                 switch (GetBuildingInfoFromSector(buildingType)?.Status?.Code)
                                {
                                    case BuildingStatuses.BROKEN:

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "class", "btn btn-warning");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                                                                  () => PerformBuildingAction(buildingType,BuildActions.FIX)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(29, "  Fix building ");
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                        break;
                                    case BuildingStatuses.BUILDING:

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(30, "<button class=\"btn btn-secondary\" onclick disabled>  Building Now... </button>");
#nullable restore
#line 32 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                        break;
                                    case BuildingStatuses.IDLE:

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(31, "<button class=\"btn btn-secondary\" onclick disabled>  Idle... </button>");
#nullable restore
#line 35 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                        break;
                                    case BuildingStatuses.FIXING:

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(32, "<button class=\"btn btn-secondary\" onclick disabled>  Fixing ... </button>");
#nullable restore
#line 38 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                        break;
                                    case BuildingStatuses.BUILT:

#line default
#line hidden
#nullable disable
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "class", "btn btn-success");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                                                                  () =>PerformBuildingAction(buildingType,BuildActions.UPGRADE)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(36, "  Upgrade building ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                                        ");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "class", "btn btn-danger");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                                                                 () => PerformBuildingAction(buildingType,BuildActions.DESTROY)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(41, " Destroy ");
            __builder.CloseElement();
#nullable restore
#line 42 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                        break;
                                    default:

#line default
#line hidden
#nullable disable
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "class", "btn btn-success");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                                                                  () => PerformBuildingAction(buildingType,BuildActions.BUILD)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(45, " Build ");
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                        break;
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 50 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                         if (GetBuildingInfoFromSector(buildingType) != null)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(46, "tr");
            __builder.OpenElement(47, "p");
            __builder.AddContent(48, "Name : ");
            __builder.AddContent(49, 
#nullable restore
#line 52 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                           GetBuildingInfoFromSector(buildingType).Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                            ");
            __builder.OpenElement(51, "tr");
            __builder.OpenElement(52, "p");
            __builder.AddContent(53, "Description: ");
            __builder.AddContent(54, 
#nullable restore
#line 53 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                                 GetBuildingInfoFromConfiguration(buildingType).Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                            ");
            __builder.OpenElement(56, "tr");
            __builder.OpenElement(57, "p");
            __builder.AddContent(58, "Lvl : ");
            __builder.AddContent(59, 
#nullable restore
#line 54 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                          GetBuildingInfoFromSector(buildingType).CurrentLvl

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                            ");
            __builder.OpenElement(61, "tr");
            __builder.OpenElement(62, "p");
            __builder.AddContent(63, "Status: ");
            __builder.AddContent(64, 
#nullable restore
#line 55 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                            GetBuildingInfoFromSector(buildingType).Status.Code

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                            ");
            __builder.OpenElement(66, "tr");
            __builder.OpenElement(67, "p");
            __builder.AddContent(68, "Type : ");
            __builder.AddContent(69, 
#nullable restore
#line 56 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                           GetBuildingInfoFromSector(buildingType).BuildingType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 57 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(70, "tr");
            __builder.OpenElement(71, "p");
            __builder.AddContent(72, "Name : ");
            __builder.AddContent(73, 
#nullable restore
#line 60 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                           GetBuildingInfoFromConfiguration(buildingType).Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                            ");
            __builder.OpenElement(75, "tr");
            __builder.OpenElement(76, "p");
            __builder.AddContent(77, "Description: ");
            __builder.AddContent(78, 
#nullable restore
#line 61 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                                 GetBuildingInfoFromConfiguration(buildingType).Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                            ");
            __builder.AddMarkupContent(80, "<tr><p>Lvl : 0</p></tr>\r\n                            ");
            __builder.OpenElement(81, "tr");
            __builder.OpenElement(82, "p");
            __builder.AddContent(83, "Status: ");
            __builder.AddContent(84, 
#nullable restore
#line 63 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                            BuildingStatuses.NOT_BUILT

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                            ");
            __builder.OpenElement(86, "tr");
            __builder.OpenElement(87, "p");
            __builder.AddContent(88, "Type : ");
            __builder.AddContent(89, 
#nullable restore
#line 64 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                           GetBuildingInfoFromConfiguration(buildingType).BuildingType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 65 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(90, "tr");
            __builder.AddMarkupContent(91, "<td>Building Costs</td>");
#nullable restore
#line 69 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                             foreach (var resourceAmount in GetBuildingInfoFromConfiguration(buildingType).BuildCosts)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(92, "td");
            __builder.OpenElement(93, "p");
            __builder.AddContent(94, 
#nullable restore
#line 71 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                        resourceAmount.Resource

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(95, " : ");
            __builder.AddContent(96, 
#nullable restore
#line 71 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                                                   resourceAmount.Amount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 72 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n\r\n                        ");
            __builder.OpenElement(98, "tr");
            __builder.AddMarkupContent(99, "<td>Consumption</td>");
#nullable restore
#line 77 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                             foreach (var resourceAmount in GetBuildingInfoFromConfiguration(buildingType).BaseResourceConsumption)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(100, "td");
            __builder.OpenElement(101, "p");
            __builder.AddContent(102, 
#nullable restore
#line 79 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                        resourceAmount.Resource

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(103, " : ");
            __builder.AddContent(104, 
#nullable restore
#line 79 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                                                   resourceAmount.Amount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 80 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n\r\n                        ");
            __builder.OpenElement(106, "tr");
            __builder.AddMarkupContent(107, "<td>Production</td>");
#nullable restore
#line 85 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                             foreach (var resourceAmount in GetBuildingInfoFromConfiguration(buildingType).BaseResourceProduction)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(108, "td");
            __builder.OpenElement(109, "p");
            __builder.AddContent(110, 
#nullable restore
#line 87 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                        resourceAmount.Resource

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(111, " : ");
            __builder.AddContent(112, 
#nullable restore
#line 87 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                                                   resourceAmount.Amount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 88 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 93 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
        }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 95 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
               
            // var building in CurrentPlayerSector.Buildings
            [CascadingParameter]
            public Task<AuthenticationState> AuthState { get; set; }

            protected List<BuildingDocument> PlayerBuildings { get; set; }
            protected SectorDocument CurrentPlayerSector { get; set; }

            protected override async Task OnInitializedAsync()
            {
                await UpdatePageData();
                await base.OnInitializedAsync();
            }

            protected async Task UpdatePageData()
            {
                var authState = await AuthState;
                var currentUserId = Guid.Parse(authState.User.Claims.Where(c => c.Type == "PlayerGuid").Single().Value);
                var playerInfo = await Mediator.Send(new GetPlayerInfoQuery { Id = currentUserId });
                CurrentPlayerSector = await Mediator.Send(new GetSectorInfoQuery { Id = playerInfo.CurrentSector });
            }

            protected BuildingDocument GetBuildingInfoFromSector(BuildingTypes buildingType)
            {
                return CurrentPlayerSector?.Buildings?.SingleOrDefault(b => b.BuildingType == buildingType);
            }

            protected Building GetBuildingInfoFromConfiguration(BuildingTypes buildingType)
            {
                return BuildingConfiguration?.Buildings?.SingleOrDefault(b => b.BuildingType == buildingType);
            }

            protected async Task PerformBuildingAction(BuildingTypes buildingType, BuildActions buildAction)
            {                
                switch(buildAction)
                {
                    case BuildActions.BUILD:
                        await Mediator.Publish(new BuildBuildingCommand { BuildingType = buildingType, SectorId = CurrentPlayerSector?.Id });
                        break;
                    case BuildActions.DESTROY:
                        await Mediator.Publish(new DestroyBuildingCommand { BuildingType = buildingType, SectorId = CurrentPlayerSector?.Id });
                        //EventScheduler.ScheduleEvent(TimeSpan.FromSeconds(3), new DestroyBuildingCommand { BuildingType = buildingType, SectorId = CurrentPlayerSector.Id });
                        break;
                    case BuildActions.FIX:
                        await Mediator.Publish(new FixBuildingCommand { BuildingType = buildingType, SectorId = CurrentPlayerSector?.Id });
                        break;
                    case BuildActions.UPGRADE:
                        await Mediator.Publish(new UpgradeBuildingCommand { BuildingType = buildingType, SectorId = CurrentPlayerSector?.Id });
                        break;
                }

                await UpdatePageData();
                this.StateHasChanged();
            }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BuildingConfiguration BuildingConfiguration { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MapConfiguration MapConfiguration { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEventScheduler EventScheduler { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMediator Mediator { get; set; }
    }
}
#pragma warning restore 1591
