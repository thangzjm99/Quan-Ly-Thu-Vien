USE QLThuVienHVKTQS
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DONGSACH](
[MASACH] [INT] NULL,
[TENSACH] [NVARCHAR](100) NULL,
[TACGIA] [NVARCHAR](100) NULL,
[SOTRANG] [INT] NULL,
[THELOAI] [NVARCHAR](100) NULL,
[TINHTRANG] [NVARCHAR](100) NULL,
[NHAXUATBAN] [NVARCHAR](100) NULL,
[NAMXUATBAN] [NVARCHAR](100) NULL )

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOCGIA](
[MASINHVIEN] [INT] NULL,
[TENDOCGIA] [NVARCHAR](100) NULL,
[GIOITINH] [NVARCHAR](100) NULL,
[NGAYSINH] [DATE] NULL,
[LOP] [NVARCHAR](100) NULL,
[DIACHI] [NVARCHAR](100) NULL,
[MATHETV] [INT] NULL)
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MUONSACK](
[MAMUONTRA] [INT] NULL,
[MATHETV] [INT] NULL,
[MASINHVIEN] [INT] NULL,
[MASACH] [INT] NULL,
[NGAYMUON] [DATE] NULL)
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRASACH](
[MAMUONTRA] [INT] NULL,
[MASACH] [INT] NULL,
[DA_TRA] [INT] NOT NULL,
[NGAYTRA] [DATE] NULL)
GO



INSERT [dbo].[DONGSACH] ([MASACH], [TENSACH], [TACGIA], [SOTRANG], [THELOAI], [NHAXUATBAN], [NAMXUATBAN]) VALUES (1122 , N'Vật lí đại cương 1', N'Ðỗ Ngọc Uẩn', 300 , N'Vật lí', N'Nhà xuất bản giáo dục VN' , 1997)
INSERT [dbo].[DONGSACH] ([MASACH], [TENSACH], [TACGIA], [SOTRANG], [THELOAI], [NHAXUATBAN], [NAMXUATBAN]) VALUES (2233 , N'Vật lý đại cương 2', N'Ðỗ Ngọc Uẩn', 238 , N'Vật lí', N'Nhà xuất bản giáo dục VN' , 1997)
INSERT [dbo].[DONGSACH] ([MASACH], [TENSACH], [TACGIA], [SOTRANG], [THELOAI], [NHAXUATBAN], [NAMXUATBAN]) VALUES (3344 , N'Giải tích 1', N'Nguyễn Thị Xuân Anh', 555 , N'Toán h?c', N'Nhà xuất bản ÐH Bách Khoa HCM' , 2004)
INSERT [dbo].[DONGSACH] ([MASACH], [TENSACH], [TACGIA], [SOTRANG], [THELOAI], [NHAXUATBAN], [NAMXUATBAN]) VALUES (4455 , N'Giải tích 2', N'Lê Xuân Ðới', 340 , N'Toán học', N'Nhà xuất bản ÐH Bách Khoa HCM' , 2006)
INSERT [dbo].[DONGSACH] ([MASACH], [TENSACH], [TACGIA], [SOTRANG], [THELOAI], [NHAXUATBAN], [NAMXUATBAN]) VALUES (5566 , N'Toán rời rạc', N'Ðinh La Thăng', 389 , N'Toán học', N'Nhà xuất bản giáo dục VN' , 2003)
INSERT [dbo].[DONGSACH] ([MASACH], [TENSACH], [TACGIA], [SOTRANG], [THELOAI], [NHAXUATBAN], [NAMXUATBAN]) VALUES (6677 , N'Lập trình cơ bản', N'Tạ Ðình Thanh', 155 , N'Công nghệ thông tin', N'Nhà xuất bản HVKTQS' , 1990)
INSERT [dbo].[DONGSACH] ([MASACH], [TENSACH], [TACGIA], [SOTRANG], [THELOAI], [NHAXUATBAN], [NAMXUATBAN]) VALUES (7788 , N'Hình họa và vẽ kỹ thuật cơ bản + BTL', N'Nguyễn Ðình Sinh', 222 , N'Vật lí', N'Nhà xuất bản giáo dục VN' , 1997)
INSERT [dbo].[DONGSACH] ([MASACH], [TENSACH], [TACGIA], [SOTRANG], [THELOAI], [NHAXUATBAN], [NAMXUATBAN]) VALUES (8899 , N'Những nguyên lý cơ bản của chủ nghĩa Mác-Lênin 1', N'Truong Van Thái Quý', 300 , N'Triết học', N'Nhà xuất bản giáo dục VN' , 1999)
INSERT [dbo].[DONGSACH] ([MASACH], [TENSACH], [TACGIA], [SOTRANG], [THELOAI], [NHAXUATBAN], [NAMXUATBAN]) VALUES (9900 , N'Những nguyên lý cơ bản của chủ nghĩa Mác-Lênin 2', N'Nguyễn Phong Hồng Duy', 899 , N'Triết học', N'Nhà xuất bản giáo dục VN' , 2010)
INSERT [dbo].[DONGSACH] ([MASACH], [TENSACH], [TACGIA], [SOTRANG], [THELOAI], [NHAXUATBAN], [NAMXUATBAN]) VALUES (9988 , N'Đường lối quốc phòng và an ninh của Đảng cộng sản Việt Nam', N'Trịnh Công Son', 232 , N'Lịc sử', N'Nhà xuất bản HVKTQS' , 1997)
INSERT [dbo].[DONGSACH] ([MASACH], [TENSACH], [TACGIA], [SOTRANG], [THELOAI], [NHAXUATBAN], [NAMXUATBAN]) VALUES (8877 , N'Tư tưởng Hồ Chí Minh + Tiểu luận', N'Hà Anh Tuấn', 122 , N'Triết học', N'Nhà xuất bản ÐH Bách Hoa HN' , 1980)
INSERT [dbo].[DONGSACH] ([MASACH], [TENSACH], [TACGIA], [SOTRANG], [THELOAI], [NHAXUATBAN], [NAMXUATBAN]) VALUES (7766 , N'Ngôn ngữ lập trình 1', N'Trần Ðình Trọng', 787 , N'Công nghệ thông tin', N'Nhà xuất bản công nghệ VN' , 2012)
INSERT [dbo].[DONGSACH] ([MASACH], [TENSACH], [TACGIA], [SOTRANG], [THELOAI], [NHAXUATBAN], [NAMXUATBAN]) VALUES (6655 , N'Ngôn ngữ lập trình 2', N'Quế Ngọc Hải', 666 , N'Công nghệ thông tin', N'Nhà xuất bản công nghệ VN' , 2015)
INSERT [dbo].[DONGSACH] ([MASACH], [TENSACH], [TACGIA], [SOTRANG], [THELOAI], [NHAXUATBAN], [NAMXUATBAN]) VALUES (5544 , N'Cơ sở dữ liệu', N'Trịnh Công Minh', 300 , N'Công nghệ thông tin', N'Nhà xuất bản cơ sở dữ liệu VN' , 1987)
INSERT [dbo].[DONGSACH] ([MASACH], [TENSACH], [TACGIA], [SOTRANG], [THELOAI], [NHAXUATBAN], [NAMXUATBAN]) VALUES (4433 , N'Xác xuất thống kê', N'Nguyễn Thị Thu Hà', 676, N'Toán học', N'Nhà xuất bản giáo dục VN' , 2020)
INSERT [dbo].[DONGSACH] ([MASACH], [TENSACH], [TACGIA], [SOTRANG], [THELOAI], [NHAXUATBAN], [NAMXUATBAN]) VALUES (3322 , N'Lý thuyết hệ điều hành', N'Nhâm Mạnh Hùng', 212 , N'Công nghệ máy tính', N'Nhà xuất bản công nghệ VN' , 2010)
INSERT [dbo].[DONGSACH] ([MASACH], [TENSACH], [TACGIA], [SOTRANG], [THELOAI], [NHAXUATBAN], [NAMXUATBAN]) VALUES (2211 , N'An toàn thông tin', N'Nguyễn Việt Anh', 3233 , N'An toàn thông tin', N'Nhà xuất bản công nghệ VN' , 2016)
INSERT [dbo].[DONGSACH] ([MASACH], [TENSACH], [TACGIA], [SOTRANG], [THELOAI], [NHAXUATBAN], [NAMXUATBAN]) VALUES (1100 , N'Mạng máy tính', N'Ðỗ Duy Minh', 455 , N'Công nghệ máy tính', N'Nhà xuất bản công nghệ VN' , 2011)
INSERT [dbo].[DONGSACH] ([MASACH], [TENSACH], [TACGIA], [SOTRANG], [THELOAI], [NHAXUATBAN], [NAMXUATBAN]) VALUES (1212 , N'Cấu trúc máy tính', N'Ðỗ Quang Hà', 420 , N'Công nghệ máy tính', N'Nhà xuất bản công nghệ VN' , 2019)
INSERT [dbo].[DONGSACH] ([MASACH], [TENSACH], [TACGIA], [SOTRANG], [THELOAI], [NHAXUATBAN], [NAMXUATBAN]) VALUES (2323 , N'Kinh tế công nghiệp', N'Ðặng Van Lâm', 80, N'Kinh tế', N'Nhà xuất bản kinh tế VN' , 1990)
INSERT [dbo].[DONGSACH] ([MASACH], [TENSACH], [TACGIA], [SOTRANG], [THELOAI], [NHAXUATBAN], [NAMXUATBAN]) VALUES (3434 , N'Mạng viễn thông', N'Quang Hải', 502 , N'Điện tử viễn thông', N'Nhà xuất bản viễn thông VN' , 1996)
INSERT [dbo].[DONGSACH] ([MASACH], [TENSACH], [TACGIA], [SOTRANG], [THELOAI], [NHAXUATBAN], [NAMXUATBAN]) VALUES (4545 , N'Tương tác nguời máy', N'Hoàng Ðức', 378 , N'Công nghệ thông tin', N'Nhà xuất bản công nghệ VN' , 2008)
INSERT [dbo].[DONGSACH] ([MASACH], [TENSACH], [TACGIA], [SOTRANG], [THELOAI], [NHAXUATBAN], [NAMXUATBAN]) VALUES (5656 , N'Xây dựng và quản lý hệ thống', N'Ðỗ Ngọc Thịnh', 567 , N'Công nghệ máy tính', N'Nhà xuất bản công nghệ VN' , 2014)
INSERT [dbo].[DONGSACH] ([MASACH], [TENSACH], [TACGIA], [SOTRANG], [THELOAI], [NHAXUATBAN], [NAMXUATBAN]) VALUES (6767 , N'Công nghệ web', N'Hà Minh Thái', 560 , N'Công nghệ máy tính', N'Nhà xuất bản công nghệ VN' , 2020)
INSERT [dbo].[DONGSACH] ([MASACH], [TENSACH], [TACGIA], [SOTRANG], [THELOAI], [NHAXUATBAN], [NAMXUATBAN]) VALUES (7878 , N'Toán chuyên dề', N'Hà Huy Tập', 322 , N'Toán học', N'Nhà xuất bản ÐH Bách Khoa HN' , 2007)

INSERT [dbo].[DOCGIA] ([MASINHVIEN], [TENDOCGIA], [GIOITINH], [NGAYSINH],[LOP], [DIACHI]) VALUES (17150101, N'Nguyễn Minh Ðức' , N'Nam', CAST (N'1998-2-1' AS Date), N'CNTT15', N'554, Ngõ 232 Phạm Văn Ðồng, Hà Nội')
INSERT [dbo].[DOCGIA] ([MASINHVIEN], [TENDOCGIA], [GIOITINH], [NGAYSINH],[LOP], [DIACHI]) VALUES (17150102, N'Nguyễn Khắc Ðức Quân' , N'Nam', CAST (N'1999-10-10' AS Date), N'CNTT16A', N'266, Lê Trọng Tấn , Hà Nội')
INSERT [dbo].[DOCGIA] ([MASINHVIEN], [TENDOCGIA], [GIOITINH], [NGAYSINH],[LOP], [DIACHI]) VALUES (17150103, N'Nguyễn Đình Thịnh' , N'Nam', CAST (N'1998-11-19' AS Date), N'CNTT16A', N'47A, Ngõ 467 Phạm Văn Ðồng, Hà Nội')
INSERT [dbo].[DOCGIA] ([MASINHVIEN], [TENDOCGIA], [GIOITINH], [NGAYSINH],[LOP], [DIACHI]) VALUES (17150104, N'Phạm Hữu Duy Anh' , N'Nam', CAST (N'1999-3-7' AS Date), N'ĐTVT16', N'451, Nghĩa Tân, Tô Hiệu , Hà Nội')
INSERT [dbo].[DOCGIA] ([MASINHVIEN], [TENDOCGIA], [GIOITINH], [NGAYSINH],[LOP], [DIACHI]) VALUES (17150105, N'Đỗ Quang Huy' , N'Nam', CAST (N'2000-12-12' AS Date), N'CNTT17', N'4, Ngõ 525 Cổ Nhuế, Hà Nội')
INSERT [dbo].[DOCGIA] ([MASINHVIEN], [TENDOCGIA], [GIOITINH], [NGAYSINH],[LOP], [DIACHI]) VALUES (17150106, N'Nguyễn Việt Long' , N'Nam', CAST (N'1999-3-13' AS Date), N'CNTT16A', N'266, Lê Trọng Tấn , Hà Nội')
INSERT [dbo].[DOCGIA] ([MASINHVIEN], [TENDOCGIA], [GIOITINH], [NGAYSINH],[LOP], [DIACHI]) VALUES (17150107, N'Nguyễn Thị Hồng Ánh' , N'Nữ', CAST (N'1997-8-3' AS Date), N'TDH15', N'50, Ngõ 45 Hoàng Quốc Việt , Hà Nội')
INSERT [dbo].[DOCGIA] ([MASINHVIEN], [TENDOCGIA], [GIOITINH], [NGAYSINH],[LOP], [DIACHI]) VALUES (17150108, N'Bùi Trung Anh' , N'Nam', CAST (N'1999-3-8' AS Date), N'TDH16', N'Sầm Sơn, Thanh Hóa ')
INSERT [dbo].[DOCGIA] ([MASINHVIEN], [TENDOCGIA], [GIOITINH], [NGAYSINH],[LOP], [DIACHI]) VALUES (17150109, N'Phạm Văn Tùng' , N'Nam', CAST (N'1998-12-19' AS Date), N'CNTT15', N'Cổ loa , Đông Anh , Hà Tây')
INSERT [dbo].[DOCGIA] ([MASINHVIEN], [TENDOCGIA], [GIOITINH], [NGAYSINH],[LOP], [DIACHI]) VALUES (17150110, N'Trần Minh Duyệt' , N'Nam', CAST (N'1999-6-17' AS Date), N'CNTT16A', N'Bến xe Nước Ngầm , Thanh Trì , Hà Nội')
INSERT [dbo].[DOCGIA] ([MASINHVIEN], [TENDOCGIA], [GIOITINH], [NGAYSINH],[LOP], [DIACHI]) VALUES (17150111, N'Hoàng Gia Lâm' , N'Nam', CAST (N'1998-12-7' AS Date), N'TDH15', N'43 Đinh Tiên Hoàng, P. Bến Nghé, Quận 1, TP. HCM')
INSERT [dbo].[DOCGIA] ([MASINHVIEN], [TENDOCGIA], [GIOITINH], [NGAYSINH],[LOP], [DIACHI]) VALUES (17150112, N'Đỗ Tiến Thành' , N'Nam', CAST (N'1999-5-5' AS Date), N'CNTT16A', N'Ngõ 148 Hàn Thuyên, Tp. Nam Định')
INSERT [dbo].[DOCGIA] ([MASINHVIEN], [TENDOCGIA], [GIOITINH], [NGAYSINH],[LOP], [DIACHI]) VALUES (17150113, N'Đỗ Hoàng Trung' , N'Nam', CAST (N'1998-2-2' AS Date), N'CNTT15', N'86 Âu Cơ, Tp. Bắc Ninh, Bắc Ninh')
INSERT [dbo].[DOCGIA] ([MASINHVIEN], [TENDOCGIA], [GIOITINH], [NGAYSINH],[LOP], [DIACHI]) VALUES (17150114, N'Hoàng Hải Thành' , N'Nam', CAST (N'1999-3-3' AS Date), N'CNTT16A', N'90 Lý Tự Trọng, Tp. Hà Tĩnh, Hà Tĩnh')
INSERT [dbo].[DOCGIA] ([MASINHVIEN], [TENDOCGIA], [GIOITINH], [NGAYSINH],[LOP], [DIACHI]) VALUES (17150115, N'Chu Nhất Long' , N'Nam', CAST (N'1998-2-30' AS Date), N'CNTT15', N'Tầng 1 Big C Thanh Hóa, Tp. Thanh Hóa')
INSERT [dbo].[DOCGIA] ([MASINHVIEN], [TENDOCGIA], [GIOITINH], [NGAYSINH],[LOP], [DIACHI]) VALUES (17150116, N'Nguyễn Minh Phương' , N'Nữ', CAST (N'1998-8-2' AS Date), N'ĐTYS15A', N'26 - 28 Trưng Trắc, P. 1, Tp. Vũng Tàu')
INSERT [dbo].[DOCGIA] ([MASINHVIEN], [TENDOCGIA], [GIOITINH], [NGAYSINH],[LOP], [DIACHI]) VALUES (17150117, N'Nguyễn Minh Châu' , N'Nữ', CAST (N'1998-8-7' AS Date), N'CNTT15', N'133B Ký Con, P. Nguyễn Thái Bình, Quận 1, TP. HCM')
INSERT [dbo].[DOCGIA] ([MASINHVIEN], [TENDOCGIA], [GIOITINH], [NGAYSINH],[LOP], [DIACHI]) VALUES (17150118, N'Nguyễn Khắc Ðức Thống' , N'Nam', CAST (N'1999-5-12' AS Date), N'CNTT16A', N'401 Thống Nhất, Thị xã Lagi, Bình Thuận')
INSERT [dbo].[DOCGIA] ([MASINHVIEN], [TENDOCGIA], [GIOITINH], [NGAYSINH],[LOP], [DIACHI]) VALUES (17150119, N'Đỗ Vân Anh' , N'Nữ', CAST (N'1998-10-11' AS Date), N'CNTT15', N'Z35 Đào Tấn, Tp. Phan Thiết, Bình Thuận')
INSERT [dbo].[DOCGIA] ([MASINHVIEN], [TENDOCGIA], [GIOITINH], [NGAYSINH],[LOP], [DIACHI]) VALUES (17150101, N'Nguyễn Thanh Hà' , N'Nữ', CAST (N'1999-12-28' AS Date), N'CNTT16A', N'Đường Số 9, Dĩ An, Bình Dương')
INSERT [dbo].[DOCGIA] ([MASINHVIEN], [TENDOCGIA], [GIOITINH], [NGAYSINH],[LOP], [DIACHI]) VALUES (17150120, N'Đặng Ngô Hiền' , N'Nữ', CAST (N'1998-1-19' AS Date), N'CNTT15', N'Nguyễn Du, P.Nông Trang,Tp.Việt Trì,Phú Thọ')
INSERT [dbo].[DOCGIA] ([MASINHVIEN], [TENDOCGIA], [GIOITINH], [NGAYSINH],[LOP], [DIACHI]) VALUES (17150121, N'Nguyễn Tuấn Hưng' , N'Nam', CAST (N'1999-1-5' AS Date), N'CNTT16A', N'Big C Việt Trì, Nguyễn Tất Thành, Phú Thọ')
INSERT [dbo].[DOCGIA] ([MASINHVIEN], [TENDOCGIA], [GIOITINH], [NGAYSINH],[LOP], [DIACHI]) VALUES (17150122, N'Nguyễn Đình Minh Mẫn' , N'Nữ', CAST (N'1998-5-11' AS Date), N'CNTT15', N'55 Trần Cao Vân, Tp. Qui Nhơn, Bình Định')
INSERT [dbo].[DOCGIA] ([MASINHVIEN], [TENDOCGIA], [GIOITINH], [NGAYSINH],[LOP], [DIACHI]) VALUES (17150123, N'Tô Khả Hân' , N'Nữ', CAST (N'1999-11-23' AS Date), N'CNTT16A', N'10M Hồ Sen, Quận Lê Chân, Hải Phòng')
INSERT [dbo].[DOCGIA] ([MASINHVIEN], [TENDOCGIA], [GIOITINH], [NGAYSINH],[LOP], [DIACHI]) VALUES (17150124, N'Đoàn Khánh Linh' , N'Nữ', CAST (N'1998-4-7' AS Date), N'CNTT15', N'20 Trần Nguyên Hãn, Quận Lê Chân, Hải Phòng')
INSERT [dbo].[DOCGIA] ([MASINHVIEN], [TENDOCGIA], [GIOITINH], [NGAYSINH],[LOP], [DIACHI]) VALUES (17150125, N'Doãn Hoàng Yễn' , N'Nữ', CAST (N'1999-6-6' AS Date), N'CNTT16A', N'172 Điện Biên, P. Lê Lợi, Tp. Hưng Yên')


INSERT [dbo].[MUONSACK] ([MAMUONTRA],[MATHETV],[MASACH],[NGAYMUON],[MASINHVIEN]) VALUES (1001,1,1122,CAST (N'2020-2-25' AS DATE),17150101)
INSERT [dbo].[MUONSACK] ([MAMUONTRA],[MATHETV],[MASACH],[NGAYMUON],[MASINHVIEN]) VALUES (1002,2,2233,CAST (N'2020-3-24' AS DATE),17150102)
INSERT [dbo].[MUONSACK] ([MAMUONTRA],[MATHETV],[MASACH],[NGAYMUON],[MASINHVIEN]) VALUES (1003,3,3344,CAST (N'2020-4-26' AS DATE),17150103)
INSERT [dbo].[MUONSACK] ([MAMUONTRA],[MATHETV],[MASACH],[NGAYMUON],[MASINHVIEN]) VALUES (1004,4,4455,CAST (N'2020-5-27' AS DATE),17150104)
INSERT [dbo].[MUONSACK] ([MAMUONTRA],[MATHETV],[MASACH],[NGAYMUON],[MASINHVIEN]) VALUES (1005,5,5566,CAST (N'2020-6-28' AS DATE),17150105)


INSERT [dbo].[TRASACH] ([MAMUONTRA], [MASACH], [DA_TRA],[NGAYTRA]) VALUES (1001,1122,NULL , CAST (N'2020-2-27' AS DATE))
INSERT [dbo].[TRASACH] ([MAMUONTRA], [MASACH], [DA_TRA],[NGAYTRA]) VALUES (1002,2233,NULL , CAST (N'2020-2-28' AS DATE))
INSERT [dbo].[TRASACH] ([MAMUONTRA], [MASACH], [DA_TRA],[NGAYTRA]) VALUES (1003,3344,NULL , CAST (N'2020-2-29' AS DATE))
INSERT [dbo].[TRASACH] ([MAMUONTRA], [MASACH], [DA_TRA],[NGAYTRA]) VALUES (1004,4455,NULL ,CAST (N'2020-2-30' AS DATE))
INSERT [dbo].[TRASACH] ([MAMUONTRA], [MASACH], [DA_TRA],[NGAYTRA]) VALUES (1005,5566,NULL ,CAST (N'2020-2-31' AS DATE))












