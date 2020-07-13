using HistClinica.Models;
using Microsoft.EntityFrameworkCore;
using System;
namespace HistClinica.Data
{
    public class ClinicaServiceContext:DbContext
    {
        public ClinicaServiceContext(DbContextOptions<ClinicaServiceContext> options)
       : base(options)
        { }

        public DbSet<PERSONA> PERSONA { get; set; }
        public DbSet<EMPLEADO> EMPLEADO { get; set; }
        public DbSet<PACIENTE> PACIENTE { get; set; }
        public DbSet<CRONOGRAMA_MEDICO> CRONOGRAMA_MEDICO { get; set; }
        public DbSet<MEDICO> MEDICO { get; set; }
        public DbSet<CITA> CITA { get; set; }
        public DbSet<ESTADO_CITA> ESTADO_CITA { get; set; }
        public DbSet<USUARIO> USUARIO { get; set; }
        public DbSet<PERFIL> PERFIL { get; set; }
        public DbSet<TABLA_GENERAL> TABLA_GENERAL { get; set; }
        public DbSet<TABLA_DETALLE> TABLA_DETALLE { get; set; }
        public DbSet<CAJA> CAJA { get; set; }
        public DbSet<LICENCIA> LICENCIA { get; set; }
        public DbSet<CAJA_ASIGNADA> CAJA_ASIGNADA { get; set; }


        /// AGREGANDO LOS MODELS FREDY JOHEL
        public DbSet<EMPRESA> EMPRESA { get; set; }
        public DbSet<MENU> MENU { get; set; }
        public DbSet<MODULO> MODULO { get; set; }
        public DbSet<ROL> ROL { get; set; }
        public DbSet<SEDE> SEDE { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CAJA_ASIGNADA>()
                .HasKey(o => new { o.idCaja,o.fechaApertura,o.turno});
            modelBuilder.Entity<USUARIO>()
                .HasKey(c => new { c.idEmpleado, c.loginUser });
        }
        public DbSet<PAGO> PAGO { get; set; }
    }
}
