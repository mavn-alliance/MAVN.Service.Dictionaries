using AutoMapper;
using Lykke.Common.MsSql;
using Lykke.Service.Dictionaries.Domain.Entities;
using Lykke.Service.Dictionaries.Domain.Repositories;
using Lykke.Service.Dictionaries.MsSqlRepositories.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Lykke.Service.Dictionaries.MsSqlRepositories.Repositories
{
    public class NotificationRepository : INotificationRepository
    {
        private readonly MsSqlContextFactory<DataContext> _contextFactory;
        private readonly IMapper _mapper;

        public NotificationRepository(MsSqlContextFactory<DataContext> contextFactory, IMapper mapper)
        {
            _contextFactory = contextFactory;
            _mapper = mapper;
        }

        public async Task<CommonInformationProperties> GetEmailNotificationPropertiesAsync()
        {
            using (var context = _contextFactory.CreateDataContext())
            {
                var result = await context.EmailNotificationProperties.FirstOrDefaultAsync();

                return _mapper.Map<CommonInformationProperties>(result);
            }
        }
    }
}
