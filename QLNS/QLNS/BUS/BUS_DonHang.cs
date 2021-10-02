using QLNS.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace QLNS.BUS
{
    class BUS_DonHang
    {
        DAO_DonHang dDH;

        public BUS_DonHang()
        {
            dDH = new DAO_DonHang();
        }

        public void HienThiDSDH(DataGridView dg)
        {
            dg.DataSource = dDH.LayDSSDH();
        }

        public void HienThiDSNV(ComboBox cb)
        {
            cb.DataSource = dDH.LayDSNV();
            cb.DisplayMember = "HoTen";
            cb.ValueMember = "ID";
        }

        public bool TaoDonHang(DonHang don)
        {
            try
            {
                dDH.ThemDonHang(don);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
       
        public bool SuaDonHang(DonHang dh)
        {
           if(dDH.KTDonHang(dh))
            {
                try
                {
                    dDH.SuaDH(dh);
                    return true;
                }
                //xu ly vi pham rang buoc
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool XoaDonHang(DonHang dh)
        {
            if (dDH.KTDonHang(dh))
            {
                try
                {
                    dDH.XoaDH(dh);
                    return true;
                }
                //xu ly vi pham rang buoc
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        //Chi Tiet Don Hang

        public void HienThiChiTietDH(DataGridView dg, int maDH)
        {
            dg.DataSource = dDH.DSChiTietDH(maDH);
        }

        public bool XoaCTDonHangSP(ChiTietDonHang dh)
        {
            if (dDH.KTCTDonHang(dh))
            {
                try
                {
                    dDH.XoaCTDH(dh);
                    return true;
                }
                //xu ly vi pham rang buoc
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        /*public bool SuaCTDonHang(ChiTietDonHang dh)
        {
            if (dDH.KTCTDonHang(dh))
            {
                try
                {
                    dDH.SuaCTDH(dh);
                    return true;
                }
                //xu ly vi pham rang buoc
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
*/
        //Dat hang
        public void HienThiDSCTDatDH(DataGridView dg, int maDH)
        {
            dg.DataSource = dDH.DSCTDatDH(maDH);
        }

        public bool ThemCTDonHang(int maDH, DataTable tbDonHang)
        {
            bool kqTraVe = false;
            using (var trans = new TransactionScope())
            {
                try
                {
                    foreach (DataRow item in tbDonHang.Rows)
                    {
                        ChiTietDonHang d = new ChiTietDonHang();
                        d.IDDonHang = maDH;
                        d.IDSanPham = Int32.Parse(item[0].ToString());
                        d.DonGia = Decimal.Parse(item[1].ToString());
                        d.SoLuong = Int32.Parse(item[2].ToString());
                        d.GiamGia = float.Parse(item[3].ToString());
                        if (!dDH.ThemCTDonHang(d))
                        {
                            tbDonHang.Rows.Remove(item);
                            throw new Exception("Sản phẩm " + d.IDSanPham + " đã tồn tại!");
                        }
                            
                    }
                    trans.Complete();
                    kqTraVe = true;
                }
                catch (Exception ex)
                {
                    kqTraVe = false;
                    MessageBox.Show(ex.Message);
                } 
            }
            return kqTraVe;
        }
        public bool XoaDatHang(int maDH, DataTable tbDonHang)
        {
            bool kqTraVe = false;
            using (var trans = new TransactionScope())
            {
                try
                {
                    foreach (DataRow item in tbDonHang.Rows)
                    {
                        ChiTietDonHang d = new ChiTietDonHang();
                        d.IDDonHang = maDH;
                        d.IDSanPham = Int32.Parse(item[0].ToString());
                        d.DonGia = Decimal.Parse(item[1].ToString());
                        d.SoLuong = Int32.Parse(item[2].ToString());
                        d.GiamGia = float.Parse(item[3].ToString());
                        if (!dDH.ThemCTDonHang(d))
                        {
                            tbDonHang.Rows.Remove(item);
                            throw new Exception("Sản phẩm " + d.IDSanPham + " đã tồn tại!");
                        }

                    }
                    trans.Complete();
                    kqTraVe = true;
                }
                catch (Exception ex)
                {
                    kqTraVe = false;
                    MessageBox.Show(ex.Message);
                }
            }
            return kqTraVe;
        }  
    }
}
