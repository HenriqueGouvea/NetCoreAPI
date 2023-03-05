using NetCoreAPI.Domain.Models;
using NetCoreAPI.Dto.Product;

namespace NetCoreAPI.Applicaiton.Interfaces
{
    public interface IProductService
    {
        Task<ProductResponse?> GetByIdAsync(int id);

        Task<ProductsResponse> GetAllAsync(int pageNumber, int pageSize);

        Task<ProductsResponse> GetAllAsync();

        Task<ProductResponse?> AddAsync(ProductRequest productRequest);

        Task UpdateAsync(ProductRequest productRequest);

        Task DeleteAsync(int id);
    }
}
