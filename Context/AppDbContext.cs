using aspnet_core_api.Models.Database;
using Microsoft.EntityFrameworkCore;

namespace aspnet_core_api.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
