namespace BlipDrop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveCompoundKey : DbMigration
    {
        public override void Up()
        {
            //DropForeignKey("dbo.Customers", new[] { "Region_Iso3", "Region_RegionCode" }, "dbo.Regions");
            DropForeignKey("dbo.Regions", "Iso3", "dbo.Countries");
            DropIndex("dbo.Customers", new[] { "Region_Iso3", "Region_RegionCode" });
            DropIndex("dbo.Regions", new[] { "Iso3" });
            DropColumn("dbo.Customers", "RegionCode");
            RenameColumn(table: "dbo.Customers", name: "Region_Iso3", newName: "RegionCode");
            DropPrimaryKey("dbo.Regions");
            AlterColumn("dbo.Regions", "Iso3", c => c.String(maxLength: 3));
            AddPrimaryKey("dbo.Regions", "RegionCode");
            CreateIndex("dbo.Customers", "RegionCode");
            CreateIndex("dbo.Regions", "Iso3");
            AddForeignKey("dbo.Customers", "RegionCode", "dbo.Regions", "RegionCode");
            AddForeignKey("dbo.Regions", "Iso3", "dbo.Countries", "Iso3");
            DropColumn("dbo.Customers", "Region_RegionCode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Region_RegionCode", c => c.String(maxLength: 3));
            DropForeignKey("dbo.Regions", "Iso3", "dbo.Countries");
            DropForeignKey("dbo.Customers", "RegionCode", "dbo.Regions");
            DropIndex("dbo.Regions", new[] { "Iso3" });
            DropIndex("dbo.Customers", new[] { "RegionCode" });
            DropPrimaryKey("dbo.Regions");
            AlterColumn("dbo.Regions", "Iso3", c => c.String(nullable: false, maxLength: 3));
            AddPrimaryKey("dbo.Regions", new[] { "Iso3", "RegionCode" });
            RenameColumn(table: "dbo.Customers", name: "RegionCode", newName: "Region_Iso3");
            AddColumn("dbo.Customers", "RegionCode", c => c.String(maxLength: 3));
            CreateIndex("dbo.Regions", "Iso3");
            CreateIndex("dbo.Customers", new[] { "Region_Iso3", "Region_RegionCode" });
            AddForeignKey("dbo.Regions", "Iso3", "dbo.Countries", "Iso3", cascadeDelete: true);
            AddForeignKey("dbo.Customers", new[] { "Region_Iso3", "Region_RegionCode" }, "dbo.Regions", new[] { "Iso3", "RegionCode" });
        }
    }
}
