namespace MobileShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateAuditable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Products", "CreatedBy", c => c.String(maxLength: 256));
            AlterColumn("dbo.Products", "UpdatedDate", c => c.DateTime());
            AlterColumn("dbo.Products", "UpdatedBy", c => c.String(maxLength: 256));
            AlterColumn("dbo.Products", "MetaKeyword", c => c.String(maxLength: 256));
            AlterColumn("dbo.Products", "MetaDescription", c => c.String(maxLength: 256));
            AlterColumn("dbo.ProductCategories", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.ProductCategories", "CreatedBy", c => c.String(maxLength: 256));
            AlterColumn("dbo.ProductCategories", "UpdatedDate", c => c.DateTime());
            AlterColumn("dbo.ProductCategories", "UpdatedBy", c => c.String(maxLength: 256));
            AlterColumn("dbo.ProductCategories", "MetaKeyword", c => c.String(maxLength: 256));
            AlterColumn("dbo.ProductCategories", "MetaDescription", c => c.String(maxLength: 256));
            AlterColumn("dbo.Pages", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Pages", "CreatedBy", c => c.String(maxLength: 256));
            AlterColumn("dbo.Pages", "UpdatedDate", c => c.DateTime());
            AlterColumn("dbo.Pages", "UpdatedBy", c => c.String(maxLength: 256));
            AlterColumn("dbo.Pages", "MetaKeyword", c => c.String(maxLength: 256));
            AlterColumn("dbo.Pages", "MetaDescription", c => c.String(maxLength: 256));
            AlterColumn("dbo.PostCategories", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.PostCategories", "CreatedBy", c => c.String(maxLength: 256));
            AlterColumn("dbo.PostCategories", "UpdatedDate", c => c.DateTime());
            AlterColumn("dbo.PostCategories", "UpdatedBy", c => c.String(maxLength: 256));
            AlterColumn("dbo.PostCategories", "MetaKeyword", c => c.String(maxLength: 256));
            AlterColumn("dbo.PostCategories", "MetaDescription", c => c.String(maxLength: 256));
            AlterColumn("dbo.Posts", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Posts", "CreatedBy", c => c.String(maxLength: 256));
            AlterColumn("dbo.Posts", "UpdatedDate", c => c.DateTime());
            AlterColumn("dbo.Posts", "UpdatedBy", c => c.String(maxLength: 256));
            AlterColumn("dbo.Posts", "MetaKeyword", c => c.String(maxLength: 256));
            AlterColumn("dbo.Posts", "MetaDescription", c => c.String(maxLength: 256));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "MetaDescription", c => c.String());
            AlterColumn("dbo.Posts", "MetaKeyword", c => c.String());
            AlterColumn("dbo.Posts", "UpdatedBy", c => c.String());
            AlterColumn("dbo.Posts", "UpdatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Posts", "CreatedBy", c => c.String());
            AlterColumn("dbo.Posts", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PostCategories", "MetaDescription", c => c.String());
            AlterColumn("dbo.PostCategories", "MetaKeyword", c => c.String());
            AlterColumn("dbo.PostCategories", "UpdatedBy", c => c.String());
            AlterColumn("dbo.PostCategories", "UpdatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PostCategories", "CreatedBy", c => c.String());
            AlterColumn("dbo.PostCategories", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Pages", "MetaDescription", c => c.String());
            AlterColumn("dbo.Pages", "MetaKeyword", c => c.String());
            AlterColumn("dbo.Pages", "UpdatedBy", c => c.String());
            AlterColumn("dbo.Pages", "UpdatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Pages", "CreatedBy", c => c.String());
            AlterColumn("dbo.Pages", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ProductCategories", "MetaDescription", c => c.String());
            AlterColumn("dbo.ProductCategories", "MetaKeyword", c => c.String());
            AlterColumn("dbo.ProductCategories", "UpdatedBy", c => c.String());
            AlterColumn("dbo.ProductCategories", "UpdatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ProductCategories", "CreatedBy", c => c.String());
            AlterColumn("dbo.ProductCategories", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Products", "MetaDescription", c => c.String());
            AlterColumn("dbo.Products", "MetaKeyword", c => c.String());
            AlterColumn("dbo.Products", "UpdatedBy", c => c.String());
            AlterColumn("dbo.Products", "UpdatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Products", "CreatedBy", c => c.String());
            AlterColumn("dbo.Products", "CreatedDate", c => c.DateTime(nullable: false));
        }
    }
}
