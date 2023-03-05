using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NetCoreAPI.Applicaiton.Interfaces;
using NetCoreAPI.Dto.Product;
using NetCoreAPI.Extensions;
using System.ComponentModel.DataAnnotations;

namespace NetCoreAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IUrlHelper _urlHelper;

        public ProductsController(
            IProductService productService, IUrlHelper urlHelper)
        {
            _productService = productService;
            _urlHelper = urlHelper;
        }

        [HttpGet("{id}", Name = "GetProductById")]
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
            }
            else
            {
                result = await _productService.GetAllAsync();
            }

            await result.Products.SetLinksAsync(_urlHelper);

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

        [HttpPut(Name = "UpdateProduct")]
        public async Task<IActionResult> Put(UpdateProductRequest productRequest)
        {
            var success = await _productService.UpdateAsync(productRequest);

            if (!success)
                return BadRequest($"None product found with the ID {productRequest.Id}");

            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteProduct")]
        public async Task<IActionResult> Delete([Range(1, int.MaxValue)] int id)
        {
            // check if product exists, if not, return 404

            return NoContent();
        }
    }
}
