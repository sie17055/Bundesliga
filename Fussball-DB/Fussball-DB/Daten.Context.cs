﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fussball_DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class bundesligaEntities : DbContext
    {
        public bundesligaEntities()
            : base("name=bundesligaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<liga> ligas { get; set; }
        public DbSet<spiel> spiels { get; set; }
        public DbSet<spieler> spielers { get; set; }
        public DbSet<verein> vereins { get; set; }
    }
}