using Microsoft.EntityFrameworkCore;
using MiniShop.Data.Concrete.Contexts;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();//mvc uygulamas� olsayd� burada AddControllersWithView yazard�.
//burada �retilen ve container i�ine koyulan  MiniShopDbContext istedi�imiz zaman constructor ile almam�z� bekliyor.
//constructor ile ald���m�zda dependency injection yapm�� oluyoruz. bu sayede kullanaca��m�z yerde newleme yapmam�za gerek kalm�yor.
builder.Services.AddDbContext<MiniShopDbContext>(options =>
options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection"))
);

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies()); //bu komut AutoMapper'� uygulamaya ekler ve t�m uygulama alan�ndaki tipleri kullanarak AutoMapper'� yap�land�r�r, b�ylece s�n�flar aras�nda otomatik nesne e�leme yeteneklerini kullanabiliriz.






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
