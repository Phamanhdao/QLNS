//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLNS
{
    using System;
    using System.Collections.Generic;
    
    public partial class NhanVien_KinhNghiem
    {
        public int IDNhanVien { get; set; }
        public int IDKinhNghiem { get; set; }
        public string GhiChu { get; set; }
    
        public virtual KinhNghiem KinhNghiem { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
