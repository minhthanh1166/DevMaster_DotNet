USE [QLHH]
GO
/****** Object:  Table [dbo].[CTDONDH]    Script Date: 18/07/2023 6:15:00 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTDONDH](
	[SoDh] [char](4) NOT NULL,
	[MaVTu] [char](4) NOT NULL,
	[SlDat] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SoDh] ASC,
	[MaVTu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTPNHAP]    Script Date: 18/07/2023 6:15:00 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPNHAP](
	[SoPn] [char](4) NOT NULL,
	[MaVTu] [char](4) NOT NULL,
	[SlNhap] [char](4) NOT NULL,
	[DgNhap] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SoPn] ASC,
	[MaVTu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTPXUAT]    Script Date: 18/07/2023 6:15:00 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPXUAT](
	[SoPx] [char](4) NOT NULL,
	[MaVTu] [char](4) NOT NULL,
	[SlXuat] [int] NOT NULL,
	[DgXuat] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SoPx] ASC,
	[MaVTu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DONDH]    Script Date: 18/07/2023 6:15:00 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DONDH](
	[SoDh] [char](4) NOT NULL,
	[NgayDh] [datetime] NULL,
	[MaNhaCc] [char](3) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SoDh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHACC]    Script Date: 18/07/2023 6:15:00 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHACC](
	[MaNhaCc] [char](3) NOT NULL,
	[TenNhaCc] [varchar](100) NOT NULL,
	[DiaChi] [varchar](200) NOT NULL,
	[DienThoai] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhaCc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PNHAP]    Script Date: 18/07/2023 6:15:00 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PNHAP](
	[SoPn] [char](4) NOT NULL,
	[NgayNhap] [datetime] NULL,
	[SoDh] [char](4) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SoPn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PXUAT]    Script Date: 18/07/2023 6:15:00 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PXUAT](
	[SoPx] [char](4) NOT NULL,
	[NgayXuat] [datetime] NULL,
	[TenKh] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SoPx] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TONKHO]    Script Date: 18/07/2023 6:15:00 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TONKHO](
	[NamThang] [char](6) NOT NULL,
	[MaVTu] [char](4) NOT NULL,
	[SLDau] [int] NOT NULL,
	[TongSLN] [int] NOT NULL,
	[TongSLX] [int] NOT NULL,
	[SLCuoi]  AS (([SLDau]+[TongSLN])-[TongSLX]) PERSISTED,
PRIMARY KEY CLUSTERED 
(
	[NamThang] ASC,
	[MaVTu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VATTU]    Script Date: 18/07/2023 6:15:00 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VATTU](
	[MaVTu] [char](4) NOT NULL,
	[TenVTu] [varchar](100) NOT NULL,
	[DvTinh] [varchar](10) NULL,
	[PhanTram] [real] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaVTu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CTDONDH] ([SoDh], [MaVTu], [SlDat]) VALUES (N'D001', N'DD01', 10)
INSERT [dbo].[CTDONDH] ([SoDh], [MaVTu], [SlDat]) VALUES (N'D001', N'DD02', 15)
INSERT [dbo].[CTDONDH] ([SoDh], [MaVTu], [SlDat]) VALUES (N'D002', N'VD02', 30)
INSERT [dbo].[CTDONDH] ([SoDh], [MaVTu], [SlDat]) VALUES (N'D003', N'TV14', 10)
INSERT [dbo].[CTDONDH] ([SoDh], [MaVTu], [SlDat]) VALUES (N'D003', N'TV29', 20)
INSERT [dbo].[CTDONDH] ([SoDh], [MaVTu], [SlDat]) VALUES (N'D004', N'TL90', 10)
INSERT [dbo].[CTDONDH] ([SoDh], [MaVTu], [SlDat]) VALUES (N'D005', N'TV14', 10)
INSERT [dbo].[CTDONDH] ([SoDh], [MaVTu], [SlDat]) VALUES (N'D005', N'TV29', 20)
INSERT [dbo].[CTDONDH] ([SoDh], [MaVTu], [SlDat]) VALUES (N'D006', N'TV14', 10)
INSERT [dbo].[CTDONDH] ([SoDh], [MaVTu], [SlDat]) VALUES (N'D006', N'TV29', 20)
INSERT [dbo].[CTDONDH] ([SoDh], [MaVTu], [SlDat]) VALUES (N'D006', N'VD01', 20)
GO
INSERT [dbo].[CTPNHAP] ([SoPn], [MaVTu], [SlNhap], [DgNhap]) VALUES (N'N001', N'DD01', N'8   ', 2500000.0000)
INSERT [dbo].[CTPNHAP] ([SoPn], [MaVTu], [SlNhap], [DgNhap]) VALUES (N'N001', N'DD02', N'10  ', 3500000.0000)
INSERT [dbo].[CTPNHAP] ([SoPn], [MaVTu], [SlNhap], [DgNhap]) VALUES (N'N002', N'DD01', N'2   ', 2500000.0000)
INSERT [dbo].[CTPNHAP] ([SoPn], [MaVTu], [SlNhap], [DgNhap]) VALUES (N'N002', N'DD02', N'5   ', 3500000.0000)
INSERT [dbo].[CTPNHAP] ([SoPn], [MaVTu], [SlNhap], [DgNhap]) VALUES (N'N003', N'VD02', N'30  ', 2500000.0000)
INSERT [dbo].[CTPNHAP] ([SoPn], [MaVTu], [SlNhap], [DgNhap]) VALUES (N'N004', N'TV14', N'5   ', 2500000.0000)
INSERT [dbo].[CTPNHAP] ([SoPn], [MaVTu], [SlNhap], [DgNhap]) VALUES (N'N004', N'TV29', N'12  ', 3500000.0000)
GO
INSERT [dbo].[CTPXUAT] ([SoPx], [MaVTu], [SlXuat], [DgXuat]) VALUES (N'X001', N'DD01', 2, 3500000.0000)
INSERT [dbo].[CTPXUAT] ([SoPx], [MaVTu], [SlXuat], [DgXuat]) VALUES (N'X002', N'DD01', 1, 3500000.0000)
INSERT [dbo].[CTPXUAT] ([SoPx], [MaVTu], [SlXuat], [DgXuat]) VALUES (N'X002', N'DD02', 5, 4900000.0000)
INSERT [dbo].[CTPXUAT] ([SoPx], [MaVTu], [SlXuat], [DgXuat]) VALUES (N'X003', N'DD01', 3, 3500000.0000)
INSERT [dbo].[CTPXUAT] ([SoPx], [MaVTu], [SlXuat], [DgXuat]) VALUES (N'X003', N'DD02', 2, 4900000.0000)
INSERT [dbo].[CTPXUAT] ([SoPx], [MaVTu], [SlXuat], [DgXuat]) VALUES (N'X003', N'VD02', 10, 3250000.0000)
GO
INSERT [dbo].[DONDH] ([SoDh], [NgayDh], [MaNhaCc]) VALUES (N'D001', CAST(N'2023-07-18T17:28:24.570' AS DateTime), N'C03')
INSERT [dbo].[DONDH] ([SoDh], [NgayDh], [MaNhaCc]) VALUES (N'D002', CAST(N'2023-07-18T17:28:24.570' AS DateTime), N'C01')
INSERT [dbo].[DONDH] ([SoDh], [NgayDh], [MaNhaCc]) VALUES (N'D003', CAST(N'2023-07-18T17:28:24.570' AS DateTime), N'C02')
INSERT [dbo].[DONDH] ([SoDh], [NgayDh], [MaNhaCc]) VALUES (N'D004', CAST(N'2023-07-18T17:28:24.570' AS DateTime), N'C05')
INSERT [dbo].[DONDH] ([SoDh], [NgayDh], [MaNhaCc]) VALUES (N'D005', CAST(N'2023-07-18T17:28:24.570' AS DateTime), N'C02')
INSERT [dbo].[DONDH] ([SoDh], [NgayDh], [MaNhaCc]) VALUES (N'D006', CAST(N'2023-07-18T17:28:24.570' AS DateTime), N'C05')
GO
INSERT [dbo].[NHACC] ([MaNhaCc], [TenNhaCc], [DiaChi], [DienThoai]) VALUES (N'C01', N'Lê Quang Thành', N'54, Kim Mã, C?u Gi?y, Hà N?i', N'8781024')
INSERT [dbo].[NHACC] ([MaNhaCc], [TenNhaCc], [DiaChi], [DienThoai]) VALUES (N'C02', N'Tr?n Quang Anh', N'145 Hùng Vuong, H?i Duong', N'7698154')
INSERT [dbo].[NHACC] ([MaNhaCc], [TenNhaCc], [DiaChi], [DienThoai]) VALUES (N'C03', N'Bùi H?ng Phuong', N'154/85 Lê Chân, H?i Phòng', N'9600125')
INSERT [dbo].[NHACC] ([MaNhaCc], [TenNhaCc], [DiaChi], [DienThoai]) VALUES (N'C04', N'Vu Nh?t Th?ng', N'198/40 Huong L? 14 QTB, HCM', N'757757')
INSERT [dbo].[NHACC] ([MaNhaCc], [TenNhaCc], [DiaChi], [DienThoai]) VALUES (N'C05', N'Nguy?n Th? Thúy', N'178 Nguy?n Ð?t Luông, Ðà L?t', N'7964251')
INSERT [dbo].[NHACC] ([MaNhaCc], [TenNhaCc], [DiaChi], [DienThoai]) VALUES (N'C07', N'Cao Minh Trung', N'125 Lê Quang Sung, Nha Trang', N'Chua có')
GO
INSERT [dbo].[PNHAP] ([SoPn], [NgayNhap], [SoDh]) VALUES (N'N001', CAST(N'2023-07-18T17:48:23.147' AS DateTime), N'D001')
INSERT [dbo].[PNHAP] ([SoPn], [NgayNhap], [SoDh]) VALUES (N'N002', CAST(N'2023-07-18T17:48:23.147' AS DateTime), N'D001')
INSERT [dbo].[PNHAP] ([SoPn], [NgayNhap], [SoDh]) VALUES (N'N003', CAST(N'2023-07-18T17:48:23.147' AS DateTime), N'D002')
INSERT [dbo].[PNHAP] ([SoPn], [NgayNhap], [SoDh]) VALUES (N'N004', CAST(N'2023-07-18T17:48:23.147' AS DateTime), N'D005')
GO
INSERT [dbo].[PXUAT] ([SoPx], [NgayXuat], [TenKh]) VALUES (N'X001', CAST(N'2023-07-18T17:50:24.707' AS DateTime), N'Nguy?n Ng?c Phuong Nhi')
INSERT [dbo].[PXUAT] ([SoPx], [NgayXuat], [TenKh]) VALUES (N'X002', CAST(N'2023-07-18T17:50:24.707' AS DateTime), N'Nguy?n H?ng Phuong')
INSERT [dbo].[PXUAT] ([SoPx], [NgayXuat], [TenKh]) VALUES (N'X003', CAST(N'2023-07-18T17:50:24.707' AS DateTime), N'Nguy?n Tu?n Tú')
GO
INSERT [dbo].[TONKHO] ([NamThang], [MaVTu], [SLDau], [TongSLN], [TongSLX]) VALUES (N'201201', N'DD01', 1, 10, 6)
INSERT [dbo].[TONKHO] ([NamThang], [MaVTu], [SLDau], [TongSLN], [TongSLX]) VALUES (N'201201', N'DD02', 1, 15, 7)
INSERT [dbo].[TONKHO] ([NamThang], [MaVTu], [SLDau], [TongSLN], [TongSLX]) VALUES (N'201201', N'VD02', 1, 30, 10)
INSERT [dbo].[TONKHO] ([NamThang], [MaVTu], [SLDau], [TongSLN], [TongSLX]) VALUES (N'201202', N'DD01', 4, 1, 1)
INSERT [dbo].[TONKHO] ([NamThang], [MaVTu], [SLDau], [TongSLN], [TongSLX]) VALUES (N'201202', N'DD02', 8, 1, 1)
INSERT [dbo].[TONKHO] ([NamThang], [MaVTu], [SLDau], [TongSLN], [TongSLX]) VALUES (N'201202', N'TV14', 5, 1, 1)
INSERT [dbo].[TONKHO] ([NamThang], [MaVTu], [SLDau], [TongSLN], [TongSLX]) VALUES (N'201202', N'TV29', 12, 1, 1)
INSERT [dbo].[TONKHO] ([NamThang], [MaVTu], [SLDau], [TongSLN], [TongSLX]) VALUES (N'201202', N'VD02', 20, 1, 1)
GO
INSERT [dbo].[VATTU] ([MaVTu], [TenVTu], [DvTinh], [PhanTram]) VALUES (N'DD01', N'Ð?u DVD Hatachi 1 dia', N'B?', 40)
INSERT [dbo].[VATTU] ([MaVTu], [TenVTu], [DvTinh], [PhanTram]) VALUES (N'DD02', N'Ð?u DVD Hatachi 3 dia', N'B?', 40)
INSERT [dbo].[VATTU] ([MaVTu], [TenVTu], [DvTinh], [PhanTram]) VALUES (N'TL15', N'T? l?nh sanyo 150 lit', N'Cái', 25)
INSERT [dbo].[VATTU] ([MaVTu], [TenVTu], [DvTinh], [PhanTram]) VALUES (N'TL90', N'T? l?nh sanyo 90 lit', N'Cái', 20)
INSERT [dbo].[VATTU] ([MaVTu], [TenVTu], [DvTinh], [PhanTram]) VALUES (N'TV14', N'TiVi Sony 14 inches', N'Cái', 15)
INSERT [dbo].[VATTU] ([MaVTu], [TenVTu], [DvTinh], [PhanTram]) VALUES (N'TV21', N'TiVi Sony 21 inches', N'Cái', 10)
INSERT [dbo].[VATTU] ([MaVTu], [TenVTu], [DvTinh], [PhanTram]) VALUES (N'TV29', N'TiVi Sony 29 inches', N'Cái', 10)
INSERT [dbo].[VATTU] ([MaVTu], [TenVTu], [DvTinh], [PhanTram]) VALUES (N'VD01', N'Ð?u VCD Sony 1 dia', N'B?', 30)
INSERT [dbo].[VATTU] ([MaVTu], [TenVTu], [DvTinh], [PhanTram]) VALUES (N'VD02', N'Ð?u VCD Sony 3 dia', N'B?', 30)
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__NHACC__BB03001847FDF1CF]    Script Date: 18/07/2023 6:15:01 CH ******/
ALTER TABLE [dbo].[NHACC] ADD UNIQUE NONCLUSTERED 
(
	[TenNhaCc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__VATTU__CEC2A25818999505]    Script Date: 18/07/2023 6:15:01 CH ******/
ALTER TABLE [dbo].[VATTU] ADD UNIQUE NONCLUSTERED 
(
	[TenVTu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DONDH] ADD  DEFAULT (getdate()) FOR [NgayDh]
GO
ALTER TABLE [dbo].[NHACC] ADD  DEFAULT (N'Chưa có') FOR [DienThoai]
GO
ALTER TABLE [dbo].[PNHAP] ADD  DEFAULT (getdate()) FOR [NgayNhap]
GO
ALTER TABLE [dbo].[PXUAT] ADD  DEFAULT (getdate()) FOR [NgayXuat]
GO
ALTER TABLE [dbo].[VATTU] ADD  DEFAULT ('') FOR [DvTinh]
GO
ALTER TABLE [dbo].[CTDONDH]  WITH CHECK ADD FOREIGN KEY([MaVTu])
REFERENCES [dbo].[VATTU] ([MaVTu])
GO
ALTER TABLE [dbo].[CTDONDH]  WITH CHECK ADD FOREIGN KEY([SoDh])
REFERENCES [dbo].[DONDH] ([SoDh])
GO
ALTER TABLE [dbo].[CTPNHAP]  WITH CHECK ADD FOREIGN KEY([MaVTu])
REFERENCES [dbo].[VATTU] ([MaVTu])
GO
ALTER TABLE [dbo].[CTPNHAP]  WITH CHECK ADD FOREIGN KEY([SoPn])
REFERENCES [dbo].[PNHAP] ([SoPn])
GO
ALTER TABLE [dbo].[CTPXUAT]  WITH CHECK ADD FOREIGN KEY([MaVTu])
REFERENCES [dbo].[VATTU] ([MaVTu])
GO
ALTER TABLE [dbo].[CTPXUAT]  WITH CHECK ADD FOREIGN KEY([SoPx])
REFERENCES [dbo].[PXUAT] ([SoPx])
GO
ALTER TABLE [dbo].[DONDH]  WITH CHECK ADD FOREIGN KEY([MaNhaCc])
REFERENCES [dbo].[NHACC] ([MaNhaCc])
GO
ALTER TABLE [dbo].[PNHAP]  WITH CHECK ADD FOREIGN KEY([SoDh])
REFERENCES [dbo].[DONDH] ([SoDh])
GO
ALTER TABLE [dbo].[TONKHO]  WITH CHECK ADD FOREIGN KEY([MaVTu])
REFERENCES [dbo].[VATTU] ([MaVTu])
GO
ALTER TABLE [dbo].[CTDONDH]  WITH CHECK ADD CHECK  (([SlDat]>(4)))
GO
ALTER TABLE [dbo].[CTPNHAP]  WITH CHECK ADD CHECK  (([DgNhap]>(0)))
GO
ALTER TABLE [dbo].[CTPNHAP]  WITH CHECK ADD CHECK  (([SlNhap]>(0)))
GO
ALTER TABLE [dbo].[CTPXUAT]  WITH CHECK ADD CHECK  (([DgXuat]>(0)))
GO
ALTER TABLE [dbo].[CTPXUAT]  WITH CHECK ADD CHECK  (([SlXuat]>(0)))
GO
ALTER TABLE [dbo].[TONKHO]  WITH CHECK ADD CHECK  (([SLDau]>(0)))
GO
ALTER TABLE [dbo].[TONKHO]  WITH CHECK ADD CHECK  (([TongSLN]>(0)))
GO
ALTER TABLE [dbo].[TONKHO]  WITH CHECK ADD CHECK  (([TongSLX]>(0)))
GO
ALTER TABLE [dbo].[VATTU]  WITH CHECK ADD CHECK  (([PhanTram]>=(0) AND [PhanTram]<=(100)))
GO
