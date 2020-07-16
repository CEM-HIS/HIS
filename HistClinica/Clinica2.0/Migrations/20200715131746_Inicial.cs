using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Clinica2._0.Migrations
{
    public partial class migracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "CAJA",
                columns: table => new
                {
                    idCaja = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(nullable: true),
                    idTipoCaja = table.Column<int>(nullable: true),
                    idEstado = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAJA", x => x.idCaja);
                });

            migrationBuilder.CreateTable(
                name: "CAJA_ASIGNADA",
                columns: table => new
                {
                    idCaja = table.Column<int>(nullable: false),
                    fechaApertura = table.Column<string>(nullable: false),
                    turno = table.Column<string>(nullable: false),
                    idEmpleado = table.Column<int>(nullable: false),
                    horaApertura = table.Column<string>(nullable: true),
                    fechaCierre = table.Column<string>(nullable: true),
                    horaCierre = table.Column<string>(nullable: true),
                    pos = table.Column<bool>(nullable: true),
                    montoSolesApertura = table.Column<double>(nullable: true),
                    montoDolaresApertura = table.Column<double>(nullable: true),
                    montoEurosApertura = table.Column<double>(nullable: true),
                    montoSolesCierre = table.Column<double>(nullable: true),
                    montoDolaresCierre = table.Column<double>(nullable: true),
                    montoEurosCierre = table.Column<double>(nullable: true),
                    glosaApertura = table.Column<string>(nullable: true),
                    glosaCierre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAJA_ASIGNADA", x => new { x.idCaja, x.fechaApertura, x.turno });
                });

            migrationBuilder.CreateTable(
                name: "CAMPUS",
                columns: table => new
                {
                    idCampus = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(nullable: true),
                    idCompany = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAMPUS", x => x.idCampus);
                });

            migrationBuilder.CreateTable(
                name: "CITA",
                columns: table => new
                {
                    idCita = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigoCita = table.Column<int>(nullable: true),
                    numeroCita = table.Column<int>(nullable: true),
                    descripcion = table.Column<string>(nullable: true),
                    fechaCita = table.Column<DateTime>(nullable: true),
                    ultCie10 = table.Column<string>(nullable: true),
                    idTipoAtencion = table.Column<int>(nullable: true),
                    numeroHC = table.Column<string>(nullable: true),
                    ejecutado = table.Column<string>(nullable: true),
                    prioridad = table.Column<string>(nullable: true),
                    precio = table.Column<double>(nullable: true),
                    descuento = table.Column<double>(nullable: true),
                    coa = table.Column<double>(nullable: true),
                    igv = table.Column<double>(nullable: true),
                    estadoReprogramacion = table.Column<string>(nullable: true),
                    idtipoCita = table.Column<int>(nullable: true),
                    motivoReprogramacion = table.Column<string>(nullable: true),
                    motivoAnulacion = table.Column<string>(nullable: true),
                    idEstadoCita = table.Column<int>(nullable: true),
                    idPaciente = table.Column<int>(nullable: true),
                    idEmpleado = table.Column<int>(nullable: true),
                    idConsultorio = table.Column<int>(nullable: true),
                    idProgramacionMedica = table.Column<int>(nullable: true),
                    idServicioClinica = table.Column<int>(nullable: true),
                    fechaBaja = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CITA", x => x.idCita);
                });

            migrationBuilder.CreateTable(
                name: "COMPANY",
                columns: table => new
                {
                    idCompany = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMPANY", x => x.idCompany);
                });

            migrationBuilder.CreateTable(
                name: "CRONOGRAMA_MEDICO",
                columns: table => new
                {
                    idProgramMedica = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mes = table.Column<string>(nullable: true),
                    semana = table.Column<string>(nullable: true),
                    dia = table.Column<string>(nullable: true),
                    fechaInicio = table.Column<DateTime>(nullable: false),
                    fechaFin = table.Column<DateTime>(nullable: false),
                    idMedico = table.Column<int>(nullable: false),
                    idEspecialidad = table.Column<int>(nullable: false),
                    idConsultorio = table.Column<int>(nullable: false),
                    horaInicio = table.Column<string>(nullable: false),
                    horaFin = table.Column<string>(nullable: false),
                    idEstado = table.Column<int>(nullable: true),
                    fechaBaja = table.Column<string>(nullable: true),
                    intervalo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CRONOGRAMA_MEDICO", x => x.idProgramMedica);
                });

            migrationBuilder.CreateTable(
                name: "EMPLEADO",
                columns: table => new
                {
                    idEmpleado = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigoEmpleado = table.Column<string>(nullable: true),
                    descripcionArea = table.Column<string>(nullable: true),
                    cargo = table.Column<string>(nullable: true),
                    fechaIngreso = table.Column<DateTime>(nullable: true),
                    salario = table.Column<double>(nullable: true),
                    idGenero = table.Column<int>(nullable: true),
                    idTipoEmpleado = table.Column<int>(nullable: true),
                    idPersona = table.Column<int>(nullable: true),
                    idEstado = table.Column<int>(nullable: true),
                    fechaBaja = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMPLEADO", x => x.idEmpleado);
                });

            migrationBuilder.CreateTable(
                name: "ESTADO_CITA",
                columns: table => new
                {
                    idEstadoCita = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigoEstadoCita = table.Column<string>(nullable: true),
                    estado = table.Column<string>(nullable: true),
                    origen = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ESTADO_CITA", x => x.idEstadoCita);
                });

            migrationBuilder.CreateTable(
                name: "LICENCIA",
                columns: table => new
                {
                    idLicencia = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idMedico = table.Column<int>(nullable: false),
                    horaInicio = table.Column<string>(nullable: true),
                    horaFin = table.Column<string>(nullable: true),
                    fechaInicio = table.Column<DateTime>(nullable: true),
                    fechaFin = table.Column<DateTime>(nullable: true),
                    idEstado = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LICENCIA", x => x.idLicencia);
                });

            migrationBuilder.CreateTable(
                name: "MEDICO",
                columns: table => new
                {
                    idMedico = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigoMedico = table.Column<string>(nullable: true),
                    numeroColegio = table.Column<int>(nullable: true),
                    numeroRne = table.Column<string>(nullable: true),
                    numeroRuc = table.Column<int>(nullable: true),
                    idTipoDocumento = table.Column<int>(nullable: true),
                    condicion = table.Column<string>(nullable: true),
                    idEmpleado = table.Column<int>(nullable: true),
                    idEspecialidad = table.Column<int>(nullable: true),
                    idPersona = table.Column<int>(nullable: true),
                    idEstado = table.Column<int>(nullable: true),
                    fechaBaja = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MEDICO", x => x.idMedico);
                });

            migrationBuilder.CreateTable(
                name: "MENU",
                columns: table => new
                {
                    IdMenu = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    menuName = table.Column<string>(nullable: true),
                    menuLink = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MENU", x => x.IdMenu);
                });

            migrationBuilder.CreateTable(
                name: "MODULE",
                columns: table => new
                {
                    idModule = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MODULE", x => x.idModule);
                });

            migrationBuilder.CreateTable(
                name: "PACIENTE",
                columns: table => new
                {
                    idPaciente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigoPaciente = table.Column<string>(nullable: true),
                    descripcion = table.Column<string>(nullable: true),
                    numeroHc = table.Column<string>(nullable: true),
                    nombreAcompañante = table.Column<string>(nullable: true),
                    edadAcompañante = table.Column<int>(nullable: true),
                    dniAcompañante = table.Column<int>(nullable: true),
                    idGrupoSanguineo = table.Column<int>(nullable: true),
                    idFactorRh = table.Column<int>(nullable: true),
                    cobertura = table.Column<string>(nullable: true),
                    ordenAtenMedica = table.Column<string>(nullable: true),
                    nombreAsegurado = table.Column<string>(nullable: true),
                    codigoAsegurado = table.Column<string>(nullable: true),
                    poliza = table.Column<string>(nullable: true),
                    idParentesco = table.Column<int>(nullable: true),
                    inicioVigencia = table.Column<DateTime>(nullable: true),
                    finVigencia = table.Column<DateTime>(nullable: true),
                    idTipoPlanSalud = table.Column<int>(nullable: true),
                    numeroPlanSalud = table.Column<int>(nullable: true),
                    idEstadoSeguro = table.Column<int>(nullable: true),
                    idTipoAfiliacion = table.Column<int>(nullable: true),
                    fechaAfiliacion = table.Column<string>(nullable: true),
                    codigoTitular = table.Column<int>(nullable: true),
                    moneda = table.Column<string>(nullable: true),
                    nombreContratante = table.Column<string>(nullable: true),
                    idTipoDocumento = table.Column<int>(nullable: true),
                    dniContratante = table.Column<int>(nullable: true),
                    planSalud = table.Column<string>(nullable: true),
                    codigoCobertura = table.Column<int>(nullable: true),
                    beneficio = table.Column<string>(nullable: true),
                    restriccion = table.Column<string>(nullable: true),
                    copagoFijo = table.Column<int>(nullable: true),
                    copagoVariable = table.Column<int>(nullable: true),
                    finCarencia = table.Column<int>(nullable: true),
                    convenio = table.Column<string>(nullable: true),
                    descuento = table.Column<double>(nullable: true),
                    codigoPacienteConvenio = table.Column<string>(nullable: true),
                    descripcionPacienteConvenio = table.Column<string>(nullable: true),
                    estadoPacienteConvenio = table.Column<string>(nullable: true),
                    codigoPacienteSoat = table.Column<string>(nullable: true),
                    descripcionPacienteSoat = table.Column<string>(nullable: true),
                    estadoPacienteSoat = table.Column<string>(nullable: true),
                    codigoPacienteExterno = table.Column<string>(nullable: true),
                    descripcionPacienteExterno = table.Column<string>(nullable: true),
                    estadoPacienteExterno = table.Column<string>(nullable: true),
                    idTipoPaciente = table.Column<int>(nullable: true),
                    idPersona = table.Column<int>(nullable: true),
                    hojafiliacion = table.Column<bool>(nullable: true),
                    concienteDato = table.Column<bool>(nullable: true),
                    idEstado = table.Column<int>(nullable: true),
                    fechaBaja = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PACIENTE", x => x.idPaciente);
                });

            migrationBuilder.CreateTable(
                name: "PAGO",
                columns: table => new
                {
                    idPago = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigoTransaccion = table.Column<string>(nullable: true),
                    codigoTransacccionRetorno = table.Column<string>(nullable: true),
                    idFormaPago = table.Column<int>(nullable: true),
                    monto = table.Column<double>(nullable: true),
                    fechaRegistro = table.Column<DateTime>(nullable: true),
                    fechaOkPasarela = table.Column<DateTime>(nullable: true),
                    idCita = table.Column<int>(nullable: true),
                    estado = table.Column<string>(nullable: true),
                    fechaBaja = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PAGO", x => x.idPago);
                });

            migrationBuilder.CreateTable(
                name: "PERSONA",
                columns: table => new
                {
                    idPersona = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    apellidoPaterno = table.Column<string>(nullable: true),
                    apellidoMaterno = table.Column<string>(nullable: true),
                    nombres = table.Column<string>(nullable: true),
                    idTipoDocumento = table.Column<int>(nullable: true),
                    dniPersona = table.Column<int>(nullable: true),
                    idSexo = table.Column<int>(nullable: true),
                    idEtnico = table.Column<int>(nullable: true),
                    fechaNacimiento = table.Column<string>(nullable: true),
                    idUbigeoResidencia = table.Column<int>(nullable: true),
                    idtipoVia = table.Column<int>(nullable: true),
                    nombreVia = table.Column<string>(nullable: true),
                    numeroVia = table.Column<int>(nullable: true),
                    numeroDepartamento = table.Column<int>(nullable: true),
                    interior = table.Column<int>(nullable: true),
                    manzana = table.Column<int>(nullable: true),
                    numeroLote = table.Column<int>(nullable: true),
                    numeroKilometro = table.Column<int>(nullable: true),
                    numeroBloque = table.Column<int>(nullable: true),
                    numeroEtapa = table.Column<int>(nullable: true),
                    edad = table.Column<int>(nullable: true),
                    idUbigeoNacimiento = table.Column<int>(nullable: true),
                    fotografia = table.Column<string>(nullable: true),
                    idGradoInstruccion = table.Column<int>(nullable: true),
                    idReligion = table.Column<int>(nullable: true),
                    centroEducativo = table.Column<string>(nullable: true),
                    idEstadoCivil = table.Column<int>(nullable: true),
                    idOcupacion = table.Column<int>(nullable: true),
                    numeroRuc = table.Column<int>(nullable: true),
                    razonSocial = table.Column<string>(nullable: true),
                    estadoRuc = table.Column<string>(nullable: true),
                    condicionRuc = table.Column<string>(nullable: true),
                    domicioFiscal = table.Column<string>(nullable: true),
                    idParentesco = table.Column<int>(nullable: true),
                    telefono = table.Column<string>(nullable: true),
                    celular = table.Column<string>(nullable: true),
                    correo = table.Column<string>(nullable: true),
                    idDatoSiteds = table.Column<int>(nullable: true),
                    idEmpresaConvenio = table.Column<int>(nullable: true),
                    idCompañiaSeguro = table.Column<int>(nullable: true),
                    idTipoIafa = table.Column<int>(nullable: true),
                    idEstado = table.Column<int>(nullable: true),
                    fechaBaja = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PERSONA", x => x.idPersona);
                });

            migrationBuilder.CreateTable(
                name: "PROFILE",
                columns: table => new
                {
                    idProfile = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    profileCode = table.Column<string>(nullable: true),
                    profileName = table.Column<string>(nullable: true),
                    idState = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROFILE", x => x.idProfile);
                });

            migrationBuilder.CreateTable(
                name: "TABLA_DETALLE",
                columns: table => new
                {
                    idTablaDetalle = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigoTablaDetalle = table.Column<string>(nullable: false),
                    descripcion = table.Column<string>(nullable: false),
                    abreviatura = table.Column<string>(nullable: true),
                    fuente = table.Column<string>(nullable: true),
                    idEstado = table.Column<int>(nullable: true),
                    idTablaGeneral = table.Column<int>(nullable: true),
                    fechaBaja = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TABLA_DETALLE", x => x.idTablaDetalle);
                });

            migrationBuilder.CreateTable(
                name: "TABLA_GENERAL",
                columns: table => new
                {
                    idTablaGeneral = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigoTablaGeneral = table.Column<string>(nullable: false),
                    descripcion = table.Column<string>(nullable: false),
                    tipo = table.Column<string>(nullable: true),
                    fechaCreacion = table.Column<DateTime>(nullable: true),
                    usuarioCreacion = table.Column<string>(nullable: true),
                    estado = table.Column<string>(nullable: true),
                    fechaBaja = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TABLA_GENERAL", x => x.idTablaGeneral);
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
                name: "ROLE",
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
                    table.PrimaryKey("PK_ROLE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "USER",
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
                    idEmployee = table.Column<int>(nullable: true),
                    idState = table.Column<int>(nullable: true),
                    creationUser = table.Column<string>(nullable: true),
                    creationDate = table.Column<string>(nullable: true),
                    modifyUser = table.Column<string>(nullable: true),
                    modifyDate = table.Column<string>(nullable: true),
                    DropDate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "USERCLAIM",
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
                    table.PrimaryKey("PK_USERCLAIM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "USERLOGIN",
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
                    table.PrimaryKey("PK_USERLOGIN", x => new { x.LoginProvider, x.ProviderKey });
                });

            migrationBuilder.CreateTable(
                name: "USERPROFILE",
                schema: "dbo",
                columns: table => new
                {
                    idUser = table.Column<string>(nullable: false),
                    idProfile = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USERPROFILE", x => new { x.idUser, x.idProfile });
                });

            migrationBuilder.CreateTable(
                name: "USERROL",
                schema: "dbo",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USERROL", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "USERTOKEN",
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
                    table.PrimaryKey("PK_USERTOKEN", x => new { x.UserId, x.LoginProvider, x.Name });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CAJA");

            migrationBuilder.DropTable(
                name: "CAJA_ASIGNADA");

            migrationBuilder.DropTable(
                name: "CAMPUS");

            migrationBuilder.DropTable(
                name: "CITA");

            migrationBuilder.DropTable(
                name: "COMPANY");

            migrationBuilder.DropTable(
                name: "CRONOGRAMA_MEDICO");

            migrationBuilder.DropTable(
                name: "EMPLEADO");

            migrationBuilder.DropTable(
                name: "ESTADO_CITA");

            migrationBuilder.DropTable(
                name: "LICENCIA");

            migrationBuilder.DropTable(
                name: "MEDICO");

            migrationBuilder.DropTable(
                name: "MENU");

            migrationBuilder.DropTable(
                name: "MODULE");

            migrationBuilder.DropTable(
                name: "PACIENTE");

            migrationBuilder.DropTable(
                name: "PAGO");

            migrationBuilder.DropTable(
                name: "PERSONA");

            migrationBuilder.DropTable(
                name: "PROFILE");

            migrationBuilder.DropTable(
                name: "TABLA_DETALLE");

            migrationBuilder.DropTable(
                name: "TABLA_GENERAL");

            migrationBuilder.DropTable(
                name: "ROLCLAIM",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ROLE",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "USER",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "USERCLAIM",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "USERLOGIN",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "USERPROFILE",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "USERROL",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "USERTOKEN",
                schema: "dbo");
        }
    }
}
