using System.Collections.Generic;
using System.Threading.Tasks;
using JetBrains.Annotations;
using MAVN.Service.Dictionaries.Client.Models.Salesforce;
using Refit;

namespace MAVN.Service.Dictionaries.Client.Api
{
    /// <summary>
    /// Provides methods for work with Salesforce lists.
    /// </summary>
    [PublicAPI]
    public interface ISalesforceApi
    {
        /// <summary>
        /// Returns an ordered collection of countries of residence.
        /// </summary>
        /// <returns>An ordered collection of countries of residence.</returns>
        [Get("/api/salesforce/countriesOfResidence")]
        Task<IReadOnlyList<CountryOfResidenceModel>> GetCountriesOfResidenceAsync();

        /// <summary>
        /// Returns an ordered collection of country dialling codes.
        /// </summary>
        /// <returns>An ordered collection of country dialling codes.</returns>
        [Get("/api/salesforce/countryPhoneCodes")]
        Task<IReadOnlyList<CountryPhoneCodeModel>> GetCountryPhoneCodesAsync();


        /// <summary>
        /// Returns a country of residence.
        /// </summary>
        /// <returns>
        /// 200 - A country of residence.
        /// </returns>
        [Get("/api/salesforce/countriesOfResidence/{id}")]
        Task<CountryOfResidenceModel> GetCountryOfResidenceByIdAsync(int id);

        /// <summary>
        /// Returns a country dialling code.
        /// </summary>
        /// <returns>
        /// 200 - A country dialling code.
        /// </returns>
        [Get("/api/salesforce/countryPhoneCodes/{id}")]
        Task<CountryPhoneCodeModel> GetCountryPhoneCodeByIdAsync(int id);
    }
}
