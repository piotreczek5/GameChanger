// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 29 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\_Imports.razor"
using System.Threading.Channels;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/buildings")]
    public partial class Buildings : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 152 "C:\Users\Piotrek\Documents\GameChanger\BlazorGame\GameChanger\GameChanger\Pages\Buildings.razor"
               
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

            protected override async Task OnAfterRenderAsync(bool firstRender)
            {
                CurrentPlayerSector?.Buildings?.ForEach(async (b) => await SpawnTimer(b));
                await base.OnAfterRenderAsync(firstRender);
            }

            protected async Task UpdatePageData()
            {
                var authState = await AuthState;
                var currentUserId = Guid.Parse(authState.User.Claims.Where(c => c.Type == "PlayerGuid").Single().Value);
                var playerInfo = await Mediator.Send(new GetPlayerInfoQuery { Id = currentUserId });
                CurrentPlayerSector = await Mediator.Send(new GetSectorInfoQuery { Id = playerInfo.CurrentSector });
            }

            private async Task SpawnTimer(BuildingDocument building)
            {
                var timerItemId = $"{building.BuildingType}_{building.Status.Code}";
                switch (building.Status.Code)
                {
                    case BuildingStatuses.BUILDING:
                        await JSRuntime.InvokeVoidAsync("startTimer", building.Status.TimeToBuild, timerItemId);
                        break;
                    case BuildingStatuses.FIXING:
                        await JSRuntime.InvokeVoidAsync("startTimer", building.Status.TimeToFix, timerItemId);
                        break;
                    case BuildingStatuses.DESTROYING:
                        await JSRuntime.InvokeVoidAsync("startTimer", building.Status.TimeToDestroy, timerItemId);
                        break;
                }

            }

            protected BuildingDocument GetBuildingInfoFromSector(BuildingTypes buildingType)
            {
                return CurrentPlayerSector?.Buildings?.SingleOrDefault(b => b.BuildingType == buildingType);
            }

            protected async Task<bool> CanPerformBuildOperation (BuildingTypes buildingType)
            {
                await UpdatePageData();

                var building = GetBuildingInfoFromConfiguration(buildingType,1);

                var currentResources =  await Mediator.Send(new GetSectorResourcesQuery { SectorId = CurrentPlayerSector?.Id });
                var hasResourcesToBuild = currentResources?.HasResources(building.BuildCosts);

                return hasResourcesToBuild.HasValue ?
                    hasResourcesToBuild.Value : false;
            }

            protected Building GetBuildingInfoFromConfiguration(BuildingTypes buildingType , int lvl)
            {
                return BuildingConfiguration?.Buildings?.SingleOrDefault(b => b.BuildingType == buildingType && b.Lvl == lvl);
            }

            protected async Task PerformBuildingAction(BuildingTypes buildingType, BuildActions buildAction, int buildingLvl)
            {
                await JSRuntime.InvokeVoidAsync("setElementDisabledStatus", $"{buildingType}_{buildAction}",true);

                var buildindInfo = GetBuildingInfoFromConfiguration(buildingType, buildingLvl);
                var sectorBuildingInfo = GetBuildingInfoFromSector(buildingType);

                switch (buildAction)
                {
                    case BuildActions.BUILD:
                        if(await CanPerformBuildOperation(buildingType) == true)
                        {
                            EventScheduler.ScheduleEvent(buildindInfo.BuildTime.Value, new BuildBuildingCommand { BuildingType = buildingType, SectorId = CurrentPlayerSector?.Id, BuildingLvl = buildingLvl });
                            await NotificationChannel.Writer.WriteAsync(new SetBuildingStatusCommand { BuildingType = buildingType, BuildingStatus = BuildingStatuses.BUILDING, SectorId = CurrentPlayerSector?.Id, TimeToBuild = DateTime.Now.Add(buildindInfo.BuildTime.Value) });
                            await NotificationChannel.Writer.WriteAsync(new ChangeResourceSupplyCommand { SectorResourcesId = CurrentPlayerSector?.SectorResourcesId, IncreaseOrDecreaseMultiplier = -1, Resources = buildindInfo.BuildCosts });
                            await SpawnTimer(sectorBuildingInfo);
                        }
                        break;
                    case BuildActions.DESTROY:
                        EventScheduler.ScheduleEvent(buildindInfo.DestroyTime.Value, new DestroyBuildingCommand { BuildingType = buildingType, SectorId = CurrentPlayerSector?.Id  });
                        await NotificationChannel.Writer.WriteAsync(new SetBuildingStatusCommand { BuildingType = buildingType, BuildingStatus = BuildingStatuses.DESTROYING, SectorId = CurrentPlayerSector?.Id, TimeToDestroy = DateTime.Now.Add(buildindInfo.DestroyTime.Value) });
                        await SpawnTimer(sectorBuildingInfo);
                        break;
                    case BuildActions.FIX:
                        await NotificationChannel.Writer.WriteAsync(new FixBuildingCommand { BuildingType = buildingType, SectorId = CurrentPlayerSector?.Id });
                        break;
                }

                Thread.Sleep(1000);
                await JSRuntime.InvokeVoidAsync("setElementDisabledStatus", $"{buildingType}_{buildAction}", false);
                await UpdatePageData();
                await InvokeAsync(StateHasChanged);
            }

        

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BuildingConfiguration BuildingConfiguration { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MapConfiguration MapConfiguration { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEventScheduler EventScheduler { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Channel<INotification> NotificationChannel { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMediator Mediator { get; set; }
    }
}
#pragma warning restore 1591
