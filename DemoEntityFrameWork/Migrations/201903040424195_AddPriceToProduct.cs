namespace DemoEntityFrameWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPriceToProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Price", c => c.Long(nullable: false, defaultValue: 0));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Price");
        }
    }
}
