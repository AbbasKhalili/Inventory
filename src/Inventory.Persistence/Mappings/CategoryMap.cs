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
            builder.HasKey(t => t.Id.Id);

            builder.Property(t => t.Id.SurrogateKey);
            builder.Property(t => t.Name);
            builder.Property(t => t.CreatedOn);
            builder.Property(t => t.LastModified);
        }
    }
}

