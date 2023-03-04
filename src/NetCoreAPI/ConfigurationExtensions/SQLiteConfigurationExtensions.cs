using NetCoreAPI.Repository;

using Microsoft.EntityFrameworkCore;

namespace NetCoreAPI.ConfigurationExtensions
{
    internal static class SQLiteConfigurationExtensions
    {
        public static void AddSqliteContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("NetCoreAPI") ?? "Data Source=NetCoreAPI.db";
            services.AddSqlite<NetCoreAPIContext>(connectionString);
        }

        public static void EnsureDatabaseSetup(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var services = scope.ServiceProvider;
            var db = services.GetRequiredService<NetCoreAPIContext>();
            db.Database.EnsureCreated();
            // Add seed
        }
    }
}
