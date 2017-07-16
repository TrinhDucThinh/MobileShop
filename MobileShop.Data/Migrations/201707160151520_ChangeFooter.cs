namespace MobileShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeFooter : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Footers");
            AddColumn("dbo.Footers", "ID", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Footers", "ID");
            DropColumn("dbo.Footers", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Footers", "MyProperty", c => c.String(nullable: false, maxLength: 128));
            DropPrimaryKey("dbo.Footers");
            DropColumn("dbo.Footers", "ID");
            AddPrimaryKey("dbo.Footers", "MyProperty");
        }
    }
}
