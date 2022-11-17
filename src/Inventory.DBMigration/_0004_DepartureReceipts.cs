using FluentMigrator;

namespace Inventory.DBMigration
{
    [Migration(4)]
    public class _0004_DepartureReceipts : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("DepartureReceipts")
                .WithColumn("Id").AsInt64().PrimaryKey()
                .WithColumn("CustomerName").AsString()
                .WithColumn("ProductId").AsInt64()
                .WithColumn("Quantity").AsInt32()
                .WithColumn("CreatedAt").AsDateTime2()
                .WithColumn("LastModified").AsDateTime2()
                .WithColumn("SurrogateKey").AsGuid();
        }
    }
}
