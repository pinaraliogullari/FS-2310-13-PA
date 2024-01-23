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


//burada �retilen ve container i�ine koyulan  MiniShopDbContext istedi�imiz zaman constructor ile almam�z� bekliyor.
//constructor ile ald���m�zda dependency injection yapm�� oluyoruz. bu sayede kullanaca��m�z yerde newleme yapmam�za gerek kalm�yor.
builder.Services.AddDbContext<MiniShopDbContext>(options =>
options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection"))
);

//builder.Services.AddAutoMapper(typeof(GeneralMappingProfile).Assembly); di�er yol
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies()); //bu komut AutoMapper'� uygulamaya ekler ve t�m uygulama alan�ndaki tipleri kullanarak AutoMapper'� yap�land�r�r, b�ylece s�n�flar aras�nda otomatik nesne e�leme yeteneklerini kullanabiliriz.

builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IProductService, ProductManager>();


builder.Services.AddScoped<ICategoryRepository, CategoryRepository>(); //categoryrepo tipinde bir nesne yarat�p containera b�rak�yoruz.ve ne zaman ICateforyRepository dersek bize CategoryRepository veriliyor.

builder.Services.AddScoped<IProductRepository, ProductRepository>();




//a�a��daki iki sat�r sayesinde Swagger ekleniyor.
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
