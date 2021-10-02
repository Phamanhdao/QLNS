using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS.DAO
{
   
    class DAO_NhaCC
    {
        QLNhaSachEntities1 db;
        public DAO_NhaCC()
        {
            db = new QLNhaSachEntities1();
        }

        public dynamic LayDSTenNCC()
        {
            var ds = db.NhaCungCaps.Select(s => new
            {
                s.ID,
                s.Ten
            }).ToList();
            return ds;
        }

        public dynamic LayDSNCC()
        {
            var ds = db.NhaCungCaps.Select(s => new
            {
                s.ID,
                s.Ten,
                s.DiaChi,
                s.SDT,
                s.Email,
                s.NguoiLienHe,
                s.ChucVuNguoiLienHe
            }).ToList();
            return ds;
        }

        public List<NhaCungCap> LayDSNCCReport()
        {
            var ds = db.NhaCungCaps.Select(s => s).ToList();
            return ds;
        }



        public void ThemNCC(NhaCungCap ncc)
        {
            db.NhaCungCaps.Add(ncc);
            db.SaveChanges();
        }

        public bool KTNhaCC(NhaCungCap n)
        {
            NhaCungCap ncc = db.NhaCungCaps.Find(n.ID);
            if (ncc != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void XoaNCC(NhaCungCap n)
        {
            NhaCungCap ncc = db.NhaCungCaps.Find(n.ID);
            db.NhaCungCaps.Remove(ncc);
            db.SaveChanges();
        }

        public void SuaNhaCC(NhaCungCap ncc)
        {
            NhaCungCap n = db.NhaCungCaps.Find(ncc.ID);
            n.Ten = ncc.Ten;
            n.DiaChi = ncc.DiaChi;
            n.Email = ncc.Email;
            n.SDT = ncc.SDT;
            n.NguoiLienHe = ncc.NguoiLienHe;
            n.ChucVuNguoiLienHe = ncc.ChucVuNguoiLienHe;
            db.SaveChanges();
        }
    }
}
