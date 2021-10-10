using FunctionApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FunctionApp.Data
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions options) : base(options) {}
        
        public DbSet<Product> Products { get; set; }
    }
}