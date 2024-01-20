using AutoMapper;
using MiniShop.Business.Abstract;
using MiniShop.Data.Abstract;
using MiniShop.Entity.Concrete;
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
        public async Task<Response<CategoryDTO>> CreateAsync(AddCategoryDTO addCategoryDTO)
        {
            var category = _mapper.Map<Category>(addCategoryDTO);
           var createdCategory= await _repository.CreateAsync(category);
            if (createdCategory == null)
            {
                return Response<CategoryDTO>.Fail("Kategori oluşturulamadı", 301);
            }
            var createdCategoryDTO=_mapper.Map<CategoryDTO>(createdCategory);
            return Response<CategoryDTO>.Success(createdCategoryDTO, 200);

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
                return Response<CategoryDTO>.Fail("Id ile eşleşen kategori bulunamadı", 404);
            }
            var categoryDTO=_mapper.Map<CategoryDTO>(categoryById);
            return Response<CategoryDTO>.Success(categoryDTO, 200);
        }

        public async Task<Response<List<CategoryDTO>>> GetNonDeletedCategories()
        {
            var categoryList = await _repository.GetAllAsyncNew(c => !c.IsDeleted && c.IsActive);
            if (categoryList == null)
            {
                return Response<List<CategoryDTO>>.Fail("Hiç kategori bulunamadı", 301);
            }
            var categoryDTOList = _mapper.Map<List<CategoryDTO>>(categoryList);
            return Response<List<CategoryDTO>>.Success(categoryDTOList, 200); ;
        }

        public async Task<Response<NoContent>> HardDeleteASync(int id)
        {
            var category=await _repository.GetByIdAsync(id);
            if (category == null)
            {
                return Response<NoContent>.Fail("Id ile eşleşen kategori bulunamadı", 404);
            }
            await _repository.HardDeleteAsync(category);
            return Response<NoContent>.Success(204);
        }

        public async Task<Response<NoContent>> SoftDeleteASync(int id)
        {
            var deletedCategory = await _repository.GetByIdAsync(id);
            if (deletedCategory == null)
            {
                return Response<NoContent>.Fail("Id ile eşleşen kategori bulunamadı", 404);
            } if (deletedCategory.IsDeleted)
            {
                return Response<NoContent>.Fail("Bu kategori zaten silinmiş.", 404);
            }
                deletedCategory.IsDeleted = true;
                deletedCategory.ModifiedDate=DateTime.Now;
                await _repository.UpdateAsync(deletedCategory);
                return Response<NoContent>.Success(200);
        }

        public async Task<Response<CategoryDTO>> UpdateAsync(EditCategoryDTO  editCategoryDTO)
        {
         var editedCategory= _mapper.Map<Category>(editCategoryDTO);
            if (editedCategory == null)
            {
                return Response<CategoryDTO>.Fail("Id ile eşleşen kategori bulunamadı", 404);
            }
            editedCategory.ModifiedDate= DateTime.Now;
            await _repository.UpdateAsync(editedCategory);
            var resultCategoryDTO=_mapper.Map<CategoryDTO>(editedCategory);
            return Response<CategoryDTO>.Success(resultCategoryDTO, 200);
        }

        public Task<Response<List<CategoryDTO>>> GetAllCategoriesActiveDeletedAsync()
        {
            throw new NotImplementedException();
        }
    }
}
