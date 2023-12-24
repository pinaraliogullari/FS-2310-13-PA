--Functions
/*
	-Geriye deðer döndürebilen yapýlardýr.
	-Sorgularýn içinde kullanýlabilirler.
	-Geriye bir DEÐER ya da TABLO döndürebilirler.
	-Parametre alabilirler.
	-Bir fonksiyon tablo üzerinde INSERT , UPDATE, DELETE gibi iþlemleri yapamaz. Ama INSERT, UPDATE, DELETE sorgusu içerisinde de fonksiyon kullanýlabilir.
	
*/
use Northwind
go

create function fnSample(@txt nvarchar(max)) 
	returns nvarchar(max)
begin
	return  upper(@txt)
end