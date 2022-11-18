using System;

namespace Inventory.Interface.Contract.DepartureReceipt.Models
{
    public class DepartureReceiptModel
    {
        public string CustomerName { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
