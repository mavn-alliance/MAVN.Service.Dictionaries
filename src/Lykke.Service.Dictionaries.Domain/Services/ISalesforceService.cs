using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Service.Dictionaries.Domain.Entities;

namespace Lykke.Service.Dictionaries.Domain.Services
{
    public interface ISalesforceService
    {
        Task<IReadOnlyList<CountryOfResidence>> GetCountriesOfResidenceAsync();

        Task<IReadOnlyList<CountryPhoneCode>> GetCountryPhoneCodesAsync();

        Task<CountryOfResidence> GetCountryOfResidenceByIdAsync(int id);

        Task<CountryPhoneCode> GetCountryPhoneCodeByIdAsync(int id);
    }
}
