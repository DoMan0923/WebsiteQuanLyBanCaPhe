//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyCaPhe.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HOADONNHAP
    {
        public HOADONNHAP()
        {
            this.CHITIETHDNHAPs = new HashSet<CHITIETHDNHAP>();
        }
    
        public int MAHDNHAP { get; set; }
        public Nullable<int> MANCC { get; set; }
        public Nullable<int> MANV { get; set; }
        public Nullable<double> TONGTIENNHAP { get; set; }
        public Nullable<System.DateTime> NGAYNHAP { get; set; }
        public string GHICHU { get; set; }
    
        public virtual ICollection<CHITIETHDNHAP> CHITIETHDNHAPs { get; set; }
        public virtual NHACC NHACC { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
