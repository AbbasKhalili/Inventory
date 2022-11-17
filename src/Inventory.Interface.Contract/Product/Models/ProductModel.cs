using System;

namespace Inventory.Interface.Contract.Product.Models
{
    public class ProductModel
    {
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public Guid CategoryId { get; set; }
        public bool Weighted { get; set; }
    }
}
