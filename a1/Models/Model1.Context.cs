﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace a1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class paathshalaEntities : DbContext
    {
        public paathshalaEntities()
            : base("name=paathshalaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<message> messages { get; set; }
        public virtual DbSet<qa> qas { get; set; }
        public virtual DbSet<qa_comment> qa_comment { get; set; }
        public virtual DbSet<qa_rating> qa_rating { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<user_rating> user_rating { get; set; }
        public virtual DbSet<user_t> user_t { get; set; }
        public virtual DbSet<vid_comment> vid_comment { get; set; }
        public virtual DbSet<vid_rating> vid_rating { get; set; }
        public virtual DbSet<video> videos { get; set; }
    }
}
