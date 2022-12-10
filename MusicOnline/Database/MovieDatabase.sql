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
	MOVIE_NAME_ENG nvarchar(100),
	MOVIE_STATE nvarchar(20),
	MOVIE_DIRECTOR nvarchar(50),
	MOVIE_TIME nvarchar(20),
	MOVIE_STATUS nvarchar(50),
	MOVIE_LANGUAGE nvarchar(50),
	MOVIE_YEAR char(4),
	MOVIE_NATION nvarchar(100),
	MOVIE_CATEGORY nvarchar(200),
	MOVIE_ACTORS nvarchar(200),
	MOVIE_STARS int,
	MOVIE_CONTENT nvarchar(1000),
	MOVIE_TAGS nvarchar(1000)
	constraint PK_MOVIE primary key (MOVIE_ID)
)
go

drop table MOVIE

insert into MOVIE values('MV01',
						N'Người Hobbit 3: Đại Chiến 5 Cánh Quân',
						N'The Hobbit: The Battle of the Five Armies (2014)',
						N'HD Vietsub',
						N'Peter Jackson',
						N'164 phút',
						N'Phim đang chiếu',
						N'Phụ đề Việt',
						N'2014',
						N'Âu - Mỹ',
						N'Phiêu Lưu - Hành Động, Khoa Học - Viễn Tưởng, Phim Chiếu Rạp',
						N'Martin Freeman, Ian McKellen, Richard Armitage',
						7,
						N'Người Hobbit 3: Đại Chiến 5 Cánh Quân là phần cuối cùng của series phim nói về người Hobbit. Đoàn quân người lùn của Thorin đã đặt được chân tới hang ổ của con rồng Smaug xấu xa. Chàng Hobbit quả cảm Bilbo và những người lùn lúc này đang ở rất gần Erebor và kho báu lẽ ra thuộc về họ. Chỉ có điều, có quá nhiều biến cố và thế lực đang nhăm nhe ập tới ngay sau khi họ đánh bại được rồng Smaug.',
						N'xem phim Người Hobbit 3: Đại Chiến 5 Cánh Quân tập Full, Phim Người Hobbit 3: Đại Chiến 5 Cánh Quân tập Full Vietsub, Người Hobbit 3: Đại Chiến 5 Cánh Quân ep Full full hd, download phim Người Hobbit 3: Đại Chiến 5 Cánh Quân tập Full, xem online Người Hobbit 3: Đại Chiến 5 Cánh Quân tập Full netflix, wetv, vieon, phim keeng, youtube, phimmoi, bilutv, biphim, hdvip, hayghe, motphim, tvhay, zingtv, fptplay, phim1080, luotphim, fimfast, dongphim, dongphym, fullphim, phephim, vtvgiaitri, preview Người Hobbit 3: Đại Chiến 5 Cánh Quân tập Full thuyết minh, Người Hobbit 3: Đại Chiến 5 Cánh Quân tập Full lồng tiếng')
go
select * from MOVIE
go