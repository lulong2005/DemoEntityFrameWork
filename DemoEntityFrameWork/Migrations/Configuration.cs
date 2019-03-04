namespace DemoEntityFrameWork.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DemoEntityFrameWork.Models.ProductDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DemoEntityFrameWork.Models.ProductDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.CategoryOfProducts.AddOrUpdate(c => c.CategoryOfProductID,
            new Models.CategoryOfProduct { CategoryOfProductID = 1, Description = @"OPTIONAL01" },
            new Models.CategoryOfProduct { CategoryOfProductID = 2, Description = @"OPTIONAL02" }
            );
            context.Products.AddOrUpdate(p => p.ProductID,
            new Models.Product { ProductID = 1, NameOfProduct = @"PRODUCT01", CategoryOfProductID = 1 },
            new Models.Product { ProductID = 2, NameOfProduct = @"PRODUCT02", CategoryOfProductID = 2 }
            );
        }
    }
}
