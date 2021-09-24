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
    public partial class FQLNV : Form
    {
        public FQLNV()
        {
            InitializeComponent();
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn có muốn đăng xuất không?", "Đăng xuất",MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (thoat == DialogResult.Yes)
                Close();       
        }
    }
}
