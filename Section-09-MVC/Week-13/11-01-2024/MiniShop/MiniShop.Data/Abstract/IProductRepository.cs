using MiniShop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Data.Abstract
{
    public interface IProductRepository:IGenericRepository<Product>
    {
        //artık burada IGenericRepository içinde ne varsa onlar var. ama product için.
        // ek olarak, producta özgü metot imzalarımızı buraya yazacağız.
        List<Product> GetProductsByCategoryId(int categoryId);
    }
}
