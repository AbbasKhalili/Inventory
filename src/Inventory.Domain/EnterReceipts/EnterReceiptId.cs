using Framework.Core;
using Framework.Domain;
using System;

namespace Inventory.Domain.EnterReceipts
{
    public class EnterReceiptId : ValueObjectBase<EnterReceiptId>
    {
        public long Id { get; private set; }
        public Guid SurrogateKey { get; private set; }

        protected EnterReceiptId() { }
        public EnterReceiptId(long dbId)
        {
            Id = dbId;
            SurrogateKey = Guid.NewGuid();
        }

        public override bool SameValueAs(EnterReceiptId valueObject)
        {
            return this.Id == valueObject?.Id;
        }

        public override int HashCode()
        {
            return new HashCodeBuilder().Append(this.Id).ToHashCode();
        }
    }
}
