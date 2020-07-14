using Clinica2._0.Models;
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
        #endregion Tablas de Clinica
        #region Tablas de Sesion
        public DbSet<USUARIO> USUARIO { get; set; }
        public DbSet<IdentityRole> ROL { get; set; }
        public DbSet<IdentityUserRole<string>> USUARIOROL { get; set; }
        public DbSet<IdentityRoleClaim<string>> ROLCLAIM { get; set; }
        public DbSet<IdentityUserClaim<string>> USUARIOCLAIM { get; set; }
        public DbSet<IdentityUserLogin<string>> USUARIOLOGIN { get; set; }
        public DbSet<IdentityUserToken<string>> USUARIOTOKEN { get; set; }
        public DbSet<PERFIL> PERFIL { get; set; }
        public DbSet<EMPRESA> EMPRESA { get; set; }
        public DbSet<SEDE> SEDE { get; set; }
        public DbSet<MENU> MENU { get; set; }
        public DbSet<MODULO> MODULO { get; set; }
        #endregion Tablas de Sesion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Tablas de Clinica
            modelBuilder.Entity<CAJA_ASIGNADA>().HasKey(o => new { o.idCaja, o.fechaApertura, o.turno });
            #endregion Tablas de Clinica
            #region Tablas de Sesion
            modelBuilder.Entity<IdentityUser>().ToTable("USUARIO", "dbo");
            modelBuilder.Entity<IdentityRole>().ToTable("ROL", "dbo");
            modelBuilder.Entity<IdentityUserRole<string>>().ToTable("USUARIOROL", "dbo").HasKey(ur => new { ur.UserId, ur.RoleId });
            modelBuilder.Entity<IdentityRoleClaim<string>>().ToTable("ROLCLAIM", "dbo");
            modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("USUARIOCLAIM", "dbo");
            modelBuilder.Entity<IdentityUserLogin<string>>().ToTable("USUARIOLOGIN", "dbo").HasKey(c => new { c.LoginProvider, c.ProviderKey });
            modelBuilder.Entity<IdentityUserToken<string>>().ToTable("USUARIOTOKEN", "dbo").HasKey(ul => new { ul.UserId, ul.LoginProvider, ul.Name });
            #endregion Tablas de Sesion
        }
    }
}