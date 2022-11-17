using Framework.Domain;
using System;

namespace Inventory.Domain.DepartureReceipts
{
    public class DepartureReceipt : EntityBase<DepartureReceiptId>, IAggregateRoot
    {
        //todo: CustomerName should be consider an Entity
        public string CustomerName { get; private set; }
        public long ProductId { get; private set; }
        public int Quantity { get; private set; }

        protected DepartureReceipt() { }
        public DepartureReceipt(string customerName, long productId, int quantity)
        {
            CustomerName = customerName;
            ProductId = productId;
            Quantity = quantity;
            CreatedAt = DateTime.Now;
            LastModified = DateTime.Now;
        }
    }
}
