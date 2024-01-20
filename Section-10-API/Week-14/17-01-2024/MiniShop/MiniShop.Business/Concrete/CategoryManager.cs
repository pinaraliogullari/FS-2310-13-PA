using AutoMapper;
using MiniShop.Business.Abstract;
using MiniShop.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Business.Concrete
{
    public class CategoryManager : ICategoryService

    {
        private readonly IMapper _mapper;

        public CategoryManager(IMapper mapper) //container yani IOS den gelen mapperı parametre olarak aldık(eklemesini program.cs tek  yapmıştık)
        {
            _mapper = mapper; //ve enjete ettik.
        }

        public Task<CategoryDTO> CreateAsync(CategoryDTO categoryDTO)
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryDTO>> GetAllCategoriesWithProductAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDTO> GetByIdAsync(int id)
        {
            throw new NotImplementedException();

        }

        public Task HardDeleteASync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteASync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDTO> UpdateAsync(CategoryDTO categoryDTO)
        {
            throw new NotImplementedException();
        }
    }
}
