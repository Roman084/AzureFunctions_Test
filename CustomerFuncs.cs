using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using FunctionApp.Data.Entities;
using FunctionApp.Services.Customers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace FunctionApp
{


    public class CustomerFuncs
    {

        private readonly ICustomers _customers;
        public CustomerFuncs(ICustomers customers)
        {
            _customers = customers;
        }
        
        

        [Function("CustomerFuncs")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post")] HttpRequestData req,
            FunctionContext executionContext)
        {
            var logger = executionContext.GetLogger("CustomerFuncs");
            logger.LogInformation("C# HTTP trigger function processed a request.");

            string body = await new StreamReader(req.Body).ReadToEndAsync();
            Customer data = JsonConvert.DeserializeObject<Customer>(body);
            await _customers.CreateNewCustomer(data);

            return new OkObjectResult(new {message = "Customer created!"});
            
        }
    }
}