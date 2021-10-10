using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace FunctionApp.Data
{
    public class DataDbContextFactory : IDesignTimeDbContextFactory<DataDbContext>
    {      

        DataDbContext IDesignTimeDbContextFactory<DataDbContext>.CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("local.settings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<DataDbContext>();
            var connectionString = configuration.GetConnectionString("DbConnection");
            builder.UseSqlServer(connectionString);

            return new DataDbContext(builder.Options);
        }
    }
}