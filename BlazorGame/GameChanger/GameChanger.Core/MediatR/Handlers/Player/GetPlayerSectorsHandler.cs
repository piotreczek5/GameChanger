using Convey.Persistence.MongoDB;
using GameChanger.Core.MediatR.Messages.Queries;
using GameChanger.Core.MongoDB.Documents;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameChanger.Core.MediatR.Handlers
{
    public class GetPlayerSectorsHandler :  IRequestHandler<GetPlayerSectorsQuery, IReadOnlyList<SectorDocument>>
    {
        private readonly IMongoRepository<PlayerDocument, Guid> _playerDocuments;
        private readonly IMongoRepository<SectorDocument, Guid> _sectorDocuments;

        public GetPlayerSectorsHandler(IMongoRepository<PlayerDocument, Guid> playerDocuments, IMongoRepository<SectorDocument, Guid> sectorDocuments)
        {
            _playerDocuments = playerDocuments;
            _sectorDocuments = sectorDocuments;
        }

        public async Task<IReadOnlyList<SectorDocument>> Handle(GetPlayerSectorsQuery notification, CancellationToken cancellationToken)
        {
            var player = await _playerDocuments.GetAsync(notification.PlayerId.Value);
            if (!notification.PlayerId.HasValue || player == null || player.Sectors.Count == 0)
            {
                return new List<SectorDocument>(); 
            }

            return  await _sectorDocuments.FindAsync(s => player.Sectors.Contains(s.Id));
        }
    }
}
