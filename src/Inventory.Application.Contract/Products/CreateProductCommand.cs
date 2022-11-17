
using System;

namespace Inventory.Application.Contract.Products
{
    public class CreateProductCommand
    {
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public Guid CategoryId { get; set; }
        public bool Weighted { get; set; }
    }
}
