﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DAO
{
    class DAO_SanPham
    {
        //Lien ket database
        QLNhaSachEntities1 db;
       
        public DAO_SanPham()
        {
            db = new QLNhaSachEntities1();
        }
        //
        //Lấy dữ liệu lên từ database
        public dynamic LayDSSP()
        {
            var dsSP = db.NhaCungCap_SanPham.Select(s => new
            {
                s.SanPham.ID,
                s.SanPham.TenSanPham,
                s.SanPham.DanhMucSanPham.TenDanhMucSanPham,
                s.SanPham.SoLuongTonKho,
                s.SanPham.DonGia,
                s.NhaCungCap.Ten,  
            }).ToList();
            return dsSP;
        }
        //Lấy dssp cho FCTDH
        public dynamic LayDSSPFCTSP()
        {
            var dsSP = db.NhaCungCap_SanPham.Select(s => new
            {
                s.IDSanPham,
                s.SanPham.TenSanPham,
                s.SanPham.DanhMucSanPham.TenDanhMucSanPham,
                s.SanPham.SoLuongTonKho,
                s.SanPham.DonGia,
                s.NhaCungCap.Ten,
                s.SanPham.NgayNhapHang,
            }).ToList();
            return dsSP;
        }
        //Lấy ra các sp không phải sách
        public dynamic LayDSSPFSP()
        {
            var dsSP = db.NhaCungCap_SanPham.Where(s => s.SanPham.DanhMucSanPham.ID != 1).Select(s => new
            {
                s.IDSanPham,
                s.SanPham.TenSanPham,
                s.SanPham.DanhMucSanPham.TenDanhMucSanPham,
                s.SanPham.SoLuongTonKho,
                s.SanPham.DonGia,
                s.NhaCungCap.Ten,
                s.SanPham.NgayNhapHang,
            }).ToList();
            return dsSP;
        }
       
        public dynamic LayDSLoaiSP()
        {

            var ds = db.DanhMucSanPhams.Select(s => new
            {
                s.ID,
                s.TenDanhMucSanPham,
            }).ToList();
            return ds;
        }
        public dynamic LayDSLoaiSPKhongCoSach()
        {

            var ds = db.DanhMucSanPhams.Where(s => s.ID != 1).Select(s => new
            {
                s.ID,
                s.TenDanhMucSanPham,
            }).ToList();
            return ds;
        }
        //
        //Lấy ds tên sp
        public dynamic LayDSTenSP()
        {

            var ds = db.SanPhams.Select(s => new
            {
                s.ID,
                s.TenSanPham,
            }).ToList();
            return ds;
        }
        //
        //Lấy danh sách nhà cung cấp sản phẩm
        public dynamic LayDSNhaCC()
        {

            var ds = db.NhaCungCaps.Select(s => new
            {
                s.ID,
                s.Ten,
            }).ToList();
            return ds;
        }
        //
        //Thêm sản phẩm
        public void ThemSP(SanPham sp, NhaCungCap_SanPham ncc)
        {
            db.SanPhams.Add(sp);
            db.NhaCungCap_SanPham.Add(ncc); 
            db.SaveChanges();
        }
        public void ThemSach(LaDanhMucSach dms, SanPham sp, NhaCungCap_SanPham ncc)
        {
            db.SanPhams.Add(sp);
            db.NhaCungCap_SanPham.Add(ncc); 
            db.LaDanhMucSaches.Add(dms);
            db.SaveChanges();
        }
        //
        //Xử lý sửa sản phẩm
        //Tìm mã sp
        public bool KiemTraMaSP(SanPham sp)
        {
            SanPham sanpham = db.SanPhams.Find(sp.ID);
            if (sanpham != null)
            {
                return true;
            }
            else
                return false;
        }
       
        public void SuaSP(SanPham sp)
        {
            SanPham sanpham = db.SanPhams.Find(sp.ID);
            sanpham.DonGia = sp.DonGia;
            sanpham.SoLuongTonKho = sp.SoLuongTonKho;

            db.SaveChanges();

        }
        // Xử lý lấy dssp theo danh mục sản phẩm:
        public dynamic HienThiSpTheoDM(int maDMSP)
        {
            var dsSP = db.NhaCungCap_SanPham.Where(s => s.SanPham.IDDanhMucSanPham == maDMSP).Select(s => new
            {
                s.SanPham.ID,
                s.SanPham.TenSanPham,
                s.SanPham.DanhMucSanPham.TenDanhMucSanPham,
                s.SanPham.SoLuongTonKho,
                s.SanPham.DonGia,
                s.NhaCungCap.Ten,
            }).ToList();
            return dsSP;
        }
        // Xử lý lấy dssp theo danh mục ncc:
        public dynamic HienThiSpTheoNCC(int mancc)
        {
            var dsSP = db.NhaCungCap_SanPham.Where(s => s.NhaCungCap.ID == mancc).Select(s => new
            {
                s.SanPham.ID,
                s.SanPham.TenSanPham,
                s.SanPham.DanhMucSanPham.TenDanhMucSanPham,
                s.SanPham.SoLuongTonKho,
                s.SanPham.DonGia,
                s.NhaCungCap.Ten,
            }).ToList();
            return dsSP;
        }
        //Lấy dl theo dmsp và ncc
        public dynamic HienThiSpTraCuu(int mdm, int mancc)
        {
            var dsSP = db.NhaCungCap_SanPham.Where(s => s.SanPham.IDDanhMucSanPham == mdm && s.NhaCungCap.ID == mancc).Select(s => new
            {
                s.SanPham.ID,
                s.SanPham.TenSanPham,
                s.SanPham.DanhMucSanPham.TenDanhMucSanPham,
                s.SanPham.SoLuongTonKho,
                s.SanPham.DonGia,
                s.NhaCungCap.Ten,
            }).ToList();
            return dsSP;
        }

        //ktra sp xóa
       
        public void XoaSP( SanPham sp)
        {
            SanPham sanpham = db.SanPhams.Find(sp.ID);
            db.SanPhams.Remove(sanpham);
            db.SaveChanges();
        }
        
    }
}
