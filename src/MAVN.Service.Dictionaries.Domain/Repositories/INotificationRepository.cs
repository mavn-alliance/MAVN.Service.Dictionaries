using System.Threading.Tasks;
using MAVN.Service.Dictionaries.Domain.Entities;

namespace MAVN.Service.Dictionaries.Domain.Repositories
{
    public interface INotificationRepository
    {
        Task<CommonInformationProperties> GetEmailNotificationPropertiesAsync();
    }
}
