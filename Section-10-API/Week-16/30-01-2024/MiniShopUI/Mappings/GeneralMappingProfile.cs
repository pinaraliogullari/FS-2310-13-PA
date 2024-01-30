using AutoMapper;
using MiniShop.MVC.Areas.Admin.Models;

namespace MiniShop.MVC.Mappings
{
    public class GeneralMappingProfile:Profile
    {
        public GeneralMappingProfile()
        {
            CreateMap<ProductViewModel,EditProductViewModel>()
                  .ForMember(ep => ep.CategoryIds, opt => opt.MapFrom(p => p.Categories.Select(c => c.Id).ToList()))
                  .ReverseMap();
            CreateMap<ProductViewModel,DeleteProductViewModel>().ReverseMap();
        }
    }
}
