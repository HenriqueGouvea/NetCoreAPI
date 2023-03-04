using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NetCoreAPI.Dto;
using System.ComponentModel.DataAnnotations;

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
        public async Task<IActionResult> GetById([Range(1, int.MaxValue)]int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
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

        [HttpPost()]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Post(AddProductRequest productRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var product = new ProductResponse
            {
                Id = 1,
                Name = productRequest.Name,
                Price = productRequest.Price,
                StockQuantity = productRequest.StockQuantity,
                SequenceNumber = productRequest.SequenceNumber,
            };

            return Ok(product);
        }
    }
}
