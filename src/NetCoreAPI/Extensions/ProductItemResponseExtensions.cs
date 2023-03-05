using Microsoft.AspNetCore.Mvc;
using NetCoreAPI.Dto.Product;

namespace NetCoreAPI.Extensions
{
    internal static class ProductItemResponseExtensions
    {
        private const string GetProductByIdRouteName = "GetProductById";
        private const string UpdateProductRouteName = "UpdateProduct";
        private const string DeleteProductRouteName = "DeleteProduct";

        public static async Task SetLinksAsync(this List<ProductItemResponse> productsResponse, IUrlHelper urlHelper)
        {
            await Task.Run(() =>
            {
                foreach (var product in productsResponse)
                {
                    product.Links.Add(
                        GetLink(GetProductByIdRouteName, new { id = product.Id }, "self", "GET", urlHelper));

                    product.Links.Add(
                        GetLink(UpdateProductRouteName, new { }, "update-product", "PUT", urlHelper));

                    product.Links.Add(
                        GetLink(DeleteProductRouteName, new { id = product.Id }, "delete-product", "DELETE", urlHelper));
                }
            });
        }

        private static LinkResponse GetLink(string routeName, object? values, string rel, string method, IUrlHelper urlHelper)
        {
            return new LinkResponse(
                urlHelper.Link(routeName, values) ?? throw new InvalidOperationException($"Couldn't find route {routeName}"),
                rel,
                method);
        }
    }
}
