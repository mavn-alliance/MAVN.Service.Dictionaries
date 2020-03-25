namespace Lykke.Service.Dictionaries.Domain.Entities
{
    /// <summary>
    /// Represents a country dialling code.
    /// </summary>
    public class CountryPhoneCode
    {
        /// <summary>
        /// The country phone code unique identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The Salesforce country phone code.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// The ISO country phone code.
        /// </summary>
        public string IsoCode { get; set; }

        /// <summary>
        /// The country localized name.
        /// </summary>
        public string CountryName { get; set; }

        /// <summary>
        /// The country ISO 3166-1 alpha-2 code.
        /// </summary>
        public string CountryIso2Code { get; set; }

        /// <summary>
        /// The country ISO 3166-1 alpha-3 code.
        /// </summary>
        public string CountryIso3Code { get; set; }

        /// <summary>
        /// Indicates that the country is available.
        /// </summary>
        public bool IsAvailable { get; set; }

        /// <summary>
        /// Used to order items.
        /// </summary>
        public ushort Order { get; set; }
    }
}
