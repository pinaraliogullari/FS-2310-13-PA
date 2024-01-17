﻿using MiniShop.Business.Abstract;
using MiniShop.Core.ViewModels;
using MiniShop.Data.Abstract;
using MiniShop.Data.Concrete;
using MiniShop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryRepository _categoryRepository;

        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void Create(CategoryViewModel model)
        {
            Category category = new Category{
                Name= model.Name,
                Description= model.Description,
                Url= model.Url
            };
            _categoryRepository.Create(category);
        }

        public List<CategoryViewModel> GetAll( bool? isActive = null, bool? isDelete = null)
        {
            List<Category> categories;
           
                if (isDelete == null)
                {
                    categories = _categoryRepository.GetAll();
                }
                else {
                    categories = _categoryRepository.GetDeletedCategories(isDelete);
                } 
            List<CategoryViewModel> categoryViewModels = categories.Select(c => new CategoryViewModel
            {
                Id = c.Id,
                Name = c.Name,
                Url = c.Url,
                Description = c.Description
            }).ToList();

            return categoryViewModels;
        }


        public CategoryViewModel GetCategoryById(int id)
        {
            Category category = _categoryRepository.GetById(id);
            CategoryViewModel categoryViewModel = new CategoryViewModel
            {
                //İlk yazılan Id,Name,Url vs. CategoryViewModeldaki propertyler.
                Id = category.Id,
                Name = category.Name,
                Url = category.Url,
                Description = category.Description
              
            };
            return categoryViewModel;
        }

        public void HardDelete(int id)
        {
            Category deletedCategory = _categoryRepository.GetById(id);
         
            _categoryRepository.HardDelete(deletedCategory);

        }

        public void SoftDelete(int id)
        {
          
            Category deletedCategory= _categoryRepository.GetById(id);
            deletedCategory.IsDelete = !deletedCategory.IsDelete;
            _categoryRepository.SoftDelete(deletedCategory);
        }

        public void Update(CategoryViewModel model)
        {
            Category editedCategory = _categoryRepository.GetById(model.Id);
            editedCategory.Name = model.Name;
            editedCategory.Url = model.Url;
            editedCategory.Description = model.Description;
           
            _categoryRepository.Update(editedCategory);
        }
    }
}
