using NetCoreAPI.Domain.Models;

namespace NetCoreAPI.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<Product> AddAsync(Product product);

        Task DeleteAsync(int id);

        Task<List<Product>> GetAllAsync();

        Task<KeyValuePair<int, List<Product>>> GetAllAsync(int pageNumber, int pageSize);

        Task<Product?> GetByIdAsync(int id);

        Task UpdateAsync(Product product);

        Task CommitAsync();
    }
}
