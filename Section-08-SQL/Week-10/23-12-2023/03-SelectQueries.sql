use MoviesDb
go

--select *
--from Categories

--select 
--	Name  as [Film Ad�] ,
--	IsActive as [Aktif mi?], 
--	CreatedDate as [Olu�turulma Tarihi]
--from Films

select 
	Name,
	IsActive,
	CreatedDate
from Films
where IsActive=0