﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BloodBankApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BloodBankDbContext : DbContext
    {
        public BloodBankDbContext()
            : base("name=BloodBankDbContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<BloodGroup> BloodGroups { get; set; }
        public virtual DbSet<BloodRequest> BloodRequests { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<NewRegistration> NewRegistrations { get; set; }
    }
}