namespace NetCoreAPI.Dto.Product
{
    public class PaginationMetadataResponse
    {
        public int Page { get; set; }

        public int TotalOnCurrentPage { get; set; }

        public int Total { get; set; }
    }
}
