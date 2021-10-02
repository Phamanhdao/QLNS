using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DAO
{
    class DAO_DonHang
    {
        QLNhaSachEntities1 db;

        public DAO_DonHang()
        {
            db = new QLNhaSachEntities1();
        }

        public dynamic LayDSSDH()
        {
            var ds = db.DonHangs.Select(s => new
            {
                s.ID,
                s.NgayTao,
                s.NhanVien.HoTen
            }).ToList();
            return ds;
        }
        public dynamic LayDSNV()
        {
            var ds = db.NhanViens.Select(s => new
            {
                s.ID,
                s.HoTen
            }).ToList();
            return ds;
        }


        public void ThemDonHang(DonHang don)
        {
            db.DonHangs.Add(don);
            db.SaveChanges();
        }
        public bool KTDonHang(DonHang don)
        {
            DonHang d = db.DonHangs.Find(don.ID);
            if(d!= null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void SuaDH(DonHang dh)
        {
            DonHang don = db.DonHangs.Find(dh.ID);
            don.NgayTao = dh.NgayTao;
            don.IDNhanVien = dh.IDNhanVien;
            db.SaveChanges();
        }
        public void XoaDH(DonHang dh)
        {
            DonHang don = db.DonHangs.Find(dh.ID);
            db.DonHangs.Remove(don);
            db.SaveChanges();
        }

        //Dat hang
        public dynamic DSChiTietDH(int maDH)
        {
            var ds = db.ChiTietDonHangs.Where(s => s.IDDonHang == maDH)
                .Select(s => new
                {
                    s.IDDonHang,
                    s.IDSanPham,
                    s.SanPham.TenSanPham,
                    s.SanPham.DanhMucSanPham.TenDanhMucSanPham,
                    s.SoLuong,
                    s.DonGia,
                    s.GiamGia
                }).ToList();
            return ds;
        }
        public dynamic DSCTDatDH(int maDH)
        {
            var ds = db.ChiTietDonHangs.Where(s => s.IDDonHang == maDH)
                .Select(s=> new
                {
                    s.IDDonHang,
                    s.SanPham.TenSanPham,
                    s.SanPham.DanhMucSanPham.TenDanhMucSanPham,
                    s.SoLuong,
                    s.DonGia,
                    s.GiamGia
                }).ToList();
            return ds;
        }

        public bool ThemCTDonHang(ChiTietDonHang d)
        {
            bool trangThai = false;
            int? sl = db.sp_KiemTraCTDH(d.IDDonHang, d.IDSanPham).FirstOrDefault();
            if(sl == 0)
            {
                db.ChiTietDonHangs.Add(d);
                db.SaveChanges();
                trangThai = true;
            }
            return trangThai;
        }


        //Chi Tiet Don Hang
        /*public bool KTCTDonHang(ChiTietDonHang dh)
        {
            int? d = db.sp_KiemTraCTDH(dh.IDDonHang, dh.IDSanPham).FirstOrDefault();
            if (d != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/

        public bool KTCTDonHang(ChiTietDonHang don)
        {
            ChiTietDonHang d = db.ChiTietDonHangs.Find(don.IDDonHang, don.IDSanPham);
            if (d != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /*public void SuaCTDH(ChiTietDonHang dh)
        {
            ChiTietDonHang d = db.ChiTietDonHangs.Find(dh.IDSanPham, dh.IDDonHang);
            d.SoLuong = dh.SoLuong;
            db.SaveChanges();
        }*/
        public void XoaCTDH(ChiTietDonHang d)
        {
            ChiTietDonHang don = db.ChiTietDonHangs.Find(d.IDDonHang, d.IDSanPham);
            db.ChiTietDonHangs.Remove(don);
            db.SaveChanges();
          
        }



        /*   public DonHang LayTTDH(int maSP) //tra ve nhieu sex laf list sp
           {
               DonHang p = db.DonHangs.FirstOrDefault(s => s.ID == maSP);
               return p;
           }*/
    }
}
