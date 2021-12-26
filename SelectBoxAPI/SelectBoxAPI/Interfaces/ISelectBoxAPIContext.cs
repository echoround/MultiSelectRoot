using Microsoft.EntityFrameworkCore;
using SelectBoxDomain.Models;
using System;


namespace SelectBoxAPI.Interfaces
{
    public interface ISelectBoxAPIContext : IDisposable
    {
        DbSet<Customer> Customers { get; }
        DbSet<Sector> Sectors { get; }
        int SaveChanges();
        void MarkAsModified(Customer customer);
        void MarkAsModified(Sector sector);

    }
}