using System;
using System.Threading.Tasks;
using AutoMapper;
using FunctionApp.Data;
using FunctionApp.Dtos;
using FunctionApp.Models;

namespace FunctionApp.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataDbContext _dbContext;
        private readonly IMapper _mapper;
        public ProductService(DataDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        
        
        public async Task CreateProduct(ProductDto productDto)
        {
            Product product = _mapper.Map<ProductDto, Product>(productDto);
            product.Id = Guid.NewGuid();
            product.CreatedBy = Guid.NewGuid();
            product.CreatedAt = DateTime.UtcNow;
            await _dbContext.Products.AddAsync(product);
            await _dbContext.SaveChangesAsync();
        }
    }
}