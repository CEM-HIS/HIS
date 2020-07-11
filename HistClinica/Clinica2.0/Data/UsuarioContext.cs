using System;
using System.Collections.Generic;
using System.Text;
using Clinica2._0.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Clinica2._0.Data
{
    public class UsuarioContext : DbContext
    {
        public UsuarioContext(DbContextOptions<UsuarioContext> options)
            : base(options)
        {}
        public DbSet<USUARIO> USUARIO { get; set; }
        public DbSet<IdentityRole> ROL { get; set; }
        public DbSet<IdentityUserRole<string>> USUARIOROL { get; set; }
        public DbSet<IdentityRoleClaim<string>> ROLCLAIM { get; set; }
        public DbSet<IdentityUserClaim<string>> USUARIOCLAIM { get; set; }
        public DbSet<IdentityUserLogin<string>> USUARIOLOGIN { get; set; }
        public DbSet<IdentityUserToken<string>> USUARIOTOKEN { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUser>().ToTable("USUARIO", "dbo");
            modelBuilder.Entity<IdentityRole>().ToTable("ROL", "dbo");
            modelBuilder.Entity<IdentityUserRole<string>>().ToTable("USUARIOROL", "dbo").HasKey(ur => new { ur.UserId, ur.RoleId });
            modelBuilder.Entity<IdentityRoleClaim<string>>().ToTable("ROLCLAIM", "dbo");
            modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("USUARIOCLAIM", "dbo");
            modelBuilder.Entity<IdentityUserLogin<string>>().ToTable("USUARIOLOGIN", "dbo").HasKey(c => new { c.LoginProvider, c.ProviderKey });
            modelBuilder.Entity<IdentityUserToken<string>>().ToTable("USUARIOTOKEN", "dbo").HasKey(ul => new { ul.UserId, ul.LoginProvider, ul.Name });
        }
    }
}
