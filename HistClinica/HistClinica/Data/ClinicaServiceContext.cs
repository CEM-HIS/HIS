using HistClinica.Models;
using Microsoft.EntityFrameworkCore;
using System;
namespace HistClinica.Data
{
    public class ClinicaServiceContext:DbContext
    {
        public ClinicaServiceContext()
        {
        }

        public ClinicaServiceContext(DbContextOptions<ClinicaServiceContext> options)
       : base(options)
        { }

        public DbSet<PERSONA> T000_PERSONA { get; set; }
        public DbSet<EMPLEADO> T120_EMPLEADO { get; set; }
        public DbSet<PACIENTE> T001_PACIENTE { get; set; }
        public DbSet<CRONOGRAMA_MEDICO> D012_CRONOMEDICO { get; set; }
        public DbSet<MEDICO> T212_MEDICO { get; set; }
        public DbSet<CITA> T068_CITA { get; set; }
        public DbSet<ESTADO_CITA> T109_ESTADOCITA { get; set; }
        public DbSet<USUARIO> D001_USUARIO { get; set; }
        public DbSet<PERFIL> D002_PERFIL { get; set; }
        public DbSet<TABLAGENERAL> D00_TBGENERAL { get; set; }
        public DbSet<TABLADETALLE> D00_TBDETALLE { get; set; }
        public DbSet<CAJA> D024_CAJA { get; set; }
        public DbSet<CAJA_ASIGNADA> D025_ASIGNACAJA { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CAJA_ASIGNADA>()
                .HasKey(o => new { o.idCaja, o.idEmpleado });
            modelBuilder.Entity<USUARIO>()
                .HasKey(c => new { c.idEmpleado, c.loginUser });
        }
        public DbSet<PAGO> D015_PAGO { get; set; }
    }
}
