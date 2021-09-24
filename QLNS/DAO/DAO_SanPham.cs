using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DAO
{
    class DAO_SanPham
    {
        //Lien ket database
        QLNhaSachEntities db;
        public DAO_SanPham()
        {
            db = new QLNhaSachEntities();
        }
        //
        //Lấy dữ liệu lên từ database
        public dynamic LayDSSP()
        {
            var dsSP = db.SanPhams.Select(s => new
            {
                s.ID,
                s.TenSanPham,
                s.DanhMucSanPham.TenDanhMucSanPham,
                s.SoLuongTonKho,
                s.DonGia,
            }).ToList();
            return dsSP;
        }
        //
        //Lấy ds loại sản phẩm
        public dynamic LayDSLoaiSP()
        {

            var ds = db.DanhMucSanPhams.Select(s => new
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
        public void ThemSP(SanPham sp)
        {
            db.SanPhams.Add(sp);
            db.SaveChanges();
        }
        
        

    }
}
