namespace Framework.Core
{
    public interface IServiceLocator
    {
        T GetInstance<T>() where T : class;
    }
}
