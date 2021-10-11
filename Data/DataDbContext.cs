using FunctionApp.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FunctionApp.Data
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions options) : base(options) {}
        
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<BankInfoInvoice> BankInfoInvoice { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<CompanyUpdates> CompanyUpdates { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Allowances> Allowances { get; set; }
        public DbSet<InvoiceAllowancePassengers> InvoiceAllowancePassengers { get; set; }
        public DbSet<InvoiceAllowanceRouteItems> InvoiceAllowanceRouteItems { get; set; }
        public DbSet<InvoiceItems> InvoiceItems { get; set; }
        public DbSet<ResoniaApp> ResoniaApp { get; set; }
        public DbSet<Salary> Salary { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ResoniaApp>().HasNoKey();
        }
    }
}