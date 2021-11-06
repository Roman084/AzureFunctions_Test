using System.Threading.Tasks;
using FunctionApp.Data.Dtos.Company;

namespace FunctionApp.Services.Company
{
    public interface ICompanyRepository
    {
        Task CreateNewCompany(RegisterCompanyDto registerCompanyDto);
        Task<CompanyDto> UpdateCompany(UpdateCompanyDto updateCompanyDto);
    }
}