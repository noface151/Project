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
    
    public partial class DonDatHangNCC
    {
        public DonDatHangNCC()
        {
            this.ChiTietDatHangNCC = new HashSet<ChiTietDatHangNCC>();
            this.HoaDonNCC = new HashSet<HoaDonNCC>();
        }
    
        public long IDDonDatHang { get; set; }
        public int IDNhaCungCap { get; set; }
        public System.DateTime NgayDat { get; set; }
        public string GhiChu { get; set; }
    
        public virtual ICollection<ChiTietDatHangNCC> ChiTietDatHangNCC { get; set; }
        public virtual NhaCungCap NhaCungCap { get; set; }
        public virtual ICollection<HoaDonNCC> HoaDonNCC { get; set; }
    }
}