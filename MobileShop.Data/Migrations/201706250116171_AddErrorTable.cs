namespace MobileShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddErrorTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Errors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Message = c.String(),
                        StackTrace = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Posts", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.Posts", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Posts", "CreatedBy", c => c.String());
            AddColumn("dbo.Posts", "UpdatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Posts", "UpdatedBy", c => c.String());
            AddColumn("dbo.Posts", "MetaKeyword", c => c.String());
            AddColumn("dbo.Posts", "MetaDescription", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "MetaDescription");
            DropColumn("dbo.Posts", "MetaKeyword");
            DropColumn("dbo.Posts", "UpdatedBy");
            DropColumn("dbo.Posts", "UpdatedDate");
            DropColumn("dbo.Posts", "CreatedBy");
            DropColumn("dbo.Posts", "CreatedDate");
            DropColumn("dbo.Posts", "Status");
            DropTable("dbo.Errors");
        }
    }
}
