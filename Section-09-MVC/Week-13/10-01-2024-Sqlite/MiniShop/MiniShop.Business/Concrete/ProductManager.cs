﻿using MiniShop.Business.Abstract;
using MiniShop.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Business.Concrete
{
    public class ProductManager : IProductService
    {
        public void Create(ProductViewModel model)
        {
            throw new NotImplementedException();
        }

        public List<ProductViewModel> GetAll(bool? isHome, bool? isActive, bool? isDelete)
        {
            throw new NotImplementedException();
        }

        public ProductViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void HardDelete(int id)
        {
            throw new NotImplementedException();
        }

        public void SoftDelete(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ProductViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
