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
    
    public partial class ChiTietHoaDonNCC
    {
        public long IDHoaDon { get; set; }
        public long IDHangHoa { get; set; }
        public long SoLuong { get; set; }
        public long Gia { get; set; }
    
        public virtual HangHoa HangHoa { get; set; }
        public virtual HoaDonNCC HoaDonNCC { get; set; }
    }
}
