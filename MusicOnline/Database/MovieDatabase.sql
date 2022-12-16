----------------------------------------------------------------------------------------------
--------------------------- Database: Movie Online ----------------------------------
----------------------------------------------------------------------------------------------
create database MovieOnline
go
--
use MovieOnline
go

-- Convert languague
CREATE FUNCTION [dbo].[LanguageComprehension](@inputVar NVARCHAR(MAX))
RETURNS NVARCHAR(MAX)
AS
BEGIN    
    IF (@inputVar IS NULL OR @inputVar = '', 0)  RETURN ''
   
    DECLARE @RT NVARCHAR(MAX)
    DECLARE @SIGN_CHARS NCHAR(256)
    DECLARE @UNSIGN_CHARS NCHAR (256)
 
    SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệếìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵýĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' + NCHAR(272) + NCHAR(208)
    SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeeeiiiiiooooooooooooooouuuuuuuuuuyyyyyAADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIIIOOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD'
 
    DECLARE @COUNTER int
    DECLARE @COUNTER1 int
   
    SET @COUNTER = 1
    WHILE (@COUNTER <= LEN(@inputVar))
    BEGIN  
        SET @COUNTER1 = 1
        WHILE (@COUNTER1 <= LEN(@SIGN_CHARS) + 1)
        BEGIN
            IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@inputVar,@COUNTER ,1))
            BEGIN          
                IF @COUNTER = 1
                    SET @inputVar = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@inputVar, @COUNTER+1,LEN(@inputVar)-1)      
                ELSE
                    SET @inputVar = SUBSTRING(@inputVar, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@inputVar, @COUNTER+1,LEN(@inputVar)- @COUNTER)
                BREAK
            END
            SET @COUNTER1 = @COUNTER1 +1
        END
        SET @COUNTER = @COUNTER +1
    END
    -- SET @inputVar = replace(@inputVar,' ','-', 0)
    RETURN @inputVar
END
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
	MOVIE_CONTENT nvarchar(3000),
	MOVIE_TAGS nvarchar(1000),
	MOVIE_LOVE_STATUS int,
	MOVIE_NUMBER_ACCESS int
	constraint PK_MOVIE primary key (MOVIE_ID)
)
go

create table HISTORY_MOVIE_LIST (
	HISTORY_MOVIE_ID char(4),
	HISTORY_MOVIE_TIME nvarchar(50),
	HISTORY_MOVIE_DURATION int
	constraint PK_HISTORY_MOVIE_LIST primary key (HISTORY_MOVIE_ID, HISTORY_MOVIE_TIME)
)

create table PLAYLIST (
	PLAYLIST_ID char(4),
	PLAYLIST_NAME nvarchar(100),
	PLAYLIST_TIME nvarchar(50),
	PLAYLIST_LOGO char(4)
	constraint PK_PLAYLIST primary key (PLAYLIST_ID)
)
go

create table PLAYLIST_DETAIL (
	PLAYLIST_ID char(4),
	MOVIE_ID char(4),
	MOVIE_TIME nvarchar(50),
	constraint PK_PLAYLIST_DETAIL primary key (PLAYLIST_ID, MOVIE_ID)
)
go

drop table MOVIE
drop table HISTORY_MOVIE_LIST
drop table PLAYLIST
drop table PLAYLIST_DETAIL
insert into MOVIE values('MV01',
						N'Người Hobbit: Hành Trình Vô Định',
						N'The Hobbit: An Unexpected Journey (2012)',
						N'HD Thuyết Minh',
						N'Peter Jackson',
						N'182 phút',
						N'Phim đang chiếu',
						N'Phụ đề Việt',
						N'2012',
						N'Âu - Mỹ',
						N'Cổ Trang - Thần Thoại, Phiêu Lưu - Hành Động',
						N'Martin Freeman, Ian McKellen, Richard Armitage',
						5,
						N'Người Hobbit: Hành Trình Vô Định xoay quanh cuộc phiêu lưu của chàng trai người Hobbit - Bilbo Baggins. Cậu cùng đội ngũ 13 người lùn Dwarf giành lại Erebor - vương quốc người lùn từ lâu đã bị rồng Smaug chiếm lĩnh. Trong hành trình đó, định mệnh đã cho Bilbo Baggins tiếp xúc với chiếc nhẫn The One, nguồn cơn của mọi cuộc chiến sau này trong " The Lord of the Rings".',
						N'xem phim Người Hobbit: Hành Trình Vô Định tập Full, Phim Người Hobbit: Hành Trình Vô Định tập Full Vietsub, Người Hobbit: Hành Trình Vô Định ep Full full hd, download phim Người Hobbit: Hành Trình Vô Định tập Full, xem online Người Hobbit: Hành Trình Vô Định tập Full netflix, wetv, vieon, phim keeng, youtube, phimmoi, bilutv, biphim, hdvip, hayghe, motphim, tvhay, zingtv, fptplay, phim1080, luotphim, fimfast, dongphim, dongphym, fullphim, phephim, vtvgiaitri, preview Người Hobbit: Hành Trình Vô Định tập Full thuyết minh, Người Hobbit: Hành Trình Vô Định tập Full lồng tiếng',
						0, 0)
go
insert into MOVIE values('MV02',
						N'Người Hobbit 2: Đại Chiến Với Rồng Lửa',
						N'The Hobbit: The Desolation of Smaug (2013)',
						N'HD Vietsub',
						N'Peter Jackson',
						N'186 phút',
						N'Phim đang chiếu',
						N'Phụ đề Việt',
						N'2013',
						N'Âu - Mỹ',
						N'Cổ Trang - Thần Thoại, Phiêu Lưu - Hành Động',
						N'Martin Freeman, Ian McKellen, Richard Armitage',
						9,
						N'Người Hobbit 2: Đại Chiến Với Rồng Lửa tiếp nối các sự kiện trong An Unexpected Journey, chàng hobbit Bilbo Baggins cùng với phù thủy Gandalf và nhóm 13 người lùn dẫn đầu bởi Thorin Oakenshield tiếp tục con đường đến Vương quốc Erebor, đi qua Mirkwood, Esgaroth và Dale để chiến đấu với rồng Smaug để đòi lại vương quốc đã mất cho tộc người lùn.',
						N'xem phim Người Hobbit 2: Đại Chiến Với Rồng Lửa tập Full, Phim Người Hobbit 2: Đại Chiến Với Rồng Lửa tập Full Vietsub, Người Hobbit 2: Đại Chiến Với Rồng Lửa ep Full full hd, download phim Người Hobbit 2: Đại Chiến Với Rồng Lửa tập Full, xem online Người Hobbit 2: Đại Chiến Với Rồng Lửa tập Full netflix, wetv, vieon, phim keeng, youtube, phimmoi, bilutv, biphim, hdvip, hayghe, motphim, tvhay, zingtv, fptplay, phim1080, luotphim, fimfast, dongphim, dongphym, fullphim, phephim, vtvgiaitri, preview Người Hobbit 2: Đại Chiến Với Rồng Lửa tập Full thuyết minh, Người Hobbit 2: Đại Chiến Với Rồng Lửa tập Full lồng tiếng',
						0, 0)
go
insert into MOVIE values('MV03',
						N'Thuỷ Chiến Đảo Hansan: Rồng Trỗi Dậy',
						N'Hansan: Rising Dragon (2022)',
						N'HD Vietsub',
						N'Kim Han Min',
						N'130 phút',
						N'Phim đang chiếu',
						N'Phụ đề Việt',
						N'2022',
						N'Hàn Quốc',
						N'Cổ Trang - Thần Thoại, Hình Sự - Chiến Tranh, Phim Chiếu Rạp',
						N'Park Hae Il, Byun Yo Han, Ahn Sung Ki, Son Hyun Joo, Kim Sung Gyu, Kim Sung Kyun',
						8,
						N'Thuỷ Chiến Đảo Hansan: Rồng Trỗi Dậy là tác phẩm thứ hai thuộc bộ ba phim về vị Đô Đốc huyền thoại Yi Sun Shin, Hansan sẽ tái hiện lại trận thuỷ chiến nổi tiếng tại Nhàn Sơn Đảo, nơi ông đánh tan tác lực lượng hải quân Nhật tinh nhuệ bằng đội hình cánh sếu và các quy bối thuyền.',
						N'xem phim Thuỷ Chiến Đảo Hansan: Rồng Trỗi Dậy tập Full, Phim Thuỷ Chiến Đảo Hansan: Rồng Trỗi Dậy tập Full Vietsub, Thuỷ Chiến Đảo Hansan: Rồng Trỗi Dậy ep Full full hd, download phim Thuỷ Chiến Đảo Hansan: Rồng Trỗi Dậy tập Full, xem online Thuỷ Chiến Đảo Hansan: Rồng Trỗi Dậy tập Full netflix, wetv, vieon, phim keeng, youtube, phimmoi, bilutv, biphim, hdvip, hayghe, motphim, tvhay, zingtv, fptplay, phim1080, luotphim, fimfast, dongphim, dongphym, fullphim, phephim, vtvgiaitri, preview Thuỷ Chiến Đảo Hansan: Rồng Trỗi Dậy tập Full thuyết minh, Thuỷ Chiến Đảo Hansan: Rồng Trỗi Dậy tập Full lồng tiếng', 0, 0)
go
insert into MOVIE values('MV04',
						N'Công Chúa',
						N'The Princess (2022)',
						N'HD Vietsub',
						N'Lê Văn Kiệt',
						N'94 phút',
						N'Phim đang chiếu',
						N'Phụ đề Việt',
						N'2022',
						N'Âu - Mỹ',
						N'Cổ Trang - Thần Thoại, Võ Thuật - Kiếm Hiệp, Phiêu Lưu - Hành Động',
						N'Joey King, Olga Kurylenko, Antoni Davidov, Radoslav Parvanov, Ludmil Kehayov, Ngô Thanh Vân',
						8,
						N'Công Chúa là dự án phim hành động trong năm 2022 của Disney dành cho các nền tảng trực tuyến khác của họ là Star và Hulu. Bộ phim được hãng miêu tả như là một sự kết hợp hoàn hảo của John Wick và Người Đẹp Ngủ Trong Rừng. Do từ chối kết hôn với kẻ sát nhân độc ác nên công chúa bị bắt cóc rồi nhốt tại một tòa tháp hẻo lánh trong lâu đài. Với lòng thù hận và quyết tâm bảo vệ gia đình cùng vương quốc, cô nàng tóc đỏ đã vùng lên đấu tranh để đoạt lại ngai vàng của cha. Trên hành trình ấy, công chúa nhận được sự giúp đỡ từ nhân vật do Ngô Thanh Vân đảm nhận. Phim hé lộ một câu chuyện cổ tích hành động ly kỳ, về một nàng công chúa trẻ, người cảm thấy bản thân mình phù hợp với một thanh kiếm hơn là vương miện. Giống như những nàng công chúa mạnh mẽ và dũng cảm khác của Disney, nữ chính The Princess cũng sẽ dùng khả năng của mình để cứu vương quốc khỏi những tên lính đánh thuê tàn nhẫn. Phim tràn ngập các cảnh quay hành động võ thuật đẹp mắt, với các khung hình và góc quay hiện đại. Hình ảnh nàng công chúa tóc đỏ và cả xù nữa của Joey King đem đến cảm giác hoàn hảo cho nhân vật trong phim, khi toát lên dáng vẻ và khí chất của một người hoàng tộc trẻ tuổi, nhưng vẫn thể hiện được sự mạnh mẽ và táo bạo trong bối cảnh hỗn loạn thời trung cổ.',
						N'xem phim Công Chúa tập Full, Phim Công Chúa tập Full Vietsub, Công Chúa ep Full full hd, download phim Công Chúa tập Full, xem online Công Chúa tập Full netflix, wetv, vieon, phim keeng, youtube, phimmoi, bilutv, biphim, hdvip, hayghe, motphim, tvhay, zingtv, fptplay, phim1080, luotphim, fimfast, dongphim, dongphym, fullphim, phephim, vtvgiaitri, preview Công Chúa tập Full thuyết minh, Công Chúa tập Full lồng tiếng', 0, 0)
go
insert into MOVIE values('MV05',
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
						N'xem phim Người Hobbit 3: Đại Chiến 5 Cánh Quân tập Full, Phim Người Hobbit 3: Đại Chiến 5 Cánh Quân tập Full Vietsub, Người Hobbit 3: Đại Chiến 5 Cánh Quân ep Full full hd, download phim Người Hobbit 3: Đại Chiến 5 Cánh Quân tập Full, xem online Người Hobbit 3: Đại Chiến 5 Cánh Quân tập Full netflix, wetv, vieon, phim keeng, youtube, phimmoi, bilutv, biphim, hdvip, hayghe, motphim, tvhay, zingtv, fptplay, phim1080, luotphim, fimfast, dongphim, dongphym, fullphim, phephim, vtvgiaitri, preview Người Hobbit 3: Đại Chiến 5 Cánh Quân tập Full thuyết minh, Người Hobbit 3: Đại Chiến 5 Cánh Quân tập Full lồng tiếng', 0, 0)
go
insert into MOVIE values('MV06',
						N'Vệ Binh Dải Ngân Hà: Kỳ Nghỉ Đặc Biệt',
						N'The Guardians of the Galaxy Holiday Special (2022)',
						N'HD Vietsub',
						N'James Gunn',
						N'45 phút',
						N'Phim đang chiếu',
						N'Phụ đề Việt',
						N'2022',
						N'Âu - Mỹ',
						N'Phiêu Lưu - Hành Động, Khoa Học - Viễn Tưởng, Hài Hước',
						N'Chris Pratt, Dave Bautista, Karen Gillan, Pom Klementieff, Vin Diesel, Bradley Cooper',
						7,
						N'Vệ Binh Dải Ngân Hà: Kỳ Nghỉ Đặc Biệt kể về theo chân nhóm Guardians of the Galaxy khi các Vệ binh đến Trái đất để tặng Peter Quill một món quà Giáng sinh tuyệt vời nhất, bằng cách bắt cóc huyền thoại Kevin Bacon.',
						N'xem phim Vệ Binh Dải Ngân Hà: Kỳ Nghỉ Đặc Biệt tập Full, Phim Vệ Binh Dải Ngân Hà: Kỳ Nghỉ Đặc Biệt tập Full Vietsub, Vệ Binh Dải Ngân Hà: Kỳ Nghỉ Đặc Biệt ep Full full hd, download phim Vệ Binh Dải Ngân Hà: Kỳ Nghỉ Đặc Biệt tập Full, xem online Vệ Binh Dải Ngân Hà: Kỳ Nghỉ Đặc Biệt tập Full netflix, wetv, vieon, phim keeng, youtube, phimmoi, bilutv, biphim, hdvip, hayghe, motphim, tvhay, zingtv, fptplay, phim1080, luotphim, fimfast, dongphim, dongphym, fullphim, phephim, vtvgiaitri, preview Vệ Binh Dải Ngân Hà: Kỳ Nghỉ Đặc Biệt tập Full thuyết minh, Vệ Binh Dải Ngân Hà: Kỳ Nghỉ Đặc Biệt tập Full lồng tiếng', 0, 0)
go
insert into MOVIE values('MV07',
						N'Xứ Sở Mộng Mơ',
						N'Slumberland (2022)',
						N'HD Vietsub',
						N'Francis Lawrence',
						N'120 phút',
						N'Phim đang chiếu',
						N'Phụ đề Việt',
						N'2022',
						N'Âu - Mỹ',
						N'Phiêu Lưu - Hành Động, Khoa Học - Viễn Tưởng, Gia Đình - Học Đường',
						N'Jason Momoa, Marlow Barkley, Chris O.Dowd, Kyle Chandler, Weruche Opia',
						10,
						N'Xứ Sở Mộng Mơ kể về đồng hành cùng kẻ bất kham đầy thu hút, một cô bé mồ côi táo bạo du hành qua vùng đất của những giấc mơ để tìm viên ngọc trai quý sẽ ban cho cô bé điều ước lớn nhất.',
						N'xem phim Xứ Sở Mộng Mơ tập Full, Phim Xứ Sở Mộng Mơ tập Full Vietsub, Xứ Sở Mộng Mơ ep Full full hd, download phim Xứ Sở Mộng Mơ tập Full, xem online Xứ Sở Mộng Mơ tập Full netflix, wetv, vieon, phim keeng, youtube, phimmoi, bilutv, biphim, hdvip, hayghe, motphim, tvhay, zingtv, fptplay, phim1080, luotphim, fimfast, dongphim, dongphym, fullphim, phephim, vtvgiaitri, preview Xứ Sở Mộng Mơ tập Full thuyết minh, Xứ Sở Mộng Mơ tập Full lồng tiếng', 0, 0)
go
insert into MOVIE values('MV08',
						N'Black Adam',
						N'Black Adam (2022)',
						N'HD Vietsub',
						N'Jaume Collet-Serra',
						N'125 phút',
						N'Phim đang chiếu',
						N'Phụ đề Việt',
						N'2022',
						N'Âu - Mỹ',
						N'Phiêu Lưu - Hành Động, Khoa Học - Viễn Tưởng, Phim Chiếu Rạp',
						N'Dwayne Johnson, Sarah Shahi, Pierce Brosnan, Noah Centineo, Aldis Hodge, Joseph Gatt, Natalie Burn, Quintessa Swindell',
						7,
						N'Black Adam là câu chuyện gần 5.000 năm sau khi anh ta được ban cho sức mạnh toàn năng của các vị thần Ai Cập - và bị cầm tù nhanh chóng - Black Adam được giải thoát khỏi ngôi mộ trần gian của mình, sẵn sàng giải phóng hình thức công lý độc nhất của anh ta trên thế giới hiện đại.',
						N'xem phim Black Adam tập Full, Phim Black Adam tập Full Vietsub, Black Adam ep Full full hd, download phim Black Adam tập Full, xem online Black Adam tập Full netflix, wetv, vieon, phim keeng, youtube, phimmoi, bilutv, biphim, hdvip, hayghe, motphim, tvhay, zingtv, fptplay, phim1080, luotphim, fimfast, dongphim, dongphym, fullphim, phephim, vtvgiaitri, preview Black Adam tập Full thuyết minh, Black Adam tập Full lồng tiếng', 0, 0)
go
insert into MOVIE values('MV09',
						N'Lyle Chú Cá Sấu Biết Hát',
						N'Lyle, Lyle, Crocodile (2022)',
						N'HD Vietsub',
						N'Will Speck, Josh Gordon',
						N'107 phút',
						N'Phim đang chiếu',
						N'Phụ đề Việt',
						N'2022',
						N'Âu - Mỹ',
						N'Hoạt Hình, Thể Thao - Âm Nhạc, Gia Đình - Học Đường, Phim Chiếu Rạp',
						N'Shawn Mendes, Javier Bardem, Winslow Fegley, Constance Wu, Lyric Hurd, Brett Gelman, Scoot McNairy',
						10,
						N'Lyle Chú Cá Sấu Biết Hát là câu chuyện khi gia đình Primm chuyển đến thành phố New York, cậu con trai nhỏ Josh gặp khó khăn trong việc thích nghi với ngôi trường và những người bạn mới. Mọi thứ thay đổi khi cậu bé phát hiện ra ra Lyle - một chàng cá sấu mê tắm rửa, trứng cá muối và âm nhạc sống trên gác mái của của mình. Hai người nhanh chóng trở thành bạn bè. Thế nhưng, khi cuộc sống của Lyle bị ông hàng xóm Grumps đe dọa, gia đình Primm buộc phải kết hợp với ông chủ cũ của Lyle là Hector P. Valenti (Javier Bardem) để cho cả thế giới thấy giá trị tình thân và sự kỳ diệu của một chàng cá sấu biết hát.',
						N'xem phim Lyle, Chú Cá Sấu Biết Hát tập Full, Phim Lyle, Chú Cá Sấu Biết Hát tập Full Vietsub, Lyle, Chú Cá Sấu Biết Hát ep Full full hd, download phim Lyle, Chú Cá Sấu Biết Hát tập Full, xem online Lyle, Chú Cá Sấu Biết Hát tập Full netflix, wetv, vieon, phim keeng, youtube, phimmoi, bilutv, biphim, hdvip, hayghe, motphim, tvhay, zingtv, fptplay, phim1080, luotphim, fimfast, dongphim, dongphym, fullphim, phephim, vtvgiaitri, preview Lyle, Chú Cá Sấu Biết Hát tập Full thuyết minh, Lyle, Chú Cá Sấu Biết Hát tập Full lồng tiếng', 0, 0)
go
insert into MOVIE values('MV10',
						N'Học Trò Xuất Sắc',
						N'The Disciple (2020)',
						N'HD Vietsub',
						N'Chaitanya Tamhane',
						N'128 phút',
						N'Phim đang chiếu',
						N'Phụ đề Việt',
						N'2020',
						N'Ấn Độ',
						N'Tâm Lý - Tình Cảm, Thể Thao - Âm Nhạc',
						N'Abhishek Kale, Aditya Modak, Arun Dravid, Deepika Bhida Bhagwat, Kiran Yadnyopavit, Neela Khedkar, Sumitra Bhave ...',
						10,
						N'Học Trò Xuất Sắc nói về sự nghi ngờ bản thân, hy sinh và đấu tranh hội tụ thành một cuộc khủng hoảng đối với một ca sĩ thanh nhạc cổ điển tận tụy vì điều mà anh ấy cố gắng đạt được vẫn khó nắm bắt.',
						N'xem phim Học Trò Xuất Sắc tập Full, Phim Học Trò Xuất Sắc tập Full Vietsub, Học Trò Xuất Sắc ep Full full hd, download phim Học Trò Xuất Sắc tập Full, xem online Học Trò Xuất Sắc tập Full netflix, wetv, vieon, phim keeng, youtube, phimmoi, bilutv, biphim, hdvip, hayghe, motphim, tvhay, zingtv, fptplay, phim1080, luotphim, fimfast, dongphim, dongphym, fullphim, phephim, vtvgiaitri, preview Học Trò Xuất Sắc tập Full thuyết minh, Học Trò Xuất Sắc tập Full lồng tiếng', 0, 0)
go
insert into MOVIE values('MV11',
						N'Hustle: Cuộc Đua NBA',
						N'Hustle (2022)',
						N'HD Vietsub',
						N'Jeremiah Zagar',
						N'117 phút',
						N'Phim đang chiếu',
						N'Phụ đề Việt',
						N'2022',
						N'Âu - Mỹ',
						N'Tâm Lý - Tình Cảm, Hài Hước, Thể Thao - Âm Nhạc',
						N'Adam Sandler, Juancho Hernangómez, Queen Latifah',
						10,
						N'Hustle: Cuộc Đua NBA kể về một siêu sao tiềm năng ở Tây Ban Nha, vị tuyển trạch viên bóng rổ xui xẻo bắt đầu chứng minh cả hai có đủ mọi yếu tố cần thiết để thành công ở NBA.',
						N'xem phim Hustle: Cuộc Đua NBA tập Full, Phim Hustle: Cuộc Đua NBA tập Full Vietsub, Hustle: Cuộc Đua NBA ep Full full hd, download phim Hustle: Cuộc Đua NBA tập Full, xem online Hustle: Cuộc Đua NBA tập Full netflix, wetv, vieon, phim keeng, youtube, phimmoi, bilutv, biphim, hdvip, hayghe, motphim, tvhay, zingtv, fptplay, phim1080, luotphim, fimfast, dongphim, dongphym, fullphim, phephim, vtvgiaitri, preview Hustle: Cuộc Đua NBA tập Full thuyết minh, Hustle: Cuộc Đua NBA tập Full lồng tiếng', 0, 0)
go
insert into MOVIE values('MV12',
						N'Đấu Trường Âm Nhạc 2',
						N'Sing 2 (2021)',
						N'HD Vietsub',
						N'Garth Jennings',
						N'110 phút',
						N'Phim đang chiếu',
						N'Phụ đề Việt',
						N'2021',
						N'Âu - Mỹ',
						N'Hoạt Hình, Hài Hước, Thể Thao - Âm Nhạc, Phim Chiếu Rạp',
						N'Matthew Scarlett Johansson, Taron Egerton, Tori Kelly, Halsey, Pharrell Williams',
						10,
						N'Đấu Trường Âm Nhạc 2 kể về sau khi thành công rực rỡ tại quê nhà, Buster Moon và các bạn quyết định dấn thân vào một cuộc chinh phục âm nhạc mới hoành tráng và cam go hơn bao giờ hết.',
						N'xem phim Đấu Trường Âm Nhạc 2 tập Full, Phim Đấu Trường Âm Nhạc 2 tập Full Vietsub, Đấu Trường Âm Nhạc 2 ep Full full hd, download phim Đấu Trường Âm Nhạc 2 tập Full, xem online Đấu Trường Âm Nhạc 2 tập Full netflix, wetv, vieon, phim keeng, youtube, phimmoi, bilutv, biphim, hdvip, hayghe, motphim, tvhay, zingtv, fptplay, phim1080, luotphim, fimfast, dongphim, dongphym, fullphim, phephim, vtvgiaitri, preview Đấu Trường Âm Nhạc 2 tập Full thuyết minh, Đấu Trường Âm Nhạc 2 tập Full lồng tiếng', 0, 0)
go
insert into MOVIE values('MV13',
						N'Bạn Cùng Phòng Rùng Rợn Của Tôi',
						N'My Chilling Roommate (2022)',
						N'HD Vietsub',
						N'Hwang Kyu Seong',
						N'112 phút',
						N'Phim đang chiếu',
						N'Phụ đề Việt',
						N'2022',
						N'Hàn Quốc',
						N'Tâm Lý - Tình Cảm, Hài Hước, Bí Ẩn - Siêu Nhiên',
						N'Kim So Jeong, Jung Chan Woo, Lee Yu Jin, Song Young Sook, Kim Ye Ji, Park Eun Woo',
						7,
						N'Bạn Cùng Phòng Rùng Rợn Của Tôi kể về Jung Se Ri (Kim So Jeong) cô gái có khả năng đặc biệt, đó là nhìn thấy và nói chuyện được với ma. Chính vì vậy mà rất nhiều đêm cô không ngủ ngon giấc bởi các hồn ma cứ lảng vảng quanh cô. Se Ri là một cô gái hiền lành, lương thiện, cô luôn giúp đỡ những hồn ma khi họ ở trong những hoàn cảnh hoang mang khi không biết chính mình đã rời xa trần thế. Rồi một ngày, cô gặp một chàng trai, không biết là nhân duyên gì đây? Song Ji Chan (Jung Chan Woo), bỗng một ngày anh nhận ra, mình đã trở thành hồn ma mà không rõ nguyên nhân cũng như không còn một chút kí ức nào về bản thân mình. Chàng ma này bề ngoài thì rất đẹp trai nhưng lại là một anh chàng thô lỗ, ăn nói khó nghe. Rồi anh gặp cô gái có cái tên Jung Se Ri, là người có thể thấy được anh nên anh phải theo về đến tận nhà và đòi ở chung, bởi ngoài cô ra, anh không còn biết ai khác, và cũng không có nơi nào để đi. Câu chuyện bắt đầu từ đây. Mọi người cùng theo dõi bộ phim để biết được diễn biến câu chuyện này nhé!',
						N'xem phim Bạn Cùng Phòng Rùng Rợn Của Tôi tập Full, Phim Bạn Cùng Phòng Rùng Rợn Của Tôi tập Full Vietsub, Bạn Cùng Phòng Rùng Rợn Của Tôi ep Full full hd, download phim Bạn Cùng Phòng Rùng Rợn Của Tôi tập Full, xem online Bạn Cùng Phòng Rùng Rợn Của Tôi tập Full netflix, wetv, vieon, phim keeng, youtube, phimmoi, bilutv, biphim, hdvip, hayghe, motphim, tvhay, zingtv, fptplay, phim1080, luotphim, fimfast, dongphim, dongphym, fullphim, phephim, vtvgiaitri, preview Bạn Cùng Phòng Rùng Rợn Của Tôi tập Full thuyết minh, Bạn Cùng Phòng Rùng Rợn Của Tôi tập Full lồng tiếng', 0, 0)
go
insert into MOVIE values('MV14',
						N'Người Bảo Vệ Thời Gian',
						N'Guardians of Time (2022)',
						N'HD Vietsub',
						N'Stephen Shimek',
						N'100 phút',
						N'Phim đang chiếu',
						N'Phụ đề Việt',
						N'2022',
						N'Âu - Mỹ',
						N'Phiêu Lưu - Hành Động, Bí Ẩn - Siêu Nhiên',
						N'Samantha Ryan, Ava Torres, Carley Coleman, Nia Salaam, Skip Schwink, KatieBurgess, Natalie Daniels, Harper Heath, Drew Pollock, Katherine Bellantone, David Fletcher-Hall, Jonathan Dale Moore',
						7,
						N'Người Bảo Vệ Thời Gian kể về một ngày nọ, trong trang viên của gia đình, bốn anh em họ phát hiện ra một lối đi dẫn đến một thế giới bí ẩn. Bị mắc kẹt trong vùng đất được khai quật này, Vương quốc Keoherus, họ phải đối đầu với Người bảo vệ Thời gian, đối mặt với những thế lực đen tối và quái thú để hy vọng trở về nhà.',
						N'xem phim Người Bảo Vệ Thời Gian tập Full, Phim Người Bảo Vệ Thời Gian tập Full Vietsub, Người Bảo Vệ Thời Gian ep Full full hd, download phim Người Bảo Vệ Thời Gian tập Full, xem online Người Bảo Vệ Thời Gian tập Full netflix, wetv, vieon, phim keeng, youtube, phimmoi, bilutv, biphim, hdvip, hayghe, motphim, tvhay, zingtv, fptplay, phim1080, luotphim, fimfast, dongphim, dongphym, fullphim, phephim, vtvgiaitri, preview Người Bảo Vệ Thời Gian tập Full thuyết minh, Người Bảo Vệ Thời Gian tập Full lồng tiếng', 0, 0)
go
insert into MOVIE values('MV15',
						N'Hạ Cánh Khẩn Cấp',
						N'Emergency Declaration (2022)',
						N'HD Vietsub',
						N'Han Jae Rim',
						N'150 phút',
						N'Phim đang chiếu',
						N'Phụ đề Việt',
						N'2022',
						N'Hàn Quốc',
						N'Phiêu Lưu - Hành Động, Khoa Học - Viễn Tưởng, Phim Chiếu Rạp, Bí Ẩn - Siêu Nhiên',
						N'Song Kang Ho, Lee Byung Hun, Jeon Do Yeon, Kim Nam Gil, Im Si Wan, Kim So Jin',
						8,
						N'Hạ Cánh Khẩn Cấp kể về bộ phim xoay quanh chuyến bay mang số hiệu KI501 của hãng hàng không Sky Korea, khởi hành từ sân bay quốc tế Incheon tới Honolulu, Hawaii. Không lâu sau khi máy bay cất cánh, một hành khách bắt đầu có những biểu hiện lạ và tử vong trước sự bàng hoàng của mọi người. Một virus lạ với tốc độ lây lan chóng mặt đã xâm nhập lên máy bay, tất cả chìm trong hỗn loạn và sợ hãi. Trong tình huống ngàn cân treo sợi tóc, một tuyên bố đề nghị hạ cánh khẩn cấp được đưa ra. Trên độ cao 8,534 mét, số phận của hơn 150 con người bao gồm cả các hành khách và phi hành đoàn sẽ ra sao?',
						N'xem phim Hạ Cánh Khẩn Cấp tập Full, Phim Hạ Cánh Khẩn Cấp tập Full Vietsub, Hạ Cánh Khẩn Cấp ep Full full hd, download phim Hạ Cánh Khẩn Cấp tập Full, xem online Hạ Cánh Khẩn Cấp tập Full netflix, wetv, vieon, phim keeng, youtube, phimmoi, bilutv, biphim, hdvip, hayghe, motphim, tvhay, zingtv, fptplay, phim1080, luotphim, fimfast, dongphim, dongphym, fullphim, phephim, vtvgiaitri, preview Hạ Cánh Khẩn Cấp tập Full thuyết minh, Hạ Cánh Khẩn Cấp tập Full lồng tiếng', 0, 0)
go
insert into MOVIE values('MV16',
						N'Thor: Tình Yêu Và Sấm Sét',
						N'Thor: Love and Thunder (2022)',
						N'HD Vietsub',
						N'Taika Waititi',
						N'118 phút',
						N'Phim đang chiếu',
						N'Phụ đề Việt',
						N'2022',
						N'Âu - Mỹ',
						N'Phiêu Lưu - Hành Động, Phim Chiếu Rạp, Bí Ẩn - Siêu Nhiên',
						N'Chris Hemsworth, Tessa Thompson, Natalie Portman, Chris Pratt',
						7,
						N'Thor: Tình Yêu Và Sấm Sét kể về một chiến binh hùng mạnh của Asgard, trải qua vô số trận chiến lớn nhỏ nhưng sau sự kiện trong Avengers: Endgame (2019) cùng vô số mất mát, Thần Sấm không còn muốn theo đuổi con đường siêu anh hùng. Từ đây, anh lên đường tìm ra ý nghĩa của cuộc sống và nhìn nhận lại bản thân mình.',
						N'xem phim Thor: Tình Yêu Và Sấm Sét tập Full, Phim Thor: Tình Yêu Và Sấm Sét tập Full Vietsub, Thor: Tình Yêu Và Sấm Sét ep Full full hd, download phim Thor: Tình Yêu Và Sấm Sét tập Full, xem online Thor: Tình Yêu Và Sấm Sét tập Full netflix, wetv, vieon, phim keeng, youtube, phimmoi, bilutv, biphim, hdvip, hayghe, motphim, tvhay, zingtv, fptplay, phim1080, luotphim, fimfast, dongphim, dongphym, fullphim, phephim, vtvgiaitri, preview Thor: Tình Yêu Và Sấm Sét tập Full thuyết minh, Thor: Tình Yêu Và Sấm Sét tập Full lồng tiếng', 0, 0)
go
insert into MOVIE values('MV17',
						N'Máu Nóng',
						N'Hot Blooded (2022)',
						N'HD Vietsub',
						N'Cheon Myeong Kwan',
						N'120 phút',
						N'Phim đang chiếu',
						N'Phụ đề Việt',
						N'2022',
						N'Hàn Quốc',
						N'Võ Thuật - Kiếm Hiệp, Phiêu Lưu - Hành Động, Tâm Lý - Tình Cảm, Hình Sự - Chiến Tranh',
						N'Jung Woo, Kim Gab Soo, Choi Moo Sung, Yoon Ji Hye, Jung Young Joo, Hyun Bong Shik',
						8,
						N'Máu Nóng kể về một tay xã hội đen kỳ cựu, Hee-su, đang tìm cách giã từ gia đình tội phạm của mình ở thành phố cảng Kuam đầy bạo lực, Hàn Quốc. Nhưng một sự phản bội bất ngờ dẫn anh ta xuống một con đường đẫm máu, nơi anh ta bị kẹt giữa một cuộc chiến tranh với những hậu quả chết người.',
						N'xem phim Máu Nóng tập Full, Phim Máu Nóng tập Full Vietsub, Máu Nóng ep Full full hd, download phim Máu Nóng tập Full, xem online Máu Nóng tập Full netflix, wetv, vieon, phim keeng, youtube, phimmoi, bilutv, biphim, hdvip, hayghe, motphim, tvhay, zingtv, fptplay, phim1080, luotphim, fimfast, dongphim, dongphym, fullphim, phephim, vtvgiaitri, preview Máu Nóng tập Full thuyết minh, Máu Nóng tập Full lồng tiếng', 0, 0)
go
insert into MOVIE values('MV18',
						N'Hoắc Gia Quyền: Mỹ Nữ Tay Sắt 3',
						N'The Queen of Kung Fu 3 (2022)',
						N'HD Vietsub',
						N'Lemi',
						N'88 phút',
						N'Phim đang chiếu',
						N'Phụ đề Việt',
						N'2022',
						N'Trung Quốc',
						N'Võ Thuật - Kiếm Hiệp, Phiêu Lưu - Hành Động',
						N'Li Meng Meng, Ma Mu Xuan, Xie Ning',
						7,
						N'Hoắc Gia Quyền: Mỹ Nữ Tay Sắt 3 kể về bà chủ xinh đẹp A Hi của Bến Thượng Hải quyết định rửa tay gác kiếm. Nhưng các môn phái khác nhau trong rừng đang tranh giành danh hiệu võ sĩ giỏi nhất thế giới. Khi A Hi về quê, sư phụ cô đã bị sát hại. Để trả thù cho sư phụ cô trở về Thượng Hải cùng sư phụ và tìm giết bọn xã hội đen, nhưng cô lại bị vu oan là giết thầy diệt tổ. Làm thế nào cô ấy có thể trả thù cho sư phụ và trừng phạt những kẻ ác?',
						N'xem phim Hoắc Gia Quyền: Mỹ Nữ Tay Sắt 3 tập Full, Phim Hoắc Gia Quyền: Mỹ Nữ Tay Sắt 3 tập Full Vietsub, Hoắc Gia Quyền: Mỹ Nữ Tay Sắt 3 ep Full full hd, download phim Hoắc Gia Quyền: Mỹ Nữ Tay Sắt 3 tập Full, xem online Hoắc Gia Quyền: Mỹ Nữ Tay Sắt 3 tập Full netflix, wetv, vieon, phim keeng, youtube, phimmoi, bilutv, biphim, hdvip, hayghe, motphim, tvhay, zingtv, fptplay, phim1080, luotphim, fimfast, dongphim, dongphym, fullphim, phephim, vtvgiaitri, preview Hoắc Gia Quyền: Mỹ Nữ Tay Sắt 3 tập Full thuyết minh, Hoắc Gia Quyền: Mỹ Nữ Tay Sắt 3 tập Full lồng tiếng', 0, 0)
go
insert into MOVIE values('MV19',
						N'Đao Phủ: Quái Đàm',
						N'Executioner is Strange Talk (2022)',
						N'HD Vietsub',
						N'Zhao Cong',
						N'80 phút',
						N'Phim đang chiếu',
						N'Phụ đề Việt',
						N'2022',
						N'Trung Quốc',
						N'Cổ Trang - Thần Thoại, Võ Thuật - Kiếm Hiệp, Kinh Dị - Ma',
						N'Wang Jiu Sheng, Cao Xi Yue, Li Tian Yu, Gao Xuan Ming, Lin Feng Ye',
						8,
						N'Đao Phủ: Quái Đàm kể về đao phủ Tạ Thất người nắm giữ quỷ đầu đao, đã vi phạm điều cấm kị, chặt đầu nữ tù nhân có đôi đồng tử vào giờ cấm, để rồi gặp ma nữ quay lại trả thù. Người dân thị trấn vô cùng tức giận và đổ lỗi cho Tạ Thất về tất cả những điều kỳ lạ đã xảy ra. Tạ Thất muốn sử dụng phương pháp cổ xưa là đem đầu người chết đến thợ săn để khâu lại và sau đó đốt nó để hủy bỏ sự xuất hiện của ma nữ. Thật bất ngờ, đầu người đã bị đánh cắp và người thợ khâu đã bị giết. Ngoài ra, việc di dời mộ của những người giàu có của trấn và vụ án cô gái mất tích cũngliên quan lẫn nhau. Sự nguy hiểm đang từng bước đến gần Tạ Thất',
						N'xem phim Đao Phủ: Quái Đàm tập Full, Phim Đao Phủ: Quái Đàm tập Full Vietsub, Đao Phủ: Quái Đàm ep Full full hd, download phim Đao Phủ: Quái Đàm tập Full, xem online Đao Phủ: Quái Đàm tập Full netflix, wetv, vieon, phim keeng, youtube, phimmoi, bilutv, biphim, hdvip, hayghe, motphim, tvhay, zingtv, fptplay, phim1080, luotphim, fimfast, dongphim, dongphym, fullphim, phephim, vtvgiaitri, preview Đao Phủ: Quái Đàm tập Full thuyết minh, Đao Phủ: Quái Đàm tập Full lồng tiếng', 0, 0)
go
insert into MOVIE values('MV20',
						N'Tề Thiên Đại Thánh',
						N'The Monkey King (2022)',
						N'HD Vietsub',
						N'Jiang Xiao Tong',
						N'80 phút',
						N'Phim đang chiếu',
						N'Phụ đề Việt',
						N'2022',
						N'Trung Quốc',
						N'Võ Thuật - Kiếm Hiệp, Phiêu Lưu - Hành Động',
						N'Từ Đông Đông, Tạ Miêu ...',
						8,
						N'Tề Thiên Đại Thánh kể về Tôn Ngộ Không bị giam giữ ở Ngũ Chỉ Sơn 400 năm, tình cờ được A Nhất cứu thoát. Cha mẹ của A Nhất bị Long thái tử giết hại, nàng ấy muốn Tôn Ngộ Không dẫn nàng đi đến thiên cung để cáo trạng. Long thái tử biết được Tôn Ngộ Không đã thoát khỏi Ngũ Chỉ Sơn, chuẩn bị bẩm báo việc năm đó Đông Hải Long Cung bị phá hủy, lợi dụng huynh đệ tốt của Ngộ Không là Ma Vương để giết hại Ngộ Không. Mặc dù pháp lực của Ngộ Không bị khống chế nhưng Ma vương vẫn ám sát thất bại. Vì vậy đã bắt A Nhất, để cứu A Nhất, Ngộ Không đánh đến Long cung. Ngộ Không và thái tử giao tranh từ biển cho đến tận Nam Thiên Môn. Cuối cùng Ngộ Không được A Nhất cảm hóa, trở về Ngũ Chỉ Sơn tiếp tục tu hành, chờ đợi người có cơ duyên đã định.',
						N'xem phim Tề Thiên Đại Thánh tập Full, Phim Tề Thiên Đại Thánh tập Full Vietsub, Tề Thiên Đại Thánh ep Full full hd, download phim Tề Thiên Đại Thánh tập Full, xem online Tề Thiên Đại Thánh tập Full netflix, wetv, vieon, phim keeng, youtube, phimmoi, bilutv, biphim, hdvip, hayghe, motphim, tvhay, zingtv, fptplay, phim1080, luotphim, fimfast, dongphim, dongphym, fullphim, phephim, vtvgiaitri, preview Tề Thiên Đại Thánh tập Full thuyết minh, Tề Thiên Đại Thánh tập Full lồng tiếng', 0, 0)
go
insert into MOVIE values('MV21',
						N'Cộng Sự Bất Đắc Dĩ',
						N'Confidential Assignment (2017)',
						N'HD Thuyết Minh',
						N'Kim Sung Hoon',
						N'90 phút',
						N'Phim đang chiếu',
						N'Thuyết minh',
						N'2017',
						N'Hàn Quốc',
						N'Phiêu Lưu - Hành Động, Hình Sự - Chiến Tranh, Phim Chiếu Rạp, Thuyết Minh',
						N'Hyun Bin, Yoo Hae Jin, Im Yoon Ah, Kim Joo Hyuk, Jang Young Nam, Lee Hae Young',
						8,
						N'Cộng Sự Bất Đắc Dĩ kể về thanh tra Cheol-ryung của Triều Tiên mất vợ và đồng đội khi Đội trưởng Cha phản bội anh để ăn cắp những bản kẽm in tiền giả. Anh lập tức tham gia vào phái đoàn sang Hàn Quốc khi biết Cha đang trốn ở đây. Thanh tra Kang của Hàn Quốc được điều đến tham gia vào nhiệm vụ mật này, nhưng anh chỉ được biết Cha là một tên sát thủ và không gì hơn. Cơ quan Tình báo Hàn Quốc tin rằng có một động cơ bí mật sau vụ này và yêu cầu Kang can thiệp vào nhiệm vụ cho đến khi họ tìm ra manh mối.',
						N'xem phim Cộng Sự Bất Đắc Dĩ tập Full, Phim Cộng Sự Bất Đắc Dĩ tập Full Vietsub, Cộng Sự Bất Đắc Dĩ ep Full full hd, download phim Cộng Sự Bất Đắc Dĩ tập Full, xem online Cộng Sự Bất Đắc Dĩ tập Full netflix, wetv, vieon, phim keeng, youtube, phimmoi, bilutv, biphim, hdvip, hayghe, motphim, tvhay, zingtv, fptplay, phim1080, luotphim, fimfast, dongphim, dongphym, fullphim, phephim, vtvgiaitri, preview Cộng Sự Bất Đắc Dĩ tập Full thuyết minh, Cộng Sự Bất Đắc Dĩ tập Full lồng tiếng', 0, 0)
go
insert into MOVIE values('MV22',
						N'Rượt Đuổi Seoul',
						N'Seoul Vibe (2022)',
						N'HD Vietsub',
						N'Moon Hyun Sung',
						N'138 phút',
						N'Phim đang chiếu',
						N'Phụ đề Việt',
						N'2022',
						N'Hàn Quốc',
						N'Phiêu Lưu - Hành Động, Hình Sự - Chiến Tranh',
						N'Yoo Ah In, Go Kyung Pyo, Lee Kyu Hyung, Park Ju Hyun, Ong Seong Wu, Kim Sung Kyun',
						8,
						N'Rượt Đuổi Seoul kể về trong những ngày trước Thế vận hội Seoul năm 1988, một nhóm tay đua và thợ sửa xe đủ thành phần bí mật triệt hạ một đường dây rửa tiền khổng lồ.',
						N'xem phim Rượt Đuổi Seoul tập Full, Phim Rượt Đuổi Seoul tập Full Vietsub, Rượt Đuổi Seoul ep Full full hd, download phim Rượt Đuổi Seoul tập Full, xem online Rượt Đuổi Seoul tập Full netflix, wetv, vieon, phim keeng, youtube, phimmoi, bilutv, biphim, hdvip, hayghe, motphim, tvhay, zingtv, fptplay, phim1080, luotphim, fimfast, dongphim, dongphym, fullphim, phephim, vtvgiaitri, preview Rượt Đuổi Seoul tập Full thuyết minh, Rượt Đuổi Seoul tập Full lồng tiếng', 0, 0)
go
insert into MOVIE values('MV23',
						N'Phi Công Siêu Đẳng Maverick',
						N'Top Gun: Maverick (2022)',
						N'HD Vietsub',
						N'Joseph Kosinski',
						N'130 phút',
						N'Phim đang chiếu',
						N'Phụ đề Việt',
						N'2022',
						N'Âu - Mỹ',
						N'Phiêu Lưu - Hành Động, Hình Sự - Chiến Tranh, Phim Chiếu Rạp',
						N'Tom Cruise, Miles Teller, Jennifer Connelly, Jon Hamm, Glen Powell',
						9,
						N'Phi Công Siêu Đẳng Maverick kể về sau hơn ba mươi năm phục vụ, Pete “Maverick” Mitchell từng nổi danh là một phi công thử nghiệm quả cảm hàng đầu của Hải quân, né tránh cơ hội thăng chức, điều khiến anh cảm thấy bị bó buộc, để trở về làm chính mình.',
						N'xem phim Phi Công Siêu Đẳng Maverick tập Full, Phim Phi Công Siêu Đẳng Maverick tập Full Vietsub, Phi Công Siêu Đẳng Maverick ep Full full hd, download phim Phi Công Siêu Đẳng Maverick tập Full, xem online Phi Công Siêu Đẳng Maverick tập Full netflix, wetv, vieon, phim keeng, youtube, phimmoi, bilutv, biphim, hdvip, hayghe, motphim, tvhay, zingtv, fptplay, phim1080, luotphim, fimfast, dongphim, dongphym, fullphim, phephim, vtvgiaitri, preview Phi Công Siêu Đẳng Maverick tập Full thuyết minh, Phi Công Siêu Đẳng Maverick tập Full lồng tiếng', 0, 0)
go
insert into MOVIE values('MV24',
						N'Sai Người Sai Thời Điểm',
						N'Wrong Place (2022)',
						N'HD Vietsub',
						N'Mike Burns',
						N'96 phút',
						N'Phim đang chiếu',
						N'Phụ đề Việt',
						N'2022',
						N'Âu - Mỹ',
						N'Phiêu Lưu - Hành Động, Hình Sự - Chiến Tranh',
						N'Bruce Willis, Ashley Greene, Michael Sirow',
						5,
						N'Sai Người Sai Thời Điểm kể về một tên đầu bếp methamphetamines săn lùng cựu Cảnh sát trưởng của một thị trấn nhỏ để bịt miệng anh ta trước khi anh ta có thể đưa ra lời khai nhân chứng chống lại gia đình anh ta, nhưng cuối cùng lại thấy mình chống lại nhiều hơn những gì anh ta đã mặc cả.',
						N'xem phim Sai Người Sai Thời Điểm tập Full, Phim Sai Người Sai Thời Điểm tập Full Vietsub, Sai Người Sai Thời Điểm ep Full full hd, download phim Sai Người Sai Thời Điểm tập Full, xem online Sai Người Sai Thời Điểm tập Full netflix, wetv, vieon, phim keeng, youtube, phimmoi, bilutv, biphim, hdvip, hayghe, motphim, tvhay, zingtv, fptplay, phim1080, luotphim, fimfast, dongphim, dongphym, fullphim, phephim, vtvgiaitri, preview Sai Người Sai Thời Điểm tập Full thuyết minh, Sai Người Sai Thời Điểm tập Full lồng tiếng', 0, 0)
go


insert into HISTORY_MOVIE_LIST values('MV01', '12-11-2022 12:24:35 PM', 20)
insert into HISTORY_MOVIE_LIST values('MV01', '12-11-2022 12:25:35 PM', 50)
insert into HISTORY_MOVIE_LIST values('MV02', '12-11-2022 12:26:35 PM', 43)
insert into HISTORY_MOVIE_LIST values('MV03', '12-11-2022 12:27:35 PM', 23)
go

insert into PLAYLIST values('PL01', N'Phim khoa học', '12-11-2022 12:24:35 PM', 'LG07')
insert into PLAYLIST values('PL02', N'Phim trinh thám', '12-11-2022 12:24:35 PM', 'LG09')
insert into PLAYLIST values('PL03', N'List phim người lớn', '12-11-2022 12:24:35 PM', 'LG13')

insert into PLAYLIST_DETAIL values('PL01', 'MV01', '12-11-2022 12:24:35 PM')
insert into PLAYLIST_DETAIL values('PL01', 'MV12', '12-11-2022 12:22:35 PM')
insert into PLAYLIST_DETAIL values('PL01', 'MV13', '12-11-2022 12:23:35 PM')
insert into PLAYLIST_DETAIL values('PL02', 'MV02', '12-11-2022 12:21:35 PM')
insert into PLAYLIST_DETAIL values('PL02', 'MV03', '12-11-2022 12:28:35 PM')
insert into PLAYLIST_DETAIL values('PL02', 'MV04', '12-11-2022 12:24:35 PM')
insert into PLAYLIST_DETAIL values('PL02', 'MV06', '12-11-2022 11:24:35 PM')
insert into PLAYLIST_DETAIL values('PL03', 'MV05', '12-11-2022 13:24:35 PM')
insert into PLAYLIST_DETAIL values('PL03', 'MV11', '12-11-2022 16:24:32 PM')
insert into PLAYLIST_DETAIL values('PL03', 'MV19', '12-11-2022 18:24:35 PM')

-- Query
select * from MOVIE
go

select * from MOVIE where MOVIE_ID like 'MV01'

select * from MOVIE where dbo.LanguageComprehension(MOVIE_NAME) like N'%thuy%'

select * from MOVIE where MOVIE_CATEGORY like N'%Cổ Trang - Thần Thoại%'

select * from FAVORITE_MOVIE_LIST inner join MOVIE on FAVORITE_MOVIE_ID = MOVIE_ID 

delete from FAVORITE_MOVIE_LIST where FAVORITE_MOVIE_ID = 'MV01'

update MOVIE set MOVIE_LOVE_STATUS = 1 where MOVIE_ID = 'MV01'


select * from HISTORY_MOVIE_LIST inner join MOVIE on HISTORY_MOVIE_ID = MOVIE_ID and MOVIE_ID = 'MV01' and HISTORY_MOVIE_TIME = '12-11-2022 12:24:35 PM'

select * from HISTORY_MOVIE_LIST order by HISTORY_MOVIE_TIME asc

SELECT HISTORY_MOVIE_ID, COUNT(HISTORY_MOVIE_TIME) AS "So luong"
FROM HISTORY_MOVIE_LIST
GROUP BY HISTORY_MOVIE_ID

select [MOVIE_ID], [MOVIE_NAME], [MOVIE_NUMBER_ACCESS] from MOVIE where MOVIE_NUMBER_ACCESS > 0 order by MOVIE_NUMBER_ACCESS desc

delete from HISTORY_MOVIE_LIST

select [MOVIE_LOVE_STATUS] from MOVIE

select * from PLAYLIST

select [PLAYLIST_ID], PLAYLIST_DETAIL.MOVIE_ID, PLAYLIST_DETAIL.MOVIE_TIME, [MOVIE_NAME] from PLAYLIST_DETAIL inner join MOVIE on PLAYLIST_DETAIL.MOVIE_ID = MOVIE.MOVIE_ID where PLAYLIST_ID = 'PL02'

select [MOVIE_ID], [MOVIE_STARS] from MOVIE where MOVIE_ID = 'MV03'

update MOVIE set MOVIE_STARS = 1 where MOVIE_ID = 'MV03'

select * from PLAYLIST_DETAIL

delete from PLAYLIST_DETAIL where PLAYLIST_ID = 'PL02' and MOVIE_ID = 'MV02'

select [PLAYLIST_ID], PLAYLIST_DETAIL.MOVIE_ID, PLAYLIST_DETAIL.MOVIE_TIME, [MOVIE_NAME] from PLAYLIST_DETAIL inner join MOVIE on PLAYLIST_DETAIL.MOVIE_ID = MOVIE.MOVIE_ID where PLAYLIST_ID = 'PL02'

select * from PLAYLIST where PLAYLIST_NAME = N'Phim khoa học'

select * from HISTORY_MOVIE_LIST

select * from PLAYLIST

delete from PLAYLIST where PLAYLIST_ID = 'PL03'

delete from PLAYLIST_DETAIL
