using Lykke.HttpClientGenerator;
using MAVN.Service.Dictionaries.Client.Api;

namespace MAVN.Service.Dictionaries.Client
{
    /// <inheritdoc />
    public class DictionariesClient : IDictionariesClient
    {
        /// <summary>
        /// Initializes a new instance of <see cref="DictionariesClient"/> with <param name="httpClientGenerator"></param>.
        /// </summary> 
        public DictionariesClient(IHttpClientGenerator httpClientGenerator)
        {
            Salesforce = httpClientGenerator.Generate<ISalesforceApi>();
            CommonInformation = httpClientGenerator.Generate<ICommonInformationApi>();
        }

        /// <inheritdoc />
        public ISalesforceApi Salesforce { get; set; }

        /// <inheritdoc />
        public ICommonInformationApi CommonInformation { get; set; }
    }
}
