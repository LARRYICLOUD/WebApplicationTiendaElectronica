﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplicationTiendaElectronica.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Tienda_ElectronicaEntities : DbContext
    {
        public Tienda_ElectronicaEntities()
            : base("name=Tienda_ElectronicaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        internal static List<Tienda_ElectronicaEntities> ToList()




        {
            


            throw new NotImplementedException();
        }

        public virtual DbSet<Almacen> Almacen { get; set; }
        public virtual DbSet<Totales> Totales { get; set; }
        public virtual DbSet<Ventas> Ventas { get; set; }
        public object AlmacenController { get; internal set; }
    }
}