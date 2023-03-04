using NetCoreAPI.Domain.Models;
using NetCoreAPI.Domain.Repositories;

namespace NetCoreAPI.Repository.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Task<Product> AddAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task CommitAsync()
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetAllAsync(int? pageNumber = null, int? pageSize = null)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
