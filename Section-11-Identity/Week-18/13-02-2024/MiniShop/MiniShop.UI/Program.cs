using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MiniShop.Business.Abstract;
using MiniShop.Business.Concrete;
using MiniShop.Data.Abstract;
using MiniShop.Data.Concrete.Contexts;
using MiniShop.Data.Concrete.Repositories;
using MiniShop.Entity.Concrete.Identity;
using MiniShop.Shared.Helpers.Abstract;
using MiniShop.Shared.Helpers.Concrete;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<MiniShopDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection"))
);

builder.Services.AddIdentity<User, Role>()
    .AddEntityFrameworkStores<MiniShopDbContext>()
    .AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(options =>
{
    #region Parola Ayarlarý
    options.Password.RequiredLength = 8;//parola en az 6 karakter olmalý.
    options.Password.RequireDigit = true; //parola sayýsal deðer içermeli.
    options.Password.RequireNonAlphanumeric = true; //parola özel karakter içermeli
    options.Password.RequireUppercase = true; //parola büyük harf içermeli
    options.Password.RequireLowercase = true;//parola küçük harf içermeli.
    /*options.Password.RequiredUniqueChars *///tekrar etmemesi istenen karakterler.
    #endregion

    #region Hesap Kilitleme Ayarlarý
    options.Lockout.MaxFailedAccessAttempts = 3; //üstüste hatalý giriþ denemesi sýnýrý
    options.Lockout.DefaultLockoutTimeSpan= TimeSpan.FromSeconds(15);// kilitlenmiþ bir hesaba yeniden giriþ yapabilmek için gereken bekleme süresi.
    //options.Lockout.AllowedForNewUsers = true; //yeniden kayýt olmaya imkan ver.
    #endregion

    options.User.RequireUniqueEmail = true;//her email sade bir kez kayýt olabilir.
    options.SignIn.RequireConfirmedEmail= false; //email onayý

});
//cookie ayarlarý
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/Login";
    options.LogoutPath = "/";
    options.AccessDeniedPath = "/Account/AccessDenied";
    options.ExpireTimeSpan=TimeSpan.FromDays(45);
    options.SlidingExpiration = true;
    options.Cookie = new CookieBuilder
    {
        Name = "MiniShop.Security.Cookie",
        HttpOnly=true,
        SameSite=SameSiteMode.Strict
    };
});

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IProductService, ProductManager>();

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();

builder.Services.AddScoped<IImageHelper, ImageHelper>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapAreaControllerRoute(
    name: "Admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
