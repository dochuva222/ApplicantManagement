﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApplicantManagement.DataBase
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EducationEntities : DbContext
    {
        public EducationEntities()
            : base("name=EducationEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Application> Application { get; set; }
        public virtual DbSet<FormOfEducation> FormOfEducation { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Speciality> Speciality { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}