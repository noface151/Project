//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TinhTrang
    {
        public TinhTrang()
        {
            this.PhieuNhapHang = new HashSet<PhieuNhapHang>();
            this.PhieuXuatHang = new HashSet<PhieuXuatHang>();
            this.YeuCauXuatHang = new HashSet<YeuCauXuatHang>();
        }
    
        public int IDTinhTrang { get; set; }
        public string MoTa { get; set; }
    
        public virtual ICollection<PhieuNhapHang> PhieuNhapHang { get; set; }
        public virtual ICollection<PhieuXuatHang> PhieuXuatHang { get; set; }
        public virtual ICollection<YeuCauXuatHang> YeuCauXuatHang { get; set; }
    }
}
