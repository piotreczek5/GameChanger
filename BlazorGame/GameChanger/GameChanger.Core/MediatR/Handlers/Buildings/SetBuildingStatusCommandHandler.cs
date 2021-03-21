using Convey.Persistence.MongoDB;
using GameChanger.Core.Extensions.Mongo;
using GameChanger.Core.GameData;
using GameChanger.Core.MediatR.Messages.Commands.Buildings;
using GameChanger.Core.MongoDB.Builders;
using GameChanger.Core.MongoDB.Documents;
using GameChanger.Core.MongoDB.Updaters;
using MediatR;
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
        public SetBuildingStatusCommandHandler(IMongoRepository<SectorDocument, Guid> sectorDocuments, BuildingConfiguration buildingConfiguration)
        {
            _sectorDocuments = sectorDocuments;
        }

        public async Task Handle(SetBuildingStatusCommand notification, CancellationToken cancellationToken)
        {
            if(!notification.SectorId.HasValue)
            {
                return;
            }

            var findBuildingOfTypeFilter = SectorFilterFactory.GetBuildingFromSectorByType(notification.SectorId.Value,notification.BuildingType);

            var updateStatusCodeBuilder = SectorUpdaterFactory.SetBuildingStatus(new BuildingStatus(notification));

            await _sectorDocuments.Collection.UpdateOneAsync(findBuildingOfTypeFilter, updateStatusCodeBuilder);
        }
    }
}
