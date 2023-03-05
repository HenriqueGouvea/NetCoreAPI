namespace NetCoreAPI.Dto.Product
{
    public class PaginationMetadataResponse
    {
        public PaginationMetadataResponse(int currentPage, int itemsOnCurrentPage, int totalItems, int totalPages)
        {
            CurrentPage = currentPage;
            ItemsOnCurrentPage = itemsOnCurrentPage;
            TotalItems = totalItems;
            TotalPages = totalPages;
        }

        public int CurrentPage { get; set; }

        public int ItemsOnCurrentPage { get; set; }

        public int TotalItems { get; set; }

        public int TotalPages { get; set; }
    }
}
