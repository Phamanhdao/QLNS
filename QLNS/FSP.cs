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
    public partial class FSP : Form
    {
        BUS_SanPham bSP;
        NhanVien nv;
        public FSP()
        {
            InitializeComponent();
            bSP = new BUS_SanPham();
        }
        public void truyenNV(NhanVien n)
        {
            nv = n;
        }

        public void HienThiDLDGFSP(DataGridView gv)
        {
            gvSP.DataSource = null;
            bSP.HienThiDSSPFSP(gvSP);
            //Định nghĩa lại các cột trong DataGridView
            gvSP.Columns[0].Width = (int)(gvSP.Width * 0.15);
            gvSP.Columns[1].Width = (int)(gvSP.Width * 0.2);
            gvSP.Columns[2].Width = (int)(gvSP.Width * 0.2);
            gvSP.Columns[3].Width = (int)(gvSP.Width * 0.2);
            gvSP.Columns[4].Width = (int)(gvSP.Width * 0.2);
            gvSP.Columns[5].Width = (int)(gvSP.Width * 0.2);
            gvSP.Columns[6].Width = (int)(gvSP.Width * 0.2);
            gvSP.Columns[0].HeaderText = "Mã sản phẩm";
            gvSP.Columns[1].HeaderText = "Tên sản phẩm";
            gvSP.Columns[2].HeaderText = "Tên danh mục sản phẩm";
            gvSP.Columns[3].HeaderText = "Số lượng";
            gvSP.Columns[4].HeaderText = "Đơn giá";
            gvSP.Columns[5].HeaderText = "Tên nhà cung cấp";
            gvSP.Columns[6].HeaderText = "Ngày nhập hàng";

            //Căn giữa, chỉnh font
            gvSP.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            gvSP.RowsDefaultCellStyle.Font = new Font("Times New Roman", 9, FontStyle.Regular);
            gvSP.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gvSP.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //Tô nền header datagridview.
            gvSP.EnableHeadersVisualStyles = false;
            gvSP.ColumnHeadersDefaultCellStyle.BackColor = Color.Coral;

        }

       
        //Báo lỗi khi bỏ trống txt
        private void txtTenSP_TextChanged(object sender, EventArgs e)
        {
            if (txtTenSP.TextLength == 0)
            {
                erTenSP.SetError(txtTenSP, "Vui lòng nhập tên sản phẩm!");
            }
            else
                erTenSP.Clear();
        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {
            if (txtGiaBan.TextLength == 0)
            {
                erGiaBan.SetError(txtGiaBan, "Vui lòng nhập giá sản phẩm!");
            }
            else
                erGiaBan.Clear();
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            if (txtSL.TextLength == 0)
            {
                erSL.SetError(txtSL, "Vui lòng nhập số lượng!");
            }
            else
                erSL.Clear();
        }

        private void FSP_Load(object sender, EventArgs e)
        {
            HienThiDLDGFSP(gvSP);
            bSP.HienThiDSNhaCCLenCb(cbNhaCC);
            bSP.HienThiDSLoaiSPKhongCoSachLenCb(cbLoaiSP);
        }
       

        private void gvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMasp.Enabled = false;
            txtMasp.Text = gvSP.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenSP.Text = gvSP.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbLoaiSP.Text = gvSP.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSL.Text = gvSP.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtGiaBan.Text = gvSP.Rows[e.RowIndex].Cells[4].Value.ToString();
            cbNhaCC.Text = gvSP.Rows[e.RowIndex].Cells[5].Value.ToString();
            dPNgayNhapHang.Value = DateTime.Parse(gvSP.Rows[e.RowIndex].Cells[6].Value.ToString());
        }
        //Xóa sản phẩm
        private void btXoa_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.ID = int.Parse(txtMasp.Text);
            if (bSP.XoaSP( sp ))
            {
                MessageBox.Show("Xóa sản phẩm thành công!");
                HienThiDLDGFSP(gvSP);
            }
            else
                MessageBox.Show("Xóa sản phẩm thất bại!");
            XoaTrongTXT();


        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }
        public void XoaTrongTXT()
        {
            txtGiaBan.Clear();
            txtMasp.Clear();
            txtSL.Clear();
            txtTenSP.Clear();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.ID = int.Parse(txtMasp.Text);
            if (bSP.CapNhatSP(sp))
            {
                MessageBox.Show("Sửa sản phẩm thành công!");
                HienThiDLDGFSP(gvSP);
            }
            else
                MessageBox.Show("Sửa sản phẩm thất bại!");
            XoaTrongTXT();
        }

        private void btLuuSP_Click(object sender, EventArgs e)
        {

            if (txtTenSP.TextLength == 0)
                erTenSP.SetError(txtTenSP, "Vui lòng nhập tên sản phẩm!");
            if (txtGiaBan.TextLength == 0)
                erGiaBan.SetError(txtGiaBan, "Vui lòng nhập giá sản phẩm!");
            if (txtSL.TextLength == 0)
                erSL.SetError(txtSL, "Vui lòng nhập số lượng!");
            if (txtTenSP.TextLength != 0 && txtGiaBan.TextLength != 0 && txtSL.TextLength != 0)
            {
                SanPham sp = new SanPham();
                sp.TenSanPham = txtTenSP.Text;
                sp.IDDanhMucSanPham = int.Parse(cbLoaiSP.SelectedValue.ToString());
                sp.DonGia = int.Parse(txtGiaBan.Text);
                sp.SoLuongTonKho = int.Parse(txtSL.Text.ToString());
                sp.NgayNhapHang = dPNgayNhapHang.Value;
                NhaCungCap_SanPham ncc = new NhaCungCap_SanPham();
                ncc.IDNhaCungCap = int.Parse(cbNhaCC.SelectedValue.ToString());
                bSP.ThemSP(sp, ncc);
                HienThiDLDGFSP(gvSP);
                XoaTrongTXT();
            }
        }
    }
}
