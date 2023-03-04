namespace NetCoreAPI.Dto.Product
{
    public class ProductsResponse
    {
        public List<ProductItemResponse> Products { get; set; }

        public PaginationMetadataResponse Pagination { get; set; }
    }
}
