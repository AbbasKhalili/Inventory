using Inventory.Domain.EnterReceipts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Inventory.Persistence.Mappings
{
    internal class EnterReceiptMap : IEntityTypeConfiguration<EnterReceipt>
    {
        public void Configure(EntityTypeBuilder<EnterReceipt> builder)
        {
            builder.ToTable("EnterReceipts");
            builder.HasKey(t => t.Id);

            builder.Property(t => t.SurrogateKey);
            builder.Property(t => t.CustomerName);
            builder.Property(t => t.ProductId);
            builder.Property(t => t.Quantity);
            builder.Property(t => t.CreatedAt);
            builder.Property(t => t.LastModified);
        }
    }
}

