using FluentMigrator;
using System;
namespace Smt.Migrations.DefaultDB
{
    [Migration(20860518_115168)]
    public class DefaultDB_20860518_115168_BrandCategory : Migration
    {
        public override void Up()
        {
            Create.Schema("brandcat");

            Create.Table("BrandCategory").InSchema("brandcat")
                .WithColumn("BrandCategoryId").AsInt32()
                    .Identity().PrimaryKey().NotNullable()
                .WithColumn("BrandId").AsInt32().NotNullable()
                    .ForeignKey("FK_BrandCategory_BrandId",
                        "brand", "Brand", "BrandId")
                .WithColumn("CategoryId").AsInt32().NotNullable()
                    .ForeignKey("FK_BrandCategory_CategoryId",
                        "cat", "Category", "CategoryId");


            Execute.Sql(
              @"INSERT INTO brandcat.BrandCategory (BrandId, CategoryId) 
                    SELECT b.BrandId, c.CategoryId 
                    FROM brand.Brand b, cat.Category c 
                    ");
        }

        public override void Down()
        {
        }
    }
}