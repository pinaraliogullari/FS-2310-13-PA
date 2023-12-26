use Northwind
go

drop proc if exists spGetOrdersWithDiscount
go

create proc spGetOrdersWithDiscount
as
	select
	od.OrderID as [Sipari� No],
	sum(od.UnitPrice*od.Quantity*(1-od.Discount)) as [Sipari� Tutar�]
	from OrderDetails od
	group by od.OrderID

go

--Test
execute spGetOrdersWithDiscount
go
