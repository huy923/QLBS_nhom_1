﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLBS : DbContext
    {
        public QLBS()
            : base("name=QLBS")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<Sach> Saches { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tac_gia> Tac_gia { get; set; }
        public virtual DbSet<Tai_khoan> Tai_khoan { get; set; }
        public virtual DbSet<Chi_tiet_hao_don> Chi_tiet_hao_don { get; set; }
        public virtual DbSet<Linh_vuc> Linh_vuc { get; set; }
        public virtual DbSet<Loai_sach> Loai_sach { get; set; }
        public virtual DbSet<Nha_xuat_ban> Nha_xuat_ban { get; set; }
        public virtual DbSet<Kho> Khoes { get; set; }
    }
}
