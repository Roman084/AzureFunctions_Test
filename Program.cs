using System.Net.Http;
using System.Threading.Tasks;
using FunctionApp.Data;
using FunctionApp.Profiles;
using FunctionApp.Services.Company;
using FunctionApp.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

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
                .ConfigureFunctionsWorkerDefaults((c, b) => { b.UseFunctionExecutionMiddleware(); })
                .ConfigureServices((context, services) =>
                {
                    services.AddDbContext<DataDbContext>(options =>
                    {
                        options.UseSqlServer(context.Configuration.GetConnectionString("DbConnection"));
                    });

                    services.AddControllers().AddNewtonsoftJson().AddNewtonsoftJson(opt =>
                        opt.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);
                    
                    // Entities Connection
                    services.AddScoped<ICompanyRepository, CompanyRepository>();
                    

                    services.AddSingleton(typeof(ILogger), typeof(Logger<Program>));
                    services.AddSingleton(typeof(HttpClient), typeof(HttpClient));
                    services.AddSingleton(typeof(AuthConnection), typeof(AuthConnection));
                    services.AddAutoMapper(typeof(MappingProfile));
                })
                .Build();

            await host.RunAsync();
        }
    }
}