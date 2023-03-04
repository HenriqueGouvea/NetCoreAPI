using NetCoreAPI.Applicaiton.Interfaces;
using NetCoreAPI.Dto.Product;

namespace NetCoreAPI.Applicaiton.Services
{
    public class ProductService : IProductService
    {
        public ProductResponse Add(ProductRequest productRequest)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ProductsResponse GetAll(int? pageNumber = null, int? pageSize = null)
        {
            throw new NotImplementedException();
        }

        public ProductResponse GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ProductRequest productRequest)
        {
            throw new NotImplementedException();
        }
    }
}
