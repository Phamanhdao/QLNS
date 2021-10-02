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
            //
           

            gvCTNV.Columns[0].Width = (int)(gvCTNV.Width * 0.2);
            gvCTNV.Columns[1].Width = (int)(gvCTNV.Width * 0.25);
            gvCTNV.Columns[2].Width = (int)(gvCTNV.Width * 0.2);
            gvCTNV.Columns[3].Width = (int)(gvCTNV.Width * 0.25);
            gvCTNV.Columns[4].Width = (int)(gvCTNV.Width * 0.2);
            gvCTNV.Columns[5].Width = (int)(gvCTNV.Width * 0.2);
            gvCTNV.Columns[6].Width = (int)(gvCTNV.Width * 0.2);
            gvCTNV.Columns[7].Width = (int)(gvCTNV.Width * 0.2);
            

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
                if (mcv == 1)
                    bNV.HienThiDSLoaiNVQLLenCb(cbLoaiNV); //Tạo nhân viên là quản lý chỉ thuộc loại toàn thời gian
            }
        }


        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {
            if (txtTenNV.TextLength == 0)
            {
                erTenNV.SetError(txtTenNV, "Vui lòng nhập thông tin");
            }
            else
                erTenNV.Clear();
            
        }

        private void txtGT_TextChanged(object sender, EventArgs e)
        {
            if (txtGT.TextLength == 0)
            {
                erGT.SetError(txtGT, "Vui lòng nhập thông tin");
            }
            else
                erGT.Clear();
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            if (txtDiaChi.TextLength == 0)
            {
                erDiaChi.SetError(txtDiaChi, "Vui lòng nhập thông tin");
            }
            else
                erDiaChi.Clear();
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            if (txtSDT.TextLength == 0)
            {
                erSDT.SetError(txtSDT, "Vui lòng nhập thông tin");
            }
            else
                erSDT.Clear();
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            if (txtMail.TextLength == 0)
            {
                erEmail.SetError(txtMail, "Vui lòng nhập thông tin");
            }
            else
                erEmail.Clear();
        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {
            if (txtCMND.TextLength == 0)
            {
                erCMND.SetError(txtCMND, "Vui lòng nhập thông tin");
            }
            else
                erCMND.Clear();
        }

        private void txtCViec_TextChanged(object sender, EventArgs e)
        {
            if (txtCViec.TextLength == 0)
            {
                erCongViec.SetError(txtCViec, "Vui lòng nhập thông tin");
            }
            else
                erCongViec.Clear();
        }

        private void txtDiaDiem_TextChanged(object sender, EventArgs e)
        {
            if (txtDiaDiem.TextLength == 0)
            {
                erDiaDiem.SetError(txtDiaDiem, "Vui lòng nhập thông tin");
            }
            else
                erDiaDiem.Clear();
        }

        private void txtbangCap_TextChanged(object sender, EventArgs e)
        {
            if (txtbangCap.TextLength == 0)
            {
                erBangCap.SetError(txtbangCap, "Vui lòng nhập thông tin");
            }
            else
                erBangCap.Clear();
        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {
            if (txtGhiChu.TextLength == 0)
            {
                erGhiChu.SetError(txtGhiChu, "Vui lòng nhập thông tin");
            }
            else
                erGhiChu.Clear();
        }
        //Xóa trống các txt
        public void XoaTrongTXT()
        {
            txtGhiChu.Clear();
            txtDiaDiem.Clear();
            txtGT.Clear();
            txtMail.Clear();
            txtMaNV.Clear();
            txtMK.Clear();
            txtSDT.Clear();
            txtTenDN.Clear();
            txtTenNV.Clear();
            txtDiaDiem.Clear();
            txtDiaChi.Clear();
            txtCViec.Clear();
            txtCMND.Clear();
            txtbangCap.Clear();
        }

        // Xử lý thêm nhân viên
        private void btThemNV_Click(object sender, EventArgs e)
        {
            if(txtGhiChu.TextLength == 0)
                erGhiChu.SetError(txtGhiChu, "Vui lòng nhập thông tin");
            if(txtbangCap.TextLength == 0)
                erBangCap.SetError(txtbangCap, "Vui lòng nhập thông tin");
            if (txtDiaDiem.TextLength == 0)
                erDiaDiem.SetError(txtDiaDiem, "Vui lòng nhập thông tin");
            if(txtCViec.TextLength == 0)
                erCongViec.SetError(txtCViec, "Vui lòng nhập thông tin");
            if(txtCMND.TextLength == 0)
                erCMND.SetError(txtCMND, "Vui lòng nhập thông tin");
           if(txtMail.TextLength == 0)
                erEmail.SetError(txtMail, "Vui lòng nhập thông tin");
           if(txtMail.TextLength == 0)
                erEmail.SetError(txtMail, "Vui lòng nhập thông tin");
           if(txtSDT.TextLength == 0)
                erSDT.SetError(txtSDT, "Vui lòng nhập thông tin");
           if(txtDiaChi.TextLength == 0)
                erDiaChi.SetError(txtDiaChi, "Vui lòng nhập thông tin");
           if(txtGT.TextLength == 0)
                erGT.SetError(txtGT, "Vui lòng nhập thông tin");
           if(txtTenNV.TextLength == 0)
                erTenNV.SetError(txtTenNV, "Vui lòng nhập thông tin");
            if (txtGhiChu.TextLength != 0 && txtbangCap.TextLength != 0 && txtDiaDiem.TextLength != 0 && txtCViec.TextLength != 0
                        && txtCMND.TextLength != 0 && txtMail.TextLength != 0 && txtMail.TextLength != 0
                      && txtSDT.TextLength != 0 && txtDiaChi.TextLength != 0 && txtGT.TextLength != 0 && txtTenNV.TextLength != 0)
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
                XoaTrongTXT();
            }

        }

        private void gvCTNV_DoubleClick(object sender, EventArgs e)
        {
            txtMaNV.Text = gvCTNV.CurrentRow.Cells[0].Value.ToString();
            txtTenNV.Text = gvCTNV.CurrentRow.Cells[1].Value.ToString();
           
            cbChucVu.Text = gvCTNV.CurrentRow.Cells[2].Value.ToString();
            cbLoaiNV.Text = gvCTNV.CurrentRow.Cells[3].Value.ToString();
            txtSDT.Text = gvCTNV.CurrentRow.Cells[4].Value.ToString();
            txtGT.Text = gvCTNV.CurrentRow.Cells[7].Value.ToString();

        }

        private void btTroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            FQLNV f = new FQLNV();
            f.ShowDialog();
            this.Close();
        }
    }
}
