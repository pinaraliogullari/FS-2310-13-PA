using Microsoft.EntityFrameworkCore;
using MiniShop.Data.Concrete.Contexts;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();//mvc uygulamasý olsaydý burada AddControllersWithView yazardý.
builder.Services.AddDbContext<MiniShopDbContext>(options =>
options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection"))
);

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies()); 






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
