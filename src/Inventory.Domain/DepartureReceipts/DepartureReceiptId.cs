using Framework.Core;
using Framework.Domain;
using System;

namespace Inventory.Domain.DepartureReceipts
{
    public class DepartureReceiptId : ValueObjectBase<DepartureReceiptId>
    {
        public long Id { get; private set; }
        public Guid SurrogateKey { get; private set; }

        protected DepartureReceiptId() { }
        public DepartureReceiptId(long dbId)
        {
            Id = dbId;
            SurrogateKey = Guid.NewGuid();
        }

        public override bool SameValueAs(DepartureReceiptId valueObject)
        {
            return this.Id == valueObject?.Id;
        }

        public override int HashCode()
        {
            return new HashCodeBuilder().Append(this.Id).ToHashCode();
        }
    }
}
