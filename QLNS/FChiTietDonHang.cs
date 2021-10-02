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
    public partial class FChiTietDonHang : Form
    {
        public int maDH;
        public int maSP;
        BUS_DonHang busDH;
        NhanVien nv;
        public FChiTietDonHang()
        {
            InitializeComponent();
            busDH = new BUS_DonHang();
        }
        public void truyenNV(NhanVien n)
        {
            nv = n;
        }

        private void HienThiLenDG(int ma)
        {
            gVCTDH.DataSource = null;
            busDH.HienThiChiTietDH(gVCTDH,ma);
            gVCTDH.Columns[0].Width = (int)(gVCTDH.Width * 0.08);
            gVCTDH.Columns[1].Width = (int)(gVCTDH.Width * 0.08);
            gVCTDH.Columns[2].Width = (int)(gVCTDH.Width * 0.3);

            gVCTDH.Columns[0].HeaderText = "Mã ĐH";
            gVCTDH.Columns[1].HeaderText = "Sản Phẩm";
            gVCTDH.Columns[2].HeaderText = "Loại";
            gVCTDH.Columns[3].HeaderText = "Số lượng";
            gVCTDH.Columns[4].HeaderText = "Đơn giá";
            gVCTDH.Columns[5].HeaderText = "Giảm giá";

        }
        private void FChiTietDonHang_Load(object sender, EventArgs e)
        {
        }
        private void gVCTDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVCTDH.Rows.Count)
            {
                txtMaDH.Enabled = false;
                txtMaSP.Enabled = false;
                txtTenSP.Enabled = false;
                txtDonGia.Enabled = false;
                txtMaDH.Text = gVCTDH.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtMaSP.Text = gVCTDH.Rows[e.RowIndex].Cells["IDSanPham"].Value.ToString();
                txtTenSP.Text = gVCTDH.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDonGia.Text = gVCTDH.Rows[e.RowIndex].Cells["DonGia"].Value.ToString();
                txtSoLuong.Text = gVCTDH.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            FDatHang f = new FDatHang();
            f.truyenNV(nv);
            f.maDH = this.maDH;
            f.ShowDialog();
        }

       

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FQLDonHang f = new FQLDonHang();
            f.truyenNV(nv);
            f.ShowDialog();
            this.Close();
        }

        private void FChiTietDonHang_Activated(object sender, EventArgs e)
        {
            HienThiLenDG(maDH);
        }

      /*  private void btSua_Click(object sender, EventArgs e)
        {
            ChiTietDonHang d = new ChiTietDonHang();
            d.IDDonHang = int.Parse(txtMaDH.Text); //kiem tra xem co don hang de sua khong
            d.IDSanPham = int.Parse(txtMaSP.Text);
            d.DonGia = int.Parse(txtDonGia.Text);
            d.SoLuong = int.Parse(txtSoLuong.Text);
            //Goi su kien them cua Bus
            if (busDH.SuaCTDonHang(d))
            {
                MessageBox.Show("Sửa đơn hàng thành công!!!");
                busDH.HienThiChiTietDH(gVCTDH, maDH);
            }
            else
            {
                MessageBox.Show("Sửa đơn hàng không thành công!!!");
            }
        }*/
         private void btXoa_Click(object sender, EventArgs e)
         {
            ChiTietDonHang d = new ChiTietDonHang();
            d.IDSanPham = int.Parse(txtMaSP.Text);
            d.IDDonHang = int.Parse(txtMaDH.Text);
            //Goi su kien them cua Bus
            if (busDH.XoaCTDonHangSP(d))
            {
                MessageBox.Show("Xóa đơn hàng thành công!!!");
                busDH.HienThiChiTietDH(gVCTDH,maDH);
            }
            else
            {
                MessageBox.Show("Xóa đơn hàng không thành công!!!");
            }
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
