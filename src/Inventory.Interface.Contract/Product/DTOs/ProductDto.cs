using System;

namespace Inventory.Interface.Contract.Product.DTOs
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public Guid CategoryId { get; set; }
        public bool Weighted { get; set; }
        public byte Status { get; set; }
    }
}
