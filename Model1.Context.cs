﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class paresetEntities : DbContext
    {
        public paresetEntities()
            : base("name=paresetEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admininfo> Admininfoes { get; set; }
        public virtual DbSet<Chresqlist> Chresqlists { get; set; }
        public virtual DbSet<Pwdpolicy> Pwdpolicies { get; set; }
        public virtual DbSet<useraudit> useraudits { get; set; }
        public virtual DbSet<Userauthoption> Userauthoptions { get; set; }
        public virtual DbSet<Userinfo> Userinfoes { get; set; }
        public virtual DbSet<UsersinAD> UsersinADs { get; set; }
    }
}
