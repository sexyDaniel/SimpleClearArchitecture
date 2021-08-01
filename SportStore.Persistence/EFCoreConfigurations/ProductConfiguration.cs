using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportStore.Domain;
namespace SportStore.Persistence.EFCoreConfigurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p=>p.Id);
            builder.HasIndex(p => p.Id).IsUnique();
        }
    }
}
