using Microsoft.EntityFrameworkCore;
using MiniShop.Data.Concrete.Configs;
using MiniShop.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Data.Concrete.Contexts
{
    public class MiniShopDbContext:DbContext
    {
        //bu metot sayesinde DbContext sınıfından gerekli olan veritabanına bağlantı bilgileri alınır.
        //base(options) ifadesi ile temel sınıfın kurucu metoduna ileterek, temel sınıfın doğru şekilde başlatılmasını sağlar. Bu, DbContext sınıfının gerekli yapılandırmayı almasını ve bir veritabanına bağlanmak için kullanılacak ayarları içermesini sağlar.
        public MiniShopDbContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<Category>  Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

  
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CategoryConfig).Assembly);
            base.OnModelCreating(modelBuilder);
        }

    }
}
