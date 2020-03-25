using JetBrains.Annotations;
using Lykke.Service.Dictionaries.Client.Api;

namespace Lykke.Service.Dictionaries.Client
{
    /// <summary>
    /// Dictionaries service client.
    /// </summary>
    [PublicAPI]
    public interface IDictionariesClient
    {
        /// <summary>
        /// The Salesforce API.
        /// </summary>
        ISalesforceApi Salesforce { get; set; }

        /// <summary>
        /// A CommonInformation Api
        /// </summary>
        ICommonInformationApi CommonInformation { get; set; }
    }
}
