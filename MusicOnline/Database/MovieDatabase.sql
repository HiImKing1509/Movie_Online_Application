----------------------------------------------------------------------------------------------
--------------------------- Database: Movie Online ----------------------------------
----------------------------------------------------------------------------------------------
create database MovieOnline
go
--
use MovieOnline
go

create table MOVIE (
	MOVIE_ID char(4),
	MOVIE_NAME nvarchar(100),
)
go

insert into MOVIE values('MV01', N'Ngọc cơ thư')
insert into MOVIE values('MV02', N'Hoàn Hồn (Phần 2)')
insert into MOVIE values('MV01', N'Ngọc cơ thư')
insert into MOVIE values('MV02', N'Hoàn Hồn (Phần 2)')
insert into MOVIE values('MV01', N'Ngọc cơ thư')
insert into MOVIE values('MV02', N'Hoàn Hồn (Phần 2)')
insert into MOVIE values('MV01', N'Ngọc cơ thư')
insert into MOVIE values('MV02', N'Hoàn Hồn (Phần 2)')
go
select * from MOVIE
go