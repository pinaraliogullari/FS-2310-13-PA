using Microsoft.EntityFrameworkCore;
using MiniShop.Data.Concrete.Contexts;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();//mvc uygulamasý olsaydý burada AddControllersWithView yazardý.
//burada üretilen ve container içine koyulan  MiniShopDbContext istediðimiz zaman constructor ile almamýzý bekliyor.
//constructor ile aldýðýmýzda dependency injection yapmýþ oluyoruz. bu sayede kullanacaðýmýz yerde newleme yapmamýza gerek kalmýyor.
builder.Services.AddDbContext<MiniShopDbContext>(options =>
options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection"))
);

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies()); //bu komut AutoMapper'ý uygulamaya ekler ve tüm uygulama alanýndaki tipleri kullanarak AutoMapper'ý yapýlandýrýr, böylece sýnýflar arasýnda otomatik nesne eþleme yeteneklerini kullanabiliriz.






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
