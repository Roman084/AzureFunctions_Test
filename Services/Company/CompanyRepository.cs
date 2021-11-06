using System;
using System.Threading.Tasks;
using AutoMapper;
using FunctionApp.Data;
using FunctionApp.Data.Dtos.Company;
using FunctionApp.Utils;
using Microsoft.EntityFrameworkCore;

namespace FunctionApp.Services.Company
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly DataDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly AuthConnection _authConnection;
        public CompanyRepository(DataDbContext dbContext, IMapper mapper, AuthConnection authConnection)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _authConnection = authConnection;
        }

        
        public async Task CreateNewCompany(RegisterCompanyDto registerCompanyDto)
        {
            var company = await _dbContext.Company_info.FirstOrDefaultAsync(c => c.Email == registerCompanyDto.Email);
            await _authConnection.Connection();
            if (company != null) throw new Exception("Company already registered!");
            var newCompany = new Data.Entities.Company()
            {
                User_contact_name = registerCompanyDto.User_contact_name.Trim(),
                Email = registerCompanyDto.Email.Trim(),
                Password = registerCompanyDto.Password
            };
            await _dbContext.AddAsync(newCompany);
            await _dbContext.SaveChangesAsync();
        }

        
        public async Task<CompanyDto> UpdateCompany(UpdateCompanyDto updateCompanyDto)
        {
            var company = await _dbContext.Company_info.FirstOrDefaultAsync();
            var updatedCompany = _mapper.Map<Data.Entities.Company>(company);
            _dbContext.Update(updatedCompany);
            await _dbContext.SaveChangesAsync();
            return _mapper.Map<CompanyDto>(updatedCompany);
        }
    }
}