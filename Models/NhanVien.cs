﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLNV_63131330.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class NhanVien
    {
        [DisplayName("Mã NV")]

        public string MaNV { get; set; }

        [DisplayName("Họ NV")]

        public string HoNV { get; set; }
        public string TenNV { get; set; }
        public Nullable<bool> GioiTinh { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]

        [DisplayName("Ngày sinh")]

        public Nullable<System.DateTime> NgaySinh { get; set; }


        public Nullable<int> Luong { get; set; }
        public string AnhNV { get; set; }
        public string DiaChi { get; set; }
        public string MaPB { get; set; }
    
        public virtual PhongBan PhongBan { get; set; }
    }
}
