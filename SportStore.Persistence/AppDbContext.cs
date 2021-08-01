using Microsoft.EntityFrameworkCore;
using SportStore.Application.Interfaces;
using SportStore.Domain;
using SportStore.Persistence.EFCoreConfigurations;

namespace SportStore.Persistence
{
    public class AppDbContext : DbContext, IDbContext
    {
        public DbSet<Product> Products { get ; set ; }
        public DbSet<Category> Categories { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
