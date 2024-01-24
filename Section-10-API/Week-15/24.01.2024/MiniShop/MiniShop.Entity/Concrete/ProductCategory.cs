using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Entity.Concrete
{
    public class ProductCategory
    {
        public int ProductId { get; set; } //foreignkey
        public int CategoryId { get; set; }//foreignkey

        public Product Product { get; set; }//Navigation Property
        public Category Category { get; set; }//Navigation Property
    }
}
