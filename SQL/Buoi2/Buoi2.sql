/*
1.1. Kiểu số nguyên: tinyint, smallint, int, BigInt
1.2. Kiểu số thực: real, float, double
1.3. Kiểu tiền tệ: money
1.4. Kiểu ngày giờ: smallDatetime, datetime
1.5. Kiểu ký tự non-unicode: char, varchar, text
1.6. Kiểu ký tự unicode: nchar, nvarchar, ntext
1.7. Kiểu logic: bit (null, 0, 1)
1.8. Kiểu bí danh: được tạo từ các kiểu dữ liệu cơ bản trong SQL
*/

CREATE TYPE myPhone FROM VARCHAR(10) NOT NULL;
GO

-----------------
--2. Biến
--2.1: Biến hệ thống 
PRINT @@VERSION
GO
SELECT @@VERSION
GO
--2.2. Biến do người dùng định nghĩa.
--2.2.1: Khai báo 
DECLARE @Ten NVARCHAR(50)
--2.2.2: Gán giá trị 
SET @Ten = N'Nguyễn Long Lanh';
--or
SELECT @Ten = N'Trần Nhật'
--2.2.3: Hiển thị
SELECT @Ten
PRINT @Ten
GO

--3. Biểu thức các phép toán
DECLARE @c INT, @b INT, @a INT
SET @a = 100
SET @b = 200;
SET @c = @a + @b;
PRINT @a
PRINT @b
PRINT @c
GO

CREATE DATABASE Buoi_02;
GO
USE Buoi_02;
GO

CREATE TABLE Students 
(
	Id INT NOT NULL PRIMARY KEY IDENTITY,
    firstName NVARCHAR(20),
	lastName NVARCHAR(20),
	age TINYINT
);
GO

INSERT INTO Students 
VALUES 
(N'Bùi Minh', N'Thành', 21),
(N'Nguyễn Tiến', N'Đạt', 22)
GO

SELECT firstName + ' ' + lastName AS fullName
FROM Students;
GO
SELECT * FROM Students; 
GO
--4. Cấu trúc điều kiển
--4.1: Lựa chọn IF
/*
IF (BTDK)
BEGIN
	--Các câu lệnh
END
---
IF(BTDK)
	BEGIN
		-- Câu lệnh thực hiện khi điều kiện đúng
	END
ELSE
	BEGIN
		-- Câu điều kiện sai
	END
GO
*/

-- 4.2. Cấu trúc lặp 
/*
WHILE(DK)
BEGIN
	-- Các câu lệnh
END 
*/

-- ví dụ:
DECLARE @i INT
SET @i = 1;
WHILE(@i <= 10)
BEGIN
	PRINT @i
	SET @i+=1;
END
GO
---------------
--5. Các câu lệnh DDL - Table
-- Các constraint trên bảng
-- NOTNULL: Cột không cho phép null khi thêm mới, sửa đổi 
-- IDENTITY: Cột giá trị tự động tăng khi thêm mới
	-- start = 1; step = 1; identity(1,1)
-- Ràng buộc PRIMARY KEY: Khóa chính của bảng (Có thể tạo trên 1 cột hoặc nhiều cột)
-- UNIQUE: Cột có giá trị duy nhất trên tất cả các hàng, cho phép chứa 
	-- Giá trị null (Cho phép giá trị null)

