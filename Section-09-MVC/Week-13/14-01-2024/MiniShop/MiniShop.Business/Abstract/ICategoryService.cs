using MiniShop.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Business.Abstract
{
    public interface ICategoryService
    {
        //CRUD işlemlerini gerçekleştirecek metot imzalarını yazacağız.

        void Create(CategoryViewModel model);
        List<CategoryViewModel> GetAll( bool? isActive = null, bool? isDelete = null);
        CategoryViewModel GetCategoryById(int id);
        void Update(CategoryViewModel model);
        void HardDelete(int id);
        void SoftDelete(int id);
    }
}
