using QLNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_LTCSDL.DAO
{
    class DAO_DangNhap
    {
        QLNhaSachEntities db;
        public DAO_DangNhap()
        {
            db = new QLNhaSachEntities();
        }
        public dynamic LayDSLNV()
        {
            var ds = db.LoaiNhanViens.Select(s => new
            {
                s.ID,
                s.TenLoaiNhanVien,
            }).ToList();
            return ds;
        }

        public bool KiemTraDangNhap(NhanVien nv)
        {
            int? id;
            id = db.sp_KiemTraDangNhap(nv.IDLoaiNhanVien, nv.TenDangNhap, nv.MatKhau).FirstOrDefault();
            if (id == 1)
                return true;
            return false;
        }
    }
}
