using NetCoreAPI.Dto.Product;

namespace NetCoreAPI.Applicaiton.Interfaces
{
    public interface IProductService
    {
        ProductResponse GetById(int id);

        ProductsResponse GetAll(int? pageNumber = null, int? pageSize = null);

        ProductResponse Add(ProductRequest productRequest);

        void Update(ProductRequest productRequest);

        void Delete(int id);
    }
}
