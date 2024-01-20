using MiniShop.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Data.Abstract
{
    //ikisi de interface olduğu için implementasyon yapılmıyor.Yani ICategoryRepository de  soyut olduğu için için de metot olmaz.
    public interface ICategoryRepository:IGenericRepository<Category>
    {
        Task<List<Category>> GetAllCategoriesWithProductAsync();
    }
}
