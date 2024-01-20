using AutoMapper;
using MiniShop.Business.Abstract;
using MiniShop.Data.Abstract;
using MiniShop.Shared.DTOs;
using MiniShop.Shared.ResponseDTOs;
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
        private readonly ICategoryRepository _repository;

        public CategoryManager(IMapper mapper, ICategoryRepository repository) //container yani IOS den gelen mapperı ve repositoryyi parametre olarak aldık(eklemesini program.cs tek  yapmıştık)
        {
            _mapper = mapper; //ve enjete ettik.
            _repository = repository;//enjekte ettik.
        }
        //Responseın içine verilen tipler Response sınıfında belirttiğimiz T.
        public Task<Response<CategoryDTO>> CreateAsync(CategoryDTO categoryDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<Response<List<CategoryDTO>>> GetAllAsync()
        {
           var categoryList= await _repository.GetAllAsync();
            if(categoryList==null)
            {
                return Response<List<CategoryDTO>>.Fail("Hiç kategori bulunamadı", 301);
            }
            var categoryDTOList = _mapper.Map<List<CategoryDTO>>(categoryList);
            return Response<List<CategoryDTO>>.Success(categoryDTOList, 200);
        }

        public async Task<Response<List<CategoryDTO>>> GetAllCategoriesWithProductAsync()
        {
            var categoryList = await _repository.GetAllCategoriesWithProductAsync();
            if (categoryList == null)
            {
                return Response<List<CategoryDTO>>.Fail("Hiç kategori bulunamadı", 301);
            }
            var categoryDTOList=_mapper.Map<List<CategoryDTO>>(categoryList);
            return Response<List<CategoryDTO>>.Success(categoryDTOList, 200);
        }

        public async Task<Response<CategoryDTO>> GetByIdAsync(int id)
        {
            var categoryById =await _repository.GetByIdAsync(id);
            if (categoryById == null)
            {
                return Response<CategoryDTO>.Fail("Id ile eşleşen kategori bulunamadı", 301);
            }
            var categoryDTO=_mapper.Map<CategoryDTO>(categoryById);
            return Response<CategoryDTO>.Success(categoryDTO, 200);
        }

        public Task<Response<NoContent>> HardDeleteASync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> SoftDeleteASync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<CategoryDTO>> UpdateAsync(CategoryDTO categoryDTO)
        {
            throw new NotImplementedException();
        }
    }
}
