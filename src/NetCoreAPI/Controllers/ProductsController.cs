using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NetCoreAPI.Applicaiton.Interfaces;
using NetCoreAPI.Dto.Product;
using System.ComponentModel.DataAnnotations;

namespace NetCoreAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetById([Range(1, int.MaxValue)] int id)
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

        [HttpGet()]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetAll(
            [FromQuery][Range(1, int.MaxValue)] int? pageNumber,
            [FromQuery][Range(1, int.MaxValue)] int? pageSize)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var products = new List<ProductResponse>
            {
                new ProductResponse{
                    Id = 1,
                    Name = "Test 1",
                    Price = 100,
                    StockQuantity = 100,
                    SequenceNumber = 1
                },
                new ProductResponse{
                    Id = 2,
                    Name = "Test 2",
                    Price = 100,
                    StockQuantity = 100,
                    SequenceNumber = 2
                }
            };

            return Ok(products);
        }

        [HttpPost]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Post(ProductRequest productRequest)
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

        [HttpPut]
        public async Task<IActionResult> Put(UpdateProductRequest productRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Pass the request object to the service layer, get the domain object and map it updating its values.

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([Range(1, int.MaxValue)] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // check if product exists, if not, return 404

            return NoContent();
        }
    }
}
