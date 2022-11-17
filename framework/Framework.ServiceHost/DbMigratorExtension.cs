using System;
using System.Reflection;
using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;

namespace Framework.ServiceHost
{
    public static class DbMigratorExtension
    {
        public static void AddFluentMigrator(this IServiceCollection services, string connectionString, Assembly assembly)
        {
            services.AddFluentMigratorCore()
                .ConfigureRunner(rb => rb
                    .AddSqlServer()
                    .WithGlobalConnectionString(connectionString)
                    .ScanIn(assembly).For.Migrations())
                .AddLogging(lb => lb.AddFluentMigratorConsole())
                .BuildServiceProvider(false);
        }

        public static void RunMigration(this IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();
            UpdateDatabase(scope.ServiceProvider);
        }

        private static void UpdateDatabase(IServiceProvider serviceProvider)
        {
            var runner = serviceProvider.GetRequiredService<IMigrationRunner>();
            runner.MigrateUp();
        }
    }
}
