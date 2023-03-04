using NetCoreAPI.Domain.Models;

namespace NetCoreAPI.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<Product> AddAsync(Product product);

        Task DeleteAsync(int id);

        Task<Product> GetAllAsync(int? pageNumber = null, int? pageSize = null);

        Task<Product?> GetByIdAsync(int id);

        Task UpdateAsync(Product product);

        Task CommitAsync();
    }
}
