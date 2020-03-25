using AutoMapper;
using Lykke.Service.Dictionaries.Domain.Entities;
using Lykke.Service.Dictionaries.MsSqlRepositories.Entities;

namespace Lykke.Service.Dictionaries.MsSqlRepositories
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CountryOfResidenceEntity, CountryOfResidence>(MemberList.Destination);
            CreateMap<CountryPhoneCodeEntity, CountryPhoneCode>(MemberList.Destination);
            CreateMap<EmailNotificationPropertiesEntity, CommonInformationProperties>(MemberList.Destination)
                .ForSourceMember(src => src.Id, opt => opt.DoNotValidate())
                .ForMember(src => src.SupportPhoneNumber, opt => opt.Ignore())
                .ForMember(src => src.SupportEmailAddress, opt => opt.Ignore());
        }
    }
}
