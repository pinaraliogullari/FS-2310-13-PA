using MiniShop.Shared.DTOs;
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
        Task<CategoryDTO> GetByIdAsync(int id);
        Task<List<CategoryDTO>> GetAllAsync();
        Task<CategoryDTO> CreateAsync(CategoryDTO categoryDTO);
        Task<CategoryDTO> UpdateAsync(CategoryDTO categoryDTO);
        Task HardDeleteASync(int id);
        Task SoftDeleteASync(int id);

        #endregion

        #region Category

        Task<List<CategoryDTO>> GetAllCategoriesWithProductAsync();
        #endregion
    }
}
