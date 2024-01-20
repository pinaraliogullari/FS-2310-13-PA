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
            //ReverseMap sayesinde ; ihtiyaç halinde Category i CategoryDTO ya ihtiyaz halinde de tam tersini yapar.
            CreateMap<Category, CategoryDTO>().ReverseMap();
        }
    }
}
