using Inventory.Domain.Contract;
using System;

namespace Inventory.Application.Contract.Products
{
    public class ChangeProductStatusCommand
    {
        public Guid ProductId { get; set; }
        public ProductStatus ProductStatus { get; set; }
}
}
