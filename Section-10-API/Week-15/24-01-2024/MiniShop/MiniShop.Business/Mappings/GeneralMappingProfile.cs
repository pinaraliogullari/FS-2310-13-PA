using AutoMapper;
using MiniShop.Entity.Concrete;
using MiniShop.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Business.Mappings
{
    public class GeneralMappingProfile:Profile
    {
        public GeneralMappingProfile()


        {
            CreateMap<Category, AddCategoryDTO>().ReverseMap();
            CreateMap<Category, EditCategoryDTO>().ReverseMap();
            CreateMap<Category,InCategoryDTO>().ReverseMap();

            CreateMap<Product,AddProductDTO>().ReverseMap();
            CreateMap<Product, EditProductDTO>()
                  .ForMember(pdto => pdto.CategoryList, options =>
                   options.MapFrom(p => p.ProductCategories.Select(pc => pc.Category)))
                .ReverseMap();
            CreateMap<Product,InProductDTO>().ReverseMap();


            CreateMap<Product, ProductDTO>()
               .ForMember(pdto=>pdto.CategoryList, options=>
                   options.MapFrom(p=>p.ProductCategories.Select(pc=>pc.Category)))
               .ReverseMap();



            //ReverseMap sayesinde ; ihtiyaç halinde Category i CategoryDTO ya dönüşürür. ihtiyaç halinde de tam tersini yapar.
            CreateMap<Category, CategoryDTO>() //şu an CategoryDTO içindeyiz.
                .ForMember(cdto=>cdto.ProductList,options=> //productlisti dolduracaksın
                options.MapFrom(c=>c.ProductCategories.Select(pc=>pc.Product))).ReverseMap();//category eden  productcategoriese 
            //sonuç olarak categoryDTodaki ProductListi,  product ile dolduruyoruz. 
        }
    }
}
