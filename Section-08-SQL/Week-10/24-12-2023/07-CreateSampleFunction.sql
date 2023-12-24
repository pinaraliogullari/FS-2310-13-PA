--Functions
/*
	-Geriye de�er d�nd�rebilen yap�lard�r.
	-Sorgular�n i�inde kullan�labilirler.
	-Geriye bir DE�ER ya da TABLO d�nd�rebilirler.
	-Parametre alabilirler.
	-Bir fonksiyon tablo �zerinde INSERT , UPDATE, DELETE gibi i�lemleri yapamaz. Ama INSERT, UPDATE, DELETE sorgusu i�erisinde de fonksiyon kullan�labilir.
	
*/
use Northwind
go

create function fnSample(@txt nvarchar(max)) 
	returns nvarchar(max)
begin
	return  upper(@txt)
end