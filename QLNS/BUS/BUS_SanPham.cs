using QLNS.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS.BUS
{
    class BUS_SanPham
    {
        DAO_SanPham dSP;

        public BUS_SanPham()
        {
            dSP = new DAO_SanPham();
        }


        //San Pham
        public void HienThiDSTenSP(ComboBox cb)
        {
            cb.DataSource = dSP.LayDSTenSP();
            cb.DisplayMember = "TenSanPham";
            cb.ValueMember = "ID";
        }
        public void HienThiDSLoaiSP(ComboBox cb)
        {
            cb.DataSource = dSP.LayDSLoaiSP();
            cb.DisplayMember = "TenDanhMucSanPham";
            cb.ValueMember = "ID";
        }

        //Lay san pham theo ma san pham truyen vao, thuc hien ben DAO, dua vao trycatch de bat loi neu cos
        public NhaCungCap_SanPham LayTTSPNCC(int maSP)
        {
            NhaCungCap_SanPham s = dSP.LayTTSPNCC(maSP);
            return s;
        }
    }
}
