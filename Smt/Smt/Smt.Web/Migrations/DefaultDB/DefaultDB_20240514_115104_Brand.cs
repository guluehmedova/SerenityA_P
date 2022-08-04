using FluentMigrator;
using System;
namespace Smt.Migrations.DefaultDB
{
    [Migration(20240514_115104)]
    public class DefaultDB_20240514_115104_Brand : Migration
    {
        public override void Up()
        {
            Create.Schema("brand");

            Create.Table("Brand").InSchema("brand")
                .WithColumn("BrandId").AsInt32()
                    .Identity().PrimaryKey().NotNullable()
                .WithColumn("Title").AsString(150).NotNullable()
                .WithColumn("BrandImage").AsString(250).NotNullable();
        }

        public override void Down()
        {
        }
    }
}