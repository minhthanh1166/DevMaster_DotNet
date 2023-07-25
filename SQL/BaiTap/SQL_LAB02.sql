
-- Tạo database
CREATE DATABASE Lab02;

USE Lab02;

GO

-- Tạo biến và gán giá trị

DECLARE @Name NVARCHAR(70) = N'Bui Minh Thanh';
PRINT @Name

DECLARE @Age INT = 21;
PRINT @Age

GO

-- Tạo bảng 

CREATE TABLE dbo.Employee 
(
	Id INT PRIMARY KEY IDENTITY,
	FullName NVARCHAR(35),
	Gender BIT,
	BirthDay DATETIME,
	Address NVARCHAR(MAX),
	Email VARCHAR(50),
	Salary FLOAT
);

GO

-- Thêm column phone 

ALTER TABLE dbo.Employee ADD phone VARCHAR(20);

GO

-- khởi tạo 5 bản ghi

INSERT INTO dbo.Employee 
(
	FullName,
	Gender,
	BirthDay,
	Address,
	Email,
	Salary
) VALUES
(N'Bui Minh Thành', 1, '2001-06-11', N'Quỳnh Phụ, Thái Bình', 'buiminhthanh116@gmail.com', 500000000),
(N'Đàm Quốc Dân', 1, '2002-12-28', N'Hải Hậu, Nam Định', 'maicute@gmail.com', 3000000),
(N'Giàng A Xênh', 1, '1991-07-22', N'Chí Linh, Hải Dương', 'doremon@gmail.com', 100000),
(N'Tòng A Hùng', 1, '2005-10-14', N'Bắc Từ Liêm, Hà Nội', 'hackerhaohan@gmail.com', 70000),
(N'Luân Giám Tài', 1, '2003-02-18', N'Từ Sơn, Bắc Ninh', 'chuahe123@gmail.com', 40000);

GO

SELECT * FROM dbo.Employee;

GO 

DELETE FROM dbo.Employee;

GO

-- Đưa ra tất cả nhân viên có lương > 2000000

SELECT * FROM dbo.Employee WHERE Salary > 2000000;

SELECT FullName, Salary FROM dbo.Employee WHERE Salary > 2000000;

GO

-- Đưa ra danh sách nhân viên sinh nhật trong tháng này

SELECT FullName, BirthDay FROM dbo.Employee WHERE DATEPART(MONTH, BirthDay) = MONTH(GETDATE());

-- Đưa ra danh sách nhân viên hiển thị kèm thêm cột tuổi và cột BirthDay hiển thị dạng dd/MM/yyyy

SELECT FullName, 
       CASE WHEN Gender = 1 THEN 'Nam' 
            WHEN Gender = 2 THEN 'Nữ' 
            ELSE 'Khác' 
       END AS N'Giới tính', 
       FORMAT(BirthDay, 'dd/MM/yyyy') AS BirthDay, 
       DATEDIFF(YEAR, BirthDay, GETDATE()) AS Tuổi
FROM dbo.Employee;

GO

-- Đưa ra những nhân viên có địa chỉ ở Hà Nội
SELECT FullName, Address
FROM dbo.Employee
WHERE Address LIKE N'%Hà Nội%';

GO

-- Sửa tên nhân viên có mã là 1 thành tên "John"
UPDATE dbo.Employee
SET FullName = N'John'
WHERE Id = 22;
GO
SELECT * FROM dbo.Employee;

GO

-- Xóa những nhân viên có tuổi > 25
DELETE FROM dbo.Employee 
WHERE DATEDIFF(YEAR, BirthDay, GETDATE()) > 25;
SELECT FullName, DATEDIFF(YEAR, BirthDay, GETDATE()) AS Tuổi 
FROM dbo.Employee;

GO

-- Copy những nhân viên có tuổi > 20 sang bảng mới

	-- Tạo bảng mới 
CREATE TABLE dbo.NewEmployees
(
    Id INT PRIMARY KEY,
    FullName NVARCHAR(35),
    Gender BIT,
    BirthDay DATETIME,
    Address NVARCHAR(MAX),
    Email VARCHAR(50),
    Salary FLOAT
);
GO
	-- Sao chép những nhân viên có tuổi > 20 sang bảng mới
INSERT INTO dbo.NewEmployees (Id, FullName, Gender, BirthDay, Address, Email, Salary)
SELECT Id, FullName, Gender, BirthDay, Address, Email, Salary
FROM dbo.Employee
WHERE DATEDIFF(YEAR, BirthDay, GETDATE()) > 20;
GO
SELECT * FROM dbo.NewEmployees;
GO
SELECT * FROM dbo.Employee;

GO

-- Đếm số nhân viên
SELECT COUNT(*) AS N'Số nhân viên' FROM dbo.Employee;