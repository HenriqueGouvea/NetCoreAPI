﻿using NetCoreAPI.Domain.Models;
using NetCoreAPI.Dto.Product;

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

        public static ProductResponse ToProductResponse(this Product product)
        {
            return new ProductResponse
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