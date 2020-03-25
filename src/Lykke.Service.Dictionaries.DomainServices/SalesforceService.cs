using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lykke.Service.Dictionaries.Domain.Entities;
using Lykke.Service.Dictionaries.Domain.Repositories;
using Lykke.Service.Dictionaries.Domain.Services;

namespace Lykke.Service.Dictionaries.DomainServices
{
    public class SalesforceService : ISalesforceService
    {
        private readonly ICountryOfResidenceRepository _countryOfResidenceRepository;
        private readonly ICountryPhoneCodeRepository _countryPhoneCodeRepository;

        public SalesforceService(
            ICountryOfResidenceRepository countryOfResidenceRepository,
            ICountryPhoneCodeRepository countryPhoneCodeRepository)
        {
            _countryOfResidenceRepository = countryOfResidenceRepository;
            _countryPhoneCodeRepository = countryPhoneCodeRepository;
        }

        public async Task<IReadOnlyList<CountryOfResidence>> GetCountriesOfResidenceAsync()
        {
            var countriesOfResidence = await _countryOfResidenceRepository.GetAllAsync();

            return countriesOfResidence
                .Where(o => o.IsAvailable)
                .OrderBy(o => o.Order)
                .ToList();
        }

        public async Task<IReadOnlyList<CountryPhoneCode>> GetCountryPhoneCodesAsync()
        {
            var countryPhoneCodes = await _countryPhoneCodeRepository.GetAllAsync();

            return countryPhoneCodes
                .Where(o => o.IsAvailable)
                .OrderBy(o => o.Order)
                .ToList();
        }
        public Task<CountryOfResidence> GetCountryOfResidenceByIdAsync(int id)
        {
            return _countryOfResidenceRepository.GetById(id);
        }

        public Task<CountryPhoneCode> GetCountryPhoneCodeByIdAsync(int id)
        {
            return _countryPhoneCodeRepository.GetById(id);
        }
    }
}
