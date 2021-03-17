using GameChanger.Core.MongoDB.Documents;

namespace GameChanger.Core.Services.Sector
{
    public interface ISectorService
    {
        SectorResourcesDocument RecalculateSectorResourceBalances(SectorDocument sector, SectorResourcesDocument sectorResources);
        void PerformBuildingProduction(SectorResourcesDocument sectorResources, BuildingDocument building);
        void PerformBuildingConsumption(SectorResourcesDocument sectorResources, BuildingDocument building);
    }
}