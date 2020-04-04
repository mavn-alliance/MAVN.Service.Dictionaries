using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Lykke.Common.MsSql;
using MAVN.Service.Dictionaries.Domain.Entities;
using MAVN.Service.Dictionaries.Domain.Repositories;
using MAVN.Service.Dictionaries.MsSqlRepositories.Contexts;
using Microsoft.EntityFrameworkCore;

namespace MAVN.Service.Dictionaries.MsSqlRepositories.Repositories
{
    public class CountryPhoneCodeRepository : ICountryPhoneCodeRepository
    {
        private readonly MsSqlContextFactory<DataContext> _contextFactory;
        private readonly IMapper _mapper;

        public CountryPhoneCodeRepository(MsSqlContextFactory<DataContext> contextFactory, IMapper mapper)
        {
            _contextFactory = contextFactory;
            _mapper = mapper;
        }

        public async Task<IReadOnlyList<CountryPhoneCode>> GetAllAsync()
        {
            using (var context = _contextFactory.CreateDataContext())
            {
                var entities = await context.CountryPhoneCodes.ToListAsync();

                return _mapper.Map<IReadOnlyList<CountryPhoneCode>>(entities);
            }
        }

        public async Task<CountryPhoneCode> GetById(int id)
        {
            using (var context = _contextFactory.CreateDataContext())
            {
                var entity = await context.CountryPhoneCodes.FirstOrDefaultAsync(x => x.Id == id);

                return _mapper.Map<CountryPhoneCode>(entity);
            }
        }
    }
}
