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
        //Lien ket DAO
        DAO_SanPham dSP;
        public BUS_SanPham()
        {
            dSP = new DAO_SanPham();
        }

        //
        //Hiển thị data lên DataGridView
        public void HienThiDSSP(DataGridView dg)
        {
            dg.DataSource = dSP.LayDSSP();
        }
        //Hiển thị lên cbbox form sp
        //ds loại sp 
        public void HienThiDSLoaiSPLenCb(ComboBox cb)
        {
            cb.DataSource = dSP.LayDSLoaiSP();
            cb.DisplayMember = "TenDanhMucSanPham";
            cb.ValueMember = "ID";
        }
        //ds tên sp
        public void HienThiDSTenSPLenCb(ComboBox cb)
        {
            cb.DataSource = dSP.LayDSTenSP();
            cb.DisplayMember = "TenSanPham";
            cb.ValueMember = "ID";
        }
        //ds tên nhà cung cấp
        public void HienThiDSNhaCCLenCb(ComboBox cb)
        {
            cb.DataSource = dSP.LayDSNhaCC();
            cb.DisplayMember = "Ten";
            cb.ValueMember = "ID";
        }
      
        //
        //Thêm sản phẩm
        public void ThemSP(SanPham sp)
        {
            try
            {
                dSP.ThemSP(sp);
                MessageBox.Show("Thêm sản phẩm thành công!!!");
                
            }
            catch (Exception)
            {
                 MessageBox.Show("Thêm sản phẩm thất bại!!!");
            }
        }
    }
}
