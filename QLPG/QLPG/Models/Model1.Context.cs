﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLPG.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLPG1Entities : DbContext
    {
        public QLPG1Entities()
            : base("name=QLPG1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<BuoiTap> BuoiTap { get; set; }
        public virtual DbSet<ChiTietDK_GoiTap> ChiTietDK_GoiTap { get; set; }
        public virtual DbSet<GoiTap> GoiTap { get; set; }
        public virtual DbSet<HoiVien> HoiVien { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<ThanhVien> ThanhVien { get; set; }
    }
}
