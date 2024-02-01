﻿using MiniShop.Entity.Concrete;
using MiniShop.Shared.DTOs;
using MiniShop.Shared.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Business.Abstract
{
    public interface IProductService
    {
        #region Generic
        Task<Response<ProductDTO>> GetByIdAsync(int id);
        Task<Response<List<ProductDTO>>> GetAllAsync();
        Task<Response<ProductDTO>> CreateAsync(AddProductDTO addProductDTO);
        Task<Response<ProductDTO>> UpdateAsync(EditProductDTO editProductDTO);
        Task <Response<NoContent>> HardDeleteASync(int id);
        Task<Response<NoContent>> SoftDeleteASync(int id);

        #endregion

        #region Product
        Task<Response<List<ProductDTO>>> GetAllProductsWithCategoriesAsync();
        Task<Response<ProductDTO>> GetProductWithCategoriesAsync(int id);
        Task<Response<List<ProductDTO>>> GetProductsByCategoryIdAsync(int categoryId);
        Task<Response<NoContent>> UpdateIsHomeAsync(int id);
        Task<Response<NoContent>> UpdateIsActiveAsync(int id);

        #endregion
    }
}