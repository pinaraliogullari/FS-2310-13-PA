using Microsoft.EntityFrameworkCore;
using MiniShop.Data.Abstract;
using MiniShop.Data.Concrete.Contexts;
using MiniShop.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Data.Concrete.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        //containerın yani servis collectionun içinde kullanmamız üzere bekleyen MiniShopDbContexti constructor ile buraya alıyoruz.
        //nasıl ki entity tipini (category) generic repostitorye gönderip bu entitye göre işlemleri yaptırıp sonra oradan miras alıyorsak, DbContexti de göndermeliyiz. Dbcontext buraya containerdan geliyor.buradan da generic repoya.bu gönderme işlemini de base(_context) sayesinde yapabiliyoruz. category reponun base i olan Generic repoya dbContexti gönder

        //minishopDbContext tipindeki contexti aldık ve base e gönderdik
        public CategoryRepository(MiniShopDbContext _context) : base(_context)  
        {
        }
        private MiniShopDbContext MiniShopDbContext
        {
            get { return _dbContext as MiniShopDbContext; }
        }

    

        public async Task<List<Category>> GetAllCategoriesWithProductAsync()
        {
            List<Category> categories = await MiniShopDbContext.Categories

                .Include(c=>c.ProductCategories)//categori tablosundaki productcategories kolonunu   dahil et.
                .ThenInclude(pc=>pc.Product) //daha sonra ProductCategory tablosundaki productı dahil et
                .ToListAsync();
            return categories;
        }

        public Task<Category> GetCategoryWithProductsAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
