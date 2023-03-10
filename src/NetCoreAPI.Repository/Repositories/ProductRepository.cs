using Microsoft.EntityFrameworkCore;
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

        public async Task DeleteAsync(int id)
        {
            var product = await GetByIdAsync(id);

            if (product != null)
            {
                await Task.Run(() => _context.Products.Remove(product));
                await SaveChangesAsync();
            }
        }

        public async Task<KeyValuePair<int, List<Product>>> GetAllAsync(int pageNumber, int pageSize)
        {
            var recordsToSkip = (pageNumber - 1) * pageSize;
            var query = _context.Products.Skip(recordsToSkip).Take(pageSize);

            var totalTask = _context.Products.CountAsync();
            var resultTask = query.ToListAsync();

            await Task.WhenAll(totalTask, resultTask);

            return new KeyValuePair<int, List<Product>>(totalTask.Result, resultTask.Result);
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product?> GetByIdAsync(int id) 
            => await _context.Products.FirstOrDefaultAsync(p => p.Id == id);

        public async Task UpdateAsync(Product product)
        {
            await Task.Run(() => _context.Products.Update(product));
            await SaveChangesAsync();
        }
    }
}
