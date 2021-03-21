using Convey.Persistence.MongoDB;
using GameChanger.Core.GameData;
using GameChanger.Core.MediatR.Handlers.Sector;
using GameChanger.Core.MediatR.Messages.Commands.Buildings;
using GameChanger.Core.MongoDB.Builders;
using GameChanger.Core.MongoDB.Documents;
using GameChanger.Core.MongoDB.Updaters;
using GameChanger.Core.Services.Sector;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace GameChanger.Core.MediatR.Handlers.Buildings
{
    public class BuildBuildingCommandHandler : BaseSectorHandler, INotificationHandler<BuildBuildingCommand>
    {
        public BuildBuildingCommandHandler(IMongoRepository<SectorDocument, Guid> sectorDocuments, IMediator mediator, ISectorService sectorService, IMongoRepository<SectorResourcesDocument, Guid> sectorResourcesDocuments, Channel<INotification> channel, BuildingConfiguration buildingConfiguration) : base(sectorDocuments, mediator, sectorService, sectorResourcesDocuments, channel, buildingConfiguration)
        {
        }

        public async Task Handle(BuildBuildingCommand notification, CancellationToken cancellationToken)
        {
            if (!notification.SectorId.HasValue)
                return;

            var sector = await  _sectorDocuments.GetAsync(notification.SectorId.Value);
            var existingBuilding = sector.Buildings.SingleOrDefault(b => b.BuildingType == notification.BuildingType);
            if (sector!= null)
            {
                if(existingBuilding != null )
                {
                    var sectorResources = await _sectorResourcesDocuments.GetAsync(sector.SectorResourcesId);
                    var buildingTemplate = _buildingConfiguration.GetBuildingByType(notification.BuildingType, notification.BuildingLvl);

                    if (buildingTemplate == null || !sectorResources.HasResources(buildingTemplate.BuildCosts))
                    {
                        return;
                    }

                    var buildingInSectorFilter = SectorFilterFactory.GetBuildingFromSectorByType(sector.Id, existingBuilding.BuildingType);
                    var upgradeBuildingUpdater = SectorUpdaterFactory.SetBuildingLvlBuilding(notification.BuildingLvl);
                    
                    await _sectorDocuments.Collection.UpdateOneAsync(buildingInSectorFilter, upgradeBuildingUpdater);
                    
                }
                else
                {
                    var sectorResources = await _sectorResourcesDocuments.GetAsync(sector.SectorResourcesId);
                    var buildingTemplate = _buildingConfiguration.GetBuildingByType(notification.BuildingType, 1);

                    if (buildingTemplate != null && !sectorResources.HasResources(buildingTemplate.BuildCosts))
                    {
                        return;
                    }

                    var addBuildingUpdater = SectorUpdaterFactory.AddBuilding(new BuildingDocument(buildingTemplate));
                    var buildingInSectorFilter = SectorFilterFactory.GetSectorById(sector.Id);

                    await _sectorDocuments.Collection.FindOneAndUpdateAsync<SectorDocument>(buildingInSectorFilter, addBuildingUpdater);                   
                }

                await _channel.Writer.WriteAsync(new SetBuildingStatusCommand()
                {
                    BuildingStatus = BuildingStatuses.BUILT,
                    BuildingType = notification.BuildingType,
                    SectorId = notification.SectorId                    
                });
            }
        }
    }
}
