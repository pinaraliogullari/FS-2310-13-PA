use Northwind
go

select
	od.OrderID,
	od.UnitPrice as [Birim Fiyat],
	od.Quantity as [Adet],
	od.UnitPrice*od.Quantity as [Tutar],
	dbo.fnKdvHesapla(od.UnitPrice*od.Quantity, 0.2) as [KDV Tutarý], 
	od.UnitPrice*od.Quantity+ dbo.fnKdvHesapla
	(od.UnitPrice*od.Quantity,0.2) as [KDV Dahil Tutar]
from OrderDetails od