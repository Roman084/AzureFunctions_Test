using System.Threading.Tasks;
using FunctionApp.Data.Entities;

namespace FunctionApp.Services.Customers
{
    public interface ICustomers
    {
        Task CreateNewCustomer(Customer customer);
    }
}