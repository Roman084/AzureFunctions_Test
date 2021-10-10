using System.Threading.Tasks;
using FunctionApp.Data;
using FunctionApp.Profiles;
using FunctionApp.Services.ProductService;
using Microsoft.Azure.WebJobs;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FunctionApp
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            var host = new HostBuilder()
                .ConfigureAppConfiguration(c =>
                {
                    c.AddEnvironmentVariables();
                    c.AddCommandLine(args);
                })
                .ConfigureFunctionsWorkerDefaults((c, b) =>
                {
                    b.UseFunctionExecutionMiddleware();
                })
                .ConfigureServices((context, services) =>
                {
                    services.AddDbContext<DataDbContext>(options =>
                        options.UseSqlServer(context.Configuration.GetConnectionString("DbConnection")));
                    
                    
                    services.AddScoped<IProductService, ProductService>();

                    services.AddAutoMapper(typeof(MappingProfile));
                    
                    
                })
                .Build();
            
            await host.RunAsync();
        }
    }
}