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
        public CategoryRepository(MiniShopDbContext dbContext) : base(dbContext)
        {
        }
        private MiniShopDbContext MiniShopDbContext
        {
            get { return _dbContext as MiniShopDbContext; }
        }
        public async Task<List<Category>> GetAllCategoriesWithProductAsync()
        {
            List<Category> categories = await MiniShopDbContext.Categories
                .Include(c=>c.ProductCategories)
                .ThenInclude(pc=>pc.Product)
                .ToListAsync();
            return categories;
        }
    }
}
