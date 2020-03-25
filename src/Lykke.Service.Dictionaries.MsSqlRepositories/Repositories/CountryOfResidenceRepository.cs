using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Lykke.Common.MsSql;
using Lykke.Service.Dictionaries.Domain.Entities;
using Lykke.Service.Dictionaries.Domain.Repositories;
using Lykke.Service.Dictionaries.MsSqlRepositories.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Lykke.Service.Dictionaries.MsSqlRepositories.Repositories
{
    public class CountryOfResidenceRepository : ICountryOfResidenceRepository
    {
        private readonly MsSqlContextFactory<DataContext> _contextFactory;
        private readonly IMapper _mapper;

        public CountryOfResidenceRepository(MsSqlContextFactory<DataContext> contextFactory, IMapper mapper)
        {
            _contextFactory = contextFactory;
            _mapper = mapper;
        }

        public async Task<IReadOnlyList<CountryOfResidence>> GetAllAsync()
        {
            using (var context = _contextFactory.CreateDataContext())
            {
                var entities = await context.CountriesOfResidence.ToListAsync();

                return _mapper.Map<IReadOnlyList<CountryOfResidence>>(entities);
            }
        }

        public async Task<CountryOfResidence> GetById(int id)
        {
            using (var context = _contextFactory.CreateDataContext())
            {
                var entity = await context.CountriesOfResidence.FirstOrDefaultAsync(x => x.Id == id);

                return _mapper.Map<CountryOfResidence>(entity);
            }
        }
    }
}
