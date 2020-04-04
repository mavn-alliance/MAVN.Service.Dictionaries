using JetBrains.Annotations;
using MAVN.Service.Dictionaries.Client.Api;

namespace MAVN.Service.Dictionaries.Client
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
