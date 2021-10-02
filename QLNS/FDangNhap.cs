using BTL_LTCSDL.BUS;
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
    public partial class FDangNhap : Form
    {
        BUS_DangNhap busDN;
        public FDangNhap()
        {
            InitializeComponent();
            busDN = new BUS_DangNhap();
        }

        private void FDangNhap_Load(object sender, EventArgs e)
        {
            busDN.LayDSCV(cbChucVu);
            this.KeyPreview = true;
        }

        private void FDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btDangNhap_Click(sender, e);
            }
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDangNhap.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
                MessageBox.Show("Vui lòng nhập đầy đủ!!!");
            else
            {
                NhanVien nv = new NhanVien();
                nv.IDChucVu = Int32.Parse(cbChucVu.SelectedValue.ToString());
                nv.TenDangNhap = txtTenDangNhap.Text;
                nv.MatKhau = txtMatKhau.Text;
                if (busDN.DangNhap(nv))
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
                else
                    MessageBox.Show("Sai Chức Vụ hoặc Tên Đăng Nhập hoặc Mật Khẩu!!!");
            }
        }

        private void txtTenDangNhap_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = false;
            if (string.IsNullOrEmpty(txtTenDangNhap.Text))
                errorProvider1.SetError(txtTenDangNhap, "Vui lòng nhập tên đăng nhập!!!");
            else
            {
                errorProvider1.SetError(txtTenDangNhap, null);
            }
        }

        private void txtMatKhau_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = false;
            if (string.IsNullOrEmpty(txtMatKhau.Text))
                errorProvider2.SetError(txtMatKhau, "Vui lòng nhập mật khẩu!!!");
            else
            {
                errorProvider2.SetError(txtMatKhau, null);
            }
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
