CREATE DATABASE QuanLyManNon
GO

USE QuanLyManNon

CREATE TABLE tblNhanVien (
	MaNhanVien VARCHAR(15) PRIMARY KEY,
	TenNhanVien NVARCHAR(100) NOT NULL,
	ChucVu NVARCHAR(150) NOT NULL,
	GioiTinh NVARCHAR(5)  NULL,
	DiaChi NVARCHAR(200) NOT NULL,
	NgaySinh DATE NOT NULL,
	SDT VARCHAR(15) NULL
);
GO

CREATE TABLE tblLop (
	MaLop VARCHAR(15) PRIMARY KEY,
	TenLop NVARCHAR(50) NOT NULL,
	MaGiaoVien VARCHAR(15) FOREIGN KEY REFERENCES tblNhanVien(MaNhanVien), 
	DiaChi NVARCHAR(200) NOT NULL,
	SiSo INT NOT NULL
);
GO

CREATE TABLE tblHocSinh (
	MaHocSinh INT IDENTITY(1,1) PRIMARY KEY,
	TenHocSinh NVARCHAR(100) NOT NULL,
	MaLop VARCHAR(15) FOREIGN KEY REFERENCES tblLop(MaLop), 
	GioiTinh NVARCHAR(5) NULL,
	NgaySinh DATE NOT NULL,
	Diachi NVARCHAR(200) NOT NULL,
	SDT TEXT NULL
);
GO

INSERT INTO tblNhanVien
VALUES ('QLHS001', N'Đồng Thị Thùy Linh', N'Giáo vụ', N'Nữ', N'Kiến Thụy - Hải Phòng', '1997-04-06', '0383639483');

INSERT INTO tblNhanVien
VALUES ('GV001', N'Nguyễn Thị Thúy Nga', N'Giáo viên', N'Nữ', N'Lạch Tray - Hải Phòng', '1997-12-03', '0373915205');

INSERT INTO tblNhanVien
VALUES ('GV002', N'Đoàn Xuân Vượng', N'Giáo viên', N'Nam', N'Vĩnh Bảo - Hải Phòng', '1996-09-06', '0225843620');
----------------------------------------
INSERT INTO tblLop
VALUES ('5T', N'Lớp 5 tuổi', 'GV001', N'Phòng 1 - Tầng 1', 0);

INSERT INTO tblLop
VALUES ('4T', N'Lớp 4 tuổi', 'GV002', N'Phòng 2 - Tầng 1', 0);
----------------------------------------
INSERT INTO tblHocSinh
VALUES (N'Cù Thế Huy', '4T', 'Nam', '2015-05-09', N'Hải Phòng', '0383412572');

INSERT INTO tblHocSinh
VALUES (N'Nguyễn Văn Bắc', '4T', 'Nam', '2015-05-21', N'Hải Phòng', '0352412572');

INSERT INTO tblHocSinh
VALUES (N'Trần Thị Bình', '4T', N'Nữ', '2015-10-09', N'Hải Phòng', '0383485572');

INSERT INTO tblHocSinh
VALUES (N'Trần Văn Ngọc', '5T', 'Nam', '2014-05-09', N'Hải Phòng', '0842684102');

INSERT INTO tblHocSinh
VALUES (N'Nguyễn Văn Thắng', '5T', 'Nam', '2014-05-21', N'Hải Phòng', '0311412572');

INSERT INTO tblHocSinh
VALUES (N'Trần Thị Kiều', '5T', N'Nữ', '2014-10-09', N'Hải Phòng', '0383005572');
----------------------------------------


