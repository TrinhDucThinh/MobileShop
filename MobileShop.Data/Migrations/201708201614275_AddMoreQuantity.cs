namespace MobileShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMoreQuantity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Quantity", c => c.Int(nullable: false));
            Sql("Update dbo.Products Set Quantity=0");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Quantity");
        }
    }
}