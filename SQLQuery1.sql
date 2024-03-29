﻿create database ProjectCShaft
go
use ProjectCShaft
go
create table Table_Bida(
	idTable int identity primary key,
	nameTable nvarchar(50) not null,
	typeTable nvarchar(100) not null,
	priceTable float not null,
	statusTable bit,
	description nvarchar(255)
)
create table Account(
	id int identity primary key,
	username varchar(50) not null,
	password varchar(255) not null,
	status bit
)

create table Menu(
	idMenu int identity primary key,
	nameMenu nvarchar(100) not null,
	unitMenu nvarchar(20),
	priceMenu float,
	descriptionMenu nvarchar(255),
	status bit
)

create table Order_Table(
	idOrder int identity primary key,
	idTable int foreign key(idTable) REFERENCES Table_Bida(idTable),
	timeStart datetime,
	timeEnd datetime,
	sumPriceTable float,
	status bit
)

create table OrderMenu(
	idOrderMenu int identity primary key,
	idTable int foreign key(idTable) REFERENCES Table_Bida(idTable) NOT NULL,
	idMenuOrder int foreign key(idMenuOrder) REFERENCES Menu(idMenu) NOT NULL,
	idOrder int foreign key(idOrder) REFERENCES Order_Table(idOrder) NOT NULL,
	nameMenuOrder nvarchar(100),
	unitMenuOrder nvarchar(20),
	priceMenuOrder float,
	quantity int,
	sumPrice float
)

insert into Menu values(N'String Vàng','chai',10000,N'Nước ngọt',1)

insert into Account values('nvmduc','123',1)

insert into Table_Bida values(N'Bàn số 16','France',60000,0,N'Hết nơ')

insert into OrderMenu values(N'Sting đỏ',N'Chai',15000,1,15000)

select * from OrderMenu