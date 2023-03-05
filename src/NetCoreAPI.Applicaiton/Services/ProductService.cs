using NetCoreAPI.Applicaiton.Interfaces;
using NetCoreAPI.Applicaiton.Mappers;
using NetCoreAPI.Domain.Models;
using NetCoreAPI.Domain.Repositories;
using NetCoreAPI.Dto.Product;
using System.Reflection.Metadata.Ecma335;

namespace NetCoreAPI.Applicaiton.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ProductResponse?> AddAsync(ProductRequest productRequest)
        {
            var product = await _productRepository.AddAsync(productRequest.ToProduct());
            return product.ToProductResponse();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var product = _productRepository.GetByIdAsync(id);

            if (product == null)
            {
                // TODO: Log a bad request/invalid arguments here
                return false;
            }

            await _productRepository.DeleteAsync(id);
            return true;
        }

        public async Task<ProductsResponse> GetAllAsync(int pageNumber, int pageSize)
        {
            var result = await _productRepository.GetAllAsync(pageNumber, pageSize);
            var totalPages = Math.Ceiling((double) result.Key / pageSize);

            var productsResponse = new ProductsResponse
            {
                Products = result.Value.ToProductItemResponse().ToList(),
                Pagination = new PaginationMetadataResponse(pageNumber, result.Value.Count, result.Key, (int)totalPages)
            };

            return productsResponse;
        }

        public async Task<ProductsResponse> GetAllAsync()
        {
            var result = await _productRepository.GetAllAsync();

            var productsResponse = new ProductsResponse
            {
                Products = result.ToProductItemResponse().ToList()
            };

            return productsResponse;
        }

        public async Task<ProductResponse?> GetByIdAsync(int id)
        {
            var result = await _productRepository.GetByIdAsync(id);
            return result?.ToProductResponse();
        }

        public async Task<bool> UpdateAsync(UpdateProductRequest productRequest)
        {
            var product = await _productRepository.GetByIdAsync(productRequest.Id);

            if (product == null || string.IsNullOrEmpty(productRequest.Name)) 
            {
                // TODO: Log a bad request/invalid arguments here
                return false;
            }

            product.Name = productRequest.Name;
            product.SequenceNumber = productRequest.SequenceNumber;
            product.Price = productRequest.Price;
            product.StockQuantity = productRequest.StockQuantity;

            await _productRepository.UpdateAsync(product);

            return true;
        }
    }
}
