using Framework.Domain;
using Inventory.Domain.DepartureReceipts.DomainServices;
using Inventory.Domain.Products;
using System;
using System.Threading.Tasks;

namespace Inventory.Domain.DepartureReceipts
{
    public class DepartureReceipt : EntityBase<long>, IAggregateRoot
    {
        //todo: CustomerName should be consider an Entity
        public string CustomerName { get; private set; }
        public long ProductId { get; private set; }
        public int Quantity { get; private set; }


        public Product Product { get; private set; }

        protected DepartureReceipt() { }
        private DepartureReceipt(string customerName, long productId, int quantity)
        {
            CustomerName = customerName;
            ProductId = productId;
            Quantity = quantity;
            CreatedAt = DateTime.Now;
            LastModified = DateTime.Now;
            SurrogateKey = Guid.NewGuid();
        }

        public static async Task<DepartureReceipt> Create(string customerName, long productId, int quantity,
            IInquiryExistingProductDomainService inquiryExistingProduct)
        {
            await inquiryExistingProduct.Inqiry(productId, quantity);

            return new DepartureReceipt(customerName, productId, quantity);
        }
    }
}
