﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLNS
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QLNhaSachEntities : DbContext
    {
        public QLNhaSachEntities()
            : base("name=QLNhaSachEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<DanhMucSanPham> DanhMucSanPhams { get; set; }
        public virtual DbSet<DonHang> DonHangs { get; set; }
        public virtual DbSet<KinhNghiem> KinhNghiems { get; set; }
        public virtual DbSet<LaDanhMucSach> LaDanhMucSaches { get; set; }
        public virtual DbSet<LoaiNhanVien> LoaiNhanViens { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<NhaCungCap_SanPham> NhaCungCap_SanPham { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<NhanVien_KinhNghiem> NhanVien_KinhNghiem { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
    
        public virtual ObjectResult<Nullable<int>> sp_KiemTraCTDH(Nullable<int> maDH, Nullable<int> maSP)
        {
            var maDHParameter = maDH.HasValue ?
                new ObjectParameter("MaDH", maDH) :
                new ObjectParameter("MaDH", typeof(int));
    
            var maSPParameter = maSP.HasValue ?
                new ObjectParameter("MaSP", maSP) :
                new ObjectParameter("MaSP", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_KiemTraCTDH", maDHParameter, maSPParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_KiemTraDangNhap(Nullable<int> idChucVu, string tenDN, string matKhau)
        {
            var idChucVuParameter = idChucVu.HasValue ?
                new ObjectParameter("idChucVu", idChucVu) :
                new ObjectParameter("idChucVu", typeof(int));
    
            var tenDNParameter = tenDN != null ?
                new ObjectParameter("tenDN", tenDN) :
                new ObjectParameter("tenDN", typeof(string));
    
            var matKhauParameter = matKhau != null ?
                new ObjectParameter("matKhau", matKhau) :
                new ObjectParameter("matKhau", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_KiemTraDangNhap", idChucVuParameter, tenDNParameter, matKhauParameter);
        }
    }
}
