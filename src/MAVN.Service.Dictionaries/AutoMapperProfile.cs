using AutoMapper;
using MAVN.Service.Dictionaries.Client.Models.Notifications;
using MAVN.Service.Dictionaries.Client.Models.Salesforce;
using MAVN.Service.Dictionaries.Domain.Entities;

namespace MAVN.Service.Dictionaries
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
