using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SARH.Core.EF.Entities;

namespace SARH.Core.EF
{
    public partial class SARHDbContext:DbContext
    {
        public SARHDbContext()
            : base("name=SARHConnetions")
        {

        }

       
        public virtual DbSet<centro_educativo> centro_educativo { get; set; }
        public virtual DbSet<departamento> departamento { get; set; }
        public virtual DbSet<distrito_educativo> distrito_educativo { get; set; }
        public virtual DbSet<distrito_municipal> distrito_municipal { get; set; }
        public virtual DbSet<empleado> empleado { get; set; }
        public virtual DbSet<empleado_familia> empleado_familia { get; set; }
        public virtual DbSet<formacion_academica> formacion_academica { get; set; }
        public virtual DbSet<funcion> funcion { get; set; }
        public virtual DbSet<instancia_militar> instancia_militar { get; set; }
        public virtual DbSet<municipio> municipio { get; set; }
        public virtual DbSet<nacionalidad> nacionalidad { get; set; }
        public virtual DbSet<ocupacion> ocupacion { get; set; }
        public virtual DbSet<parentezco_familiar> parentezco_familiar { get; set; }
        public virtual DbSet<profesion> profesion { get; set; }
        public virtual DbSet<provincia> provincia { get; set; }
        public virtual DbSet<rango> rango { get; set; }
        public virtual DbSet<regional_educativa> regional_educativa { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tanda_laboral> tanda_laboral { get; set; }
        public virtual DbSet<tipo_armas> tipo_armas { get; set; }
        public virtual DbSet<tipo_ingreso> tipo_ingreso { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<departamento>()
                .HasMany(e => e.empleado)
                .WithRequired(e => e.departamento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<distrito_educativo>()
                .HasMany(e => e.centro_educativo)
                .WithRequired(e => e.distrito_educativo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<distrito_municipal>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<distrito_municipal>()
                .HasMany(e => e.empleado)
                .WithRequired(e => e.distrito_municipal)
                .HasForeignKey(e => e.distrito_municipal_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<empleado>()
                .Property(e => e.documento)
                .IsFixedLength();

            modelBuilder.Entity<empleado>()
                .Property(e => e.telefono1)
                .IsFixedLength();

            modelBuilder.Entity<empleado>()
                .Property(e => e.telefono2)
                .IsFixedLength();

            modelBuilder.Entity<empleado_familia>()
                .Property(e => e.telefono)
                .IsFixedLength();

            modelBuilder.Entity<funcion>()
                .HasMany(e => e.empleado)
                .WithRequired(e => e.funcion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<instancia_militar>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<instancia_militar>()
                .HasMany(e => e.empleado)
                .WithRequired(e => e.instancia_militar)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<municipio>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<municipio>()
                .HasMany(e => e.empleado)
                .WithRequired(e => e.municipio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nacionalidad>()
                .HasMany(e => e.empleado)
                .WithRequired(e => e.nacionalidad)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<parentezco_familiar>()
                .HasMany(e => e.empleado_familia)
                .WithRequired(e => e.parentezco_familiar)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<profesion>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<profesion>()
                .HasMany(e => e.empleado)
                .WithRequired(e => e.profesion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<provincia>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<provincia>()
                .HasMany(e => e.empleado)
                .WithRequired(e => e.provincia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<rango>()
                .HasMany(e => e.empleado)
                .WithRequired(e => e.rango)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<regional_educativa>()
                .HasMany(e => e.distrito_educativo)
                .WithRequired(e => e.regional_educativa)
                .HasForeignKey(e => e.regional_educativa_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tanda_laboral>()
                .HasMany(e => e.empleado)
                .WithRequired(e => e.tanda_laboral)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tipo_ingreso>()
                .HasMany(e => e.empleado)
                .WithRequired(e => e.tipo_ingreso)
                .WillCascadeOnDelete(false);
        }
    }


}

