using Autofac;
using Framework.Core;

namespace Framewrok.Bootstrap
{
    public class ServiceLocator : IServiceLocator
    {
        private readonly ILifetimeScope _lifetimeScope;
        public ServiceLocator(ILifetimeScope lifetimeScope)
        {
            _lifetimeScope = lifetimeScope;
        }

        public T GetInstance<T>() where T : class
        {
            return _lifetimeScope.Resolve<T>();
        }
    }
}
