using FluentMigrator;
using System;
namespace Smt.Migrations.DefaultDB
{
    [Migration(20220512_115102)]
    public class DefaultDB_20220512_115102_CommonFaq : Migration
    {
        public override void Up()
        {
            Create.Schema("comfaq");

            Create.Table("CommonFaq").InSchema("comfaq")
                .WithColumn("CommonFaqId").AsInt32()
                    .Identity().PrimaryKey().NotNullable()
                .WithColumn("Question").AsString(200).NotNullable()
                .WithColumn("Answer").AsString(1000).NotNullable();
        }

        public override void Down()
        {
        }
    }
}