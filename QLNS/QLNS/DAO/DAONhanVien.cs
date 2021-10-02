using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DAO
{
    
    class DAONhanVien
    {
        QLNhaSachEntities1 db;
        public DAONhanVien()
        {
            db = new QLNhaSachEntities1();
           
        }
        //Lấy danh sách nhân viên ra gvNV
        public dynamic LayDSNV()
        {
            var dsnv = db.NhanViens.Select(s => new
            {
                s.ID,
                s.HoTen,
                s.ChucVu.TenChucVu,
                s.LoaiNhanVien.TenLoaiNhanVien,
                s.SDT,
                s.NgayVaoLam,
                s.NgaySinh,
                s.GioiTinh,
            }).ToList();
            return dsnv;
        }
        //Lấy ds nhân viên đổ ra datagridview form CTNV
        public dynamic LayDSCTNV()
        {
            var dsnv = db.NhanVien_KinhNghiem.Select(s => new
            {
                s.NhanVien.ID,
                s.NhanVien.HoTen,
                s.NhanVien.ChucVu.TenChucVu,
                s.NhanVien.LoaiNhanVien.TenLoaiNhanVien,
                s.NhanVien.SDT,
                s.NhanVien.NgayVaoLam,
                s.NhanVien.NgaySinh,
                s.NhanVien.GioiTinh,
                //
              
               

            }).ToList();
            return dsnv;
        }
        //Lấy tên, loại, chức vụ nhân viên đổ ra cbb
        public dynamic layTenNVCBB()
        {
            var ds = db.NhanViens.Select(s => new
            {
                s.ID,
                s.HoTen,
            }).ToList();
            return ds;
        }
        public dynamic layLoaiNVCBB()
        {
            var ds = db.LoaiNhanViens.Select(s => new
            {
                s.ID,
                s.TenLoaiNhanVien,
            }).ToList();
            return ds;
        }
        //
        public dynamic layLoaiNVQLCBB()
        {
            var ds = db.LoaiNhanViens.Where(s => s.ID == 1).Select(s => new
            {
                s.ID,
                s.TenLoaiNhanVien,
            }).ToList();
            return ds;
        }
        public dynamic layChucVuNVCBB()
        {
            var ds = db.ChucVus.Select(s => new
            {
                s.ID,
                s.TenChucVu,
            }).ToList();
            return ds;
        }
        
        //Xử lý lọc ds và tra cứu
        // Xử lý lấy dssp theo danh mục sản phẩm:
        public dynamic HienThiNVTheoTen(int maNV)
        {
            var ds = db.NhanViens.Where(s => s.ID == maNV).Select(s => new
            {
                s.ID,
                s.HoTen,
                s.ChucVu.TenChucVu,
                s.LoaiNhanVien.TenLoaiNhanVien,
                s.SDT,
                s.NgayVaoLam,
                s.NgaySinh,
                s.GioiTinh,
            }).ToList();
            return ds;
        }
        public dynamic HienThiNVTheoLoaiNV(int maNV)
        {
            var ds = db.NhanViens.Where(s => s.IDLoaiNhanVien == maNV).Select(s => new
            {
                s.ID,
                s.HoTen,
                s.ChucVu.TenChucVu,
                s.LoaiNhanVien.TenLoaiNhanVien,
                s.SDT,
                s.NgayVaoLam,
                s.NgaySinh,
                s.GioiTinh,
            }).ToList();
            return ds;
        }
        public dynamic HienThiNVTheoCVNV(int maNV)
        {
            var ds = db.NhanViens.Where(s => s.IDChucVu == maNV).Select(s => new
            {
                s.ID,
                s.HoTen,
                s.ChucVu.TenChucVu,
                s.LoaiNhanVien.TenLoaiNhanVien,
                s.SDT,
                s.NgayVaoLam,
                s.NgaySinh,
                s.GioiTinh,
            }).ToList();
            return ds;
        }
        //Tra cứu ds theo loại nv và cvu
        public dynamic HienThiNVTraCuu(int lnv, int cv)
        {
            var ds = db.NhanViens.Where(s => s.IDLoaiNhanVien == lnv && s.IDChucVu == cv).Select(s => new
            {
                s.ID,
                s.HoTen,
                s.ChucVu.TenChucVu,
                s.LoaiNhanVien.TenLoaiNhanVien,
                s.SDT,
                s.NgayVaoLam,
                s.NgaySinh,
                s.GioiTinh,
            }).ToList();
            return ds;
        }
        //Thêm nhân viên mới
        public void ThemNV(NhanVien nv, KinhNghiem kn, NhanVien_KinhNghiem nvkn)
        {
            db.NhanViens.Add(nv);
            db.KinhNghiems.Add(kn);
            db.NhanVien_KinhNghiem.Add(nvkn);
            db.SaveChanges();
        }
        //sửa
        public bool KiemTraMaNV(NhanVien nv)
        {
            NhanVien nvien = db.NhanViens.Find(nv.ID);
            if (nvien != null)
            {
                return true;
            }
            else
                return false;
        }

        public void SuaNV(NhanVien nv)
        {
            NhanVien nvien = db.NhanViens.Find(nv.ID);
            nv.SDT = nvien.SDT;
            nv.DiaChi = nvien.DiaChi;

            db.SaveChanges();

        }

    }
}
