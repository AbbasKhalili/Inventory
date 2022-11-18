using Framework.Domain;
using Inventory.Domain.Categories;
using Inventory.Domain.Contract;
using Inventory.Domain.DepartureReceipts;
using Inventory.Domain.EnterReceipts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory.Domain.Products
{
    public class Product : EntityBase<long>, IAggregateRoot
    {
        public string Name { get; private set; }
        public string Barcode { get; private set; }
        public string Description { get; private set; }
        public long CategoryId { get; private set; }
        public bool Weighted { get; private set; }
        public ProductStatus Status { get; private set; }


        public Category Category { get; private set; }


        private HashSet<DepartureReceipt> _departureReceipts = new();
        public IEnumerable<DepartureReceipt> DepartureReceipts => _departureReceipts?.ToList();


        private HashSet<EnterReceipt> _enterReceipts = new();
        public IEnumerable<EnterReceipt> EnterReceipts => _enterReceipts?.ToList();

        protected Product() { }
        public Product(string name, string barcode, string description, long categoryId, bool weighted)
        {
            Name = name;
            Barcode = barcode;
            Description = description;
            CategoryId = categoryId;
            Weighted = weighted;
            Status = ProductStatus.UnAvailable;
            CreatedAt = DateTime.Now;
            LastModified = DateTime.Now;
            SurrogateKey = Guid.NewGuid();
        }

        public void SetStatus(ProductStatus status)
        {
            Status = status;
            LastModified = DateTime.Now;
        }
    }
}
