using System.Collections.Generic;
using System.Threading.Tasks;
using MAVN.Service.Dictionaries.Domain.Entities;

namespace MAVN.Service.Dictionaries.Domain.Repositories
{
    public interface ICountryOfResidenceRepository
    {
        Task<IReadOnlyList<CountryOfResidence>> GetAllAsync();

        Task<CountryOfResidence> GetById(int id);
    }
}
