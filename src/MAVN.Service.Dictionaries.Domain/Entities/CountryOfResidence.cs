namespace MAVN.Service.Dictionaries.Domain.Entities
{
    /// <summary>
    /// Represents a Salesforce country of residence.
    /// </summary>
    public class CountryOfResidence
    {
        /// <summary>
        /// The country of residence unique identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The country localized name.
        /// </summary>
        public string Name { get; set; }

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
