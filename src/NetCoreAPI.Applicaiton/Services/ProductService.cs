using NetCoreAPI.Applicaiton.Interfaces;
using NetCoreAPI.Dto.Product;

namespace NetCoreAPI.Applicaiton.Services
{
    public class ProductService : IProductService
    {
        public async Task<ProductResponse> AddAsync(ProductRequest productRequest)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductsResponse> GetAllAsync(int? pageNumber = null, int? pageSize = null)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductResponse> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(ProductRequest productRequest)
        {
            throw new NotImplementedException();
        }
    }
}
