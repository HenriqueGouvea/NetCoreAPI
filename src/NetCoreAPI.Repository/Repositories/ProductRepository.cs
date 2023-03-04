using NetCoreAPI.Domain.Models;
using NetCoreAPI.Domain.Repositories;

namespace NetCoreAPI.Repository.Repositories
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(NetCoreAPIContext context) : base (context)
        {
        }

        public async Task<Product> AddAsync(Product product)
        {
            await _context.Products.AddAsync(product);
            await SaveChangesAsync();
            return product;
        }

        public async Task CommitAsync()
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> GetAllAsync(int? pageNumber = null, int? pageSize = null)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
