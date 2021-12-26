using SelectBoxDomain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SelectBoxAPI.Interfaces
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        Task<IEnumerable<Customer>> GetCustomersAsync();

        Task<Customer> GetCustomerAsync(int id);

        Task<Customer> GetCustomerByGUIDAsync(string guid);

        Task<bool> PostCustomerAsync(Customer customer);

        public IEnumerable<Customer> GetCustomers();


    }
}
