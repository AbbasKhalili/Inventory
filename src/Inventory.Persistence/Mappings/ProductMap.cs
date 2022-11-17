using Inventory.Domain.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Inventory.Persistence.Mappings
{
    internal class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(t => t.Id.Id);

            builder.Property(t => t.Id.SurrogateKey);
            builder.Property(t => t.Name);
            builder.Property(t => t.Barcode);
            builder.Property(t => t.Description);
            builder.Property(t => t.CategoryId);
            builder.Property(t => t.Weighted);
            builder.Property(t => t.Status);
            builder.Property(t => t.CreatedAt);
            builder.Property(t => t.LastModified);
        }
    }
}

