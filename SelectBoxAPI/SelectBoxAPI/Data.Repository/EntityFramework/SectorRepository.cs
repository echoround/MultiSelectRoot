using Microsoft.EntityFrameworkCore;
using SelectBoxAPI.Data.Repository.EntityFramework.Common;
using SelectBoxAPI.Interfaces;
using SelectBoxDomain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelectBoxAPI.Data.Repository.EntityFramework
{
    public class SectorRepository : GenericRepository<Sector>, ISectorRepository
    {
        public SectorRepository(SelectBoxAPIContext context) : base(context)
        {
        }
        public async Task<string[]> GetSectorsAsyncAsStringArray()
        {

            return await _context.Sectors.Where(e => e.CustomerId == null).Select(e => e.SectorName).ToArrayAsync();

        }

        public async Task<IEnumerable<Sector>> GetSectorsAsync()
        {

            return await _context.Sectors.Where(e => e.CustomerId == null).ToListAsync();

        }

    }
}