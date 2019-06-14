--SELECT COUNT(*) SiSo
ALTER PROCEDURE DSHSTheoLop @MaLop VARCHAR(5)
AS
SELECT l.TenLop, nv.TenNhanVien, nv.ChucVu, hs.TenHocSinh, hs.TenPhuHuynh, hs.SDT, hs.Diachi
FROM tblLop l
INNER JOIN tblHocSinh hs ON l.MaLop = hs.MaLop 
INNER JOIN tblNhanVien nv ON nv.MaNhanVien = l.MaGiaoVien
WHERE l.MaLop = @MaLop;

EXEC DSHSTheoLop @MaLop = '5T';

SELECT *
FROM tblLop