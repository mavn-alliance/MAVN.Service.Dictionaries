using JetBrains.Annotations;
using MAVN.Service.Dictionaries.Client.Models.Notifications;
using Refit;
using System.Threading.Tasks;

namespace MAVN.Service.Dictionaries.Client.Api
{
    /// <summary>
    /// Provides methods for work with Notifications
    /// </summary>
    [PublicAPI]
    public interface ICommonInformationApi
    {
        /// <summary>
        /// Returns a common information model
        /// </summary>
        /// <returns>
        /// 200 - Common information model
        /// </returns>
        [Get("/api/commonInformation")]
        Task<CommonInformationPropertiesModel> GetCommonInformationAsync();
    }
}
