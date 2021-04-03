using Convey.Persistence.MongoDB;
using GameChanger.Core.GameData;
using GameChanger.Core.MediatR.Messages.Commands.Sector;
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
using System.Threading.Tasks;

namespace GameChanger.Core.MediatR.Handlers.Sector
{
    public class RemoveSectorHandler : BaseSectorHandler, INotificationHandler<RemoveSectorCommand>
    {
        private readonly IMongoRepository<PlayerDocument, Guid> _playerDocuments;
        public RemoveSectorHandler(IMongoRepository<SectorDocument, Guid> sectorDocuments, IMediator mediator, ISectorService sectorService, IMongoRepository<SectorResourcesDocument, Guid> sectorResourcesDocuments, BuildingConfiguration buildingConfiguration, IMongoRepository<PlayerDocument, Guid> playerDocuments) : base(sectorDocuments, mediator, sectorService, sectorResourcesDocuments, buildingConfiguration)
        {
            _playerDocuments = playerDocuments;
        }

        public async Task Handle(RemoveSectorCommand notification, CancellationToken cancellationToken)
        {
            if(!notification.SectorId.HasValue)
            {
                return;
            }

            var sector = await _sectorDocuments.GetAsync(notification.SectorId.Value);
            if(sector == null)
            {
                return;
            }

            var playerIdFilter = PlayerFilterFactory.GetPlayerById(sector.PlayerOwner);
            var playerRemoveSectorUpdater = PlayerUpdaterFactory.RemoveSector(sector.Id);

            await _playerDocuments.Collection.UpdateOneAsync(playerIdFilter, playerRemoveSectorUpdater);            
            await _sectorResourcesDocuments.DeleteAsync(sector.SectorResourcesId);
            await _sectorDocuments.DeleteAsync(sector.Id);
        }
    }
}
