create proc sp_KiemTraCTDH @MaDH int, @MaSP int
as
begin
	SET NOCOUNT ON  //Không yêu cầu nó trả về kiểm tra hay số dòng thay đối xuống dâtbase
	declare @sl int
	Select @sl = COUNT(*) from [ChiTietDonHang]
	where IDDonHang=@MaDH and IDSanPham=@MaSP
	select @sl as kli
end

declare @sl int
exec @sl=sp_KiemTraCTDH 1,1