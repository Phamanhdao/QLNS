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
    public partial class FSach : Form
    {
        BUS_SanPham bSP;
        public FSach()
        {
            InitializeComponent();
            bSP = new BUS_SanPham();
            
        }
        

        private void btLuu_Click(object sender, EventArgs e)
        {
            if(txtNhaXB.TextLength == 0 )
                erTenSach.SetError(txtTenSP, "Vui lòng nhập tên sách");
            if(txtTacGia.TextLength == 0)
                ertenTG.SetError(txtTacGia, "Vui lòng nhập tên tác giả");
            if (txtTheLoai.TextLength == 0)
                erTheLoai.SetError(txtTheLoai, "Vui lòng nhập thể loại");
            if(txtSL.TextLength == 0)
                erSL.SetError(txtSL, "Vui lòng số lượng!");
            if (txtNamXB.TextLength == 0)
                erNamXB.SetError(txtNamXB, "Vui lòng nhập năm XB");
            if(txtGiaBan.TextLength == 0)
                erGiaBan.SetError(txtGiaBan, "Vui lòng nhập giá sách!");
           
            if(txtNhaXB.TextLength != 0 && txtTacGia.TextLength != 0 && txtTheLoai.TextLength != 0 && txtSL.TextLength != 0
                && txtNamXB.TextLength != 0 && txtGiaBan.TextLength != 0)
                {
                   
                    SanPham sp = new SanPham();
                    LaDanhMucSach dms = new LaDanhMucSach();
                    NhaCungCap_SanPham ncc = new NhaCungCap_SanPham();
                    dms.IDSach = sp.ID;
                    dms.IDDanhMuc = 1;
                    sp.IDDanhMucSanPham = 1;
                    sp.TenSanPham = txtTenSP.Text;
                    sp.DonGia = int.Parse(txtGiaBan.Text);
                    sp.SoLuongTonKho = int.Parse(txtSL.Text.ToString());
                    sp.NgayNhapHang = dPNgayNhapHang.Value;
                    dms.NamXuatBan = txtNamXB.Text.ToString();
                    dms.TenTacGia = txtTacGia.Text.ToString();
                    dms.TheLoai = txtTheLoai.Text.ToString();
                    dms.NhaXuatBan = txtNhaXB.Text.ToString();
                    ncc.IDNhaCungCap = int.Parse(cbNhaCC.SelectedValue.ToString());
                    bSP.ThemSach(dms, sp, ncc);
                    Close();
            }
               
                 
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
                Close();
        }

        private void txtTenSP_TextChanged(object sender, EventArgs e)
        {
            if (txtTenSP.TextLength == 0)
            {
                erTenSach.SetError(txtTenSP, "Vui lòng nhập tên sách!");
            }
            else
                erTenSach.Clear();
        }

        private void txtTacGia_TextChanged(object sender, EventArgs e)
        {
            if (txtTacGia.TextLength == 0)
            {
                ertenTG.SetError(txtTenSP, "Vui lòng nhập tên tác giả!");
            }
            else
                ertenTG.Clear();
        }

        private void txtNhaXB_TextChanged(object sender, EventArgs e)
        {
            if (txtNhaXB.TextLength == 0)
            {
                erNXB.SetError(txtTenSP, "Vui lòng nhập tên NXB!");
            }
            else
                erNXB.Clear();
        }

        private void txtNamXB_TextChanged(object sender, EventArgs e)
        {
            if (txtNamXB.TextLength == 0)
            {
                erNamXB.SetError(txtTenSP, "Vui lòng nhập năm xuất bản!");
            }
            else
                erNamXB.Clear();
        }

        private void txtTheLoai_TextChanged(object sender, EventArgs e)
        {
            if (txtTheLoai.TextLength == 0)
            {
                erTheLoai.SetError(txtTheLoai, "Vui lòng nhập thể loại sách!");
            }
            else
                erTheLoai.Clear();
        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {
            if (txtGiaBan.TextLength == 0)
            {
                erGiaBan.SetError(txtGiaBan, "Vui lòng nhập giá sách!");
            }
            else
                erGiaBan.Clear();
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            if (txtSL.TextLength == 0)
            {
                erSL.SetError(txtSL, "Vui lòng số lượng!");
            }
            else
                erSL.Clear();
        }

        private void FSach_Load(object sender, EventArgs e)
        {
            bSP.HienThiDSNhaCCLenCb(cbNhaCC);
        }
    }
}
