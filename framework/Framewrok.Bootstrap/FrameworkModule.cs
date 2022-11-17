using Autofac;
using Framework.Application;
using Framework.Core;
using Framework.DataAccess.EF;

namespace Framewrok.Bootstrap
{
    public class FrameworkModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGenericDecorator(typeof(TransactionalCommandHandlerDecorator<>), typeof(ICommandHandler<>));

            builder.RegisterType<CommandBus>().As<ICommandBus>()
                .InstancePerLifetimeScope();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ServiceLocator>().As<IServiceLocator>()
                .InstancePerLifetimeScope();
        }
    }
}
