USE QLSINHVIEN
GO

/*
17. Danh sách các sinh viên của khoa Anh văn và khoa Triết,
gồm các thông tin: Mã  sinh viên, Mã khoa, Phái. 
*/

SELECT S.MaSV, K.MaKH, S.Phai
FROM dbo.SinhVien AS S
RIGHT JOIN dbo.Khoa AS K ON S.MaKH = K.MaKH
WHERE K.MaKH = 'AV' AND K.MaKH = 'AV'


/*
18. Cho biết những sinh viên có ngày sinh từ ngày 01/01/1986 đến ngày  05/06/1992, 
gồm các thông tin: Mã sinh viên, Ngày sinh, Nơi sinh, Học bổng.  
*/

SELECT MaSV, NgaySinh, NoiSinh, HocBong
FROM dbo.SinhVien
WHERE NgaySinh BETWEEN '1986-01-01' AND '1992-06-05'
ORDER BY NgaySinh ASC

/*
Danh sách những sinh viên có học bổng từ 200,000 đến 800,000, 
gồm các thông  tin: Mã sinh viên, Ngày sinh, Phái, Mã khoa.  
*/

SELECT S.MaSV, S.NgaySinh, S.Phai, K.MaKH, S.HocBong
FROM dbo.SinhVien AS S
RIGHT JOIN dbo.Khoa AS K ON S.MaKH = K.MaKH
WHERE S.HocBong BETWEEN 200000 AND 800000

/*
20. Cho biết những môn học có số tiết lớn hơn 40 và nhỏ hơn 60,
gồm các thông  tin: Mã môn học, Tên môn học, Số tiết.  
*/

SELECT MaMH, TenMH, Sotiet
FROM dbo.MonHoc
WHERE Sotiet > 40 AND Sotiet < 60

/*
21. Liệt kê những sinh viên nam của khoa Anh văn,
gồm các thông tin: Mã sinh viên,  Họ tên sinh viên, Phái.  
*/

SELECT S.MaSV, [Họ Tên] = S.HoSV + ' ' + S.TenSV, S.Phai, S.MaKH
FROM dbo.SinhVien AS S
WHERE S.Phai = 0 AND S.MaKH = 'AV'

/*
22. Danh sách sinh viên có nơi sinh ở Hà Nội và ngày sinh sau ngày 01/01/1990,
gồm các thông tin: Họ sinh viên, Tên sinh viên, Nơi sinh, Ngày sinh
*/

SELECT HoSV, TenSV, NoiSinh, NgaySinh
FROM dbo.SinhVien
WHERE NoiSinh = N'Hà Nội' AND NgaySinh > '1990-01-01'

/*
23. Liệt kê những sinh viên nữ, tên có chứa chữ N.  
*/


SELECT *
FROM dbo.SinhVien
WHERE TenSV LIKE '%N%'

/*
24. Danh sách các nam sinh viên khoa Tin Học có ngày sinh sau ngày 30/5/1986. 
*/

SELECT *
FROM dbo.SinhVien
WHERE MaKH = 'TH' AND NgaySinh < '1986-05-30' AND Phai = 0

/*
25. Liệt kê danh sách sinh viên gồm các thông tin sau: Họ và tên sinh viên,
Giới tính,  Ngày sinh. Trong đó Giới tính hiển thị ở dạng Nam/Nữ 
tuỳ theo giá trị của field  Phai là True hay False.  
*/

SELECT [Họ Tên] = HoSV + ' ' + TenSV, 
  CASE Phai 
  WHEN 0 THEN 'Nam'
  WHEN 1 THEN N'Nữ'
  END 
, NgaySinh
FROM dbo.SinhVien

/*
26. Cho biết danh sách sinh viên gồm các thôngtin sau: Mã sinh viên, Tuổi, Nơi sinh,
Mã khoa. Trong đó Tuổi sẽ được tính bằng cách lấy năm hiện hành trừ cho năm  sinh  
*/

SELECT MaSV, [Tuổi] = YEAR(GETDATE()) - YEAR(NgaySinh), NoiSinh, MaKH
FROM dbo.SinhVien

/*
27. Cho biết những sinh viên có tuổi lớn hơn 30, thông tin gồm: Họ tên sinh viên,
Tuổi, Học bổng  
*/

SELECT [Họ Tên] = S.HoSV + ' ' + S.TenSV, [Tuổi] = YEAR(GETDATE()) - YEAR(S.NgaySinh), S.HocBong
FROM dbo.SinhVien AS S
WHERE  YEAR(GETDATE()) - YEAR(S.NgaySinh) > 30

/*
28. Danh sách những sinh viên có tuổi từ 20 đến 30, thông tin gồm: Họ tên sinh  viên,
Tuổi, Tên khoa 
*/

SELECT [Họ Tên] = S.HoSV + ' ' + S.TenSV, [Tuổi] = YEAR(GETDATE()) - YEAR(S.NgaySinh), K.TenKH
FROM dbo.SinhVien AS S
RIGHT JOIN dbo.Khoa AS K ON S.MaKH = K.MaKH
WHERE YEAR(GETDATE()) - YEAR(S.NgaySinh) BETWEEN 20 AND 30

/*
1. Liệt kê danh sách sinh viên gồm các thông tin sau: Họ và tên sinh viên, Giới tính,
Tuổi, Mã khoa. Trong đó Giới tính hiển thị ởdạng Nam/Nữ tuỳ theo giá trị của
field Phai là True hay False, Tuổi sẽ được tính bằng cách lấy năm hiện hành trừ 
cho năm sinh. Danh sách sẽ được sắp xếp theo thứ tự Tuổi giảm dần  
*/

SELECT [Họ Tên] = S.HoSV + ' ' + S.TenSV,
[Giới tính] = CASE S.Phai 
					WHEN 1 THEN N'Nữ'
					WHEN 0 THEN 'Nam'
					END,
[Tuổi] = YEAR(GETDATE()) - YEAR(S.NgaySinh),
S.MaKH
FROM dbo.SinhVien AS S
ORDER BY YEAR(GETDATE()) - YEAR(S.NgaySinh) DESC 

/*
2. Danh sách sinh viên sinh vào tháng 2 năm 1994, gồm các thông tin: Họ tên sinh  viên,
Phái, Ngày sinh. Trong đó, Ngày sinh chỉ lấy giá trị ngày của trường  NGAYSINH.  
*/

SELECT [Họ Tên] = S.HoSV + ' ' + S.TenSV, S.Phai, CONVERT(DATE, S.NgaySinh) AS [Ngày sinh]
FROM dbo.SinhVien AS S
WHERE MONTH(S.NgaySinh) = 2 AND YEAR(S.NgaySinh) = 1994

/*
3. Sắp xếp dữ liệu giảm dần theo cột Ngày sinh  
*/

SELECT [MaSV], [HoSV], [TenSV], [Phai], CONVERT(DATE, [NgaySinh]) , [NoiSinh], [MaKH], [HocBong], [DiemTrungBinh]
FROM dbo.SinhVien
ORDER BY NgaySinh DESC

/*
4. Cho biết thông tin về mức học bổng của các sinh viên, gồm: Mã sinh viên,
Phái,  Mã khoa, Mức học bổng. Trong đó, mức học bổng sẽ hiển thị là “Học bổng cao”
nếu giá trị của field học bổng lớn hơn 500,000 và ngược lại hiển thị là “Mức
trung bình”  
*/

SELECT MaSV, Phai, MaKH, 
FROM dbo.SinhVien