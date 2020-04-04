using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MAVN.Service.Dictionaries.Domain.Entities;
using MAVN.Service.Dictionaries.Domain.Repositories;
using MAVN.Service.Dictionaries.Domain.Services;

namespace MAVN.Service.Dictionaries.DomainServices
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
