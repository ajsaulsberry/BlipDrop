namespace BlipDrop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Iso3 = c.String(nullable: false, maxLength: 3),
                        CountryNameEnglish = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Iso3);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Guid(nullable: false),
                        CustomerName = c.String(maxLength: 128),
                        CountryIso3 = c.String(maxLength: 3),
                        RegionCode = c.String(),
                        Region_Iso3 = c.String(maxLength: 3),
                        Region_RegionCode = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.CustomerID)
                .ForeignKey("dbo.Countries", t => t.CountryIso3)
                .ForeignKey("dbo.Regions", t => new { t.Region_Iso3, t.Region_RegionCode })
                .Index(t => t.CountryIso3)
                .Index(t => new { t.Region_Iso3, t.Region_RegionCode });
            
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        Iso3 = c.String(nullable: false, maxLength: 3),
                        RegionCode = c.String(nullable: false, maxLength: 128),
                        RegionNameEnglish = c.String(),
                    })
                .PrimaryKey(t => new { t.Iso3, t.RegionCode })
                .ForeignKey("dbo.Countries", t => t.Iso3, cascadeDelete: true)
                .Index(t => t.Iso3);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", new[] { "Region_Iso3", "Region_RegionCode" }, "dbo.Regions");
            DropForeignKey("dbo.Regions", "Iso3", "dbo.Countries");
            DropForeignKey("dbo.Customers", "CountryIso3", "dbo.Countries");
            DropIndex("dbo.Regions", new[] { "Iso3" });
            DropIndex("dbo.Customers", new[] { "Region_Iso3", "Region_RegionCode" });
            DropIndex("dbo.Customers", new[] { "CountryIso3" });
            DropTable("dbo.Regions");
            DropTable("dbo.Customers");
            DropTable("dbo.Countries");
        }
    }
}
