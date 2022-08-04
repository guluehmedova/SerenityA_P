using FluentMigrator;
using Serenity.Extensions;
using System;
namespace Smt.Migrations.DefaultDB
{
    [Migration(20790918_115199)]
    public class DefaultDB_20790918_115199_Vendor : Migration
    {
        public override void Up()
        {
            Create.Table("Vendor").InSchema("vendor")
                .WithColumn("VendorId").AsInt32()
                    .Identity().PrimaryKey().NotNullable()
                .WithColumn("UserName").AsString(100).NotNullable()
                .WithColumn("Email").AsString(200).NotNullable()
                .WithColumn("Password").AsString(100).NotNullable()
                .WithColumn("ConfirmPassword").AsString(100).NotNullable()
                .WithColumn("Name").AsString(100).NotNullable()
                .WithColumn("UserImage").AsString(250).NotNullable();
        }
        public override void Down() { }
    }
}
