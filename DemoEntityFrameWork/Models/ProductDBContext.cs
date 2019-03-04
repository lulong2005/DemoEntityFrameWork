namespace DemoEntityFrameWork.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ProductDBContext : DbContext
    {
        public ProductDBContext()
            : base("name=ProductDBContext")
        {
        }

        public virtual DbSet<CategoryOfProduct> CategoryOfProducts { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
