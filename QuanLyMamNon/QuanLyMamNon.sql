CREATE DATABASE QuanLyManNon
GO

USE QuanLyManNon

CREATE TABLE tblNhanVien (
	MaNhanVien VARCHAR(10) PRIMARY KEY,
	TenNhanVien NVARCHAR(50) NOT NULL,
	ChucVu NVARCHAR(50) NOT NULL,
	GioiTinh NVARCHAR(5)  NULL,
	DiaChi NVARCHAR(100) NOT NULL,
	NgaySinh DATE NOT NULL,
	SDT TEXT NULL
);
GO

CREATE TABLE tblLop (
	MaLop VARCHAR(5) PRIMARY KEY,
	TenLop NVARCHAR(50) NOT NULL,
	MaGiaoVien VARCHAR(10) FOREIGN KEY REFERENCES tblNhanVien(MaNhanVien), 
	DiaChi NVARCHAR(100) NOT NULL
);
GO

CREATE TABLE tblHocSinh (
	MaHocSinh INT IDENTITY(1,1) PRIMARY KEY,
	TenHocSinh NVARCHAR(50) NOT NULL,
	MaLop VARCHAR(5) FOREIGN KEY REFERENCES tblLop(MaLop), 
	GioiTinh NVARCHAR(5) NULL,
	NgaySinh DATE NOT NULL,
	Diachi NVARCHAR(100) NOT NULL,
	SDT TEXT NULL,
	TenPhuHuynh NVARCHAR(50) NOT NULL,
	BanSaoGiayKhaiSinh NVARCHAR(10) NULL,
	BanSaoSoHoKhau NVARCHAR(10) NULL,
	BanSaoTCC NVARCHAR(10) NULL
);
GO

CREATE TABLE tblTaiKhoan
(
	TaiKhoan VARCHAR(10) NOT NULL,
	MatKhau VARCHAR(30) NOT NULL,
	ChucVu  NVARCHAR(50) NOT NULL
)

INSERT INTO tblNhanVien
VALUES ('CBTS001', N'Đồng Thị Thùy Linh', N'Cán bộ tuyển sinh', N'Nữ', N'Kiến Thụy - Hải Phòng', '1997-04-06', '0383639483');

INSERT INTO tblNhanVien
VALUES ('GV001', N'Nguyễn Thị Thúy Nga', N'Giáo viên', N'Nữ', N'Lạch Tray - Hải Phòng', '1997-12-03', '0373915205');

INSERT INTO tblNhanVien
VALUES ('GV002', N'Đoàn Xuân Vượng', N'Giáo viên', N'Nam', N'Vĩnh Bảo - Hải Phòng', '1996-09-06', '0225843620');
----------------------------------------
INSERT INTO tblLop
VALUES ('5T', N'Lớp 5 tuổi', 'GV001', N'Phòng 1 - Tầng 1');

INSERT INTO tblLop
VALUES ('4T', N'Lớp 4 tuổi', 'GV002', N'Phòng 2 - Tầng 1');

INSERT INTO tblLop
VALUES ('3T', N'Lớp 3 tuổi', 'GV002', N'Phòng 3 - Tầng 1');
----------------------------------------
INSERT INTO tblHocSinh
VALUES (N'Cù Thế Huy', '4T', N'Nam', '2015-05-09', N'Hải Phòng', '0383412572', N'Đoàn Thị Ngọc', N'Đã nộp', N'Đã nộp', N'Đã nộp');

INSERT INTO tblHocSinh
VALUES (N'Nguyễn Văn Bắc', '4T', N'Nam', '2015-05-21', N'Hải Phòng', '0352412572', N'Đoàn Thị Ngọc', N'Đã nộp', N'Đã nộp', N'Đã nộp');

INSERT INTO tblHocSinh
VALUES (N'Trần Thị Bình', '4T', N'Nữ', '2015-10-09', N'Hải Phòng', '0383485572', N'Đoàn Thị Ngọc', N'Đã nộp', N'Đã nộp', N'Đã nộp');

INSERT INTO tblHocSinh
VALUES (N'Trần Văn Ngọc', '5T', N'Nam', '2014-05-09', N'Hải Phòng', '0842684102', N'Đoàn Thị Ngọc', N'Đã nộp', N'Đã nộp', N'Đã nộp');

INSERT INTO tblHocSinh
VALUES (N'Nguyễn Văn Thắng', '5T', 'Nam', '2014-05-21', N'Hải Phòng', '0311412572', N'Đoàn Thị Ngọc', N'Đã nộp', N'Đã nộp', N'Đã nộp');

INSERT INTO tblHocSinh
VALUES (N'Trần Thị Kiều', '5T', N'Nữ', '2014-10-09', N'Hải Phòng', '0383005572', N'Đoàn Thị Ngọc', N'Đã nộp', N'Đã nộp', N'Đã nộp');
----------------------------------------
INSERT INTO tblTaiKhoan
VALUES ('GV001', '123456', N'Giáo viên');

INSERT INTO tblTaiKhoan
VALUES ('GV002', '123456', N'Giáo viên');

INSERT INTO tblTaiKhoan
VALUES ('CBTS001', '123456', N'Cán bộ tuyển sinh');
