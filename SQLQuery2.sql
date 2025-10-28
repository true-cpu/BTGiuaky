create database ql_tin
go
use ql_tin
go

create table Theloaitin
(
	IDLoai int primary key,
	Tentheloai nvarchar(100)
)

create table Tintuc
(	
	IDTin int primary key ,
	IDLoai int,
	Tieudetin nvarchar(100),
	Noidungtin ntext,
	constraint fk_ID_Loai foreign key (IDLoai) references Theloaitin(IDLoai)
	)


