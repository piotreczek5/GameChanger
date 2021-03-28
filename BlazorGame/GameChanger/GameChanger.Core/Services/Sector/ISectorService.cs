using GameChanger.Core.MongoDB.Documents;
using System.Threading.Tasks;

namespace GameChanger.Core.Services.Sector
{
    public interface ISectorService
    {
        SectorResourcesDocument RecalculateSectorResourceBalances(SectorDocument sector, SectorResourcesDocument sectorResources);
        Task PerformBuildingProduction(SectorResourcesDocument sectorResources, BuildingDocument building);
        Task<bool> PerformBuildingConsumption(SectorResourcesDocument sectorResources, BuildingDocument building);
    }
}