CREATE DATABASE QLHH;
GO
USE QLHH;
GO

CREATE TABLE VATTU
(
	MaVTu CHAR(4) PRIMARY KEY NOT NULL,
	TenVTu VARCHAR(100) NOT NULL UNIQUE,
	DvTinh VARCHAR(10) NULL DEFAULT '',
	PhanTram REAL CHECK (PhanTram >= 0 AND PhanTram <= 100)
);
GO

CREATE TABLE NHACC
(
	MaNhaCc CHAR(3) PRIMARY KEY NOT NULL,
	TenNhaCc VARCHAR(100) UNIQUE NOT NULL,
	DiaChi VARCHAR(200) NOT NULL,
	DienThoai VARCHAR(20) NULL DEFAULT N'Chưa có'
);
GO

CREATE TABLE DONDH
(
	SoDh CHAR(4) PRIMARY KEY NOT NULL,
	NgayDh DATETIME DEFAULT GETDATE(),
	MaNhaCc CHAR(3) NOT NULL
	FOREIGN KEY (MaNhaCc) REFERENCES dbo.NHACC(MaNhaCc)
);

CREATE TABLE CTDONDH
(
	SoDh CHAR(4) NOT NULL,
	MaVTu CHAR(4) NOT NULL,
	PRIMARY KEY (SoDh, MaVTu),
	FOREIGN KEY (SoDh) REFERENCES dbo.DONDH(SoDh),
	FOREIGN KEY (MaVTu) REFERENCES dbo.VATTU(MaVTu),
	SlDat INT CHECK(SlDat > 4) NOT NULL
);

CREATE TABLE PNHAP
(
	SoPn CHAR(4) PRIMARY KEY NOT NULL,
	NgayNhap DATETIME DEFAULT GETDATE(),
	SoDh CHAR(4) NOT NULL
	FOREIGN KEY (SoDh) REFERENCES dbo.DONDH(SoDh)
);
GO

CREATE TABLE CTPNHAP
(
	SoPn CHAR(4) NOT NULL,
	MaVTu CHAR(4) NOT NULL,
	SlNhap CHAR(4) NOT NULL CHECK(SlNhap > 0),
	DgNhap MONEY NOT NULL CHECK(DgNhap > 0),
	PRIMARY KEY (SoPn, MaVTu),
	FOREIGN KEY (MaVTu) REFERENCES dbo.VATTU(MaVTu),
	FOREIGN KEY (SoPn) REFERENCES dbo.PNHAP(SoPn)
);
GO

CREATE TABLE PXUAT 
(
	SoPx CHAR(4) PRIMARY KEY NOT NULL,
	NgayXuat DATETIME DEFAULT GETDATE(),
	TenKh VARCHAR(100) NOT NULL
);
GO

CREATE TABLE CTPXUAT
(
	SoPx CHAR(4) NOT NULL,
	MaVTu CHAR(4) NOT NULL,
	SlXuat INT NOT NULL CHECK(SlXuat > 0),
	DgXuat MONEY NOT NULL CHECK(DgXuat > 0),
	PRIMARY KEY (SoPx, MaVTu),
	FOREIGN KEY (SoPx) REFERENCES dbo.PXUAT(SoPx),
	FOREIGN KEY (MaVTu) REFERENCES dbo.VATTU(MaVTu)
);
GO

CREATE TABLE TONKHO
(
	NamThang CHAR(6) NOT NULL,
	MaVTu CHAR(4) NOT NULL,
	SLDau INT NOT NULL CHECK(SLDau > 0),
	TongSLN INT NOT NULL CHECK(TongSLN > 0),
	TongSLX INT NOT NULL CHECK(TongSLX > 0),
	SLCuoi AS (SLDau + TongSLN - TongSLX) PERSISTED,
	PRIMARY KEY (NamThang, MaVTu),
	FOREIGN KEY (MaVTu) REFERENCES dbo.VATTU(MaVTu)
);
GO

INSERT INTO dbo.NHACC
(
    MaNhaCc,
    TenNhaCc,
    DiaChi,
    DienThoai
)
VALUES
(   'C01',     -- MaNhaCc - char(3)
    'Lê Quang Thành',     -- TenNhaCc - varchar(100)
    '54, Kim Mã, Cầu Giấy, Hà Nội',     -- DiaChi - varchar(200)
    '8781024' -- DienThoai - varchar(20)
),
(   'C02',     -- MaNhaCc - char(3)
    'Trần Quang Anh',     -- TenNhaCc - varchar(100)
    '145 Hùng Vương, Hải Dương',     -- DiaChi - varchar(200)
    '7698154' -- DienThoai - varchar(20)
),
(   'C03',     -- MaNhaCc - char(3)
    'Bùi Hồng Phương',     -- TenNhaCc - varchar(100)
    '154/85 Lê Chân, Hải Phòng',     -- DiaChi - varchar(200)
    '9600125' -- DienThoai - varchar(20)
),
(   'C04',     -- MaNhaCc - char(3)
    'Vũ Nhật Thắng',     -- TenNhaCc - varchar(100)
    '198/40 Hương Lộ 14 QTB, HCM',     -- DiaChi - varchar(200)
    '757757' -- DienThoai - varchar(20)
),
(   'C05',     -- MaNhaCc - char(3)
    'Nguyễn Thị Thúy',     -- TenNhaCc - varchar(100)
    '178 Nguyễn Đạt Luông, Đà Lạt',     -- DiaChi - varchar(200)
    '7964251' -- DienThoai - varchar(20)
),
(   'C07',     -- MaNhaCc - char(3)
    'Cao Minh Trung',     -- TenNhaCc - varchar(100)
    '125 Lê Quang Sung, Nha Trang',     -- DiaChi - varchar(200)
    DEFAULT -- DienThoai - varchar(20)
)
GO

INSERT INTO dbo.VATTU
(
    MaVTu,
    TenVTu,
    DvTinh,
    PhanTram
)
VALUES
(   'DD01',      -- MaVTu - char(4)
    'Đầu DVD Hatachi 1 đĩa',      -- TenVTu - varchar(100)
    'Bộ', -- DvTinh - varchar(10)
     40     -- PhanTram - real
),
(   'DD02',      -- MaVTu - char(4)
    'Đầu DVD Hatachi 3 đĩa',      -- TenVTu - varchar(100)
    'Bộ', -- DvTinh - varchar(10)
     40     -- PhanTram - real
),
(   'TL15',      -- MaVTu - char(4)
    'Tủ lạnh sanyo 150 lit',      -- TenVTu - varchar(100)
    'Cái', -- DvTinh - varchar(10)
     25     -- PhanTram - real
),
(   'TL90',      -- MaVTu - char(4)
    'Tủ lạnh sanyo 90 lit',      -- TenVTu - varchar(100)
    'Cái', -- DvTinh - varchar(10)
     20     -- PhanTram - real
),
(   'TV14',      -- MaVTu - char(4)
    'TiVi Sony 14 inches',      -- TenVTu - varchar(100)
    'Cái', -- DvTinh - varchar(10)
     15     -- PhanTram - real
),
(   'TV21',      -- MaVTu - char(4)
    'TiVi Sony 21 inches',      -- TenVTu - varchar(100)
    'Cái', -- DvTinh - varchar(10)
     10     -- PhanTram - real
),
(   'TV29',      -- MaVTu - char(4)
    'TiVi Sony 29 inches',      -- TenVTu - varchar(100)
    'Cái', -- DvTinh - varchar(10)
     10     -- PhanTram - real
),
(   'VD01',      -- MaVTu - char(4)
    'Đầu VCD Sony 1 đĩa',      -- TenVTu - varchar(100)
    'Bộ', -- DvTinh - varchar(10)
     30     -- PhanTram - real
),
(   'VD02',      -- MaVTu - char(4)
    'Đầu VCD Sony 3 đĩa',      -- TenVTu - varchar(100)
    'Bộ', -- DvTinh - varchar(10)
     30     -- PhanTram - real
)
GO 

INSERT INTO dbo.DONDH
(
    SoDh,
    NgayDh,
    MaNhaCc
)
VALUES
(   'D001',      -- SoDh - char(4)
    DEFAULT, -- NgayDh - datetime
    'C03'       -- MaNhaCc - char(3)
),
(   'D002',      -- SoDh - char(4)
    DEFAULT, -- NgayDh - datetime
    'C01'       -- MaNhaCc - char(3)
),
(   'D003',      -- SoDh - char(4)
    DEFAULT, -- NgayDh - datetime
    'C02'       -- MaNhaCc - char(3)
),
(   'D004',      -- SoDh - char(4)
    DEFAULT, -- NgayDh - datetime
    'C05'       -- MaNhaCc - char(3)
),
(   'D005',      -- SoDh - char(4)
    DEFAULT, -- NgayDh - datetime
    'C02'       -- MaNhaCc - char(3)
),
(   'D006',      -- SoDh - char(4)
    DEFAULT, -- NgayDh - datetime
    'C05'       -- MaNhaCc - char(3)
)
GO

INSERT INTO dbo.PNHAP
(
    SoPn,
    NgayNhap,
    SoDh
)
VALUES
(   'N001',      -- SoPx - char(4)
    DEFAULT, -- NgayNhap - datetime
    'D001'       -- TenKh - varchar(100)
),
(   'N002',      -- SoPx - char(4)
    DEFAULT, -- NgayNhap - datetime
    'D001'       -- TenKh - varchar(100)
),
(   'N003',      -- SoPx - char(4)
    DEFAULT, -- NgayNhap - datetime
    'D002'       -- TenKh - varchar(100)
),
(   'N004',      -- SoPx - char(4)
    DEFAULT, -- NgayNhap - datetime
    'D005'       -- TenKh - varchar(100)
)
GO

INSERT INTO dbo.CTDONDH
(
    SoDh,
    MaVTu,
    SlDat
)
VALUES
(   'D001',  -- SoDh - char(4)
    'DD01',  -- MaVTu - char(4)
     10 -- SlDat - int
),
(   'D001',  -- SoDh - char(4)
    'DD02',  -- MaVTu - char(4)
     15 -- SlDat - int
),
(   'D002',  -- SoDh - char(4)
    'VD02',  -- MaVTu - char(4)
     30 -- SlDat - int
),
(   'D003',  -- SoDh - char(4)
    'TV14',  -- MaVTu - char(4)
     10 -- SlDat - int
),
(   'D003',  -- SoDh - char(4)
    'TV29',  -- MaVTu - char(4)
     20 -- SlDat - int
),
(   'D004',  -- SoDh - char(4)
    'TL90',  -- MaVTu - char(4)
     10 -- SlDat - int
),
(   'D005',  -- SoDh - char(4)
    'TV14',  -- MaVTu - char(4)
     10 -- SlDat - int
),
(   'D005',  -- SoDh - char(4)
    'TV29',  -- MaVTu - char(4)
     20 -- SlDat - int
),
(   'D006',  -- SoDh - char(4)
    'TV14',  -- MaVTu - char(4)
     10 -- SlDat - int
),
(   'D006',  -- SoDh - char(4)
    'TV29',  -- MaVTu - char(4)
     20 -- SlDat - int
),
(   'D006',  -- SoDh - char(4)
    'VD01',  -- MaVTu - char(4)
     20 -- SlDat - int
)
GO

INSERT INTO dbo.CTPNHAP
(
    SoPn,
    MaVTu,
    SlNhap,
    DgNhap
)
VALUES
(   'N001',  -- SoPn - char(4)
    'DD01',  -- MaVTu - char(4)
    '8',  -- SlNhap - char(4)
     2500000 -- DgNhap - money
),
(   'N001',  -- SoPn - char(4)
    'DD02',  -- MaVTu - char(4)
    '10',  -- SlNhap - char(4)
     3500000 -- DgNhap - money
),
(   'N002',  -- SoPn - char(4)
    'DD01',  -- MaVTu - char(4)
    '2',  -- SlNhap - char(4)
     2500000 -- DgNhap - money
),
(   'N002',  -- SoPn - char(4)
    'DD02',  -- MaVTu - char(4)
    '5',  -- SlNhap - char(4)
     3500000 -- DgNhap - money
),
(   'N003',  -- SoPn - char(4)
    'VD02',  -- MaVTu - char(4)
    '30',  -- SlNhap - char(4)
     2500000 -- DgNhap - money
),
(   'N004',  -- SoPn - char(4)
    'TV14',  -- MaVTu - char(4)
    '5',  -- SlNhap - char(4)
     2500000 -- DgNhap - money
),
(   'N004',  -- SoPn - char(4)
    'TV29',  -- MaVTu - char(4)
    '12',  -- SlNhap - char(4)
     3500000 -- DgNhap - money
)
GO 

INSERT INTO dbo.PXUAT
(
    SoPx,
    NgayXuat,
    TenKh
)
VALUES
(   'X001',      -- SoPx - char(4)
    DEFAULT, -- NgayXuat - datetime
    'Nguyễn Ngọc Phương Nhi'       -- TenKh - varchar(100)
),
(   'X002',      -- SoPx - char(4)
    DEFAULT, -- NgayXuat - datetime
    'Nguyễn Hồng Phương'       -- TenKh - varchar(100)
),
(   'X003',      -- SoPx - char(4)
    DEFAULT, -- NgayXuat - datetime
    'Nguyễn Tuấn Tú'       -- TenKh - varchar(100)
)
GO 

INSERT INTO dbo.CTPXUAT
(
    SoPx,
    MaVTu,
    SlXuat,
    DgXuat
)
VALUES
(   'X001',  -- SoPn - char(4)
    'DD01',  -- MaVTu - char(4)
    '2',  -- SlNhap - char(4)
     3500000 -- DgNhap - money
),
(   'X002',  -- SoPn - char(4)
    'DD01',  -- MaVTu - char(4)
    '1',  -- SlNhap - char(4)
     3500000 -- DgNhap - money
),
(   'X002',  -- SoPn - char(4)
    'DD02',  -- MaVTu - char(4)
    '5',  -- SlNhap - char(4)
     4900000 -- DgNhap - money
),
(   'X003',  -- SoPn - char(4)
    'DD01',  -- MaVTu - char(4)
    '3',  -- SlNhap - char(4)
     3500000 -- DgNhap - money
),
(   'X003',  -- SoPn - char(4)
    'DD02',  -- MaVTu - char(4)
    '2',  -- SlNhap - char(4)
     4900000 -- DgNhap - money
),
(   'X003',  -- SoPn - char(4)
    'VD02',  -- MaVTu - char(4)
    '10',  -- SlNhap - char(4)
     3250000 -- DgNhap - money
)
GO

INSERT INTO dbo.TONKHO
(
    NamThang,
    MaVTu,
    SLDau,
    TongSLN,
    TongSLX
)
VALUES
(   '201201', -- NamThang - char(6)
    'DD01', -- MaVTu - char(4)
    1,  -- SLDau - int
    10,  -- TongSLN - int
    6   -- TongSLX - int
),
(   '201201', -- NamThang - char(6)
    'DD02', -- MaVTu - char(4)
    1,  -- SLDau - int
    15,  -- TongSLN - int
    7   -- TongSLX - int
),
(   '201201', -- NamThang - char(6)
    'VD02', -- MaVTu - char(4)
    1,  -- SLDau - int
    30,  -- TongSLN - int
    10   -- TongSLX - int
),
(   '201202', -- NamThang - char(6)
    'DD01', -- MaVTu - char(4)
    4,  -- SLDau - int
    1,  -- TongSLN - int
    1   -- TongSLX - int
),
(   '201202', -- NamThang - char(6)
    'DD02', -- MaVTu - char(4)
    8,  -- SLDau - int
    1,  -- TongSLN - int
    1   -- TongSLX - int
),
(   '201202', -- NamThang - char(6)
    'VD02', -- MaVTu - char(4)
    20,  -- SLDau - int
    1,  -- TongSLN - int
    1   -- TongSLX - int
),
(   '201202', -- NamThang - char(6)
    'TV14', -- MaVTu - char(4)
    5,  -- SLDau - int
    1,  -- TongSLN - int
    1   -- TongSLX - int
),
(   '201202', -- NamThang - char(6)
    'TV29', -- MaVTu - char(4)
    12,  -- SLDau - int
    1,  -- TongSLN - int
    1   -- TongSLX - int
)




