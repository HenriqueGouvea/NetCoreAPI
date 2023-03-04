using NetCoreAPI.Applicaiton.Interfaces;
using NetCoreAPI.Applicaiton.Mappers;
using NetCoreAPI.Domain.Repositories;
using NetCoreAPI.Dto.Product;

namespace NetCoreAPI.Applicaiton.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ProductResponse?> AddAsync(ProductRequest productRequest)
        {
            var product = await _productRepository.AddAsync(productRequest.ToProduct());
            return product.ToProductResponse();
        }

        public async Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductsResponse> GetAllAsync(int? pageNumber = null, int? pageSize = null)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductResponse?> GetByIdAsync(int id)
        {
            var result = await _productRepository.GetByIdAsync(id);
            return result?.ToProductResponse();
        }

        public async Task UpdateAsync(ProductRequest productRequest)
        {
            throw new NotImplementedException();
        }
    }
}
