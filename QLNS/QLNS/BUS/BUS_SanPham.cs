using QLNS.DAO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
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
        //
        //Hiển thị data lên DataGridView quản lý sản phẩm
        public void HienThiDSSP(DataGridView dg)
        {
            dg.DataSource = dSP.LayDSSP();
        }

        //Hiển thị dssp lên datagridview của FCTSP
        public void HienThiDSSPDGCTSP(DataGridView dg)
        {
            dg.DataSource = dSP.LayDSSPFCTSP();
        }
        //HIển thị dssp không có sách
        public void HienThiDSSPFSP(DataGridView dg)
        {
            dg.DataSource = dSP.LayDSSPFSP();
        }
        //HIển thị sp là sách
        //Hiển thị lên cbbox form sp
        //ds loại sp 
        public void HienThiDSLoaiSPLenCb(ComboBox cb)
        {
            cb.DataSource = dSP.LayDSLoaiSP();
            cb.DisplayMember = "TenDanhMucSanPham";
            cb.ValueMember = "ID";
        }
        //HIển thị ds loại sp k có sách
        public void HienThiDSLoaiSPKhongCoSachLenCb(ComboBox cb)
        {
            cb.DataSource = dSP.LayDSLoaiSPKhongCoSach();
            cb.DisplayMember = "TenDanhMucSanPham";
            cb.ValueMember = "ID";
        }
        //ds tên nhà cung cấp
        public void HienThiDSNhaCCLenCb(ComboBox cb)
        {
            cb.DataSource = dSP.LayDSNhaCC();
            cb.DisplayMember = "Ten";
            cb.ValueMember = "ID";
        }
        public void HienThiDSSPTheoDM(DataGridView dg, int maDMSP)
        {
            dg.DataSource = dSP.HienThiSpTheoDM(maDMSP);
        }
        //Xử lý lấy dssp theo nhà cung cấp
        public void HienThiDSSPTheoNCC(DataGridView dg, int maNCC)
        {
            dg.DataSource = dSP.HienThiSpTheoNCC(maNCC);
        }
        //
        //Thêm sản phẩm
        public void ThemSP(SanPham sp, NhaCungCap_SanPham ncc)
        {
            try
            {
                dSP.ThemSP(sp, ncc);
                MessageBox.Show("Thêm sản phẩm thành công!!!");

            }
            catch (Exception)
            {
                MessageBox.Show("Thêm sản phẩm thất bại!!!");
            }
        }
        public void ThemSach(LaDanhMucSach dms, SanPham sp, NhaCungCap_SanPham ncc)
        {
            try
            {
                dSP.ThemSach(dms, sp, ncc);
                MessageBox.Show("Thêm sách thành công!!!");

            }
            catch (Exception)
            {
                MessageBox.Show("Thêm sách thất bại!!!");
            }
        }

        //Xử lý lấy dssp theo loại sản phẩm

       
        //Xử lý tra cứu lấy ra dsdp theo dm và nhà cc
        public void HienThiSpTraCuu(DataGridView dg, int mdm, int maNCC)
        {
            dg.DataSource = dSP.HienThiSpTraCuu(mdm, maNCC);
        }
        //Xóa sản phẩm
        public bool XoaSP(SanPham s)
        {

            if (dSP.KiemTraMaSP(s) )
            {
                try
                {
                    dSP.Xoa(s);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
                return false;
        }
        //
        //Sửa sản phẩm
        public bool CapNhatSP(SanPham sp)
        {

            if (dSP.KiemTraMaSP(sp))
            {
                try
                {
                    dSP.SuaSP(sp);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
                return false;
        }


        //-------------------------------------------//

        //San Pham
        public void HienThiDSTenSP(ComboBox cb)
        {
            cb.DataSource = dSP.LayDSTenSP();
            cb.DisplayMember = "TenSanPham";
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
