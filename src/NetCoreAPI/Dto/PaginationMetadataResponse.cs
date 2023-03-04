namespace NetCoreAPI.Dto
{
    public class PaginationMetadataResponse
    {
        public int Page { get; set; }

        public int TotalOnCurrentPage { get; set; }

        public int Total { get; set; }
    }
}
