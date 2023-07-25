-- Buổi 3: 
 --Làm việc với T-SQL: DDL, DML, DCL
 --1. Biến , kiểu dữ liệu, phép toán, ...
 --Khai báo biến
 DECLARE @TenBien INT 
 -- Gán giá trị 
 SET @TenBien = 2 + 2 * (4 + (5 - 3))
 -- Lấy giá trị của biến: Print hoặc select 
 PRINT N'Giá trị ' + CAST(@TenBien AS VARCHAR)
 -- Giá trị bằng select 
 SELECT @TenBien = 1000
 --Lấy giá trị
 SELECT N'Giá trị ' + CONVERT(VARCHAR, @TenBien)
 GO
 -- Biến hệ thống 
 PRINT @@VERSION
 SELECT @@ROWCOUNT
 -- 2. DDL: (CREATE / ALTER / DROP: database, tablem views, ...)
 -- 2.1 Tạo csdl 
 CREATE DATABASE DEV2306LM_SQL35_LA03;
 GO
 USE DEV2306LM_SQL35_LA03
 GO
-- 2.2. Tạo đối tượng bảng trong csdl trong T-SQL(Create)
CREATE TABLE Employee 
(
	ID INT PRIMARY KEY,
	FULLNAME NVARCHAR(35),
	GENDER BIT,
	BIRTHDAY DATETIME,
	ADDRESS NVARCHAR(MAX),
	EMAIL VARCHAR(50),
	SALARY FLOAT
);
GO
-- 2.3. Sửa đổi Alter
-- Thêm một cột vào 
ALTER TABLE dbo.Employee ADD PHONE VARCHAR(13);
GO

-- 2.4 xóa đối tượng bảng 
--DROP TABLE dbo.Employee;
GO
--3. DML: SELECT, INSERT, UPDATE, DELETE -> TABLE, VIEW, ...
--3.1: INSERT 
-- Thêm một hoặc nhiều bản ghi vào bảng
/*
	- Dữ liệu chuỗi đặt trong ''
	- Dữ liệu số: 123
	- Dữ liệu ngày: 'yyyy/mm/dd'; 'mm/dd/yyyy'
	

	- Giá trị match các cột trong bảng
*/

SELECT * FROM dbo.Employee;
GO

-- 
INSERT INTO dbo.Employee VALUES
(111, N'Minh Thành', 1, '06-11-2001', N'25 Vũ Ngọc Phan', 'buiminhthanh116@gmail.com', 200000000)
GO

INSERT INTO dbo.Employee([ID], [FULLNAME], [GENDER], [BIRTHDAY], [ADDRESS], [EMAIL], [SALARY])
VALUES
(111, N'Minh Thành', 1, '06-11-2001', N'25 Vũ Ngọc Phan', 'buiminhthanh116@gmail.com', 200000000)
GO

-- Thêm nhiều bản ghi cùng lúc
INSERT INTO dbo.Employee(ID, FULLNAME, GENDER, SALARY) VALUES
(333, N'Nguyễn Văn A', 0, 1234),
(444, N'Nguyễn Văn B', 1, 1235),
(555, N'Nguyễn Văn C', 2, 1236),
(666, N'Nguyễn Văn D', 3, 1237);
GO

INSERT INTO dbo.Employee(ID, FULLNAME, GENDER, ADDRESS) 
SELECT 9, N'Nguyễn Văn E', 4, N'25 Vũ Ngọc Phan' UNION
SELECT 10, N'Nguyễn Văn G', 5, N'25 Vũ Ngọc Phan' UNION
SELECT 11, N'Nguyễn Văn H', 6, N'25 Vũ Ngọc Phan' UNION
SELECT 12, N'Nguyễn Văn K', 7, N'25 Vũ Ngọc Phan'
GO

SELECT * FROM dbo.Employee
GO

--3.2 Update DML -> sửa giá trị trong cột trên bảng
/*
	UPDATE <Table_name> [join...]
	SET <column_name> = <value1> [,...]
	WHERE <condition>
*/

-- cập nhật giá trị cột birthday là ngày hiện tại với điều hiện là birthday đang là null

UPDATE dbo.Employee 
SET BIRTHDAY = GETDATE()
-- SO sánh với giá trị null dùng IS
WHERE BIRTHDAY IS NULL
GO

SELECT * FROM dbo.Employee
GO

--2.3: DELETE -> Xóa 1 hay nhiều bản ghi trong bảng
/*
	DELETE <table_name>
	WHERE <condition>
*/

-- Xóa nhân viên có địa chỉ là null
DELETE dbo.Employee WHERE ADDRESS IS NULL;
GO

-- Xóa hết 
DELETE dbo.Employee
GO

-- Example: 
CREATE TABLE TABLE_TEMP
(
	ID INT IDENTITY PRIMARY KEY,
	NAME NVARCHAR(50)
);

GO

INSERT INTO dbo.TABLE_TEMP
SELECT N'Nguyễn Văn C' UNION
SELECT N'Nguyễn Văn D' 
GO

DELETE dbo.TABLE_TEMP WHERE NAME LIKE N'%d%'
SELECT * FROM dbo.TABLE_TEMP
GO

-- làm sạch bảng 
TRUNCATE TABLE dbo.TABLE_TEMP
GO
SELECT * FROM dbo.TABLE_TEMP
GO

--2.4: SELECT
-- truy vấn chọn / lock / trích -> dữ liệu trên bảng 
SELECT * FROM dbo.Employee
GO

-- Sắp xếp lương giảm dần
SELECT * FROM dbo.Employee ORDER BY SALARY DESC
GO

-- Sắp xếp lương tăng dần
SELECT * FROM dbo.Employee ORDER BY SALARY ASC
GO

-- Tìm kiếm lương > 0 
SELECT * FROM dbo.Employee WHERE SALARY > 0
GO
