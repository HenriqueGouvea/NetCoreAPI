namespace NetCoreAPI.Dto
{
    public class ProductResponse
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        public int SequenceNumber { get; set; }
    }
}
