using FluentMigrator;
using Serenity.Extensions;
using System;
namespace Smt.Migrations.DefaultDB
{
    [Migration(20790915_115188)]
    public class DefaultDB_20790915_115188_Checks : Migration
    {
        public override void Up()
        {
            Alter.Table("Model").InSchema("model")
                 .AddColumn("Check").AsBoolean().WithDefaultValue(false);

            Alter.Table("Brand").InSchema("brand")
                .AddColumn("Check").AsBoolean().WithDefaultValue(false);

            Alter.Table("Category").InSchema("cat")
                .AddColumn("Check").AsBoolean().WithDefaultValue(false);
        }
        public override void Down() { }
    }
}
