using Inventory.Domain.Categories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Inventory.Persistence.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");

            builder.HasKey(t => t.Id);            

            builder.Property(t => t.SurrogateKey);
            builder.Property(t => t.Name);
            builder.Property(t => t.CreatedAt);
            builder.Property(t => t.LastModified);
        }
    }
}

