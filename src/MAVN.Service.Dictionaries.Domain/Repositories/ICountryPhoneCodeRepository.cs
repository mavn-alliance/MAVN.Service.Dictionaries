using System.Collections.Generic;
using System.Threading.Tasks;
using MAVN.Service.Dictionaries.Domain.Entities;

namespace MAVN.Service.Dictionaries.Domain.Repositories
{
    public interface ICountryPhoneCodeRepository
    {
        Task<IReadOnlyList<CountryPhoneCode>> GetAllAsync();

        Task<CountryPhoneCode> GetById(int id);
    }
}
