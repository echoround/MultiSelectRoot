using Microsoft.EntityFrameworkCore;
using SelectBoxAPI.Data.Repository.EntityFramework.Common;
using SelectBoxAPI.Interfaces;
using SelectBoxDomain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelectBoxAPI.Data.Repository.EntityFramework
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(SelectBoxAPIContext context) : base(context)
        {
        }
        public async Task<IEnumerable<Customer>> GetCustomersAsync()
        {
            return await _context.Customers.ToListAsync();
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return  _context.Customers.ToList();
        }

        public async Task<Customer> GetCustomerAsync(int id)
        {
            return await _context.Customers.Where(c => c.CustomerId == id).FirstOrDefaultAsync();
        }

        public async Task<Customer> GetCustomerByGUIDAsync(string guid)
        {
            return await _context.Customers.Where(c => c.CustomerAuth == guid).Include(c => c.Sectors).FirstOrDefaultAsync();
        }

        public async Task<bool> PostCustomerAsync(Customer customer)
        {
            _context.Customers.Attach(customer);
            var alreadyExists = _context.Customers.Include(c => c.Sectors).Any(x => x.CustomerAuth == customer.CustomerAuth);
            _context.Entry(customer).State = alreadyExists ? EntityState.Modified : EntityState.Added;

            int count = await _context.SaveChangesAsync();

            return count > 0;

        }


    }
}
