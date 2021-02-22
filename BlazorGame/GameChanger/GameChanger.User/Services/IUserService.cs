using GameChanger.GameUser.EntityFramework.Domain;
using System.Threading.Tasks;

namespace GameChanger.GameUser.Services
{
    public interface IUserService
    {
        Task<GameChangerUser> LoginAsync(GameChangerUser user);
    }
}