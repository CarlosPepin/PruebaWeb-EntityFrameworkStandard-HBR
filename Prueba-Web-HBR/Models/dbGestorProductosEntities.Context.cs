﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Prueba_Web_HBR.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbGestorProductosEntities : DbContext
    {
        public dbGestorProductosEntities()
            : base("name=dbGestorProductosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tblCategoria> tblCategorias { get; set; }
        public virtual DbSet<tblProducto> tblProductoes { get; set; }
        public virtual DbSet<tblUsuatio> tblUsuatios { get; set; }
    }
}