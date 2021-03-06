﻿using Clinica2._0.Core.Clinica.Models;
using Clinica2._0.Models;
using Clinica2._0.Sesion.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
namespace Clinica2._0.Data
{
    public class ClinicaServiceContext : DbContext
    {
        public ClinicaServiceContext(DbContextOptions<ClinicaServiceContext> options)
       : base(options)
        { }
        #region Tablas de Clinica
        public DbSet<PERSONA> PERSONA { get; set; }
        public DbSet<EMPLEADO> EMPLEADO { get; set; }
        public DbSet<PACIENTE> PACIENTE { get; set; }
        public DbSet<CRONOGRAMA_MEDICO> CRONOGRAMA_MEDICO { get; set; }
        public DbSet<MEDICO> MEDICO { get; set; }
        public DbSet<CITA> CITA { get; set; }
        public DbSet<ESTADO_CITA> ESTADO_CITA { get; set; }
        public DbSet<TABLA_GENERAL> TABLA_GENERAL { get; set; }
        public DbSet<TABLA_DETALLE> TABLA_DETALLE { get; set; }
        public DbSet<CAJA> CAJA { get; set; }
        public DbSet<LICENCIA> LICENCIA { get; set; }
        public DbSet<CAJA_ASIGNADA> CAJA_ASIGNADA { get; set; }
        public DbSet<PAGO> PAGO { get; set; }
        public DbSet<PLAN_SALUD> PLAN_SALUD { get; set; }
        public DbSet<LABORATORIO> LABORATORIO { get; set; }

        public DbSet<ORDEN_ATENCION> ORDEN_ATENCION { get; set; }
        public DbSet<ORDEN_ATE_DETALLE> ORDEN_ATE_DETALLE { get; set; }
        #endregion Tablas de Clinica
        #region Tablas de Sesion
        public DbSet<USER> USER { get; set; }
        public DbSet<ROLE> ROLE { get; set; }
        public DbSet<IdentityUserRole<string>> USER_ROLE { get; set; }
        public DbSet<IdentityRoleClaim<string>> ROL_CLAIM { get; set; }
        public DbSet<IdentityUserClaim<string>> USER_CLAIM { get; set; }
        public DbSet<IdentityUserLogin<string>> USER_LOGIN { get; set; }
        public DbSet<IdentityUserToken<string>> USER_TOKEN { get; set; }
        public DbSet<USERPROFILE> USER_PROFILE { get; set; }
        public DbSet<PROFILE> PROFILE { get; set; }
        public DbSet<COMPANY> COMPANY { get; set; }
        public DbSet<CAMPUS> CAMPUS { get; set; }
        public DbSet<MENU> MENU { get; set; }
        public DbSet<MODULE> MODULE { get; set; }
        #endregion Tablas de Sesion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Tablas de Clinica
            modelBuilder.Entity<CAJA_ASIGNADA>().HasKey(o => new { o.idCaja, o.fechaApertura, o.turno });
            #endregion Tablas de Clinica
            #region Tablas de Sesion
            modelBuilder.Entity<IdentityUser>().ToTable("USER", "dbo");
            modelBuilder.Entity<IdentityRole>().ToTable("ROLE", "dbo");
            modelBuilder.Entity<IdentityUserRole<string>>().ToTable("USER_ROLE", "dbo").HasKey(ur => new { ur.UserId, ur.RoleId });
            modelBuilder.Entity<IdentityRoleClaim<string>>().ToTable("ROL_CLAIM", "dbo");
            modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("USER_CLAIM", "dbo");
            modelBuilder.Entity<IdentityUserLogin<string>>().ToTable("USER_LOGIN", "dbo").HasKey(ul => new { ul.LoginProvider, ul.ProviderKey });
            modelBuilder.Entity<IdentityUserToken<string>>().ToTable("USER_TOKEN", "dbo").HasKey(ut => new { ut.UserId, ut.LoginProvider, ut.Name });
            modelBuilder.Entity<USERPROFILE>().ToTable("USER_PROFILE", "dbo").HasKey(up => new { up.idUser, up.idProfile});
            #endregion Tablas de Sesion
        }
    }
}