USE master
GO

--Tạo Database
CREATE DATABASE QLNhaSach
GO
USE QLNhaSach
GO

--Tạo Bảng
CREATE TABLE LoaiNhanVien(
	ID int IDENTITY(1,1) PRIMARY KEY,
	TenLoaiNhanVien nvarchar(255) NOT NULL,
	LuongTheoThang decimal NULL,
	LuongTheoGio decimal NULL,
	SoGioLam int
)

CREATE TABLE ChucVu(
	ID int IDENTITY(1,1) PRIMARY KEY,
	TenChucVu nvarchar(255)NOT NULL,
	IDLoaiNhanVien int NULL,
	
	FOREIGN KEY(IDLoaiNhanVien)REFERENCES LoaiNhanVien(ID)
)

CREATE TABLE NhanVien(
	ID int IDENTITY(1,1) PRIMARY KEY,
	TenDangNhap varchar(100) NOT NULL,
	MatKhau varchar(10) NOT NULL,
	HoTen nvarchar(255) NOT NULL,
	CMND nchar(12) NOT NULL,
	GioiTinh nvarchar(4) NOT NULL,
	NgaySinh date NULL,
	DiaChi nvarchar(255) NULL,
	SDT nchar(10) NULL,
	Email varchar(255) NULL,
	NgayVaoLam date NOT NULL,
	IDChucVu int NULL,
	IDLoaiNhanVien int NULL,
	
	FOREIGN KEY(IDChucVu) REFERENCES ChucVu(ID),
	FOREIGN KEY(IDLoaiNhanVien) REFERENCES LoaiNhanVien(ID)
)

CREATE TABLE KinhNghiem(
	ID int IDENTITY(1,1) PRIMARY KEY,
	CongViec nvarchar(255) NULL,
	DiaDiem nvarchar(255) NOT NULL,
	BangCap nvarchar(255) NULL,
	ThoiGian date NOT NULL,
	GhiChu nvarchar(255) NULL
)

CREATE TABLE NhanVien_KinhNghiem(
	IDNhanVien int,
	IDKinhNghiem int,
	
	PRIMARY KEY(IDNhanVien,IDKinhNghiem),
	FOREIGN KEY(IDNhanVien) REFERENCES NhanVien(ID),
	FOREIGN KEY(IDKinhNghiem) REFERENCES KinhNghiem(ID)
)

CREATE TABLE DanhMucSanPham(
	ID int IDENTITY(1,1) PRIMARY KEY,
	TenDanhMucSanPham nvarchar(255) NOT NULL
)

CREATE TABLE NhaCungCap(
	ID int IDENTITY(1,1) PRIMARY KEY,
	Ten nvarchar(255) NOT NULL,
	NguoiLienHe nvarchar(255) NULL,
	ChucVuNguoiLienHe nvarchar(255) NULL,
	DiaChi nvarchar(255) NULL,
	SDT nchar(11) NULL,
	Email varchar(255) NULL
)

CREATE TABLE SanPham(
	ID int IDENTITY(1,1)PRIMARY KEY,
	TenSanPham nvarchar(255) NOT NULL,
	DonGia decimal NOT NULL,
	SoLuongTonKho int NOT NULL,
	SoLuongDaBan int NOT NULL,
	NgayNhapHang datetime NOT NULL,
	TinhTrang bit NOT NULL DEFAULT 1,
	IDDanhMucSanPham int NULL,
	
	FOREIGN KEY(IDDanhMucSanPham) REFERENCES DanhMucSanPham(ID)
)

CREATE TABLE LaDanhMucSach(
	IDDanhMuc int,
	IDSach int,
	TenTacGia nvarchar(255) NOT NULL,
	NhaXuatBan nvarchar(255) NOT NULL,
	NamXuatBan nchar(4)NULL,
	TheLoai nvarchar(255)NOT NULL,
	GhiChu nvarchar(255) NULL,
	
	PRIMARY KEY(IDDanhMuc, IDSach),
	FOREIGN KEY(IDDanhMuc) REFERENCES DanhMucSanPham(ID),
	FOREIGN KEY(IDSach) REFERENCES SanPham(ID)
)

CREATE TABLE NhaCungCap_SanPham(
	IDNhaCungCap int,
	IDSanPham int,
	GhiChu nvarchar(255) NULL,
	PRIMARY KEY(IDNhaCungCap, IDSanPham),
	
	FOREIGN KEY(IDNhaCungCap) REFERENCES NhaCungCap(ID),
	FOREIGN KEY(IDSanPham) REFERENCES SanPham(ID)
)

CREATE TABLE DonHang(
	ID int IDENTITY(1,1)PRIMARY KEY,
	IDNhanVien int NOT NULL,
	NgayTao datetime NOT NULL,
	
	FOREIGN KEY(IDNhanVien) REFERENCES NhanVien(ID)
)

CREATE TABLE ChiTietDonHang(
	IDDonHang int,
	IDSanPham int,
	NgayTao datetime NOT NULL,
	DonGia decimal NOT NULL,
	SoLuong int NOT NULL,
	GiamGia real NULL DEFAULT 0,
	
	PRIMARY KEY (IDDonHang, IDSanPham),
	FOREIGN KEY(IDDonHang) REFERENCES DonHang(ID),
	FOREIGN KEY(IDSanPham) REFERENCES SanPham(ID)
)

--Thêm Dữ Liệu
INSERT INTO LoaiNhanVien VALUES (N'Nhân Viên Toàn Thời Gian', 5000000, NULL, NULL)
INSERT INTO LoaiNhanVien VALUES (N'Nhân Viên Bán Thời Gian',NULL, 17000, 4)


INSERT INTO ChucVu VALUES (N'Quản Lý', 1)
INSERT INTO ChucVu VALUES (N'Kế Toán', 1)
INSERT INTO ChucVu VALUES (N'Thu Ngân', 1)
INSERT INTO ChucVu VALUES (N'Bảo Vệ', 2)
INSERT INTO ChucVu VALUES (N'Nhân Viên Bán Hàng', 2)
INSERT INTO ChucVu VALUES (N'Nhân Viên Sắp Xếp Sản Phẩm', 2)


--Băm mã
--select EncryptedData = EncryptByPassPhrase('123', 'nguyenminhchau.com' )
--select convert(varchar(100),DecryptByPassPhrase('123', 0x0100000075B24804C1A3BB07034DC0D08FDDED5BAD29FA31CD7027A174C28FC0BF4F28A0)) as giaima
INSERT INTO NhanVien VALUES ('truongphong', '1', 'Trương Phong', '0222334455' , 'Nam', '1990-01-01', 'Quận 7, TP.HCM', '0123456789', 'truongphong@gmail.com', '2011-03-02', 1, 1)
INSERT INTO NhanVien VALUES ('phamluan', '1', 'Phạm Luân', '033445567788', 'Nam', '1980-04-27', 'Gò Vấp, TP.HCM', '0987654321', NULL, '2008-03-28', 2, 1)
INSERT INTO NhanVien VALUES ('huynhthithanh', '1', 'Huỳnh Thị Thanh', '0364687732' ,' Nữ', '1999-03-21', 'Bình Dương', NULL, NULL, '2013-04-29', 3, 1)
INSERT INTO NhanVien VALUES ('duongtam', '1', 'Dương Tâm', '034293277829', 'Nam', '2000-05-28', 'Quận 6, TP.HCM', NULL, NULL, '2020-05-01', 1, 2)
INSERT INTO NhanVien VALUES ('lenhu', '1', 'Lê Như', '023479372892', 'Nữ', '2001-08-16', 'Quận Bình Tân, TP.HCM', '0902374862', NULL, '2021-06-06', 2, 2)
INSERT INTO NhanVien VALUES ('nguyenbinh', '1', 'Nguyễn Bình', '0329732497' , 'Nam', '2002-04-20', 'Quận Tân Phú, TP.HCM', '0923489266', 'nguyenbinh@gmail.com', '2020-08-21', 3, 2)

INSERT INTO KinhNghiem VALUES (NULL,'Trường Đại học Tôn Đức Thắng', 'Tốt nghiệp ngành Quản Trị Kinh Doanh', '2012-09-20', NULL)
INSERT INTO KinhNghiem VALUES (NULL,'Trường Đại học Mở TPHCM', 'Tốt nghiệp ngành Kế Toán', '2005-10-04', NULL)
INSERT INTO KinhNghiem VALUES (NULL,'Trường Đại học Mở TPHCM', 'Tốt nghiệp ngành Ngôn Ngữ Anh', '2007-12-22', NULL)
INSERT INTO KinhNghiem VALUES (NULL,'Trường Đại học Kinh Tế TPHCM', 'Tốt nghiệp ngành Kinh Tế', '2021-06-19', NULL)
INSERT INTO KinhNghiem VALUES ('Nhân viên bán hàng','Cửa hàng Ministop Đào Duy Từ', NULL, '2018-07-12', NULL)
INSERT INTO KinhNghiem VALUES ('Bảo vệ','Ngân hàng TPBank Hùng Vương, đường Hậu Giang, Quận 6', NULL, '2018-07-12', NULL)
INSERT INTO KinhNghiem VALUES ('Nhân viên phục vụ','Nhà hàng Đông Phương', NULL, '2021-01-20', NULL)

INSERT INTO NhanVien_KinhNghiem VALUES (1, 1)
INSERT INTO NhanVien_KinhNghiem VALUES (2, 2)
INSERT INTO NhanVien_KinhNghiem VALUES (2, 3)
INSERT INTO NhanVien_KinhNghiem VALUES (3, 4)
INSERT INTO NhanVien_KinhNghiem VALUES (3, 5)
INSERT INTO NhanVien_KinhNghiem VALUES (4, 6)
INSERT INTO NhanVien_KinhNghiem VALUES (5, 7)

INSERT INTO DanhMucSanPham VALUES (N'Sách')
INSERT INTO DanhMucSanPham VALUES (N'Văn phòng phẩm')
INSERT INTO DanhMucSanPham VALUES (N'Học cụ')
INSERT INTO DanhMucSanPham VALUES (N'Quà lưu niệm')
INSERT INTO DanhMucSanPham VALUES (N'Phụ kiện dịp Noel')
INSERT INTO DanhMucSanPham VALUES (N'Phụ kiện dịp Tết Nguyên Đán')

INSERT INTO SanPham VALUES (N'Lịch Sử Lớp 7', 12000, 200, 250, '2021-06-20 07:39:58', 1, 1)
INSERT INTO SanPham VALUES (N'Vật Lí Lớp 12', 19500, 500, 70, '2021-08-13 14:00:00', 1, 1)
INSERT INTO SanPham VALUES (N'Công Nghệ Lớp 10', 16000, 373, 29, '2021-07-11 21:05:03', 1, 1)
INSERT INTO SanPham VALUES (N'Lời Hứa Của Một Chú Chó', 165000, 10, 90, '2020-12-04 15:08:29', 1, 1)
INSERT INTO SanPham VALUES (N'Kẻ Săn Chuột', 95000, 49, 72, '2021-01-19 03:14:04', 1, 1)
INSERT INTO SanPham VALUES (N'Trên Nẻo Đường Giao Liên (Tái Bản 2021)', 30000, 19, 289, '2021-02-10 16:23:20', 1, 1)
INSERT INTO SanPham VALUES (N'Thay Câu Hỏi - Đổi Cuộc Đời', 148000, 91, 39, '2021-04-19 20:20:40', 1, 1)
INSERT INTO SanPham VALUES (N'Thử Thách Tự Tin', 139000, 493, 31, '2021-04-12 23:23:54', 1, 1)
INSERT INTO SanPham VALUES (N'Trưởng Thành Không Đáng Sợ', 149000, 234, 124, '2021-07-23 19:23:54', 1, 1)

INSERT INTO LaDanhMucSach VALUES (1, 1, N'Bộ Giáo Dục Và Đào Tạo', N'NXB Giáo Dục', '2021', N'Sách Giáo Khoa', NULL)
INSERT INTO LaDanhMucSach VALUES (1, 2, N'Bộ Giáo Dục Và Đào Tạo', N'NXB Giáo Dục', '2021', N'Sách Giáo Khoa', NULL)
INSERT INTO LaDanhMucSach VALUES (1, 3, N'Bộ Giáo Dục Và Đào Tạo', N'NXB Giáo Dục', '2021', N'Sách Giáo Khoa', NULL)
INSERT INTO LaDanhMucSach VALUES (1, 4, N'W Bruce Cameron', N'NXB Trẻ', '2019', N'Sách Văn Học', NULL)
INSERT INTO LaDanhMucSach VALUES (1, 5, N'Phã Nguyện', N'NXB Trẻ', '2021', N'Sách Văn Học', NULL)
INSERT INTO LaDanhMucSach VALUES (1, 6, N'Bùi Tự Lực', N'NXB Kim Đồng', '2021', N'Sách Văn Học', NULL)
INSERT INTO LaDanhMucSach VALUES (1, 7, N'Paul Angone', N'NXB Dân Trí', '2021', N'Sách Kỹ Năng', NULL)
INSERT INTO LaDanhMucSach VALUES (1, 8, N'Tiến sĩ Rob Yeung', 'NXB Phụ Nữ Việt Nam', NULL, N'Sách Kỹ Năng', NULL)
INSERT INTO LaDanhMucSach VALUES (1, 9, N'Nora Bradbury Haehl', N'NXB Thế Giới', NULL, N'Sách Kỹ Năng', NULL)

INSERT INTO NhaCungCap VALUES (N'NXB Giáo Dục', NULL, NULL, N'231 Nguyễn Văn Cừ, Phường 4, Quận 5, Thành phố Hồ Chí Minh' ,'02838356111', NULL)
INSERT INTO NhaCungCap VALUES (N'NXB Trẻ', NULL, NULL, N'161B Lý Chính Thắng, Phường 7, Quận 3; Thành phố Hồ Chí Minh' ,'0839316211', NULL)
INSERT INTO NhaCungCap VALUES (N'NXB Kim Đồng', NULL, NULL, N'Hà Nội' ,'0439434730', 'info@nxbkimdong.com.vn')
INSERT INTO NhaCungCap VALUES (N'First News - Trí Việt', NULL, NULL, N'11H Nguyễn Thị Minh Khai, Phường Bến Nghé, Quận 1, Thành phố Hồ Chí Minh' ,'02838227979', 'triviet@firstnews.com.vn')
INSERT INTO NhaCungCap VALUES (N'AZ Việt Nam', NULL, NULL, N'Số 50 - Đường 5 - Khu tập thể F361 - phố An Dương - P. Yên Phụ - Q.Tây Hồ - HN' ,' 0964484633', ' tqtoanpc1988@gmail.com')

INSERT INTO NhaCungCap_SanPham VALUES (1, 1, NULL)
INSERT INTO NhaCungCap_SanPham VALUES (1, 2, NULL)
INSERT INTO NhaCungCap_SanPham VALUES (1, 3, NULL)
INSERT INTO NhaCungCap_SanPham VALUES (2, 4, NULL)
INSERT INTO NhaCungCap_SanPham VALUES (2, 5, NULL)
INSERT INTO NhaCungCap_SanPham VALUES (3, 6, NULL)
INSERT INTO NhaCungCap_SanPham VALUES (4, 7, NULL)
INSERT INTO NhaCungCap_SanPham VALUES (5, 8, NULL)
INSERT INTO NhaCungCap_SanPham VALUES (5, 9, NULL)

SELECT  NhanVien.*, KinhNghiem.*
FROM NhanVien,KinhNghiem, NhanVien_KinhNghiem
WHERE (NhanVien.ID = NhanVien_KinhNghiem.IDNhanVien AND KinhNghiem.ID = NhanVien_KinhNghiem.IDKinhNghiem)
