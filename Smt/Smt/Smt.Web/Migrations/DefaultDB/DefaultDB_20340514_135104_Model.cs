using FluentMigrator;
using System;
namespace Smt.Migrations.DefaultDB
{
    [Migration(20340514_135104)]
    public class DefaultDB_20340514_135104_Model : Migration
    {
        public override void Up()
        {
            Create.Schema("model");

            Create.Table("Model").InSchema("model")
                .WithColumn("ModelId").AsInt32()
                    .Identity().PrimaryKey().NotNullable()
                .WithColumn("Title").AsString(150).NotNullable()
                .WithColumn("Code").AsString(100).Nullable()
                .WithColumn("ModelImage").AsString(250).NotNullable()
                .WithColumn("CategoryId").AsInt32().NotNullable()
                .ForeignKey("FK_Model_CategoryId", "cat", "Category", "CategoryId");


            Execute.Sql(
              @"INSERT INTO model.Model (CategoryId) 
                    SELECT c.CategoryId
                    FROM cat.Category c
                    WHERE c.CategoryId IS NOT NULL");

        }

        public override void Down()
        {
        }
    }
}