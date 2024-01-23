﻿using MiniShop.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Data.Abstract
{
    public interface IProductRepository:IGenericRepository<Product>
    {
        Task<List<Product>> GetAllProductsWithCategoriesAsync();
        Task<Product> GetProductWithCategoriesAsync(int id);
        Task<List<Product>> GetProductsByCategoryIdAsync(int categoryId);
   
    }
}
