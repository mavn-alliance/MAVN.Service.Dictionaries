using AutoMapper;
using Lykke.Service.Dictionaries.Client.Models.Notifications;
using Lykke.Service.Dictionaries.Client.Models.Salesforce;
using Lykke.Service.Dictionaries.Domain.Entities;

namespace Lykke.Service.Dictionaries
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CountryOfResidence, CountryOfResidenceModel>(MemberList.Destination);
            CreateMap<CountryPhoneCode, CountryPhoneCodeModel>(MemberList.Destination);
            CreateMap<CommonInformationProperties, CommonInformationPropertiesModel>(MemberList.Destination);
        }
    }
}
