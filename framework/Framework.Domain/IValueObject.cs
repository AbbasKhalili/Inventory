namespace Framework.Domain
{
    public interface IValueObject<in T>
    {
        bool SameValueAs(T valueObject);
        int HashCode();
    }
}
