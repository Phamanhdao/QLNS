using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNS.BUS;

namespace QLNS
{
    public partial class FCTNV : Form
    {
        BUSNhanVien bNV;
        private bool co = false;
        public FCTNV()
        {
            InitializeComponent();
            bNV = new BUSNhanVien();
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
                Close();
        }
        public void HienThiDSCTNV()
        {
            gvCTNV.DataSource = null;
            bNV.HienThidsctnv(gvCTNV);
            gvCTNV.Columns[0].HeaderText = "Mã nhân viên";
            gvCTNV.Columns[1].HeaderText = "Tên nhân viên";
            gvCTNV.Columns[2].HeaderText = "Chức vụ";
            gvCTNV.Columns[3].HeaderText = "Loại nhân viên";
            gvCTNV.Columns[4].HeaderText = "Số điện thoại";
            gvCTNV.Columns[5].HeaderText = "Ngày vào làm";
            gvCTNV.Columns[6].HeaderText = "Ngày sinh";
            gvCTNV.Columns[7].HeaderText = "Giới tính";
            gvCTNV.Columns[8].HeaderText = "Công việc";
            gvCTNV.Columns[9].HeaderText = "Địa điểm";
            gvCTNV.Columns[10].HeaderText = "Bằng cấp";
            gvCTNV.Columns[11].HeaderText = "Thời gian làm";
            gvCTNV.Columns[12].HeaderText = "Ghi chú";
            gvCTNV.Columns[0].Width = (int)(gvCTNV.Width * 0.2);
            gvCTNV.Columns[1].Width = (int)(gvCTNV.Width * 0.25);
            gvCTNV.Columns[2].Width = (int)(gvCTNV.Width * 0.2);
            gvCTNV.Columns[3].Width = (int)(gvCTNV.Width * 0.25);
            gvCTNV.Columns[4].Width = (int)(gvCTNV.Width * 0.2);
            gvCTNV.Columns[5].Width = (int)(gvCTNV.Width * 0.2);
            gvCTNV.Columns[6].Width = (int)(gvCTNV.Width * 0.2);
            gvCTNV.Columns[7].Width = (int)(gvCTNV.Width * 0.2);
            gvCTNV.Columns[8].Width = (int)(gvCTNV.Width * 0.25);
            gvCTNV.Columns[9].Width = (int)(gvCTNV.Width * 0.2);
            gvCTNV.Columns[10].Width = (int)(gvCTNV.Width * 0.2);
            gvCTNV.Columns[11].Width = (int)(gvCTNV.Width * 0.2);
            gvCTNV.Columns[12].Width = (int)(gvCTNV.Width * 0.2);
            //Căn giữa, tô đậm header 
            gvCTNV.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            gvCTNV.RowsDefaultCellStyle.Font = new Font("Times New Roman", 9, FontStyle.Regular);
            gvCTNV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            //Tô nền header datagridview.
            gvCTNV.EnableHeadersVisualStyles = false;
            gvCTNV.ColumnHeadersDefaultCellStyle.BackColor = Color.Coral;
            //Căn giữa datagridview
            gvCTNV.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gvCTNV.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gvCTNV.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gvCTNV.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gvCTNV.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gvCTNV.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gvCTNV.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void FCTNV_Load(object sender, EventArgs e)
        {
            HienThiDSCTNV();
            bNV.HienThiDSChucVuNVLenCb(cbChucVu);
            bNV.HienThiDSLoaiNVLenCb(cbLoaiNV);
            txtMaNV.Enabled = false;
            txtMK.Enabled = false;
            txtTenDN.Enabled = false;
            co = true;
        }

       

        private void cbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (co)
            {
                int mcv = int.Parse(cbChucVu.SelectedValue.ToString());
                if (mcv == 1 || mcv == 2 || mcv == 3)
                {
                    txtTenDN.Enabled = true;
                    txtMK.Enabled = true;
                }
                else
                {
                    txtTenDN.Enabled = false;
                    txtMK.Enabled = false;
                }    
            }
        }

        private void btThemNV_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            KinhNghiem kn = new KinhNghiem();
            NhanVien_KinhNghiem nvkn = new NhanVien_KinhNghiem();
            nvkn.IDNhanVien = nv.ID;
            nvkn.IDKinhNghiem = kn.ID;
            nv.HoTen = txtTenNV.Text;
            nv.IDLoaiNhanVien = int.Parse(cbLoaiNV.SelectedValue.ToString());
            nv.IDChucVu = int.Parse(cbChucVu.SelectedValue.ToString());
            nv.GioiTinh = txtGT.Text;
            nv.NgaySinh = dbNgaySinh.Value;
            nv.NgayVaoLam = dPThoiGianBatDau.Value;
            nv.MatKhau = txtMK.Text;
            nv.TenDangNhap = txtTenDN.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.Email = txtMail.Text;
            nv.SDT = txtSDT.Text;
            nv.CMND = txtCMND.Text;
            kn.BangCap = txtbangCap.Text;
            kn.CongViec = txtCViec.Text;
            kn.DiaDiem = txtDiaDiem.Text;
            kn.ThoiGian = dbThoiGianLam.Value;
            bNV.ThemNV(nv, kn, nvkn);
           
            HienThiDSCTNV();
            
        }
       
        public String ktrNULL()
        {
            string cout = " ";
            for (int i = 0; i < gvCTNV.Rows.Count; i++)
            {
                for (int j = 0; j < gvCTNV.Columns.Count; i++)
                {
                    cout = gvCTNV.Rows[i].Cells[j].Value.ToString();
                    if (cout == null)
                        cout = "Không có thông tin";
                }
            }
            return cout;
        }
        private void gvCTNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = gvCTNV.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenNV.Text = gvCTNV.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbChucVu.Text = gvCTNV.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbLoaiNV.Text = gvCTNV.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSDT.Text = gvCTNV.Rows[e.RowIndex].Cells[4].Value.ToString();
            dPThoiGianBatDau.Value = DateTime.Parse(gvCTNV.Rows[e.RowIndex].Cells[5].Value.ToString());
            dbNgaySinh.Value = DateTime.Parse(gvCTNV.Rows[e.RowIndex].Cells[6].Value.ToString());
            txtGT.Text = gvCTNV.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtCViec.Text = gvCTNV.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtDiaChi.Text = gvCTNV.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtbangCap.Text = gvCTNV.Rows[e.RowIndex].Cells[10].Value.ToString();
            dbThoiGianLam.Value = DateTime.Parse(gvCTNV.Rows[e.RowIndex].Cells[11].Value.ToString());
            txtGhiChu.Text = gvCTNV.Rows[e.RowIndex].Cells[12].Value.ToString();

        }
    }
}
