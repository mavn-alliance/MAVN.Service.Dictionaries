using System.Threading.Tasks;
using MAVN.Service.Dictionaries.Domain.Entities;
using MAVN.Service.Dictionaries.Domain.Repositories;
using MAVN.Service.Dictionaries.Domain.Services;

namespace MAVN.Service.Dictionaries.DomainServices
{
    public class CommonInformationService : ICommonInformationService
    {
        private readonly INotificationRepository _notificationRepository;
        private readonly string _marketingWebsiteUrl;
        private readonly string _supportEmail;
        private readonly string _supportPhoneNumber;

        public CommonInformationService(
            string marketingWebsiteUrl,
            string supportEmail,
            string supportPhoneNumber,
            INotificationRepository notificationRepository)
        {
            _marketingWebsiteUrl = marketingWebsiteUrl;
            _supportEmail = supportEmail;
            _supportPhoneNumber = supportPhoneNumber;
            _notificationRepository = notificationRepository;
        }

        public async Task<CommonInformationProperties> GetCommonInformationAsync()
        {
            var result = await _notificationRepository.GetEmailNotificationPropertiesAsync();
            result.DownloadAppLink = _marketingWebsiteUrl;
            result.SupportEmailAddress = _supportEmail;
            result.SupportPhoneNumber = _supportPhoneNumber;
            return result;
        }
    }
}
