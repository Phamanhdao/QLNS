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
    public partial class FCTSP : Form
    {
        BUS_SanPham bSP;
        public FCTSP()
        {
            InitializeComponent();
            bSP = new BUS_SanPham();
        }


        private void btThemNV_Click(object sender, EventArgs e)
        {
            
            if (int.Parse(cbLoaiSP.SelectedValue.ToString()) != 1)
            {
                FSP f = new FSP();
                f.ShowDialog();
            }
            else
            {
                FSach f = new FSach();
                f.ShowDialog();
            }
            HienThiDLDG(gvCTSP);
        }
        public void HienThiDLDG(DataGridView gv )
        {
            gvCTSP.DataSource = null;
            bSP.HienThiDSSPDGCTSP(gvCTSP);
            //Định nghĩa lại các cột trong DataGridView
            gvCTSP.Columns[0].Width = (int)(gvCTSP.Width * 0.15);
            gvCTSP.Columns[1].Width = (int) (gvCTSP.Width * 0.2);
            gvCTSP.Columns[2].Width = (int)(gvCTSP.Width * 0.2);
            gvCTSP.Columns[3].Width = (int)(gvCTSP.Width * 0.2);
            gvCTSP.Columns[4].Width = (int)(gvCTSP.Width * 0.2);
            gvCTSP.Columns[5].Width = (int)(gvCTSP.Width * 0.2);
            gvCTSP.Columns[6].Width = (int)(gvCTSP.Width * 0.2);
            gvCTSP.Columns[0].HeaderText = "Mã sản phẩm";
            gvCTSP.Columns[1].HeaderText = "Tên sản phẩm";
            gvCTSP.Columns[2].HeaderText = "Tên danh mục sản phẩm";
            gvCTSP.Columns[3].HeaderText = "Số lượng";
            gvCTSP.Columns[4].HeaderText = "Đơn giá";
            gvCTSP.Columns[5].HeaderText = "Tên nhà cung cấp";
            gvCTSP.Columns[6].HeaderText = "Ngày nhập hàng";
            
            //Căn giữa, chỉnh font
            gvCTSP.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            gvCTSP.RowsDefaultCellStyle.Font = new Font("Times New Roman", 9, FontStyle.Regular);
            gvCTSP.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gvCTSP.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //Tô nền header datagridview.
            gvCTSP.EnableHeadersVisualStyles = false;
            gvCTSP.ColumnHeadersDefaultCellStyle.BackColor = Color.Coral;
           
        }
        private void FCTSP_Load(object sender, EventArgs e)
        {
            bSP.HienThiDSLoaiSPLenCb(cbLoaiSP);
            HienThiDLDG(gvCTSP);
            bSP.HienThiDSNhaCCLenCb(cbNhaCC);
        }
     
        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
            FQLSP f = new FQLSP();
            f.ShowDialog();
        }

        private void gvCTSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenSP.Text = gvCTSP.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbLoaiSP.Text = gvCTSP.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSL.Text = gvCTSP.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtGiaBan.Text = gvCTSP.Rows[e.RowIndex].Cells[4].Value.ToString();
            cbNhaCC.Text = gvCTSP.Rows[e.RowIndex].Cells[5].Value.ToString();
            dPNgayNhapHang.Value = DateTime.Parse(gvCTSP.Rows[e.RowIndex].Cells[6].Value.ToString());
        }
        
    }
}
