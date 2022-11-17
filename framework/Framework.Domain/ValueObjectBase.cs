namespace Framework.Domain
{
    public abstract class ValueObjectBase<T> : IValueObject<T> where T : class
    {
        public abstract bool SameValueAs(T valueObject);
        public abstract int HashCode();

        public override bool Equals(object obj)
        {
            return SameValueAs(obj as T);
        }

        public override int GetHashCode()
        {
            return HashCode();
        }
    }
}
