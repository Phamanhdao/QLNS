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
using QLNS.Report;

namespace QLNS
{
    public partial class FQLNhaCC : Form
    {
        BUS_NhaCC busNCC;
        BUS_SanPham busSP;
        NhanVien nv;

        public FQLNhaCC()
        {
            InitializeComponent();
            busNCC = new BUS_NhaCC();
            busSP = new BUS_SanPham();
        }

        public void truyenNV(NhanVien n)
        {
            nv = n;
        }

        private void HienThiLenDG()
        {
            gVNCC.DataSource = null;
            busNCC.HienThiDSNCC(gVNCC);

        }

        private void FQLNhaCC_Load(object sender, EventArgs e)
        {
            HienThiLenDG();
        }

        private void gVNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataGridViewRow rw = new DataGridViewRow();
                rw = gVNCC.Rows[e.RowIndex];
                if (rw.Cells[1].Value is null && rw.Cells[2].Value is null && rw.Cells[3].Value is null && rw.Cells[4].Value is null && rw.Cells[5].Value is null && rw.Cells[6].Value is null)
                {
                    txtTenNCC.Text = txtDiaChi.Text = txtSdt.Text = txtNgLH.Text = txtChucVu.Text = txtEmail.Text = string.Empty;
                }
                else
                    if (e.RowIndex >= 0 && e.RowIndex < gVNCC.Rows.Count)
                {
                    txtMaNCC.Enabled = false;
                    txtMaNCC.Text = rw.Cells[0].Value.ToString();
                    txtTenNCC.Text = rw.Cells[1].Value.ToString();
                    txtDiaChi.Text = rw.Cells["DiaChi"].Value.ToString();
                    txtSdt.Text = rw.Cells["SDT"].Value.ToString();
                    txtNgLH.Text = rw.Cells["NguoiLienHe"].Value.ToString();
                    txtChucVu.Text = rw.Cells["ChucVuNguoiLienHe"].Value.ToString();
                    txtEmail.Text = rw.Cells["Email"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text != "")
            {
                NhaCungCap ncc = new NhaCungCap();
                ncc.ID = int.Parse(txtMaNCC.Text);
                ncc.Ten = txtTenNCC.Text;
                ncc.NguoiLienHe = txtNgLH.Text;
                ncc.ChucVuNguoiLienHe = txtChucVu.Text;
                ncc.DiaChi = txtDiaChi.Text;
                ncc.Email = txtEmail.Text;
                ncc.SDT = txtSdt.Text;

                if (busNCC.ThemNCC(ncc))
                {
                    MessageBox.Show("Thêm nhà cung cấp thành công!!!");
                    busNCC.HienThiDSNCC(gVNCC);
                }
                else
                    MessageBox.Show("TThêm không thành công!!!");
            }
            else
                MessageBox.Show("Chưa nhập thông tin cần thêm!!!");
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            NhaCungCap n = new NhaCungCap();
            n.ID = int.Parse(txtMaNCC.Text);
            //Goi su kien them cua Bus
            if (busNCC.XoaNhaCC(n))
            {
                MessageBox.Show("Xóa nhà cung cấp thành công!!!");
                busNCC.HienThiDSNCC(gVNCC);
            }
            else
            {
                MessageBox.Show("Xóa không thành công!!!");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            NhaCungCap ncc = new NhaCungCap();
            ncc.ID = int.Parse(txtMaNCC.Text);
            ncc.Ten = txtTenNCC.Text;
            ncc.NguoiLienHe = txtNgLH.Text;
            ncc.ChucVuNguoiLienHe = txtChucVu.Text;
            ncc.DiaChi = txtDiaChi.Text;
            ncc.Email = txtEmail.Text;
            ncc.SDT = txtSdt.Text;

            if (busNCC.SuaNCC(ncc))
            {
                MessageBox.Show("Sửa nhà cung cấp thành công!!!");
                busNCC.HienThiDSNCC(gVNCC);
            }
            else
                MessageBox.Show("Sửa không thành công!!!");
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (nv.IDChucVu == 1)
            { 
                MainQuanLy main = new MainQuanLy();
                main.truyenNV(nv);
                main.ShowDialog();
            }
            if (nv.IDChucVu == 2)
            {
                MainKeToan main = new MainKeToan();
                main.truyenNV(nv);
                main.ShowDialog();
            }
            if (nv.IDChucVu == 3)
            {
                MainThuNgan main = new MainThuNgan();
                main.truyenNV(nv);
                main.ShowDialog();
            }
            this.Close();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FDangNhap dn = new FDangNhap();
            dn.ShowDialog();
        }

        private void btReportSp_Click(object sender, EventArgs e)
        {
            CR_SanPham r = new CR_SanPham();
            FReportSanPham f = new FReportSanPham();

            r.SetDataSource(busNCC.LayDSNCC().ToList());
            f.crystalReportViewer1.ReportSource = r;

            f.Show();
        }

        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
