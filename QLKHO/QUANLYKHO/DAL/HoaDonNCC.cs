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
    
    public partial class HoaDonNCC
    {
        public HoaDonNCC()
        {
            this.ChiTietHoaDonNCC = new HashSet<ChiTietHoaDonNCC>();
            this.CongNoNCC = new HashSet<CongNoNCC>();
            this.ThanhToanNCC = new HashSet<ThanhToanNCC>();
        }
    
        public long IDHoaDon { get; set; }
        public long IDDonDatHang { get; set; }
        public System.DateTime NgayLap { get; set; }
        public string GhiChu { get; set; }
    
        public virtual ICollection<ChiTietHoaDonNCC> ChiTietHoaDonNCC { get; set; }
        public virtual DonDatHangNCC DonDatHangNCC { get; set; }
        public virtual ICollection<CongNoNCC> CongNoNCC { get; set; }
        public virtual ICollection<ThanhToanNCC> ThanhToanNCC { get; set; }
    }
}
