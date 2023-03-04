using System.ComponentModel.DataAnnotations;

namespace NetCoreAPI.Dto
{
    public class UpdateProductRequest : ProductRequest
    {
        [Required]
        [Range(1, int.MaxValue)]
        public int Id { get; set; }
    }
}
