﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sistemaNotas.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class notasEstudiantesEntities : DbContext
    {
        public notasEstudiantesEntities()
            : base("name=notasEstudiantesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<estudiante> estudiante { get; set; }
        public virtual DbSet<materia> materia { get; set; }
        public virtual DbSet<notas> notas { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
