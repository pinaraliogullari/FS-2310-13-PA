var builder = WebApplication.CreateBuilder(args); // �nce web uygulamas� olu�turucuyu elimize al�yoruz.

/*
 * AddControllerWithViews metodu, bu projenin bir MVC uygulamas� olmas�n� sa�lar. Burada ConstrollerWithViews servisini IOC(servis havuzu) i�ine koymu� oluruz. Uygulama ihtiya� duydu�u her anda bu havuzdan bu bilgiyi edinebilir.
 * Peki ya MVC Nedir?
 * Model:Projemizdeki, veri veritaban� gibi i�leri y�r�tt���m�z b�l�m
 * View: Projemizdeki aray�z� temsil eden b�l�m.
 * Controller:Gelen t�m istekleri kar��layan , yani projemizin as�l backend kodlar�n�n yer alaca�� b�l�m.
 */
builder.Services.AddControllersWithViews(); // uygulamam�za servis ekledi�imiz(�zellik ekledi�imiz) yer. AddControllersWithViews default olarak gelen servis.Bu servis uygulaman�n mvc uygulams� olmas�n� sa�lar.

var app = builder.Build();//uygulamay� yarat. bu sat�rdan sonra console uygulamas� bir web uygulamas� olmu� oluyor. servis ekleme i�i bitti ve app olu�tu.

//run a kadar olan kodlar(arayaz�l�m-midware) her istek at�ld���nda tekrar �al���r. yani her requestte yukar�daki web olu�turucu vs. �al��maz. sunucuyu ilgilendiren k�s�md�r buras�.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");

    app.UseHsts();
}

app.UseHttpsRedirection(); //uygulama https i destekliyor.
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//nas�l bir requestte bulundu�umuzun kontrol edildigi yer.
//https://localhost:5069/Product/AddProduct
//https://localhost:5069/
//https://localhost:5069/Home/Index
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run(); //uygulamay� �al��t�r�r. 
