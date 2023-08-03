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

SELECT MaSV, Phai, MaKH,HocBong,  [Mức học bổng] = CASE WHEN HocBong > 500000 THEN N'Học bổng cao' 
											            WHEN HocBong < 500000 THEN N'Học bổng trung bình' END 
													
FROM dbo.SinhVien 

/*
5. Cho biết điểm thi của các sinh viên, gồm các thông tin: Họ tên sinh viên, Mã  môn học, Điểm.
Kết quả sẽ được sắp theo thứ tự Họ tên sinh viên và mã môn  học tăng dần 
*/

SELECT  [Họ Tên] = S.HoSV + ' ' + S.TenSV, MH.MaMH, KQ.Diem
FROM dbo.SinhVien AS S
RIGHT JOIN dbo.Ketqua AS KQ ON S.MaSV = KQ.MaSV
LEFT JOIN dbo.MonHoc AS MH ON KQ.MaMH = MH.MaMH
ORDER BY S.HoSV + ' ' + S.TenSV ASC , MH.MaMH ASC


/*
6. Danh sách sinh viên của khoa Anh văn, điều kiện lọc phải sử dụng tên khoa, gồm  các thông tin sau:
Họ tên sinh viên, Giới tính, Tên khoa. Trong đó, Giới tính sẽ  hiển thị dạng Nam/Nữ  
*/

SELECT [Họ Tên] = HoSV + ' ' + TenSV, CASE WHEN Phai = 0 THEN 'Nam' WHEN Phai = 1 THEN N'Nữ' END, K.TenKH
FROM dbo.SinhVien AS S
RIGHT JOIN dbo.Khoa AS K ON S.MaKH = K.MaKH
WHERE K.TenKH = N'Anh Văn'

/*
7. Liệt kê bảng điểm của sinh viên khoa Tin Học, gồm các thông tin:Tên khoa, Họ  tên sinh viên,
Tên môn học, Số tiết, Điểm  
*/

SELECT K.TenKH, [Họ Tên] = SV.HoSV + ' ' + SV.TenSV, MH.TenMH, MH.Sotiet, KQ.Diem, K.TenKH
FROM dbo.SinhVien AS SV
RIGHT JOIN dbo.Ketqua AS KQ ON SV.MaSV = KQ.MaSV
RIGHT JOIN dbo.MonHoc AS MH ON KQ.MaMH = MH.MaMH
RIGHT JOIN dbo.Khoa AS K ON SV.MaKH = K.MaKH
WHERE K.TenKH = N'Tin học'


/*
8. Kết quả học tập của sinh viên, gồm các thông tin: Họ tên sinh viên, Mã khoa,
Tên môn học, Điểm thi, Loại. Trong đó, Loại sẽ là Giỏi nếu điểm thi > 8, từ 6 đến  8 thì Loại là Khá,
nhỏ hơn 6 thì loại là Trung Bình
*/

SELECT [Họ Tên] = S.HoSV + ' ' + S.TenSV, S.MaKH, MH.TenMH, KQ.Diem,
[Loại] = CASE WHEN KQ.Diem > 8 THEN N'Giỏi' 
			  WHEN KQ.Diem BETWEEN 6 AND 8 THEN N'Khá'
			  WHEN KQ.Diem < 6 THEN N'Trung bình' END 
FROM dbo.SinhVien AS S
RIGHT JOIN dbo.Ketqua AS KQ ON S.MaSV = KQ.MaSV
JOIN dbo.MonHoc AS MH ON KQ.MaMH = MH.MaMH

/*
1. Cho biết trung bình điểm thi theo từng môn, gồm các thông tin: Mã môn, Tên  môn, Trung bình điểm thi  
*/

SELECT MH.MaMH, MH.TenMH, [Điểm trung bình] = AVG(KQ.Diem) 
FROM dbo.MonHoc AS MH
RIGHT JOIN dbo.Ketqua AS KQ ON MH.MaMH = KQ.MaMH
GROUP BY  MH.MaMH, MH.TenMH

/*
2. Danh sách số môn thi của từng sinh viên, gồm các thông tin: Họ tên sinh viên,  Tên khoa, Tổng số môn thi 
*/

SELECT  [Họ Tên] = SV.HoSV + ' ' + SV.TenSV, K.TenKH, [Tổng số môn thi] = COUNT(KQ.MaMH)
FROM dbo.MonHoc AS MH 
RIGHT JOIN dbo.Ketqua AS KQ ON MH.TenMH = KQ.MaMH
LEFT JOIN dbo.SinhVien AS SV ON KQ.MaSV = SV.MaSV
LEFT JOIN dbo.Khoa AS K ON SV.MaKH = K.MaKH
GROUP BY SV.HoSV + ' ' + SV.TenSV, K.TenKH


/*
3. Tổng điểm thi của từng sinh viên, các thông tin: Tên sinh viên, Tên khoa, Phái,  Tổng điểm thi  c
*/

SELECT SV.TenSV, K.TenKH, SV.Phai, [Tổng điểm thi] = SUM(KQ.Diem)
FROM dbo.Ketqua AS KQ 
LEFT JOIN dbo.SinhVien AS SV ON KQ.MaSV = SV.MaSV
LEFT JOIN dbo.Khoa AS K ON SV.MaKH = K.MaKH
GROUP BY SV.TenSV, K.TenKH, SV.Phai

/*
4. Cho biết tổng số sinh viên ở mỗi khoa, gồm các thông tin: Tên khoa, Tổng số sinh  viên  
*/

SELECT K.TenKH, [Tổng số sinh viên] = COUNT(SV.MaSV)
FROM dbo.SinhVien AS SV
RIGHT JOIN dbo.Khoa AS K ON SV.MaKH = K.MaKH
GROUP BY K.TenKH

/*
5. Cho biết điểm cao nhất của mỗi sinh viên, gồm thông tin:Họ tên sinh viên, Điểm  
*/
SELECT [Họ Tên] = S.HoSV + ' ' + S.TenSV, KQ.Diem
FROM dbo.SinhVien AS S
LEFT JOIN dbo.Ketqua AS KQ ON S.MaSV = KQ.MaSV

/*
6.Thông tin của môn học có số tiết nhiều nhất: Tên môn học, Số tiết  
*/
SELECT TOP 10 TenMH, Sotiet FROM dbo.MonHoc ORDER BY Sotiet DESC

SELECT TOP 3 TenMH, Sotiet FROM dbo.MonHoc ORDER BY Sotiet ASC

/*
7. Cho biết học bổng cao nhất của từng khoa, gồm Mã khoa, Tên khoa, Học bổng  cao nhất  
*/
SELECT K.MaKH, K.TenKH, [Học bổng] = MAX(S.HocBong)
FROM dbo.Khoa AS K
LEFT JOIN dbo.SinhVien AS S ON K.MaKH = S.MaKH
GROUP BY K.MaKH, K.TenKH

-- Học bổng thấp nhất 
SELECT K.MaKH, K.TenKH, MIN(S.HocBong) AS [Học bổng thấp nhất]
FROM dbo.Khoa AS K
LEFT JOIN dbo.SinhVien AS S ON K.MaKH = S.MaKH
GROUP BY K.MaKH, K.TenKH

/*
8. Cho biết điểm cao nhất của mỗi môn, gồm: Tên môn, Điểm cao nhất  
*/

SELECT TenMH, [Điểm cao nhất] = MAX(KQ.Diem)
FROM dbo.MonHoc AS MH
RIGHT JOIN dbo.Ketqua AS KQ ON MH.MaMH = KQ.MaMH
GROUP BY MH.TenMH, KQ.Diem
ORDER BY KQ.Diem DESC

/*
9. Thống kê số sinh viên học của từng môn, thông tin có: Mã môn, Tên môn, Số  sinh viên đang học  
*/
SELECT MH.MaMH, MH.TenMH, [Số sinh viên đang học] = COUNT(KQ.MaSV)
FROM dbo.SinhVien AS S
RIGHT JOIN dbo.Ketqua AS KQ ON S.MaSV = KQ.MaSV
RIGHT JOIN dbo.MonHoc AS MH ON KQ.MaMH = MH.MaMH
GROUP BY MH.MaMH, MH.TenMH


/*
10.Cho biết môn nào có điểm thi cao nhất, gồmcác thông tin: Tên môn, Số tiết, Tên  sinh viên, Điểm  
*/
SELECT MH.TenMH, MH.Sotiet, S.TenSV, KQ.Diem, [Môn điểm thi cao nhất] = MAX(KQ.Diem)
FROM dbo.SinhVien AS S
RIGHT JOIN dbo.Ketqua AS KQ ON S.MaSV = KQ.MaSV
RIGHT JOIN dbo.MonHoc AS MH ON KQ.MaMH = MH.MaMH
GROUP BY MH.TenMH, MH.Sotiet, S.TenSV, KQ.Diem
ORDER BY KQ.Diem DESC

/*
11.Cho biết khoa nào có đông sinh viên nhất, gồm Mã khoa, Tên khoa, Tổng số sinh  viên  
*/

SELECT DISTINCT K.MaKH, K.TenKH, [Tổng số sinh viên] = COUNT(S.MaSV)
FROM dbo.SinhVien AS S
RIGHT JOIN dbo.Khoa AS K ON S.MaKH = K.MaKH
GROUP BY K.MaKH, K.TenKH
ORDER BY COUNT(S.MaSV) DESC

/*
12.Cho biết khoa nào có sinh viên lảnh học bổng cao nhất, gồm các thông tin sau: 
Tên khoa, Họ tên sinh viên, Học bổng 
*/
SELECT K.TenKH, S.HoSV, S.TenSV, S.HocBong
FROM dbo.SinhVien AS S
RIGHT JOIN dbo.Khoa AS K ON S.MaKH = K.MaKH
ORDER BY S.HocBong DESC


/*
13.Cho biết sinh viên của khoa Tin học có có học bổng cao nhất, gồm các thông tin:
Mã sinh viên, Họ sinh viên, Tên sinh viên, Tên khoa, Học bổng  
*/




