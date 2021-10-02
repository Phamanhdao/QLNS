using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DAO
{
    class DAO_SanPham
    {
        QLNhaSachEntities db;
        public DAO_SanPham()
        {
            db = new QLNhaSachEntities();
        }

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

        //DAO_SanPham
        public dynamic LayDSTenSP()
        {
            var ds = db.SanPhams.Select(s => new
            {
                s.ID,
                s.TenSanPham
            }).ToList();
            return ds;
        }

        public dynamic LayDSLoaiSP()
        {
            var ds = db.DanhMucSanPhams.Select(s => new
            {
                s.ID,
                s.TenDanhMucSanPham
            }).ToList();
            return ds;
        }

        public SanPham LayTTSP(int maSP) //tra ve nhieu sex laf list sp
        {
            SanPham p = db.SanPhams.FirstOrDefault(s => s.ID == maSP);
            return p;
        }

        public NhaCungCap_SanPham LayTTSPNCC(int maSP) //tra ve nhieu sex laf list sp
        {
            NhaCungCap_SanPham p = db.NhaCungCap_SanPham.FirstOrDefault(s => s.SanPham.ID == maSP);
            return p;
        }


    }
}
