using AutoMapper;
using FunctionApp.Dtos;
using FunctionApp.Models;

namespace FunctionApp.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();
        }
    }
}