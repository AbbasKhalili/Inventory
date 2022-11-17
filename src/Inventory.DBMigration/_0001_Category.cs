using FluentMigrator;

namespace Inventory.DBMigration
{
    [Migration(1)]
    public class _0001_Category : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Categories")
                .WithColumn("Id").AsInt64().PrimaryKey()
                .WithColumn("Name").AsString()
                .WithColumn("CreatedAt").AsDateTime2()
                .WithColumn("LastModified").AsDateTime2()
                .WithColumn("SurrogateKey").AsGuid();
        }
    }
}
