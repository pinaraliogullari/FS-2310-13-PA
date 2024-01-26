using AutoMapper;
using Microsoft.EntityFrameworkCore.Migrations.Operations.Builders;
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
    public class ProductManager : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _repository;

        public ProductManager(IMapper mapper, IProductRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<Response<ProductDTO>> CreateAsync(AddProductDTO addProductDTO)
        {
               var product= _mapper.Map<Product>(addProductDTO);
                product.CreatedDate=DateTime.Now;
               product.ModifiedDate=DateTime.Now;
               var createdProduct= await _repository.CreateAsync(product);

            if(product==null)
               {
                    return Response<ProductDTO>.Fail("Bir hata oluştu", 404);
                }

               createdProduct.ProductCategories = addProductDTO.CategoryList.Select(c => new ProductCategory
               {
                    ProductId=createdProduct.Id, CategoryId=c.Id
                }).ToList();
               await _repository.UpdateAsync(createdProduct);
               var resultProductDTO = _mapper.Map<ProductDTO>(createdProduct);
               return Response<ProductDTO>.Success(resultProductDTO, 200);
          
        }

        public async Task<Response<List<ProductDTO>>> GetAllAsync()
        {
            var productList= await _repository.GetAllAsync();
            if (productList == null)
            {
                return Response<List<ProductDTO>>.Fail("Hiç ürün bulunamadı", 301);
            }
            var productDTOList = _mapper.Map<List<ProductDTO>>(productList);
            return Response<List<ProductDTO>>.Success(productDTOList, 200);

        }

        public async Task<Response<List<ProductDTO>>> GetAllProductsWithCategoriesAsync()
        {
            var productList = await _repository.GetAllProductsWithCategoriesAsync();
            if (productList == null)
            {
                return Response<List<ProductDTO>>.Fail("Hiç ürün bulunamadı", 301);
            }
            var productDTOList = _mapper.Map<List<ProductDTO>>(productList);
            return Response<List<ProductDTO>>.Success(productDTOList, 200);
        }

        public async Task<Response<ProductDTO>> GetByIdAsync(int id)
        {
           var product= await _repository.GetByIdAsync(id);
            if (product == null)
            {
                return Response<ProductDTO>.Fail("İlgili ürün bulunamadı", 404);

            }

             var productDTO= _mapper.Map<ProductDTO>(product);
            return Response<ProductDTO>.Success(productDTO, 200);
        }

        public async Task<Response<List<ProductDTO>>> GetProductsByCategoryIdAsync(int categoryId)
        {
            var productList = await _repository.GetProductsByCategoryIdAsync(categoryId);
            if (productList == null)
            {
                return Response<List<ProductDTO>>.Fail("Bu kategoride hiç ürün bulunamadı", 301);
            }
            var productDtoList = _mapper.Map<List<ProductDTO>>(productList);
            return Response<List<ProductDTO>>.Success(productDtoList, 200);
        }

        public async Task<Response<ProductDTO>> GetProductWithCategoriesAsync(int id)
        {
            var product = await _repository.GetProductWithCategoriesAsync(id);
            if (product == null)
            {
                return Response<ProductDTO>.Fail("İlgili ürün bulunamadı", 404);

            }

            var productDTO = _mapper.Map<ProductDTO>(product);
            return Response<ProductDTO>.Success(productDTO, 200);
        }

        public async Task<Response<NoContent>> HardDeleteASync(int id)
        {
            var product = await _repository.GetByIdAsync(id);
            if(product == null) 
            {
                return Response<NoContent>.Fail("İlgili ürün bulunamadı", 404);
            }
          
            await _repository.HardDeleteAsync(product);
            return Response<NoContent>.Success(200);
        }

        public  async Task<Response<NoContent>> SoftDeleteASync(int id)
        {
            var product = await _repository.GetByIdAsync(id);
            if (product == null)
            {
                return Response<NoContent>.Fail("İlgili ürün bulunamadı", 404);
            }
            if (product.IsDeleted)
            {
                return Response<NoContent>.Fail("Ürün zaten silinmiş", 404);
            }
            product.IsDeleted = !product.IsDeleted;
            product.ModifiedDate = DateTime.Now;
            product.IsActive = false;
            await _repository.UpdateAsync(product);
            return Response<NoContent>.Success(200);
        }

        public async Task<Response<ProductDTO>> UpdateAsync(EditProductDTO editProductDTO)
        {
            var editedProdut= _mapper.Map<Product>(editProductDTO);
            if (editedProdut == null)
            {
                return Response<ProductDTO>.Fail("İlgili ürün bulunamadı", 404);

            }
            editedProdut.ModifiedDate= DateTime.Now;
            await _repository.UpdateAsync(editedProdut);
            var resultProduct=_mapper.Map<ProductDTO>(editedProdut);
            return Response<ProductDTO>.Success(resultProduct, 200);

        }

        public async Task<Response<NoContent>> UpdateIsHomeAsync(int id)
        {
            var product = await _repository.GetByIdAsync(id);
            if (product == null)
            {
                return Response<NoContent>.Fail("İlgili ürün bulunamadı", 404);

            }

            product.IsHome=!product.IsHome;
            product.ModifiedDate= DateTime.Now;
            await _repository.UpdateAsync(product);
            return Response<NoContent>.Success(200);
        }
    }
}
