using MiniShop.Shared.DTOs;
using MiniShop.Shared.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Business.Abstract
{
    public interface ICategoryService
    {
        #region Generic
        Task<Response<CategoryDTO>> GetByIdAsync(int id);
        Task<Response<List<CategoryDTO>>> GetAllAsync();
        Task<Response<List<CategoryDTO>>> GetNonDeletedCategories();
        Task<Response<CategoryDTO>> CreateAsync(AddCategoryDTO addCategoryDTO);
        Task<Response<CategoryDTO>> UpdateAsync(EditCategoryDTO editCategoryDTO);
        Task <Response<NoContent>> HardDeleteASync(int id); 
        Task<Response<NoContent>> SoftDeleteASync(int id);

        #endregion

        #region Category

        Task<Response<List<CategoryDTO>>> GetAllCategoriesWithProductAsync();
        Task<Response<List<CategoryDTO>>>GetAllCategoriesActiveDeletedAsync();
        #endregion
    }
}
