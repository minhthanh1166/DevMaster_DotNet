USE [Lab02]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 05/07/2023 10:42:52 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](35) NULL,
	[Gender] [bit] NULL,
	[BirthDay] [datetime] NULL,
	[Address] [nvarchar](max) NULL,
	[Email] [varchar](50) NULL,
	[Salary] [float] NULL,
	[phone] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NewEmployees]    Script Date: 05/07/2023 10:42:52 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NewEmployees](
	[Id] [int] NOT NULL,
	[FullName] [nvarchar](35) NULL,
	[Gender] [bit] NULL,
	[BirthDay] [datetime] NULL,
	[Address] [nvarchar](max) NULL,
	[Email] [varchar](50) NULL,
	[Salary] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([Id], [FullName], [Gender], [BirthDay], [Address], [Email], [Salary], [phone]) VALUES (21, N'Bui Minh Thành', 1, CAST(N'2001-06-11T00:00:00.000' AS DateTime), N'Quỳnh Phụ, Thái Bình', N'buiminhthanh116@gmail.com', 500000000, NULL)
INSERT [dbo].[Employee] ([Id], [FullName], [Gender], [BirthDay], [Address], [Email], [Salary], [phone]) VALUES (22, N'John', 1, CAST(N'2002-12-28T00:00:00.000' AS DateTime), N'Hải Hậu, Nam Định', N'maicute@gmail.com', 3000000, NULL)
INSERT [dbo].[Employee] ([Id], [FullName], [Gender], [BirthDay], [Address], [Email], [Salary], [phone]) VALUES (24, N'Tòng A Hùng', 1, CAST(N'2005-10-14T00:00:00.000' AS DateTime), N'Bắc Từ Liêm, Hà Nội', N'hackerhaohan@gmail.com', 70000, NULL)
INSERT [dbo].[Employee] ([Id], [FullName], [Gender], [BirthDay], [Address], [Email], [Salary], [phone]) VALUES (25, N'Luân Giám Tài', 1, CAST(N'2003-02-18T00:00:00.000' AS DateTime), N'Từ Sơn, Bắc Ninh', N'chuahe123@gmail.com', 40000, NULL)
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
INSERT [dbo].[NewEmployees] ([Id], [FullName], [Gender], [BirthDay], [Address], [Email], [Salary]) VALUES (21, N'Bui Minh Thành', 1, CAST(N'2001-06-11T00:00:00.000' AS DateTime), N'Quỳnh Phụ, Thái Bình', N'buiminhthanh116@gmail.com', 500000000)
INSERT [dbo].[NewEmployees] ([Id], [FullName], [Gender], [BirthDay], [Address], [Email], [Salary]) VALUES (22, N'John', 1, CAST(N'2002-12-28T00:00:00.000' AS DateTime), N'Hải Hậu, Nam Định', N'maicute@gmail.com', 3000000)
GO
