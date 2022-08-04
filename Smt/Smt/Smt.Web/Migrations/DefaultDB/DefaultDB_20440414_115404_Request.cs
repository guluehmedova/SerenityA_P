using FluentMigrator;
using System;
namespace Smt.Migrations.DefaultDB
{
    [Migration(20440414_115404)]
    public class DefaultDB_20440414_115404_Request : Migration
    {
        public override void Up()
        {
            Create.Schema("request");

            Create.Table("Request").InSchema("request")
                .WithColumn("RequestId").AsInt32()
                    .Identity().PrimaryKey().NotNullable()
                .WithColumn("Theme").AsString(150).NotNullable()
                .WithColumn("RequestImages").AsString(250).NotNullable()
                .WithColumn("ForwardedTo").AsBoolean().Nullable()
                .WithColumn("Status").AsInt32().NotNullable()
                .WithColumn("Date").AsDateTime().Nullable()
                .WithColumn("Text").AsString(1000).NotNullable()
                .WithColumn("CreationDate").AsDateTime().NotNullable()
                .WithColumn("ModelId").AsInt32().NotNullable()
                    .ForeignKey("FK_Request_ModelId",
                        "model", "Model", "ModelId")
                .WithColumn("CategoryId").AsInt32().NotNullable()
                    .ForeignKey("FK_Request_CategoryId",
                        "cat", "Category", "CategoryId")
                .WithColumn("BrandId").AsInt32().NotNullable()
                    .ForeignKey("FK_Request_BrandId",
                        "brand", "Brand", "BrandId");

            Execute.Sql(
              @"INSERT INTO request.Request (ModelId, CategoryId, BrandId) 
                    SELECT m.ModelId, c.CategoryId, b.BrandId
                    FROM model.Model m, cat.Category c, brand.Brand b");
        }

        public override void Down()
        {
        }
    }
}