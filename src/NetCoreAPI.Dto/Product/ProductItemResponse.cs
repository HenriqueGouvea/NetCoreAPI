namespace NetCoreAPI.Dto.Product
{
    public class ProductItemResponse : ProductResponse
    {
        public ProductItemResponse()
        {
            Links = new List<LinkResponse>();
        }

        public List<LinkResponse> Links { get; set; }
    }
}
