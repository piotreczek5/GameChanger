using System.Threading.Tasks;

namespace GameChanger.GameClock.Services
{
    public interface IGameClockService
    {
        Task RecalculateSectorsResources();
    }
}