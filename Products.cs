using System.IO;
using System.Threading.Tasks;
using FunctionApp.Dtos;
using FunctionApp.Services.ProductService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace FunctionApp
{
    public class Products
    {
        private readonly IProductService _productService;
        public Products(IProductService productService)
        {
            _productService = productService;
        }


        [Function("CreateProduct")]
        public async Task<IActionResult> CreateProduct(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "products")] HttpRequestData req,
            FunctionContext executionContext)
        {
            var logger = executionContext.GetLogger("Products");
            logger.LogInformation("C# HTTP trigger function processed a request.");

            string body = await new StreamReader(req.Body).ReadToEndAsync();
            ProductDto data = JsonConvert.DeserializeObject<ProductDto>(body);
            await _productService.CreateProduct(data);

            return new OkResult();
            
        }
    }
}