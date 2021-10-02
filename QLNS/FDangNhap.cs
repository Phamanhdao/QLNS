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
            busDN.LayDSLNV(cbLoaiTK);
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDangNhap.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
                MessageBox.Show("Vui lòng nhập đầy đủ!!!");
            else
            {
                NhanVien nv = new NhanVien();
                nv.IDLoaiNhanVien = Int32.Parse(cbLoaiTK.SelectedValue.ToString());
                nv.TenDangNhap = txtTenDangNhap.Text;
                nv.MatKhau = txtMatKhau.Text;
                if (busDN.DangNhap(nv))
                {
                    this.Hide();
                    MainQuanLy main = new MainQuanLy();
                    main.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("Sai Loại Nhân Viên hoặc Tên Đăng Nhập hoặc Mật Khẩu!!!");
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
    }
}
