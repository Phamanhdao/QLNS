using BTL_LTCSDL.DAO;
using QLNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_LTCSDL.BUS
{
    class BUS_DangNhap
    {
        DAO_DangNhap daoDN;
        public BUS_DangNhap()
        {
            daoDN = new DAO_DangNhap();
        }
        public void LayDSLNV(ComboBox cb)
        {
            cb.DataSource = daoDN.LayDSLNV();
            cb.DisplayMember = "TenLoaiNhanVien";
            cb.ValueMember = "ID";
        }

        public bool DangNhap(NhanVien nv)
        {
            if (daoDN.KiemTraDangNhap(nv))
                return true;
            return false;
        }
    }
}
