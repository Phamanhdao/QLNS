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
    public partial class MainThuNgan : Form
    {
        public MainThuNgan()
        {
            InitializeComponent();
        }

        private void btQLDH_Click(object sender, EventArgs e)
        {
            this.Hide();
            FQLDonHang fQLDonHang = new FQLDonHang();
            fQLDonHang.ShowDialog();
            this.Close();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn có muốn đăng xuất không?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (thoat == DialogResult.Yes)
            {
                this.Hide();
                FDangNhap dn = new FDangNhap();
                dn.ShowDialog();
                Close();
            }
        }

        private void btQLSanPham_Click(object sender, EventArgs e)
        {
            this.Hide();
            FQLSP f = new FQLSP();
            f.ShowDialog();
            this.Close();
        }
    }
}
