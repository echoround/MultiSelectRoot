using SelectBoxDomain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SelectBoxAPI.Interfaces
{
    public interface ISectorRepository : IGenericRepository<Sector>
    {

        Task<string[]> GetSectorsAsyncAsStringArray();

        Task<IEnumerable<Sector>> GetSectorsAsync();

    }
}