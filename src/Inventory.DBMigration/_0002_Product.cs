using FluentMigrator;

namespace Inventory.DBMigration
{
    [Migration(2)]
    public class _0002_Product : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Products")
                .WithColumn("Id").AsInt64().PrimaryKey()
                .WithColumn("Name").AsString()
                .WithColumn("Barcode").AsString()
                .WithColumn("Description").AsString()
                .WithColumn("CategoryId").AsInt64()
                .WithColumn("Weighted").AsBoolean()
                .WithColumn("Status").AsByte()
                .WithColumn("CreatedAt").AsDateTime2()
                .WithColumn("LastModified").AsDateTime2()
                .WithColumn("SurrogateKey").AsGuid();
        }
    }
}
