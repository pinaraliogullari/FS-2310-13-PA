using Microsoft.EntityFrameworkCore;
using MiniShop.Business.Abstract;
using MiniShop.Business.Concrete;
using MiniShop.Business.Mappings;
using MiniShop.Data.Abstract;
using MiniShop.Data.Concrete.Contexts;
using MiniShop.Data.Concrete.Repositories;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();
    //.AddJsonOptions(options=>options.JsonSerializerOptions.ReferenceHandler=ReferenceHandler.IgnoreCycles);


//burada üretilen ve container içine koyulan  MiniShopDbContext istediðimiz zaman constructor ile almamýzý bekliyor.
//constructor ile aldýðýmýzda dependency injection yapmýþ oluyoruz. bu sayede kullanacaðýmýz yerde newleme yapmamýza gerek kalmýyor.
builder.Services.AddDbContext<MiniShopDbContext>(options =>
options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection"))
);

//builder.Services.AddAutoMapper(typeof(GeneralMappingProfile).Assembly); diðer yol
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies()); //bu komut AutoMapper'ý uygulamaya ekler ve tüm uygulama alanýndaki tipleri kullanarak AutoMapper'ý yapýlandýrýr, böylece sýnýflar arasýnda otomatik nesne eþleme yeteneklerini kullanabiliriz.

builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IProductService, ProductManager>();


builder.Services.AddScoped<ICategoryRepository, CategoryRepository>(); //categoryrepo tipinde bir nesne yaratýp containera býrakýyoruz.ve ne zaman ICateforyRepository dersek bize CategoryRepository veriliyor.

builder.Services.AddScoped<IProductRepository, ProductRepository>();




//aþaðýdaki iki satýr sayesinde Swagger ekleniyor.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
