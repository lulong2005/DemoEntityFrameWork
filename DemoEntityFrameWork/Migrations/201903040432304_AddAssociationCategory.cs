namespace DemoEntityFrameWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAssociationCategory : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Products", "CategoryOfProductID");
            AddForeignKey("dbo.Products", "CategoryOfProductID", "dbo.CategoryOfProducts", "CategoryOfProductID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CategoryOfProductID", "dbo.CategoryOfProducts");
            DropIndex("dbo.Products", new[] { "CategoryOfProductID" });
        }
    }
}
