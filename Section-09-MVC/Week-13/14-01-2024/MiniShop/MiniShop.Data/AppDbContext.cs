using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MiniShop.Data.Config;
using MiniShop.Entity;

namespace MiniShop.Data
{
    public class AppDbContext:DbContext
    {
        //Aşağıdaki constructor metot sayesinde AppDbContext sınıfı, Entity Framework Core'un genel ayarlarını ve veritabanı bağlantısı için gerekli bilgileri içeren bir DbContextOptions nesnesiyle yapılandırılmış olur.
        public AppDbContext(DbContextOptions options):base(options)
        {
            
        }


        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CategoryProduct> CategoryProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new CategoryProductConfig());
            base.OnModelCreating(modelBuilder);
        }

    }
}
