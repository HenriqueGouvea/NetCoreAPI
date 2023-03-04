using NetCoreAPI.Applicaiton.Interfaces;
using NetCoreAPI.Applicaiton.Services;

namespace NetCoreAPI.ConfigurationExtensions
{
    internal static class ApplicationServicesExtension
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
        }
    }
}
