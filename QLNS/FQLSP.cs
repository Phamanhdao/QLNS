using QLNS.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
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
        private int maNCC;
        private int maDMSP;
        private bool co = false;
        NhanVien nv;
        public FQLSP()
        {
            InitializeComponent();
            bSP = new BUS_SanPham();
        }
        public void truyenNV(NhanVien n)
        {
            nv = n;
        }

        //
        //HIển thị dữ liệu lên dg
        public void HienThiDLDG()
        {
            gvQLSP.DataSource = null;
            bSP.HienThiDSSP(gvQLSP);
            gvQLSP.Columns[0].HeaderText = "Mã sản phẩm";
            gvQLSP.Columns[1].HeaderText = "Tên sản phẩm";
            gvQLSP.Columns[2].HeaderText = "Tên danh mục sản phẩm";
            gvQLSP.Columns[3].HeaderText = "Số lượng";
            gvQLSP.Columns[4].HeaderText = "Đơn giá";
            gvQLSP.Columns[5].HeaderText = "Tên nhà cung cấp";
            gvQLSP.Columns[0].Width = (int)(gvQLSP.Width * 0.15);
            gvQLSP.Columns[1].Width = (int)(gvQLSP.Width * 0.2);
            gvQLSP.Columns[2].Width = (int)(gvQLSP.Width * 0.25);
            gvQLSP.Columns[3].Width = (int)(gvQLSP.Width * 0.15);
            gvQLSP.Columns[4].Width = (int)(gvQLSP.Width * 0.15);
            gvQLSP.Columns[5].Width = (int)(gvQLSP.Width * 0.2);
            //Căn giữa, tô đậm header gvSP
            gvQLSP.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            gvQLSP.RowsDefaultCellStyle.Font = new Font("Times New Roman", 9, FontStyle.Regular);
            gvQLSP.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gvQLSP.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gvQLSP.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //Tô nền header datagridview.
            gvQLSP.EnableHeadersVisualStyles = false;
            gvQLSP.ColumnHeadersDefaultCellStyle.BackColor = Color.Coral;

            
        }
        private void FQLSP_Load(object sender, EventArgs e)
        {
            HienThiDLDG();
            bSP.HienThiDSLoaiSPLenCb(cbLoaiSP);
            bSP.HienThiDSNhaCCLenCb(cbNCC);
            txtmasp.Text = " ";
            txtncc.Text = " ";
            co = true;
           
        }

        //chuyển qua form chi tiêt sản phẩm
        private void btCTSP_Click(object sender, EventArgs e)
        {
            FCTSP f = new FCTSP();
            f.truyenNV(nv);
            f.ShowDialog();
            Close();
        }

        //HIển thị lại tất cả sản phẩm
        private void btHienThiSP_Click(object sender, EventArgs e)
        {
            HienThiDLDG();
        }

        private void btDangXuat_Click(object sender, EventArgs e)
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

        private void cbLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (co)
            {

                txtmasp.Text = cbLoaiSP.SelectedValue.ToString();
                maDMSP = int.Parse(txtmasp.Text);
                bSP.HienThiDSSPTheoDM(gvQLSP, maDMSP); 
            }

        }

        private void cbNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (co)
            {
                txtncc.Text = cbNCC.SelectedValue.ToString();
                maNCC = int.Parse(txtncc.Text);
                bSP.HienThiDSSPTheoNCC(gvQLSP, maNCC);
            }
        }

        private void btTraCuu_Click(object sender, EventArgs e)
        {
                txtncc.Text = cbNCC.SelectedValue.ToString();
                maNCC = int.Parse(txtncc.Text);
                txtmasp.Text = cbLoaiSP.SelectedValue.ToString();
                maDMSP = int.Parse(txtmasp.Text);
                bSP.HienThiSpTraCuu(gvQLSP, maDMSP, maNCC); 
        }

        private void btTraCuu_MouseHover(object sender, EventArgs e)
        {
            ttTraCuu.SetToolTip(btTraCuu, "Lọc thông tin theo danh mục sản phẩm và nhà cung cấp ");
        }

        private void cbLoaiSP_MouseHover(object sender, EventArgs e)
        {
            ttcbLSP.SetToolTip(cbLoaiSP, "Lấy danh sách sản phẩm theo loại sản phẩm");
        }

        private void cbNCC_MouseHover(object sender, EventArgs e)
        {
            ttcbNCC.SetToolTip(cbNCC, "Lấy danh sách sản phẩm theo  nhà cung cấp");
        }

        private void btCTSP_MouseHover(object sender, EventArgs e)
        {
            ttbtCTSP.SetToolTip(btCTSP, "Hiển thị thông tin chi tiết sản phẩm");
        }

        private void btHienThiSP_MouseHover(object sender, EventArgs e)
        {
            ttbtTCSP.SetToolTip(btHienThiSP, "Hiển thị tất cả sản phẩm");
        }
    }
}
