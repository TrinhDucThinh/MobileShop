namespace MobileShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeHomeFlag : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProductCategories", "HomeFlag", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProductCategories", "HomeFlag", c => c.Boolean(nullable: false));
        }
    }
}
