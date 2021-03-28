using MediatR;
using System.Threading.Tasks;

namespace GameChanger.Core.Services
{
    public interface IGameNotificationProcessor
    {
        Task ProcessAsync(INotification notification);
    }
}