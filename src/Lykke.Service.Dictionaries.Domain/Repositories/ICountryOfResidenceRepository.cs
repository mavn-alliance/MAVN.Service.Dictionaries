using System.Collections.Generic;
using System.Threading.Tasks;
using Lykke.Service.Dictionaries.Domain.Entities;

namespace Lykke.Service.Dictionaries.Domain.Repositories
{
    public interface ICountryOfResidenceRepository
    {
        Task<IReadOnlyList<CountryOfResidence>> GetAllAsync();

        Task<CountryOfResidence> GetById(int id);
    }
}
