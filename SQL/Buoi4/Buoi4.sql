USE DEV2306_SQL_04
GO 

CREATE VIEW vw_GetStudents
AS
	SELECT StudentId, [Fullname] = LastName + ' ' + FirstName
	FROM [dbo].[Student]
GO

SELECT * FROM vw_GetStudents

DROP VIEW vw_GetStudents
GO



--2. Store Procedure
--2.1. Tạo thủ tục người dùng - Đơn giản 
-- Tạo thủ tục lấy ra danh sách nhân viên 
CREATE PROC spud_ListStudent 
AS 
	SELECT *
	FROM dbo.Student
GO 

-- Gọi thực hiện thủ tục 
EXEC spud_ListStudent
GO

EXEC spud_ListStudent WITH RECOMPILE
GO

--2.2 Thêm các tùy chọn vào thủ tục: encryptyion / recompile
-- sửa đổi thì dùng lệnh
ALTER PROC spud_ListStudent
WITH ENCRYPTION, RECOMPILE
AS 
	SELECT *
	FROM dbo.Student
GO 
-- 2.3: Xóa thủ tục 
DROP PROC dbo.spud_ListStudent
GO

--2.4 thủ tục với tham số đầu vào 
-- tạo thủ tục hiển thị với danh sách sinh viên theo mã lớp theo người dùng truyền vào
CREATE PROC spud_GetStudentByClassId
	-- Tham số đầu vào 
	@ClassId INT
	WITH ENCRYPTION, RECOMPILE
AS 
	SELECT *
	FROM dbo.Student
	WHERE ClassId = @ClassId
GO
-- Gọi thực thi
EXEC dbo.spud_GetStudentByClassId @ClassId = 4 -- int
GO 

-- Ví dụ:
-- Tạo thủ tục cho hành động thêm mới trên bảng class
-- Tham số đầu vào input: Tương ứng với các cột
-- Kiểm tra khóa chính không được trùng

SELECT * FROM dbo.Class
GO 

CREATE PROC spud_CreateTables
	@ClassName VARCHAR(10) 
	WITH ENCRYPTION, RECOMPILE
AS 
	IF NOT EXISTS (
		SELECT 1 FROM dbo.Class WHERE ClassName = @ClassName
	)
		BEGIN
			INSERT INTO dbo.Class
			VALUES (@ClassName);
			SELECT * FROM dbo.Class
			SELECT N'Thêm mới thành công!' AS [Thêm mới];
		END 
	ELSE 
		BEGIN
			PRINT N'Thêm mới thất bại!';
		END
GO 

drop PROC  dbo.spud_CreateTables

EXEC spud_CreateTables @ClassName = 'Oknhe'
GO


CREATE PROC spud_ClassInsert 
	-- Tham số truyền vào 
	@ClassId INT,
	@ClassName VARCHAR(10)
	WITH ENCRYPTION, RECOMPILE
AS 
	-- Kiểm tra 
	IF EXISTS(SELECT 1 FROM  dbo.Class WHERE ClassId = @ClassId)
		BEGIN 
			RAISERROR(N'Mã lớp đã tồn tại', 16,1);
			RETURN 0
		END 
	ELSE 
		BEGIN 
			INSERT INTO dbo.Class
			VALUES (@ClassName)
			RETURN 1
		END 
GO

-- Test 
DECLARE @res BIT  
EXEC @res = dbo.spud_ClassInsert @ClassId = 1,   -- int
                                 @ClassName = 'abs' -- varchar(10)
PRINT @res
GO 

-- Xây dựng chức năng sửa, xóa trên bảng class
CREATE PROC spud_ClassUpdate
	@ClassId int,
	@ClassName varchar(10)
	WITH ENCRYPTION, RECOMPILE
AS 
	IF NOT EXISTS(SELECT 1 FROM dbo.Class WHERE ClassId = @ClassId)
	BEGIN 
		RAISERROR(N'Update không thành công!', 16,1);
		RETURN 0
	END

	UPDATE dbo.Class 
	SET ClassName = @ClassName
	WHERE ClassId = @ClassId
	RETURN 1
GO 

SELECT * FROM dbo.Class
GO


DECLARE @res INT
EXEC @res = dbo.spud_ClassUpdate @ClassId = 10,   -- int
                                 @ClassName = 'cmm part 3' -- varchar(10)
PRINT @res
SELECT * FROM dbo.Class
GO

CREATE PROC spud_ClassDelete
	@ClassId INT 
	WITH ENCRYPTION, RECOMPILE 
AS 
	IF NOT EXISTS (SELECT 1 FROM dbo.Class WHERE ClassId = @ClassId)
	BEGIN
		RAISERROR(N'Delete không thành công!', 16, 1);
		RETURN 0
	END
	
	DELETE FROM dbo.Class WHERE ClassId = @ClassId
	RETURN 1
GO 


DECLARE @res INT 
EXEC @res = dbo.spud_ClassDelete @ClassId = 10 -- int
PRINT @res
SELECT * FROM dbo.Class
GO 

--2.5. Thủ tục có tham số đầu ra: OUTPUT
-- Viết thủ tục tính toán số sinh viên từng lớp 
/*
	Input: @ClassId
	Output: @Tong
*/

CREATE PROC spud_TotalStudentByClassId
	-- Input 
	@ClassId int,
	-- Output
	@Total int OUTPUT
	WITH ENCRYPTION, RECOMPILE
AS 
	SELECT @Total = COUNT(StudentId) 
	FROM dbo.Student
	WHERE ClassId = @ClassId
GO 

--2.6. thủ tục có tham số tùy chọn (có thể truyền giá trị hoặc không)
/*
Sửa đổi lại ví dụ 2.5; nếu người dùng mà không chọn mã lớp thì tính 
tổng tất cả sinh viên

*/

ALTER PROC spud_TotalStudentByClassId
	-- Input 
	@ClassId INT = NULL ,
	-- Output
	@Total int OUTPUT
	WITH ENCRYPTION, RECOMPILE
AS 
	IF(@ClassId IS NULL)
		SELECT @Total = COUNT(StudentId) 
		FROM dbo.Student
	ELSE 
		SELECT @Total = COUNT(StudentId) 
		FROM dbo.Student
		WHERE ClassId = @ClassId
GO 

DECLARE @total INT 
EXEC dbo.spud_TotalStudentByClassId  @Total=@total OUTPUT
PRINT N'Tổng số: ' +  CAST(@total AS NVARCHAR)

