Create Database DBProducts
go

Use DBProducts

Create Table Products(
IdProduct int primary key identity,
NameProduct varchar(50),
CodeProduct varchar(50),
DescriptionProduct varchar(50),
Price int
)

