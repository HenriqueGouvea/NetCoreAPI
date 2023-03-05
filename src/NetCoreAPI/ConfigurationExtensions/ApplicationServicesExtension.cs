using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc;
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
            services.AddScoped<IUrlHelper>(x => x.GetRequiredService<IUrlHelperFactory>()
                .GetUrlHelper(x.GetRequiredService<IActionContextAccessor>().ActionContext));
        }
    }
}
