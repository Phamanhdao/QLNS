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
    public partial class FDatHang : Form
    {
        //Khai báo một biến mã đơn hàng, để lấy mã đơn hàng từ form quản lý  
        public int maDH;
        BUS_DonHang busDH;
        BUS_SanPham busSP;
        BUS_NhaCC busNCC;
        DataTable tbDonHang;
        private bool co = false;


        public FDatHang()
        {
            InitializeComponent();
            busDH = new BUS_DonHang();
            busSP = new BUS_SanPham();
            busNCC = new BUS_NhaCC();
        }

        private void gVCTDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.RowIndex < gVCTDH.Rows.Count)
            {
                txtMaDh.Enabled = false;
                txtMaDh.Text= gVCTDH.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbLoaiSanPham.Text = gVCTDH.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDonGia.Text = gVCTDH.Rows[e.RowIndex].Cells["DonGia"].Value.ToString();
                txtGiamGia.Text = gVCTDH.Rows[e.RowIndex].Cells["GiamGia"].Value.ToString();
            }
        }

        private void FDatHang_Load(object sender, EventArgs e)
        {
            txtMaDh.Enabled = false;
            busSP.HienThiDSTenSP(cbSanPham);
            co = true;
            txtMaDh.Text = maDH.ToString();
            txtGiamGia.Text = "0";
            //Dinh nghia GV 4 cot
            tbDonHang = new DataTable();
            tbDonHang.Columns.Add("ID");
            tbDonHang.Columns.Add("DonGia");
            tbDonHang.Columns.Add("SoLuong");
            tbDonHang.Columns.Add("GiamGia");
            //Dua datatable vaof gv
            gVCTDH.DataSource = tbDonHang;
            gVCTDH.Columns[0].Width = (int)(gVCTDH.Width * 0.2);
            gVCTDH.Columns[1].Width = (int)(gVCTDH.Width * 0.25);
            gVCTDH.Columns[2].Width = (int)(gVCTDH.Width * 0.25);
            gVCTDH.Columns[3].Width = (int)(gVCTDH.Width * 0.25);
        }      
        
        private void cbSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int maSP;
            NhaCungCap_SanPham dh;
            //Lay thong tin
            if (co)
            {
                maSP = Int32.Parse(cbSanPham.SelectedValue.ToString());
                dh = busSP.LayTTSPNCC(maSP);

                cbLoaiSanPham.Text = dh.SanPham.DanhMucSanPham.TenDanhMucSanPham.ToString();
                txtDonGia.Text = dh.SanPham.DonGia.ToString();
                cbNCC.Text = dh.NhaCungCap.Ten.ToString();
            }
        }
        
        private void btThoat_Click(object sender, EventArgs e)
        {
           Close();

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtDonGia.Text != "")
            {
                DataRow r;
                bool kt = true;
                foreach (DataRow item in tbDonHang.Rows)
                {
                    if (cbSanPham.SelectedValue.ToString() == item[0].ToString())
                    {
                        //da co
                        item[2] = (int.Parse(item[2].ToString()) + Convert.ToInt32(numericSlg.Value)).ToString();
                        kt = false;
                        break;
                    }
                }
                //Them 1 dong vao gv
                if (kt)
                {
                    //1. tao moi 1 dong datarow
                    r = tbDonHang.NewRow();
                    //2. thiet lap cac thuoc tinh cho dong
                    r[0] = int.Parse(cbSanPham.SelectedValue.ToString()); //ma
                    r[1] = int.Parse(txtDonGia.Text.Replace(".", ""));
                    r[2] = Convert.ToInt32(numericSlg.Value);
                    r[3] = float.Parse(txtGiamGia.Text);
                    //3. them vao datatable
                    tbDonHang.Rows.Add(r);
                }
                cbLoaiSanPham.Text = txtDonGia.Text = cbNCC.Text =  string.Empty;
                numericSlg.Value = default;

            }
            else
                MessageBox.Show("Chọn sản phầm cần thêm vào đơn hàng");
        }

        private void btDatHang_Click(object sender, EventArgs e)
        {
            //Luu datatable xuong database
            if (busDH.ThemCTDonHang(maDH, tbDonHang))
            {
                MessageBox.Show("Đặt hàng thành công!!");
                Close();
            }
            else
                MessageBox.Show("Đặt hàng không thành công!!!");
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell item in gVCTDH.SelectedCells)
            {
                if (item.Selected)
                    gVCTDH.Rows.RemoveAt(item.RowIndex);
            }
            tbDonHang.AcceptChanges();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
