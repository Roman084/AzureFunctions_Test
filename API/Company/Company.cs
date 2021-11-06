using System;
using System.IO;
using System.Threading.Tasks;
using FunctionApp.Data.Dtos.Company;
using FunctionApp.Services.Company;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace FunctionApp.API.Company
{
    public class Company
    {
        private readonly ILogger _logger;
        private readonly ICompanyRepository _companyRepository;
        public Company(ILogger logger, ICompanyRepository companyRepository)
        {
            _logger = logger;
            _companyRepository = companyRepository;
        }


        [Function("CreateCompany")]
        public async Task<ActionResult> CreateCompany(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = "CreateNewCompany")] HttpRequestData req)
        {
            try
            {
                _logger.LogInformation("Create New Company");
                var question = req;
                string reqBody = await new StreamReader(req.Body).ReadToEndAsync();
                var result = JsonConvert.DeserializeObject<RegisterCompanyDto>(reqBody);
                await _companyRepository.CreateNewCompany(result);
                return new OkObjectResult(new {message = "Company created successful!"});
            }
            catch (Exception e)
            {
                return new BadRequestObjectResult(new {errorMsg = e.Message});
            }
        }
        
        
        [Function("UpdateCompany")]
        public async Task<ActionResult<CompanyDto>> UpdateCompany(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = "UpdateCompany")] HttpRequestData req)
        {
            try
            {
                _logger.LogInformation("Update exist Company");
                string reqBody = await new StreamReader(req.Body).ReadToEndAsync();
                var result = JsonConvert.DeserializeObject<UpdateCompanyDto>(reqBody);
                await _companyRepository.UpdateCompany(result);
                return new OkObjectResult(new {message = "Company updated successful!"});
            }
            catch (Exception e)
            {
                return new BadRequestObjectResult(new {errorMsg = e.Message});
            }
        }
    }
}