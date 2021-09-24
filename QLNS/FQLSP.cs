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
    public partial class FQLSP : Form
    {
        BUS_SanPham bSP;
        public FQLSP()
        {
            InitializeComponent();
            bSP = new BUS_SanPham();
        }

      

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn có muốn đăng xuất không?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (thoat == DialogResult.Yes)
                Close();
        }

        //
        //HIển thị dữ liệu lên dg
        public void HienThiDLDG()
        {
            gvSP.DataSource = null;
            bSP.HienThiDSSP(gvSP);
            gvSP.Columns[0].Width = (int)(gvSP.Width * 0.2);
            gvSP.Columns[1].Width = (int)(gvSP.Width * 0.2);
            gvSP.Columns[2].Width = (int)(gvSP.Width * 0.2);
            gvSP.Columns[3].Width = (int)(gvSP.Width * 0.2);
            gvSP.Columns[4].Width = (int)(gvSP.Width * 0.2);
        }
        private void FQLSP_Load(object sender, EventArgs e)
        {
            HienThiDLDG();
            bSP.HienThiDSLoaiSPLenCb(cbLoaiSP);
            bSP.HienThiDSTenSPLenCb(cbTenSP);
            bSP.HienThiDSNhaCCLenCb(cbNCC);
        }

        private void gvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSP.Enabled = false;
            txtMaSP.Text = gvSP.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbTenSP.Text = gvSP.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbLoaiSP.Text = gvSP.Rows[e.RowIndex].Cells[2].Value.ToString();
            // cbNCC.Text = gvSP.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSL.Text = gvSP.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDonGia.Text = gvSP.Rows[e.RowIndex].Cells[4].Value.ToString();
            
        }
    }
}
