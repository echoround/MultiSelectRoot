using SelectBoxAPI.Data.Repository.EntityFramework;
using SelectBoxAPI.Interfaces;
using System.Threading.Tasks;

namespace SelectBoxAPI.Data.Repository.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SelectBoxAPIContext _context;
        public UnitOfWork(SelectBoxAPIContext context)
        {
            _context = context;
            Sectors = new SectorRepository(_context);
            Customers = new CustomerRepository(_context);
        }
        public ISectorRepository Sectors { get; private set; }
        public ICustomerRepository Customers { get; private set; }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public async Task<bool> SaveAsync()
        {
            int count = await _context.SaveChangesAsync();
            return count > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}