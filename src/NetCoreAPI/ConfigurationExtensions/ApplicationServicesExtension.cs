using NetCoreAPI.Applicaiton.Interfaces;
using NetCoreAPI.Applicaiton.Services;

namespace NetCoreAPI.ConfigurationExtensions
{
    internal static class ApplicationServicesExtension
    {
        public static void AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IProductService, ProductService>();
        }
    }
}
