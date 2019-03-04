using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEntityFrameWork.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string NameOfProduct { get; set; }
        public int CategoryOfProductID { get; set; }
        public CategoryOfProduct categoryOfProduct
        {
            get
            {
                CategoryOfProduct category = new CategoryOfProduct();
                using (ProductDBContext db = new ProductDBContext())
                {
                    category = db.CategoryOfProducts.Find(this.CategoryOfProductID);
                }
                return category;
            }
        }
        public long Price { get; set; }
    }
}
