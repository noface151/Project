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
    
    public partial class NguoiDung
    {
        public string IDNguoiDung { get; set; }
        public int IDVaiTro { get; set; }
        public string TenHienThi { get; set; }
        public string MatKhau { get; set; }
    
        public virtual VaiTro VaiTro { get; set; }
    }
}
