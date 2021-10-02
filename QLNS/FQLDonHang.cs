using QLNS.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS
{
    public partial class FQLDonHang : Form
    {
        BUS_DonHang busDH;

        public FQLDonHang()
        {
            InitializeComponent();
            busDH = new BUS_DonHang();
        }

        private void HienThiLenDG()
        {
            gVDH.DataSource = null;
            busDH.HienThiDSDH(gVDH);
            gVDH.Columns[0].Width = (int)(gVDH.Width * 0.2);
            gVDH.Columns[1].Width = (int)(gVDH.Width * 0.3);
            gVDH.Columns[2].Width = (int)(gVDH.Width * 0.4);
        }

        private void FQLDonHang_Load(object sender, EventArgs e)
        {
            HienThiLenDG();
            busDH.HienThiDSNV(cbNhanVien);
            dtpNgayDatHang.MaxDate = DateTime.Now;/*
            int dayofmonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            dtpNgayDatHang.MaxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, dayofmonth);*/
        }

        private void gVDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < gVDH.Rows.Count)
            {
                txtMaDH.Enabled = false;
                txtMaDH.Text = gVDH.Rows[e.RowIndex].Cells[0].Value.ToString();
                dtpNgayDatHang.Text = gVDH.Rows[e.RowIndex].Cells["NgayTao"].Value.ToString();
                cbNhanVien.Text = gVDH.Rows[e.RowIndex].Cells["HoTen"].Value.ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            DonHang donHang = new DonHang();
            donHang.NgayTao = dtpNgayDatHang.Value;
            donHang.IDNhanVien = Int32.Parse(cbNhanVien.SelectedValue.ToString());

            //Goi su kien them cua Bus
            if (busDH.TaoDonHang(donHang))
            {
                MessageBox.Show("Tạo đơn hàng thành công!!!");
                busDH.HienThiDSDH(gVDH);
            }
            else
                MessageBox.Show("Tạo đơn hàng không thành công!!!");
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            DonHang d = new DonHang();
            d.ID = int.Parse(txtMaDH.Text); //kiem tra xem co don hang de sua khong
            d.NgayTao = dtpNgayDatHang.Value;
            d.IDNhanVien = int.Parse(cbNhanVien.SelectedValue.ToString());

            //Goi su kien them cua Bus
            if (busDH.SuaDonHang(d))
            {
                MessageBox.Show("Sửa đơn hàng thành công!!!");
                busDH.HienThiDSDH(gVDH);
            }
            else
            {
                MessageBox.Show("Sửa đơn hàng không thành công!!!");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DonHang d = new DonHang();
            d.ID = int.Parse(txtMaDH.Text);
            //Goi su kien them cua Bus
            if (busDH.XoaDonHang(d))
            {
                MessageBox.Show("Xóa đơn hàng thành công!!!");
                busDH.HienThiDSDH(gVDH);
            }
            else
            {
                MessageBox.Show("Xóa đơn hàng không thành công!!!");
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainQuanLy main = new MainQuanLy();
            main.ShowDialog();
            this.Close();
        }

        //Chuyenn sang chi tiết đơn hàng 
        private void gVDH_DoubleClick(object sender, EventArgs e)
        {
            int ma;
            ma = int.Parse(gVDH.CurrentRow.Cells[0].Value.ToString());
            this.Hide();
            FChiTietDonHang f = new FChiTietDonHang();
            f.maDH = ma;
            f.ShowDialog();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FDangNhap dn = new FDangNhap();
            dn.ShowDialog();
            Close();
        }
    }
}
