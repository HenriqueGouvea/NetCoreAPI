using NetCoreAPI.Applicaiton.Interfaces;
using NetCoreAPI.Applicaiton.Services;
using NetCoreAPI.Domain.Repositories;
using NetCoreAPI.Repository.Repositories;

namespace NetCoreAPI.ConfigurationExtensions
{
    internal static class ApplicationServicesExtension
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
