using Framework.Domain;
using System;

namespace Inventory.Domain.Products
{
    public class Product : EntityBase<ProductId>, IAggregateRoot
    {
        public string Name { get; private set; }
        public string Barcode { get; private set; }
        public string Description { get; private set; }
        public long CategoryId { get; private set; }
        public bool Weighted { get; private set; }
        public ProductStatus Status { get; private set; }

        protected Product() { }
        public Product(string name, string barcode, string description, long categoryId, bool weighted)
        {
            Name = name;
            Barcode = barcode;
            Description = description;
            CategoryId = categoryId;
            Weighted = weighted;
            Status = ProductStatus.InAvailable;
            CreatedOn = DateTime.Now;
            LastModified = DateTime.Now;
        }

        public void Available()
        {
            Status = ProductStatus.Available;
            LastModified = DateTime.Now;
        }

        public void InAvailable()
        {
            Status = ProductStatus.InAvailable;
            LastModified = DateTime.Now;
        }
    }
}
