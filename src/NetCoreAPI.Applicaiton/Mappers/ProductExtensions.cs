using NetCoreAPI.Domain.Models;
using NetCoreAPI.Dto.Product;
using System.Reflection.Metadata.Ecma335;

namespace NetCoreAPI.Applicaiton.Mappers
{
    internal static class ProductExtensions
    {
        public static Product ToProduct(this ProductRequest productRequest)
        {
            return new Product
            {
                Name = productRequest.Name,
                Price = productRequest.Price,
                SequenceNumber = productRequest.SequenceNumber,
                StockQuantity = productRequest.StockQuantity,
            };
        }

        public static IEnumerable<ProductResponse> ToProductResponse(this List<Product> products)
        {
            _ = new List<ProductResponse>();

            foreach (var product in products)
            {
                yield return product.ToProductResponse();
            }
        }

        public static IEnumerable<ProductItemResponse> ToProductItemResponse(this List<Product> products)
        {
            _ = new List<ProductItemResponse>();

            foreach (var product in products)
            {
                yield return product.ToProductItemResponse();
            }
        }

        public static ProductResponse? ToProductResponse(this Product product)
        {
            if (product == null) return null;

            return new ProductResponse
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                SequenceNumber = product.SequenceNumber,
                StockQuantity = product.StockQuantity,
            };
        }

        public static ProductItemResponse? ToProductItemResponse(this Product product)
        {
            if (product == null) return null;

            return new ProductItemResponse
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                SequenceNumber = product.SequenceNumber,
                StockQuantity = product.StockQuantity,
            };
        }
    }
}
