namespace NetCoreAPI.Dto.Product
{
    public class ProductsResponse
    {
        public ProductsResponse()
        {
            Products = new List<ProductItemResponse>();
        }

        public List<ProductItemResponse> Products { get; set; }

        public PaginationMetadataResponse? Pagination { get; set; }
    }
}
