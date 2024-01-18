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
            CreateMap<Product,ProductDTO>().ReverseMap();
            //ReverseMap sayesinde ; ihtiyaç halinde Category i CategoryDTO ya dönüşürür. ihtiyaç halinde de tam tersini yapar.
            CreateMap<Category, CategoryDTO>()
                .ForMember(cdto=>cdto.ProductList,options=>
                options.MapFrom(c=>c.ProductCategories.Select(pc=>pc.Product))).ReverseMap();
        }
    }
}
