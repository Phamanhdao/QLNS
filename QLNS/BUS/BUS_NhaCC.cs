using QLNS.DAO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS.BUS
{
    class BUS_NhaCC
    {
        DAO_NhaCC dNCC;
        public BUS_NhaCC()
        {
            dNCC = new DAO_NhaCC();
        }

        public void HienThiCBNhaCC(ComboBox cb)
        {
            cb.DataSource = dNCC.LayDSTenNCC();
            cb.DisplayMember = "Ten";
            cb.ValueMember = "ID";
        }
        
        public void HienThiDSNCC(DataGridView dg)
        {
            dg.DataSource = dNCC.LayDSNCC();
        }

        public bool ThemNCC (NhaCungCap ncc)
        {
            try
            {
                dNCC.ThemNCC(ncc);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool XoaNhaCC(NhaCungCap n)
        {
            if (dNCC.KTNhaCC(n))
            {
                try
                {
                    dNCC.XoaNCC(n);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
                return false;
        }

        public bool SuaNCC(NhaCungCap ncc)
        {
            if (dNCC.KTNhaCC(ncc))
            {
                try
                {
                    dNCC.SuaNhaCC(ncc);
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
    }
}
