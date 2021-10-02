using QLNS.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS.BUS
{
    class BUSNhanVien
    {
        DAONhanVien dNV;
        public BUSNhanVien()
        {
            dNV = new DAONhanVien();
        }
        //Hiển thị dữ liệu lên datagridview
        public void HienThidsctnv(DataGridView gv)
        {
            gv.DataSource = dNV.LayDSCTNV();
        }
        public void HienThidsnv(DataGridView gv)
        {
            gv.DataSource = dNV.LayDSNV();
        }
        //Lấy dl lên combobox
        public void HienThiDSLoaiNVQLLenCb(ComboBox cb)
        {
            cb.DataSource = dNV.layLoaiNVQLCBB();
            cb.DisplayMember = "HoTen";
            cb.ValueMember = "ID";
        }
        public void HienThiDSTenNVLenCb(ComboBox cb)
        {
            cb.DataSource = dNV.layTenNVCBB();
            cb.DisplayMember = "HoTen";
            cb.ValueMember = "ID";
        }
        public void HienThiDSLoaiNVLenCb(ComboBox cb)
        {
            cb.DataSource = dNV.layLoaiNVCBB();
            cb.DisplayMember = "TenLoaiNhanVien";
            cb.ValueMember = "ID";
        }
        public void HienThiDSChucVuNVLenCb(ComboBox cb)
        {
            cb.DataSource = dNV.layChucVuNVCBB();
            cb.DisplayMember = "TenChucVu";
            cb.ValueMember = "ID";
        }

        //Lọc dl theo teennv, loại nv, chức vụ
        public void HienThiDSNVTheoTenNV(DataGridView dg, int maNV)
        {
            dg.DataSource = dNV.HienThiNVTheoTen(maNV);
        }
        public void HienThiDSNVTheoLoaiNV(DataGridView dg, int maLoaiNV)
        {
            dg.DataSource = dNV.HienThiNVTheoLoaiNV(maLoaiNV);
        }
        public void HienThiDSNVTheoCVNV(DataGridView dg, int maCVNV)
        {
            dg.DataSource = dNV.HienThiNVTheoCVNV(maCVNV);
        }
        public void HienThiDSNVTheoLNVVaCV(DataGridView dg, int lnv, int cv)
        {
            dg.DataSource = dNV.HienThiNVTraCuu(lnv, cv);
        }
        //Thêm nhân viên:
        public void ThemNV(NhanVien nv, KinhNghiem kn, NhanVien_KinhNghiem nvkn)
        {
            try
            {
                dNV.ThemNV(nv, kn, nvkn);
                MessageBox.Show("Thêm nhân viên thành công!!!");

            }
            catch (Exception)
            {
                MessageBox.Show("Thêm nhân viên thất bại!!!");
            }
        }
    }
}
