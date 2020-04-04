using System.Collections.Generic;
using System.Threading.Tasks;
using MAVN.Service.Dictionaries.Domain.Entities;

namespace MAVN.Service.Dictionaries.Domain.Services
{
    public interface ISalesforceService
    {
        Task<IReadOnlyList<CountryOfResidence>> GetCountriesOfResidenceAsync();

        Task<IReadOnlyList<CountryPhoneCode>> GetCountryPhoneCodesAsync();

        Task<CountryOfResidence> GetCountryOfResidenceByIdAsync(int id);

        Task<CountryPhoneCode> GetCountryPhoneCodeByIdAsync(int id);
    }
}
