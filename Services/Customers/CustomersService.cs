using System.Threading.Tasks;
using FunctionApp.Data;
using FunctionApp.Data.Entities;

namespace FunctionApp.Services.Customers
{
    public class CustomersService : ICustomers
    {
        private readonly DataDbContext _dbContext;
        public CustomersService(DataDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateNewCustomer(Customer data)
        {
            var customer = new Customer
            {
                Country = data.Country
            };
            await _dbContext.AddAsync(customer);
            await _dbContext.SaveChangesAsync();
        }
    }
}