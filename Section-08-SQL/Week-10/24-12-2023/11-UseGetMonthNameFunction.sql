--declare @birthDay date
--set @birthDay='1975-07-16'

--select dbo.GetMonthName(@birthDay)

use Northwind
go

select
o.OrderDate,
dbo.GetMonthName(o.OrderDate) [Ay]
from Orders o