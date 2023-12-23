use master
go

create database Shopping 
go

use Shopping
go

--Categories tablosunu oluþturma
create table Categories(
	Id int primary key identity(1,1),
	Name  nvarchar(50) not null,
	Description nvarchar(100),
	IsActive bit default 1,
	CreatedDate datetime default getdate()

)
go

--categories tablosuna veri giriþi
insert into Categories(Name) values	
	('Telefon'),
	('Elektronik'),
	('Televizyon'),
	('Bilgisayar')

go

--Products tablosunu oluþturma
create table Products(
	Id int primary key identity(1,1),
	Name nvarchar(50) not null,
	Properties nvarchar(500),
	Price money not null,
	ISActive bit default 1,
	CreatedDate datetime default getdate(),
	CategoryId int foreign key references Categories(Id) --category ýd foreign keydir.bu id  categories tablosundaki ýd kolonu ile baðlantýlý olmuþ oluyor bu sayede.

)
go

--Products tablosuna veri giriþi
insert into Products(Name, Price, CategoryId) values
	('Iphone 13', 45000,1), --veri giriþi yukarýdaki sýrayla ayný olmalýdýr.
	('Samsung S23', 37000,1),
	('Xiaomi 13', 21000,1),

	('Vestel Elk. süpürge', 9500,2),

	('Sony', 30000,3),
	('Blaupunkt 13', 22000,3),

	('Macbook Air M1', 40000,4),
	('Lenovo', 45000,4),
	('Casper Excalibur', 60000,4),
	('Macbook Pro M3', 90000,4)

go


