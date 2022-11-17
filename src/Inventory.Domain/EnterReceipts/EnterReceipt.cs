using Framework.Domain;
using Inventory.Domain.Contract;
using System;

namespace Inventory.Domain.EnterReceipts
{
    public class EnterReceipt : EntityBase<long>, IAggregateRoot
    {
        //todo: CustomerName should be consider an Entity
        public string CustomerName { get; private set; }
        public long ProductId { get; private set; }
        public int Quantity { get; private set; }
        public EnterReceiptStatus Status { get; private set; }

        protected EnterReceipt() { }
        public EnterReceipt(string customerName, long productId, int quantity, EnterReceiptStatus status)
        {
            CustomerName = customerName;
            ProductId = productId;
            Quantity = quantity;
            Status = status;
            CreatedAt = DateTime.Now;
            LastModified = DateTime.Now;
            SurrogateKey = Guid.NewGuid();
        }
    }
}
