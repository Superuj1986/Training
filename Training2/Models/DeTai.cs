//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Training2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DeTai
    {
        public string MaSoDT { get; set; }
        public string TenDT { get; set; }
        public Nullable<int> TGTH { get; set; }
        public string TienDo { get; set; }
        public string MaGV { get; set; }
        public string KinhPhi { get; set; }
        public string MaSV { get; set; }
    
        public virtual GVHD GVHD { get; set; }
        public virtual SinhVien SinhVien { get; set; }
    }
}
