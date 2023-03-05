using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
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
            
            services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();
            services.AddScoped(x => x.GetRequiredService<IUrlHelperFactory>()
                .GetUrlHelper(x.GetRequiredService<IActionContextAccessor>().ActionContext 
                    ?? throw new InvalidOperationException("Couldn't not find the ActionContext instance")));
        }
    }
}
