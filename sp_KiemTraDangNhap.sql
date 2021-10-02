USE QLNhaSach
GO

CREATE PROC sp_KiemTraDangNhap @idLNV int
								,@tenDN varchar(100)
								,@matKhau varchar(10)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @idNV int
	SELECT @idNV = COUNT(*)	
	FROM NhanVien
	WHERE IDLoaiNhanVien = @idLNV AND TenDangNhap = @tenDN AND MatKhau = @matKhau
	SELECT @idNV as [ID Nhân Viên]
END
GO

DECLARE @idNV int
EXEC @idNV = sp_KiemTraDangNhap 1, 'truongphong', '1'
PRINT @idNV