namespace BlipDrop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequiredCustomerFields : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "CountryIso3", "dbo.Countries");
            DropIndex("dbo.Customers", new[] { "CountryIso3" });
            AlterColumn("dbo.Customers", "CustomerName", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Customers", "CountryIso3", c => c.String(nullable: false, maxLength: 3));
            CreateIndex("dbo.Customers", "CountryIso3");
            AddForeignKey("dbo.Customers", "CountryIso3", "dbo.Countries", "Iso3", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "CountryIso3", "dbo.Countries");
            DropIndex("dbo.Customers", new[] { "CountryIso3" });
            AlterColumn("dbo.Customers", "CountryIso3", c => c.String(maxLength: 3));
            AlterColumn("dbo.Customers", "CustomerName", c => c.String(maxLength: 128));
            CreateIndex("dbo.Customers", "CountryIso3");
            AddForeignKey("dbo.Customers", "CountryIso3", "dbo.Countries", "Iso3");
        }
    }
}
