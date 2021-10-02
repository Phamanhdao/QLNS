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
    public partial class MainQuanLy : Form
    {
        public MainQuanLy()
        {
            InitializeComponent();
        }

        private void qldh_bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            FQLDonHang fQLDonHang = new FQLDonHang();
            fQLDonHang.ShowDialog();
            this.Close();
        }

        private void qlncc_bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            FQLNhaCC fQLNhaCC = new FQLNhaCC();
            fQLNhaCC.ShowDialog();
            this.Close();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn có muốn đăng xuất không?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (thoat == DialogResult.Yes)
                Close();
        }
    }
}
