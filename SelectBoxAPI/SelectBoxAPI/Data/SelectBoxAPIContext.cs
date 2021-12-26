using Microsoft.EntityFrameworkCore;
using SelectBoxDomain.Models;


namespace SelectBoxAPI.Data
{


    public class SelectBoxAPIContext : DbContext
    {
        public SelectBoxAPIContext(DbContextOptions<SelectBoxAPIContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Sector> Sectors { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Customer>()
            .HasMany(c => c.Sectors);


        }


    }
    
}
