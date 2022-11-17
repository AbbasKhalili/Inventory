using Framework.Core;

namespace Framework.Domain
{
    public abstract class EntityBase<T>
    {
        public T Id { get; protected set; }

        public override bool Equals(object obj)
        {
            if (!(obj is EntityBase<T> entity)) return false;

            return Id.Equals(entity.Id);
        }

        public override int GetHashCode()
        {
            return new HashCodeBuilder().Append(this.Id).ToHashCode();
        }
    }
}
