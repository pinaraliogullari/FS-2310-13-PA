--Functions
/*
	-Geriye değer döndürebilen yapılardır.
	-Sorguların içinde kullanılabilirler.
	-Geriye bir DEĞER ya da TABLO döndürebilirler.
	-Parametre alabilirler.
	-Bir fonksiyon tablo üzerinde INSERT , UPDATE, DELETE gibi işlemleri yapamaz. Ama INSERT, UPDATE, DELETE sorgusu içerisinde de fonksiyon kullanılabilir.
	
*/
use Northwind
go

create function fnSample(@txt nvarchar(max)) 
	returns nvarchar(max)
begin
	return  upper(@txt)
end