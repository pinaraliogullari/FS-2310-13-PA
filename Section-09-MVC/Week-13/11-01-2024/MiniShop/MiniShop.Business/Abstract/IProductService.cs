using MiniShop.Entity;
using MiniShop.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Business.Abstract
{
    public interface IProductService
    {
        //CRUD işlemlerini gerçekleştirecek metot imzalarımızı yazacağız.

        void Create(ProductViewModel model);                                           //CREATE
        List<ProductViewModel> GetAll(bool? isHome = null, bool? isActive=null, bool? isDelete = null);   //READ
        ProductViewModel GetById(int id);                                              //READ
        void Update(ProductViewModel model);                                           //UPDATE
        void HardDelete(int id);                                                       //DELETE
        void SoftDelete(int id);                                                       //DELETE
    }
}
