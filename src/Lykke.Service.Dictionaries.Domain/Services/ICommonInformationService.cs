using System.Threading.Tasks;
using Lykke.Service.Dictionaries.Domain.Entities;

namespace Lykke.Service.Dictionaries.Domain.Services
{
    public interface ICommonInformationService
    {
        Task<CommonInformationProperties> GetCommonInformationAsync();
    }
}
