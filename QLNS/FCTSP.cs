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
           
        }
        public void HienThiDLDG(DataGridView gv )
        {
            gvCTSP.DataSource = null;
            bSP.HienThiDSSP(gvCTSP);
            //Định nghĩa lại các cột trong DataGridView
            gvCTSP.Columns[0].Width = (int) (gvCTSP.Width * 0.2);
            gvCTSP.Columns[1].Width = (int)(gvCTSP.Width * 0.2);
            gvCTSP.Columns[2].Width = (int)(gvCTSP.Width * 0.2);
            gvCTSP.Columns[3].Width = (int)(gvCTSP.Width * 0.2);
            gvCTSP.Columns[4].Width = (int)(gvCTSP.Width * 0.2);
        }
        private void FCTSP_Load(object sender, EventArgs e)
        {
            bSP.HienThiDSLoaiSPLenCb(cbLoaiSP);
            HienThiDLDG(gvCTSP);
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.TenSanPham = txtTenSP.Text;
            sp.IDDanhMucSanPham = int.Parse(cbLoaiSP.SelectedValue.ToString());
            sp.DonGia = int.Parse(txtGiaBan.Text);
            sp.SoLuongTonKho = int.Parse(txtSL.Text.ToString());
            sp.NgayNhapHang = dPNgayNhapHang.Value;
            bSP.ThemSP(sp);

            HienThiDLDG(gvCTSP);
        }

        //private void btThoat_Click(object sender, EventArgs e)
        //{
        //    Close();
        //}
    }
}
