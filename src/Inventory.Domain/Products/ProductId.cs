using Framework.Core;
using Framework.Domain;

namespace Inventory.Domain.Products
{
    public class ProductId : ValueObjectBase<ProductId>
    {
        public long Id { get; private set; }

        protected ProductId() { }
        public ProductId(long dbId)
        {
            Id = dbId;
        }

        public override bool SameValueAs(ProductId valueObject)
        {
            return this.Id == valueObject?.Id;
        }

        public override int HashCode()
        {
            return new HashCodeBuilder().Append(this.Id).ToHashCode();
        }
    }
}
