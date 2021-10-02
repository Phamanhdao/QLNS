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
    public partial class FQLNV : Form
    {
        BUSNhanVien bNV;
        private int maNV, maLoaiNV, maCV;
        private bool co = false;
        public FQLNV()
        {
            InitializeComponent();
            bNV = new BUSNhanVien();
        }


        private void btTaoNV_Click(object sender, EventArgs e)
        {
            FCTNV f = new FCTNV();
            f.ShowDialog();
        }
        //Đổ dữ liệu vào datagridview
        public void HienThiDSNV()
        {
            gvNV.DataSource = null;
            bNV.HienThidsnv(gvNV);
            //Định dạng lại datagridview
            gvNV.Columns[0].HeaderText = "Mã nhân viên";
            gvNV.Columns[1].HeaderText = "Tên nhân viên";
            gvNV.Columns[2].HeaderText = "Chức vụ";
            gvNV.Columns[3].HeaderText = "Loại nhân viên";
            gvNV.Columns[4].HeaderText = "Số điện thoại";
            gvNV.Columns[5].HeaderText = "Ngày vào làm";
            gvNV.Columns[6].HeaderText = "Ngày sinh";
            gvNV.Columns[7].HeaderText = "Giới tính";
            gvNV.Columns[0].Width = (int)(gvNV.Width * 0.2);
            gvNV.Columns[1].Width = (int)(gvNV.Width * 0.25);
            gvNV.Columns[2].Width = (int)(gvNV.Width * 0.2);
            gvNV.Columns[3].Width = (int)(gvNV.Width * 0.25);
            gvNV.Columns[4].Width = (int)(gvNV.Width * 0.2);
            gvNV.Columns[5].Width = (int)(gvNV.Width * 0.2);
            gvNV.Columns[6].Width = (int)(gvNV.Width * 0.2);
            gvNV.Columns[7].Width = (int)(gvNV.Width * 0.2);
            //Căn giữa, tô đậm header 
            gvNV.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            gvNV.RowsDefaultCellStyle.Font = new Font("Times New Roman", 9, FontStyle.Regular);
            gvNV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
           
            
            //Tô nền header datagridview.
            gvNV.EnableHeadersVisualStyles = false ;
            gvNV.ColumnHeadersDefaultCellStyle.BackColor = Color.Coral;
            //Căn giữa datagridview
            gvNV.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gvNV.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gvNV.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gvNV.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gvNV.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gvNV.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void FQLNV_Load(object sender, EventArgs e)
        {
            HienThiDSNV();
            bNV.HienThiDSTenNVLenCb(cbTenNV);
            bNV.HienThiDSLoaiNVLenCb(cbLoaiNV);
            bNV.HienThiDSChucVuNVLenCb(cbChucVu);
            txtmaNV.Text = " ";
            txtmaloainv.Text = " ";
            txtmacv.Text = " ";
            co = true;
            txtmacv.Enabled = false;
            txtmaloainv.Enabled = false;
            txtmaNV.Enabled = false;
        }

        private void btDSNV_Click(object sender, EventArgs e)
        {
            HienThiDSNV();
        }

        private void cbTenNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (co)
            {
                txtmaNV.Text = cbTenNV.SelectedValue.ToString();
                maNV = int.Parse(txtmaNV.Text);
                bNV.HienThiDSNVTheoTenNV(gvNV, maNV); 
            }
        }

        private void btTraCuu_Click(object sender, EventArgs e)
        {
            
            txtmacv.Text = cbChucVu.SelectedValue.ToString();
            maCV = int.Parse(txtmacv.Text);
            txtmaloainv.Text = cbLoaiNV.SelectedValue.ToString();
            maLoaiNV = int.Parse(txtmaloainv.Text);
            bNV.HienThiDSNVTheoLNVVaCV(gvNV, maLoaiNV, maCV);
        }

        private void btTroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainQuanLy main = new MainQuanLy();
            main.ShowDialog();
            this.Close();
        }

        private void cbLoaiNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (co)
            {
                txtmaloainv.Text = cbLoaiNV.SelectedValue.ToString();
                maLoaiNV = int.Parse(txtmaloainv.Text);
                bNV.HienThiDSNVTheoLoaiNV(gvNV, maLoaiNV);
            }
        }
        private void cbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (co)
            {
                txtmacv.Text = cbChucVu.SelectedValue.ToString();
                maCV = int.Parse(txtmacv.Text);
                bNV.HienThiDSNVTheoCVNV(gvNV, maCV);
            }
        }

        //
    }
}
