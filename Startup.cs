using System;
using FunctionApp;
using FunctionApp.Data;
using FunctionApp.Profiles;
using FunctionApp.Services.ProductService;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(Startup))]
namespace FunctionApp
{
    class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddDbContext<DataDbContext>(opt =>
            {
                opt.UseSqlServer(Environment.GetEnvironmentVariable("[ConnectionStrings:DbConnection]"));
            });

            builder.Services.AddScoped<IProductService, ProductService>();

            builder.Services.AddAutoMapper(typeof(MappingProfile));
        }
    }
}