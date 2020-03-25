using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Service.Dictionaries.Domain.Entities;

namespace Lykke.Service.Dictionaries.Domain.Repositories
{
    public interface ICountryPhoneCodeRepository
    {
        Task<IReadOnlyList<CountryPhoneCode>> GetAllAsync();

        Task<CountryPhoneCode> GetById(int id);
    }
}
