using System.Threading.Tasks;
using FunctionApp.Dtos;

namespace FunctionApp.Services.ProductService
{
    public interface IProductService
    {
        Task CreateProduct(ProductDto productDto);
    }
}