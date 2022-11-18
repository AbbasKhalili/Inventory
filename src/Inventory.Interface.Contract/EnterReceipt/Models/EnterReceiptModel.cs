using System;

namespace Inventory.Interface.Contract.EnterReceipt.Models
{
    public class EnterReceiptModel
    {
        public string CustomerName { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
