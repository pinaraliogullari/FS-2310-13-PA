--kendisine gönderilecek iki adet sayýyý toplayýp sonucu döndüren bir function hazýrlayýnýz.



drop function  if exists dbo.fnTopla 
go
create function fnTopla
	(@sayi1 int, @sayi2 int)
	returns int
begin
    return @sayi1 + @sayi2
end

--select dbo.fnTopla(10,20)