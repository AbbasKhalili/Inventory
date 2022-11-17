using Autofac;
using System;
using System.Linq;
using Inventory.Application.CategoryHandlers;
using Inventory.Persistence.Mappings;
using Framework.Application;
using Framework.Core;
using Framework.Domain;
using Microsoft.EntityFrameworkCore;
using Inventory.Persistence.Repositories;
using Inventory.Interface.WriteModel;
using Inventory.Interface.QueryModel;
using Framework.DataAccess.EF;

namespace Inventory.Bootstrap
{
    internal class InventoryModule : Module
    {
        private readonly string _connectionString;

        public InventoryModule(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(CategoryRepository).Assembly)
                .Where(a => typeof(IRepository).IsAssignableFrom(a))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(typeof(CategoryFacadeQuery).Assembly)
                .Where(a => typeof(IFacadeService).IsAssignableFrom(a))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(typeof(CategoryFacadeService).Assembly)
                .Where(a => typeof(IFacadeService).IsAssignableFrom(a))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();


            //builder.RegisterAssemblyTypes(typeof(ValidateNationalIdentity).Assembly)
            //    .Where(a => typeof(IDomainService).IsAssignableFrom(a))
            //    .AsImplementedInterfaces()
            //    .InstancePerLifetimeScope();


            builder.RegisterAssemblyTypes(typeof(CategoryCommandHandler).Assembly)
                .AsClosedTypesOf(typeof(ICommandHandler<>)).InstancePerLifetimeScope();


            builder.Register<EFContext>(s =>
            {
                var options = new DbContextOptionsBuilder<EFContext>()
                    .UseSqlServer(_connectionString)
                    .EnableSensitiveDataLogging(true)
                    .LogTo(Console.Write, Microsoft.Extensions.Logging.LogLevel.Information)
                    .Options;
                var context = new EFContext(options, typeof(CategoryMap).Assembly);
                return context;
            }).As<EFContext>().As<IDbContext>().InstancePerLifetimeScope().OnRelease(a => a.Dispose());
        }
    }
}
