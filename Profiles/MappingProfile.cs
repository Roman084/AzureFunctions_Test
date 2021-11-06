using AutoMapper;
using FunctionApp.Data.Dtos.Company;
using FunctionApp.Data.Entities;

namespace FunctionApp.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Company, RegisterCompanyDto>(MemberList.Destination);
        }
    }
}