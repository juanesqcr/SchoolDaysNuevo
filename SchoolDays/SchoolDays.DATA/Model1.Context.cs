﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolDays.DATA
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SchoolDaysEntities : DbContext
    {
        public SchoolDaysEntities()
            : base("name=SchoolDaysEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Estudiante> Estudiante { get; set; }
        public virtual DbSet<Grados> Grados { get; set; }
        public virtual DbSet<Horario> Horario { get; set; }
        public virtual DbSet<Materia> Materia { get; set; }
        public virtual DbSet<Mensualidad> Mensualidad { get; set; }
        public virtual DbSet<Notas> Notas { get; set; }
        public virtual DbSet<Profesor> Profesor { get; set; }
        public virtual DbSet<Salario> Salario { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}