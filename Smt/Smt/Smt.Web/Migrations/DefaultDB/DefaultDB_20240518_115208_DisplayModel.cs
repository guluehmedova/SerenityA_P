using FluentMigrator;
using System;
namespace Smt.Migrations.DefaultDB
{
    [Migration(20240518_115208)]
    public class DefaultDB_20240518_115208_DisplayModel : Migration
    {
        public override void Up()
        {
            Create.Schema("dModel");

            Create.Table("DisplayModel").InSchema("dModel")
                .WithColumn("DisplayModelId").AsInt32()
                    .Identity().PrimaryKey().NotNullable()
            .WithColumn("ModelId").AsInt32().NotNullable()
                    .ForeignKey("FK_DisplayModel_ModelId",
                        "model", "Model", "ModelId")
                .WithColumn("VendorId").AsInt32().NotNullable()
                    .ForeignKey("FK_DisplayMode_VendorId",
                        "vendor", "Vendor", "VendorId");

            Execute.Sql(
              @"INSERT INTO dModel.DisplayModel (ModelId, VendorId) 
                    SELECT m.ModelId, v.VendorId 
                    FROM model.Model m, vendor.Vendor v");
        }

        public override void Down()
        {
        }
    }
}
