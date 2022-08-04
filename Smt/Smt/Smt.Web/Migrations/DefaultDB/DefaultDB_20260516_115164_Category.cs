using FluentMigrator;
using System;
namespace Smt.Migrations.DefaultDB
{
    [Migration(20260516_115164)]
    public class DefaultDB_20260516_115164_Category : Migration
    {
        public override void Up()
        {
            Create.Schema("cat");

            Create.Table("Category").InSchema("cat")
                .WithColumn("CategoryId").AsInt32()
                    .Identity().PrimaryKey().NotNullable()
                .WithColumn("Title").AsString(150).NotNullable();
        }

        public override void Down()
        {
        }
    }
}