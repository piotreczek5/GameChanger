using Convey.Persistence.MongoDB;
using GameChanger.Core.GameData;
using GameChanger.Core.MediatR.Handlers.Sector;
using GameChanger.Core.MediatR.Messages.Commands.Buildings;
using GameChanger.Core.MongoDB.Builders;
using GameChanger.Core.MongoDB.Documents;
using GameChanger.Core.MongoDB.Updaters;
using GameChanger.Core.Services.Sector;
using MediatR;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace GameChanger.Core.MediatR.Handlers.Buildings
{
    public class UpgradeBuildingCommandHandler : BaseSectorHandler,INotificationHandler<UpgradeBuildingCommand>
    {
        public UpgradeBuildingCommandHandler(IMongoRepository<SectorDocument, Guid> sectorDocuments, IMediator mediator, ISectorService sectorService, IMongoRepository<SectorResourcesDocument, Guid> sectorResourcesDocuments, Channel<INotification> channel, BuildingConfiguration buildingConfiguration) : base(sectorDocuments, mediator, sectorService, sectorResourcesDocuments, channel, buildingConfiguration)
        {
        }

        public async Task Handle(UpgradeBuildingCommand notification, CancellationToken cancellationToken)
        {
            if (!notification.SectorId.HasValue)
                return;

            var sector = await _sectorDocuments.GetAsync(notification.SectorId.Value);
            var currentBuilding = sector.Buildings.SingleOrDefault(b => b.BuildingType == notification.BuildingType);

            if (sector != null && currentBuilding != null)
            {
                var sectorResources = await _sectorResourcesDocuments.GetAsync(sector.SectorResourcesId);
                
                var newLvl = currentBuilding.CurrentLvl + 1;
                var buildingTemplate = _buildingConfiguration.GetBuildingByType(notification.BuildingType, newLvl);
                
                if (buildingTemplate == null || !sectorResources.HasResources(buildingTemplate.BuildCosts))
                {
                    return;
                }

                var buildingInSectorFilter = SectorFilterFactory.GetBuildingFromSectorByType(sector.Id, currentBuilding.BuildingType);
                var upgradeBuildingUpdater = SectorUpdaterFactory.SetBuildingLvlBuilding(newLvl);
                
                await _sectorDocuments.Collection.UpdateOneAsync(buildingInSectorFilter, upgradeBuildingUpdater);
                await _channel.Writer.WriteAsync(new ChangeResourceSupplyCommand { 
                    SectorResourcesId = sectorResources .Id,
                    IncreaseOrDecreaseMultiplier = -1,
                    Resources = buildingTemplate.BuildCosts
                });
            }
        }
    }
}
