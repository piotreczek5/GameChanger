#pragma checksum "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08658a71231a2a04ac215b6690e45a5e849958a1"
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
                                    case BuildingStatuses.FIXING:

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(31, "<button class=\"btn btn-secondary\" onclick disabled>  Fixing ... </button>");
#nullable restore
#line 35 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                        break;
                                    case BuildingStatuses.BUILT:

#line default
#line hidden
#nullable disable
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "class", "btn btn-success");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                                                                  () =>PerformBuildingAction(buildingType,BuildActions.UPGRADE)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(35, "  Upgrade building ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                                        ");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "class", "btn btn-danger");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                                                                 () => PerformBuildingAction(buildingType,BuildActions.DESTROY)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(40, " Destroy ");
            __builder.CloseElement();
#nullable restore
#line 39 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                        break;
                                    default:

#line default
#line hidden
#nullable disable
            __builder.OpenElement(41, "button");
            __builder.AddAttribute(42, "class", "btn btn-success");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                                                                  () => PerformBuildingAction(buildingType,BuildActions.BUILD)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(44, " Build ");
            __builder.CloseElement();
#nullable restore
#line 42 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                        break;
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 47 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                         if (GetBuildingInfoFromSector(buildingType) != null)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(45, "tr");
            __builder.OpenElement(46, "p");
            __builder.AddContent(47, "Name : ");
            __builder.AddContent(48, 
#nullable restore
#line 49 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                           GetBuildingInfoFromSector(buildingType).Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                            ");
            __builder.OpenElement(50, "tr");
            __builder.OpenElement(51, "p");
            __builder.AddContent(52, "Description: ");
            __builder.AddContent(53, 
#nullable restore
#line 50 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                                 GetBuildingInfoFromConfiguration(buildingType).Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                            ");
            __builder.OpenElement(55, "tr");
            __builder.OpenElement(56, "p");
            __builder.AddContent(57, "Lvl : ");
            __builder.AddContent(58, 
#nullable restore
#line 51 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                          GetBuildingInfoFromSector(buildingType).CurrentLvl

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                            ");
            __builder.OpenElement(60, "tr");
            __builder.OpenElement(61, "p");
            __builder.AddContent(62, "Status: ");
            __builder.AddContent(63, 
#nullable restore
#line 52 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                            GetBuildingInfoFromSector(buildingType).Status.Code

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                            ");
            __builder.OpenElement(65, "tr");
            __builder.OpenElement(66, "p");
            __builder.AddContent(67, "Type : ");
            __builder.AddContent(68, 
#nullable restore
#line 53 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                           GetBuildingInfoFromSector(buildingType).BuildingType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 54 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(69, "tr");
            __builder.OpenElement(70, "p");
            __builder.AddContent(71, "Name : ");
            __builder.AddContent(72, 
#nullable restore
#line 57 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                           GetBuildingInfoFromConfiguration(buildingType).Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                            ");
            __builder.OpenElement(74, "tr");
            __builder.OpenElement(75, "p");
            __builder.AddContent(76, "Description: ");
            __builder.AddContent(77, 
#nullable restore
#line 58 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                                 GetBuildingInfoFromConfiguration(buildingType).Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                            ");
            __builder.AddMarkupContent(79, "<tr><p>Lvl : 0</p></tr>\r\n                            ");
            __builder.OpenElement(80, "tr");
            __builder.OpenElement(81, "p");
            __builder.AddContent(82, "Status: ");
            __builder.AddContent(83, 
#nullable restore
#line 60 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                            BuildingStatuses.NOT_BUILT

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                            ");
            __builder.OpenElement(85, "tr");
            __builder.OpenElement(86, "p");
            __builder.AddContent(87, "Type : ");
            __builder.AddContent(88, 
#nullable restore
#line 61 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                           GetBuildingInfoFromConfiguration(buildingType).BuildingType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 62 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(89, "tr");
            __builder.AddMarkupContent(90, "<td>Building Costs</td>");
#nullable restore
#line 66 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                             foreach (var resourceAmount in GetBuildingInfoFromConfiguration(buildingType).BuildCosts)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(91, "td");
            __builder.OpenElement(92, "p");
            __builder.AddContent(93, 
#nullable restore
#line 68 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                        resourceAmount.Resource

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(94, " : ");
            __builder.AddContent(95, 
#nullable restore
#line 68 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                                                   resourceAmount.Amount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 69 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n\r\n                        ");
            __builder.OpenElement(97, "tr");
            __builder.AddMarkupContent(98, "<td>Consumption</td>");
#nullable restore
#line 74 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                             foreach (var resourceAmount in GetBuildingInfoFromConfiguration(buildingType).BaseResourceConsumption)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(99, "td");
            __builder.OpenElement(100, "p");
            __builder.AddContent(101, 
#nullable restore
#line 76 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                        resourceAmount.Resource

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(102, " : ");
            __builder.AddContent(103, 
#nullable restore
#line 76 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                                                   resourceAmount.Amount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 77 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n\r\n                        ");
            __builder.OpenElement(105, "tr");
            __builder.AddMarkupContent(106, "<td>Production</td>");
#nullable restore
#line 82 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                             foreach (var resourceAmount in GetBuildingInfoFromConfiguration(buildingType).BaseResourceProduction)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(107, "td");
            __builder.OpenElement(108, "p");
            __builder.AddContent(109, 
#nullable restore
#line 84 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                        resourceAmount.Resource

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(110, " : ");
            __builder.AddContent(111, 
#nullable restore
#line 84 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                                                                   resourceAmount.Amount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 85 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 90 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
        }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 92 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
               
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
                        await Mediator.Publish(new BuildBuildingCommand { BuildingType = buildingType, SectorId = CurrentPlayerSector.Id });
                        break;
                    case BuildActions.DESTROY:
                        await Mediator.Publish(new DestroyBuildingCommand { BuildingType = buildingType, SectorId = CurrentPlayerSector.Id });
                        //EventScheduler.ScheduleEvent(TimeSpan.FromSeconds(3), new DestroyBuildingCommand { BuildingType = buildingType, SectorId = CurrentPlayerSector.Id });
                        break;
                    case BuildActions.FIX:
                        await Mediator.Publish(new FixBuildingCommand { BuildingType = buildingType, SectorId = CurrentPlayerSector.Id });
                        break;
                    case BuildActions.UPGRADE:
                        await Mediator.Publish(new UpgradeBuildingCommand { BuildingType = buildingType, SectorId = CurrentPlayerSector.Id });
                        break;
                }

                await Mediator.Publish(new RecalculateSectorResourcesCommand { SectorId = CurrentPlayerSector.Id });

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