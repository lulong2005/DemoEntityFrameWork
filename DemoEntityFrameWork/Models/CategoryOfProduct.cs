using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEntityFrameWork.Models
{
    public class CategoryOfProduct
    {
        public int CategoryOfProductID { get; set; }
        public string Description { get; set; }

        public ICollection<Product> products { get; set; }
    }
}
