using FluentMigrator;

namespace Inventory.DBMigration
{
    [Migration(3)]
    public class _0003_EnterReceipts : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("EnterReceipts")
                .WithColumn("Id").AsInt64().PrimaryKey().Identity()
                .WithColumn("CustomerName").AsString()
                .WithColumn("ProductId").AsInt64()
                .WithColumn("Quantity").AsInt32()
                .WithColumn("Status").AsByte()
                .WithColumn("CreatedAt").AsDateTime2()
                .WithColumn("LastModified").AsDateTime2()
                .WithColumn("SurrogateKey").AsGuid();
        }
    }
}
