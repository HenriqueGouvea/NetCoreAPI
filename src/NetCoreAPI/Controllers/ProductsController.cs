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
            var product = await _productService.GetByIdAsync(id);

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
            ProductsResponse result;

            if (pageNumber.HasValue && pageSize.HasValue)
            { 
                result = await _productService.GetAllAsync(pageNumber.Value, pageSize.Value);

                // insert link to product details in each item?

                return Ok(result);
            }

            result = await _productService.GetAllAsync();
            return Ok(result);
        }

        [HttpPost]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Post(ProductRequest productRequest)
        {
            var product = await _productService.AddAsync(productRequest);

            return Ok(product);
        }

        [HttpPut]
        public async Task<IActionResult> Put(UpdateProductRequest productRequest)
        {
            // Pass the request object to the service layer, get the domain object and map it updating its values.

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([Range(1, int.MaxValue)] int id)
        {
            // check if product exists, if not, return 404

            return NoContent();
        }
    }
}
