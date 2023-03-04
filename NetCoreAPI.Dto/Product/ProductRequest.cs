using System.ComponentModel.DataAnnotations;

namespace NetCoreAPI.Dto.Product
{
    public class ProductRequest
    {
        [Required]
        [MinLength(3)]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [Range(0.1, 999999.99)]
        public decimal Price { get; set; }

        [Required]
        [Range(0, 999999)]
        public int StockQuantity { get; set; }

        [Required]
        [Range(1, 999999)]
        public int SequenceNumber { get; set; }
    }
}
