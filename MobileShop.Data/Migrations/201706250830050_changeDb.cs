namespace MobileShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeDb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PostCategories", "DisplayOrder", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PostCategories", "DisplayOrder");
        }
    }
}
