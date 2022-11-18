using Inventory.Domain.DepartureReceipts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Inventory.Persistence.Mappings
{
    internal class DepartureReceiptMap : IEntityTypeConfiguration<DepartureReceipt>
    {
        public void Configure(EntityTypeBuilder<DepartureReceipt> builder)
        {
            builder.ToTable("DepartureReceipts");
            builder.HasKey(t => t.Id);

            builder.Property(t => t.SurrogateKey);
            builder.Property(t => t.CustomerName);
            builder.Property(t => t.ProductId);
            builder.Property(t => t.Quantity);
            builder.Property(t => t.CreatedAt);
            builder.Property(t => t.LastModified);

            builder.HasOne(a => a.Product).WithMany(a => a.DepartureReceipts).HasForeignKey(ad => ad.ProductId);
        }
    }
}

