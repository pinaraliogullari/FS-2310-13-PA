use Northwind
go

--select *
--from Products

--select *
--from Products
--where ProductID=8

--select *
--from Products 
--where CategoryID=1 and UnitsInStock>=50 and SupplierID=16

--select *
--from Products
--where CategoryID=1 or CategoryID=2

--select *
--from Products
--where UnitPrice>=50 and UnitPrice<=60

--select count(*) as [Beverages Kategorisindeki Ürün Sayýsý]
--from Products
--where CategoryID=1

--select min(UnitPrice) as [Minimum Ürün Fiyatý]
--from Products

--select max(UnitPrice) as [Maksimum Ürün Fiyatý]
--from Products

--select *, od.UnitPrice * od.Quantity as [Total]
--from OrderDetails od

--select sum(od.UnitPrice * od.Quantity) as [Ciro]
--from OrderDetails od

--select avg(od.UnitPrice * od.Quantity) as [Ortalama Satýþ]
--from OrderDetails od

--select 
--	e.TitleOfCourtesy + ' ' + e.FirstName + ' ' + e.LastName as [Employee],
--	e.City, 
--	e.Country
--from Employees e

--select upper(e.LastName) + ' ' + upper(e.FirstName) as [Soyad]
--from Employees e

--Çalýþanlarýmýza ad.soyad þeklinde mail adresi verilecektir. Bunun için gerekli mail adresini oluþturacak kodu yazýnýz. Geriye ad, soyad ve mail adresi dönsün. 
--Not: mail adresi örneði: ad.soyad@bright.com

--select
--	e.FirstName as [Ad],
--	e.LastName as [Soyad],
--	lower(e.FirstName + '.' + e.LastName + '@bright.com') as [Mail]
--from Employees e

--select 
--	len(e.FirstName) as [Not uzunluðu]
--from Employees e

--select 
--	p.ProductName as [Name],
--	lower(replace(replace(p.ProductName,' ','-'),'''','')) as [Url]
--from Products p

--select 
--	o.EmployeeID as [Çalýþan],
--	count(*) as [Satýþ Adedi]
--from Orders o
--group by o.EmployeeID

--select
--	od.OrderID,
--	sum(od.UnitPrice*od.Quantity) as [Order Total]
--from OrderDetails od
--group by od.OrderID

select
	o.EmployeeID,
	o.CustomerID,
	count(*) as [Quantity]
from Orders o
group by o.EmployeeID, o.CustomerID
