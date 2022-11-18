using System;

namespace Inventory.Application.Contract.EnterReceipts
{
    public class DamagedReceiptCommand
    {
        public string CustomerName { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
