using AutoMapper;
using MAVN.Service.Dictionaries.Domain.Entities;
using MAVN.Service.Dictionaries.Domain.Repositories;
using MAVN.Service.Dictionaries.MsSqlRepositories.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using MAVN.Persistence.PostgreSQL.Legacy;

namespace MAVN.Service.Dictionaries.MsSqlRepositories.Repositories
{
    public class NotificationRepository : INotificationRepository
    {
        private readonly PostgreSQLContextFactory<DataContext> _contextFactory;
        private readonly IMapper _mapper;

        public NotificationRepository(PostgreSQLContextFactory<DataContext> contextFactory, IMapper mapper)
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
