using Autofac;
using Framework.Core;
using Framework.Logger;
using Framewrok.Bootstrap;

namespace Framework.ServiceHost
{
    public static class RegisterModule
    {
        public static void AddFramework(this ContainerBuilder builder)
        {
            builder.RegisterModule(new FrameworkModule());
        }

        public static void AddNLog(this ContainerBuilder builder, string nlogConfigFile = "./nlog.config")
        {
            builder.RegisterType<NLoggerService>().As<ILoggerService>()
                .InstancePerLifetimeScope();

            builder.RegisterGeneric(typeof(NLoggerService<>))
                .As(typeof(ILoggerService<>))
                .InstancePerLifetimeScope();

            NLogConfigure.Config(nlogConfigFile);
        }
    }
}
