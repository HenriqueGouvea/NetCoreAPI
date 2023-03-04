using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetCoreAPI.Domain.Models;

namespace NetCoreAPI.Repository
{
    public class NetCoreAPIContext : DbContext
    {
        public DbSet<Product> Products => Set<Product>();

        public NetCoreAPIContext(DbContextOptions<NetCoreAPIContext> options) : base(options)
        {

        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            // SqlLite workaround for DateTimeOffset sorting
            configurationBuilder
                .Properties<DateTimeOffset>()
                .HaveConversion<DateTimeOffsetToStringConverter>();

            // SqlLite workaround for decimal aggregations
            configurationBuilder
                .Properties<decimal>()
                .HaveConversion<double>();
        }
    }
}
