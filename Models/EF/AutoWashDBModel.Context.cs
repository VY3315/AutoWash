﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoWash.Models.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AutoWashDBEntities : DbContext
    {
        public AutoWashDBEntities()
            : base("name=AutoWashDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_Contact1> tbl_Contact1 { get; set; }
        public virtual DbSet<tbl_services> tbl_services { get; set; }
        public virtual DbSet<tbl_Admin_Detail> tbl_Admin_Detail { get; set; }
        public virtual DbSet<tbl_basiccleaning> tbl_basiccleaning { get; set; }
        public virtual DbSet<tbl_complexcleaning> tbl_complexcleaning { get; set; }
        public virtual DbSet<tbl_premiumcleaning> tbl_premiumcleaning { get; set; }
        public virtual DbSet<tbl_Customer_Plan_Request> tbl_Customer_Plan_Request { get; set; }
        public virtual DbSet<tbl_AboutUsDetails> tbl_AboutUsDetails { get; set; }
        public virtual DbSet<tbl_SliderDetails> tbl_SliderDetails { get; set; }
        public virtual DbSet<tbl_TeamMemberDetails> tbl_TeamMemberDetails { get; set; }
        public virtual DbSet<tbl_WashingPointDetails> tbl_WashingPointDetails { get; set; }
        public virtual DbSet<tbl_ManageContactDetails> tbl_ManageContactDetails { get; set; }
        public virtual DbSet<tbl_UserRequest> tbl_UserRequest { get; set; }
    }
}
