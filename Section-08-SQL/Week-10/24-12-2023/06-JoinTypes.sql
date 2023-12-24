--hangi kategoride kaç film var?
use MoviesDb
go

--SELECT
--    c.Name as [Film],
--    COUNT(f.ID) as [Film Adeti]
--FROM  Films f  right JOIN Categories c
--	ON f.CategoryID = c.ID
--GROUP BY c.Name
--order by [Film Adeti] desc

--hangi yönetmeninkaç tane filmi var?


--select
-- d.Name as [Yönetmen],
-- count (f.Id) as [Adet]
--from Directors d left join Films f
--on d.Id=f.DirectorId
--group by d.Name


--hangi filmin oyuncusu yoktur?

--select
--f.Name 

--from Films f left outer join FilmsStars fs
--	on f.Id=fs.FilmId   left outer join Stars s
--	on fs.StarId=s.Id
--	group by f.Name
--	having  COUNT(s.Id) =0

use Northwind
go

--hangi kategoriden kaç paralýk satýþ yapmýþýz?
--select top 3
--c.CategoryName as [Kategori],
--sum(od.UnitPrice*od.Quantity) as [Tutar]
--from Categories c join Products p
--	on c.CategoryID=p.CategoryID join OrderDetails od
--	on p.ProductID=od.ProductID
--	group by c.CategoryName
--	order by [Kategori] desc

--hangi üründen kaç adet satýlmýþtýr?
--satýþý yapýlmamýþ ürün varsa o da listelensin.

--select 
--p.ProductName as [Product],
--sum(od.Quantity) as [Adet]
--from Products p left join OrderDetails od
-- on p.ProductID=od.ProductID
-- group by p.ProductName
-- order by [Adet] asc

--select 
--p.ProductName as [Product]
--from Products p left join OrderDetails od
-- on p.ProductID=od.ProductID
-- group by p.ProductName
--having sum(od.Quantity) Is Null

--en çok ciro yapýlan üç ürün hangisidir? Cirolarýyla birlikte listeleyiniz.
--select top (3)
--	p.ProductName as [Ürün],
--	sum(od.UnitPrice*od.Quantity) as [Ciro]
--from Products p join OrderDetails od
--	on p.ProductID= od.ProductID
--	group by p.ProductName
--	order by [Ciro] desc

--hangi müþteriye ne kadarlýk satýþ yapýlmýþtýr? satýþ tutarýna göre büyükten küçüðe sýralý þekilde listeliyiniz.

select 
c.CompanyName as [Müþteri],
sum(od.UnitPrice*od.Quantity) as [Tutar]
from Customers c join Orders o
	on c.CustomerID= o.CustomerID join OrderDetails od
	on od.OrderID=o.OrderID

	group by c.CompanyName
	order by [Tutar] desc

-- hangi bölgede , hangi üründen ne kadarlýk satýþ yapýlmýþtýr?
select 
r.RegionDescription as [region],
p.ProductName as [Product],
sum(od.UnitPrice*od.Quantity) as [Tutar]

from Region r join Territories t
	on r.RegionID=t.RegionID join EmployeeTerritories et
	on et.TerritoryID= t.TerritoryID join Employees e
	on et.EmployeeID=e.EmployeeID join Orders o
	on e.EmployeeID=o.EmployeeID join OrderDetails od
	on od.OrderID= o.OrderID join Products p
	on od.ProductID=p.ProductID
	where r.RegionDescription='Eastern'
	group by r.RegionDescription,p.ProductName 
	having sum(od.UnitPrice*od.Quantity) >=100000
	order by r.RegionDescription,p.ProductName 
