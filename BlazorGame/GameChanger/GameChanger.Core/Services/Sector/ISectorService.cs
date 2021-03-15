using GameChanger.Core.MongoDB.Documents;

namespace GameChanger.Core.Services.Sector
{
    public interface ISectorService
    {
        SectorDocument RecalculateSectorResources(SectorDocument sector);
    }
}