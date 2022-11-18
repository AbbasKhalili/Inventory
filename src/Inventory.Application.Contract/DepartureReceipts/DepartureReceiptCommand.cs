using System;

namespace Inventory.Application.Contract.DepartureReceipts
{
    public class DepartureReceiptCommand
    {
        public string CustomerName { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
