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
        QLNhaSachEntities1 db;
        public DAO_DangNhap()
        {
            db = new QLNhaSachEntities1();
        }

        public dynamic LayDSCV()
        {
            var ds = db.ChucVus.Where(s => s.ID == 1 || s.ID == 2 || s.ID == 3).Select(s => new
            {
                s.ID,
                s.TenChucVu,
            }).ToList();
            return ds;
        }

        public bool KiemTraDangNhap(NhanVien nv)
        {
            int? id;
            id = db.sp_KiemTraDangNhap(nv.IDChucVu, nv.TenDangNhap, nv.MatKhau).FirstOrDefault();
            if (id == 1)
                return true;
            return false;
        }
    }
}
