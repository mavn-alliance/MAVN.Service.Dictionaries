using System.Threading.Tasks;
using MAVN.Service.Dictionaries.Domain.Entities;

namespace MAVN.Service.Dictionaries.Domain.Services
{
    public interface ICommonInformationService
    {
        Task<CommonInformationProperties> GetCommonInformationAsync();
    }
}
