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
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public object SanPham { get; internal set; }
    }
}