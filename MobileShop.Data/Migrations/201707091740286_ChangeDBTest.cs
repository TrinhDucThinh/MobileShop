namespace MobileShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDBTest : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "HotFlag", c => c.Boolean());
            DropColumn("dbo.Products", "Quantity");
            DropColumn("dbo.Products", "OriginalPrice");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "OriginalPrice", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "Quantity", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "HotFlag", c => c.Boolean(nullable: false));
        }
    }
}
