//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp5
{
    using System;
    using System.Collections.Generic;
    
    public partial class Chi_tiet_hao_don
    {
        public string Ma_hoa_don { get; set; }
        public string MaSach { get; set; }
        public Nullable<int> So_luong { get; set; }
        public Nullable<decimal> Gia_tien { get; set; }
        public Nullable<decimal> Thanh_tien { get; set; }
    
        public virtual HoaDon HoaDon { get; set; }
        public virtual Sach Sach { get; set; }
    }
}
