use MoviesDb
go

--select *
--from Categories

--select 
--	Name  as [Film Adý] ,
--	IsActive as [Aktif mi?], 
--	CreatedDate as [Oluþturulma Tarihi]
--from Films

select 
	Name,
	IsActive,
	CreatedDate
from Films
where IsActive=0