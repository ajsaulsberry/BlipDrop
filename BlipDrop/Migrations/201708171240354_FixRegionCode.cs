namespace BlipDrop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixRegionCode : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", new[] { "Region_Iso3", "Region_RegionCode" }, "dbo.Regions");
            DropIndex("dbo.Customers", new[] { "Region_Iso3", "Region_RegionCode" });
            DropPrimaryKey("dbo.Regions");
            AlterColumn("dbo.Customers", "RegionCode", c => c.String(maxLength: 3));
            AlterColumn("dbo.Customers", "Region_RegionCode", c => c.String(maxLength: 3));
            AlterColumn("dbo.Regions", "RegionCode", c => c.String(nullable: false, maxLength: 3));
            AddPrimaryKey("dbo.Regions", new[] { "Iso3", "RegionCode" });
            CreateIndex("dbo.Customers", new[] { "Region_Iso3", "Region_RegionCode" });
            AddForeignKey("dbo.Customers", new[] { "Region_Iso3", "Region_RegionCode" }, "dbo.Regions", new[] { "Iso3", "RegionCode" });
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", new[] { "Region_Iso3", "Region_RegionCode" }, "dbo.Regions");
            DropIndex("dbo.Customers", new[] { "Region_Iso3", "Region_RegionCode" });
            DropPrimaryKey("dbo.Regions");
            AlterColumn("dbo.Regions", "RegionCode", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Customers", "Region_RegionCode", c => c.String(maxLength: 128));
            AlterColumn("dbo.Customers", "RegionCode", c => c.String());
            AddPrimaryKey("dbo.Regions", new[] { "Iso3", "RegionCode" });
            CreateIndex("dbo.Customers", new[] { "Region_Iso3", "Region_RegionCode" });
            AddForeignKey("dbo.Customers", new[] { "Region_Iso3", "Region_RegionCode" }, "dbo.Regions", new[] { "Iso3", "RegionCode" });
        }
    }
}
