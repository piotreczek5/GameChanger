using Convey.Persistence.MongoDB;
using GameChanger.Core.GameData;
using GameChanger.Core.MediatR.Messages.Commands.Sector;
using GameChanger.Core.MongoDB.Builders;
using GameChanger.Core.MongoDB.Documents;
using GameChanger.Core.MongoDB.Documents.Factories;
using GameChanger.Core.MongoDB.Documents.Player;
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
    public class ChangeSectorHandler : BaseSectorHandler, INotificationHandler<ChangeSectorCommand>
    {
        IMongoRepository<PlayerDocument, Guid> _playerDocuments;
        private readonly IPlayerStatusFactory _playerStatusFactory;
        public ChangeSectorHandler(IMongoRepository<SectorDocument, Guid> sectorDocuments, IMediator mediator, ISectorService sectorService, IMongoRepository<SectorResourcesDocument, Guid> sectorResourcesDocuments, BuildingConfiguration buildingConfiguration, IMongoRepository<PlayerDocument, Guid> playerDocuments, IPlayerStatusFactory playerStatusFactory) : base(sectorDocuments, mediator, sectorService, sectorResourcesDocuments, buildingConfiguration)
        {
            _playerDocuments = playerDocuments;
            _playerStatusFactory = playerStatusFactory;
        }

        public async Task Handle(ChangeSectorCommand notification, CancellationToken cancellationToken)
        {
            if(!notification.PlayerId.HasValue || !notification.SectorId.HasValue)
                return;
            var sector = await _sectorDocuments.GetAsync(notification.SectorId.Value);
            
            if(sector == null)
                return;
            
            var playerStatus =
                _playerStatusFactory.Create(
                    PlayerStatuses.IDLE_WITH_SECTOR,
                    sectorDetails: new SectorDetails() { SectorId = notification.SectorId, ArrivedAt = DateTime.UtcNow });

            var playerUpdateStatusFactory = PlayerUpdaterFactory.SetPlayerStatus(playerStatus);
            var playerFilter = PlayerFilterFactory.GetPlayerById(notification.PlayerId.Value);

            await _playerDocuments.Collection.UpdateOneAsync(playerFilter, playerUpdateStatusFactory);
        }
    }
}
