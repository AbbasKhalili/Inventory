using Framework.Core;
using Framework.Domain;

namespace Inventory.Domain.Categories
{
    public class CategoryId : ValueObjectBase<CategoryId>
    {
        public long Id { get; private set; }

        protected CategoryId() { }
        public CategoryId(long dbId)
        {
            Id = dbId;
        }

        public override bool SameValueAs(CategoryId valueObject)
        {
            return this.Id == valueObject?.Id;
        }

        public override int HashCode()
        {
            return new HashCodeBuilder().Append(this.Id).ToHashCode();
        }
    }
}
