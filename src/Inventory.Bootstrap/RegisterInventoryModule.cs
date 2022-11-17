using Autofac;

namespace Inventory.Bootstrap
{
    public static class RegisterInventoryModule
    {
        public static void AddModule(this ContainerBuilder builder, string connectionString)
        {
            builder.RegisterModule(new InventoryModule(connectionString));
        }
    }
}
