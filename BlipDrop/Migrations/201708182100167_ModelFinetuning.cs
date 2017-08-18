namespace BlipDrop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelFinetuning : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Regions", "Iso3", "dbo.Countries");
            DropIndex("dbo.Regions", new[] { "Iso3" });
            AlterColumn("dbo.Countries", "CountryNameEnglish", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Regions", "Iso3", c => c.String(nullable: false, maxLength: 3));
            AlterColumn("dbo.Regions", "RegionNameEnglish", c => c.String(nullable: false));
            CreateIndex("dbo.Regions", "Iso3");
            AddForeignKey("dbo.Regions", "Iso3", "dbo.Countries", "Iso3", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Regions", "Iso3", "dbo.Countries");
            DropIndex("dbo.Regions", new[] { "Iso3" });
            AlterColumn("dbo.Regions", "RegionNameEnglish", c => c.String());
            AlterColumn("dbo.Regions", "Iso3", c => c.String(maxLength: 3));
            AlterColumn("dbo.Countries", "CountryNameEnglish", c => c.String(maxLength: 50));
            CreateIndex("dbo.Regions", "Iso3");
            AddForeignKey("dbo.Regions", "Iso3", "dbo.Countries", "Iso3");
        }
    }
}
