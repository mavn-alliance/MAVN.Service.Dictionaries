using System.Threading.Tasks;
using Lykke.Service.Dictionaries.Domain.Entities;

namespace Lykke.Service.Dictionaries.Domain.Repositories
{
    public interface INotificationRepository
    {
        Task<CommonInformationProperties> GetEmailNotificationPropertiesAsync();
    }
}
