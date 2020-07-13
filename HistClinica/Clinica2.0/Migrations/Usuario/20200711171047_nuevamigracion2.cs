using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Clinica2._0.Migrations.Usuario
{
    public partial class nuevamigracion2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "ROL",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ROL", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ROLCLAIM",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: true),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ROLCLAIM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "USUARIO",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    idEmpleado = table.Column<int>(nullable: true),
                    idEstado = table.Column<int>(nullable: true),
                    usuarioCreacion = table.Column<string>(nullable: true),
                    fechaCreacion = table.Column<string>(nullable: true),
                    usuarioModifica = table.Column<string>(nullable: true),
                    fechaModifica = table.Column<string>(nullable: true),
                    fechaBaja = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "USUARIOCLAIM",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIOCLAIM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "USUARIOLOGIN",
                schema: "dbo",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIOLOGIN", x => new { x.LoginProvider, x.ProviderKey });
                });

            migrationBuilder.CreateTable(
                name: "USUARIOROL",
                schema: "dbo",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIOROL", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "USUARIOTOKEN",
                schema: "dbo",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIOTOKEN", x => new { x.UserId, x.LoginProvider, x.Name });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ROL",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ROLCLAIM",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "USUARIO",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "USUARIOCLAIM",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "USUARIOLOGIN",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "USUARIOROL",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "USUARIOTOKEN",
                schema: "dbo");
        }
    }
}
