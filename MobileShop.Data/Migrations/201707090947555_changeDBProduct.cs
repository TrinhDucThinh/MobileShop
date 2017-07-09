namespace MobileShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeDBProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "MoreImages", c => c.String(storeType: "xml"));
            AlterColumn("dbo.Products", "PromotionPrice", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Products", "Warranty", c => c.Int());
            AlterColumn("dbo.Products", "HomeFlag", c => c.Boolean());
            DropColumn("dbo.Products", "MoreImage");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "MoreImage", c => c.String(storeType: "xml"));
            AlterColumn("dbo.Products", "HomeFlag", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Products", "Warranty", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "PromotionPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Products", "MoreImages");
        }
    }
}
