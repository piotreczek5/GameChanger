using Convey.Persistence.MongoDB;
using GameChanger.Core.Extensions.Mongo;
using GameChanger.Core.GameData;
using GameChanger.Core.MediatR.Messages.Commands.Buildings;
using GameChanger.Core.MongoDB.Builders;
using GameChanger.Core.MongoDB.Documents;
using GameChanger.Core.MongoDB.Factories;
using GameChanger.Core.MongoDB.Updaters;
using GameChanger.Core.SignalR;
using MediatR;
using Microsoft.AspNet.SignalR.Client;
using Microsoft.AspNetCore.SignalR;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameChanger.Core.MediatR.Handlers.Buildings
{
    public class SetBuildingStatusCommandHandler : INotificationHandler<SetBuildingStatusCommand>
    {
        private readonly IMongoRepository<SectorDocument, Guid> _sectorDocuments;
        private readonly IHubContext<BuildingsHub> _notificationHub;
        private readonly IBuildingStatusFactory _buildingStatusFactory;
        public SetBuildingStatusCommandHandler(IMongoRepository<SectorDocument, Guid> sectorDocuments, BuildingConfiguration buildingConfiguration, IHubContext<BuildingsHub> notificationHub, IBuildingStatusFactory buildingStatusFactory)
        {
            _sectorDocuments = sectorDocuments;
            _notificationHub = notificationHub;
            _buildingStatusFactory = buildingStatusFactory;
        }

        public async Task Handle(SetBuildingStatusCommand notification, CancellationToken cancellationToken)
        {
            if(!notification.SectorId.HasValue)
            {
                return;
            }

            var findBuildingOfTypeFilter = SectorFilterFactory.GetBuildingFromSectorByType(notification.SectorId.Value,notification.BuildingType);

            var buildingStatus = _buildingStatusFactory.CreateBuildingStatus(notification.BuildingStatus, notification.TimeToComplete);
            var updateStatusCodeBuilder = SectorUpdaterFactory.SetBuildingStatus(buildingStatus);

            await _sectorDocuments.Collection.UpdateOneAsync(findBuildingOfTypeFilter, updateStatusCodeBuilder);

            await _notificationHub.Clients.All.SendAsync("BuildingStatusChanged", notification.BuildingType.ToString(), notification.BuildingStatus.ToString());
        }
    }
}
