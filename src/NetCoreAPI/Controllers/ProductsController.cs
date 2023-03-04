using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NetCoreAPI.Dto;

namespace NetCoreAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsController()
        {

        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetById(int id)
        {
            if (id <=0)
            {
                return BadRequest("Invalid id");
            }

            var product = new ProductResponse
            {
                Id = id,
                Name = "Test",
                Price = 100,
                StockQuantity = 100,
                SequenceNumber = 1,
            };

            return Ok(product);
        }
    }
}
