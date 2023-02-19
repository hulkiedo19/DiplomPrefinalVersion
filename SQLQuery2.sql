CREATE TABLE ProductType (
	Id int primary key identity,
	[Name] nvarchar(MAX) not null,
	[Description] nvarchar(MAX) not null,
	Width int not null,
	[Length] int not null,
	Thickness int not null,
	[Weight] int not null
);

CREATE TABLE Stockroom (
	Id int primary key identity,
	OpeningTime TIME not null,
	ClosingTime TIME not null,
	Capacity int not null,
	FreeSpace int not null
);

CREATE TABLE Kit (
	Id int primary key identity,
	ProductTypeId int foreign key references ProductType(Id),
	QuantitySet int not null,
	StockroomId int foreign key references Stockroom(Id),
	StockroomDeliveryDate DATE not null
);

CREATE TABLE [Order] (
	Id int primary key identity,
	DepartureDate DATE not null,
	StartPreparationDate DATE not null,
	KitId int foreign key references Kit(Id),
	QuantityKit int not null
);