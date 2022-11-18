using System;

namespace Inventory.Interface.Contract.DamagedReceipt.Models
{
    public class DamagedReceiptModel
    {
        public string CustomerName { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
