using System;
using System.Threading.Tasks;

namespace SelectBoxAPI.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ISectorRepository Sectors { get; }
        ICustomerRepository Customers { get; }
        int Complete();
        Task<bool> SaveAsync();

    }
}