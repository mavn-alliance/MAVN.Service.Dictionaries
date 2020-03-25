using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Lykke.Service.Dictionaries.Client.Api;
using Lykke.Service.Dictionaries.Client.Models.Salesforce;
using Lykke.Service.Dictionaries.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lykke.Service.Dictionaries.Controllers
{
    [ApiController]
    [Route("api/salesforce")]
    public class SalesforceController : ControllerBase, ISalesforceApi
    {
        private readonly ISalesforceService _salesforceService;
        private readonly IMapper _mapper;

        public SalesforceController(ISalesforceService salesforceService, IMapper mapper)
        {
            _salesforceService = salesforceService;
            _mapper = mapper;
        }

        /// <summary>
        /// Returns an ordered collection of countries of residence.
        /// </summary>
        /// <returns>
        /// 200 - An ordered collection of countries of residence.
        /// </returns>
        [HttpGet("countriesOfResidence")]
        [ProducesResponseType(typeof(IReadOnlyList<CountryOfResidenceModel>), (int) HttpStatusCode.OK)]
        public async Task<IReadOnlyList<CountryOfResidenceModel>> GetCountriesOfResidenceAsync()
        {
            var countriesOfResidence = await _salesforceService.GetCountriesOfResidenceAsync();

            return _mapper.Map<IReadOnlyList<CountryOfResidenceModel>>(countriesOfResidence);
        }

        /// <summary>
        /// Returns an ordered collection of country dialling codes.
        /// </summary>
        /// <returns>
        /// 200 - An ordered collection of country dialling codes.
        /// </returns>
        [HttpGet("countryPhoneCodes")]
        [ProducesResponseType(typeof(IReadOnlyList<CountryPhoneCodeModel>), (int) HttpStatusCode.OK)]
        public async Task<IReadOnlyList<CountryPhoneCodeModel>> GetCountryPhoneCodesAsync()
        {
            var countryPhoneCodes = await _salesforceService.GetCountryPhoneCodesAsync();

            return _mapper.Map<IReadOnlyList<CountryPhoneCodeModel>>(countryPhoneCodes);
        }

        /// <summary>
        /// Returns a country of residence.
        /// </summary>
        /// <returns>
        /// 200 - A country of residence.
        /// </returns>
        [HttpGet("countriesOfResidence/{id}")]
        [ProducesResponseType(typeof(CountryOfResidenceModel), (int) HttpStatusCode.OK)]
        public async Task<CountryOfResidenceModel> GetCountryOfResidenceByIdAsync(int id)
        {
            var countriesOfResidence = await _salesforceService.GetCountryOfResidenceByIdAsync(id);

            return _mapper.Map<CountryOfResidenceModel>(countriesOfResidence);
        }

        /// <summary>
        /// Returns a country dialling code.
        /// </summary>
        /// <returns>
        /// 200 - A country dialling code.
        /// </returns>
        [HttpGet("countryPhoneCodes/{id}")]
        [ProducesResponseType(typeof(CountryPhoneCodeModel), (int) HttpStatusCode.OK)]
        public async Task<CountryPhoneCodeModel> GetCountryPhoneCodeByIdAsync(int id)
        {
            var countryPhoneCodes = await _salesforceService.GetCountryPhoneCodeByIdAsync(id);

            return _mapper.Map<CountryPhoneCodeModel>(countryPhoneCodes);
        }
    }
}
