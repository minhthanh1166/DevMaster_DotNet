USE [DEV_2306]
GO
/****** Object:  Table [dbo].[KetQua]    Script Date: 04/07/2023 7:42:50 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KetQua](
	[MaSV] [nchar](10) NOT NULL,
	[MaMH] [nchar](10) NULL,
	[Diem] [real] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 04/07/2023 7:42:50 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa](
	[MaKH] [nchar](10) NOT NULL,
	[TenKhoa] [nvarchar](50) NULL,
 CONSTRAINT [PK_Khoa] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 04/07/2023 7:42:50 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[MAMH] [nchar](10) NOT NULL,
	[TenMH] [nvarchar](50) NULL,
	[SOTC] [real] NULL,
 CONSTRAINT [PK_MonHoc] PRIMARY KEY CLUSTERED 
(
	[MAMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 04/07/2023 7:42:50 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSV] [nchar](10) NOT NULL,
	[HoSV] [nchar](10) NULL,
	[TenSV] [nchar](10) NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh] [tinyint] NULL,
	[MaKH] [nchar](10) NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[KetQua] ([MaSV], [MaMH], [Diem]) VALUES (N'A001      ', N'MH001     ', 10)
INSERT [dbo].[KetQua] ([MaSV], [MaMH], [Diem]) VALUES (N'A002      ', N'MH002     ', 8)
GO
INSERT [dbo].[Khoa] ([MaKH], [TenKhoa]) VALUES (N'AV        ', N'Anh Van')
INSERT [dbo].[Khoa] ([MaKH], [TenKhoa]) VALUES (N'NN        ', N'Ngoai Ngu')
INSERT [dbo].[Khoa] ([MaKH], [TenKhoa]) VALUES (N'TH        ', N'Tin Hoc')
GO
INSERT [dbo].[MonHoc] ([MAMH], [TenMH], [SOTC]) VALUES (N'MH001     ', N'SQL Server', 5)
INSERT [dbo].[MonHoc] ([MAMH], [TenMH], [SOTC]) VALUES (N'MH002     ', N'.Net Core', 10)
GO
INSERT [dbo].[SinhVien] ([MaSV], [HoSV], [TenSV], [NgaySinh], [GioiTinh], [MaKH]) VALUES (N'A001      ', N'Bui       ', N'Minh Thanh', CAST(N'2001-06-11T00:00:00.000' AS DateTime), 1, N'AV        ')
INSERT [dbo].[SinhVien] ([MaSV], [HoSV], [TenSV], [NgaySinh], [GioiTinh], [MaKH]) VALUES (N'A002      ', N'Dam       ', N'Quoc Dan  ', CAST(N'2003-04-21T00:00:00.000' AS DateTime), 2, N'NN        ')
GO
ALTER TABLE [dbo].[KetQua]  WITH CHECK ADD  CONSTRAINT [FK_KetQua_MonHoc] FOREIGN KEY([MaMH])
REFERENCES [dbo].[MonHoc] ([MAMH])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[KetQua] CHECK CONSTRAINT [FK_KetQua_MonHoc]
GO
ALTER TABLE [dbo].[KetQua]  WITH CHECK ADD  CONSTRAINT [FK_KetQua_SinhVien] FOREIGN KEY([MaSV])
REFERENCES [dbo].[SinhVien] ([MaSV])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[KetQua] CHECK CONSTRAINT [FK_KetQua_SinhVien]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SinhVien_Khoa] FOREIGN KEY([MaKH])
REFERENCES [dbo].[Khoa] ([MaKH])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SinhVien_Khoa]
GO
