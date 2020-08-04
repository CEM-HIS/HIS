using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HistClinica.Migrations
{
    public partial class nueva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "D00_TBDETALLE",
                columns: table => new
                {
                    idDet = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    coddetTab = table.Column<string>(nullable: false),
                    descripcion = table.Column<string>(nullable: false),
                    abrev = table.Column<string>(nullable: true),
                    fuente = table.Column<string>(nullable: true),
                    estado = table.Column<string>(nullable: true),
                    idTab = table.Column<int>(nullable: true),
                    fechabaja = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D00_TBDETALLE", x => x.idDet);
                });

            migrationBuilder.CreateTable(
                name: "D00_TBGENERAL",
                columns: table => new
                {
                    idTab = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codTab = table.Column<string>(nullable: true),
                    descripcion = table.Column<string>(nullable: true),
                    tipo = table.Column<string>(nullable: true),
                    fechaCreate = table.Column<DateTime>(nullable: true),
                    usuCreate = table.Column<string>(nullable: true),
                    estado = table.Column<string>(nullable: true),
                    fechabaja = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D00_TBGENERAL", x => x.idTab);
                });

            migrationBuilder.CreateTable(
                name: "D001_USUARIO",
                columns: table => new
                {
                    idEmpleado = table.Column<int>(nullable: false),
                    loginUser = table.Column<string>(nullable: false),
                    claveUser = table.Column<string>(nullable: true),
                    estado = table.Column<string>(nullable: true),
                    usuCrea = table.Column<string>(nullable: true),
                    fechaCrea = table.Column<string>(nullable: true),
                    usuMod = table.Column<string>(nullable: true),
                    fechaMod = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D001_USUARIO", x => new { x.idEmpleado, x.loginUser });
                });

            migrationBuilder.CreateTable(
                name: "D002_PERFIL",
                columns: table => new
                {
                    idPerfil = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codPerfil = table.Column<string>(nullable: true),
                    nombrePerfil = table.Column<string>(nullable: true),
                    idUsuario = table.Column<int>(nullable: false),
                    estado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D002_PERFIL", x => x.idPerfil);
                });

            migrationBuilder.CreateTable(
                name: "D012_CRONOMEDICO",
                columns: table => new
                {
                    idProgramMedica = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mes = table.Column<string>(nullable: true),
                    semana = table.Column<string>(nullable: true),
                    dia = table.Column<string>(nullable: true),
                    fechaIni = table.Column<DateTime>(nullable: true),
                    fechaFin = table.Column<DateTime>(nullable: true),
                    idMedico = table.Column<int>(nullable: true),
                    idEspecialidad = table.Column<int>(nullable: true),
                    idConsultorio = table.Column<int>(nullable: true),
                    hrInicio = table.Column<string>(nullable: true),
                    hrFin = table.Column<string>(nullable: true),
                    idEstado = table.Column<int>(nullable: true),
                    fechaBaja = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D012_CRONOMEDICO", x => x.idProgramMedica);
                });

            migrationBuilder.CreateTable(
                name: "D015_PAGO",
                columns: table => new
                {
                    idPago = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codTransaccion = table.Column<string>(nullable: true),
                    codTransacRetorno = table.Column<string>(nullable: true),
                    idFormaPago = table.Column<int>(nullable: true),
                    monto = table.Column<double>(nullable: true),
                    fecRegistro = table.Column<DateTime>(nullable: true),
                    fecOkPasarela = table.Column<DateTime>(nullable: true),
                    idCita = table.Column<int>(nullable: true),
                    estado = table.Column<string>(nullable: true),
                    fechaBaja = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D015_PAGO", x => x.idPago);
                });

            migrationBuilder.CreateTable(
                name: "D024_CAJA",
                columns: table => new
                {
                    idCaja = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nroCaja = table.Column<int>(nullable: true),
                    montoAper = table.Column<double>(nullable: true),
                    divisa = table.Column<string>(nullable: true),
                    turno = table.Column<string>(nullable: true),
                    pos = table.Column<bool>(nullable: true),
                    modopago = table.Column<string>(nullable: true),
                    proveedor = table.Column<string>(nullable: true),
                    tipo = table.Column<string>(nullable: true),
                    montoCierre = table.Column<double>(nullable: true),
                    motivo = table.Column<string>(nullable: true),
                    estado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D024_CAJA", x => x.idCaja);
                });

            migrationBuilder.CreateTable(
                name: "D025_ASIGNACAJA",
                columns: table => new
                {
                    idCaja = table.Column<int>(nullable: false),
                    idEmpleado = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D025_ASIGNACAJA", x => new { x.idCaja, x.idEmpleado });
                });

            migrationBuilder.CreateTable(
                name: "T000_PERSONA",
                columns: table => new
                {
                    idPersona = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    apePaterno = table.Column<string>(nullable: true),
                    apeMaterno = table.Column<string>(nullable: true),
                    nombres = table.Column<string>(nullable: true),
                    idtpDocumento = table.Column<int>(nullable: true),
                    dniPersona = table.Column<int>(nullable: true),
                    idSexo = table.Column<int>(nullable: true),
                    idEtnico = table.Column<int>(nullable: true),
                    fecNace = table.Column<string>(nullable: true),
                    idUbigeoResi = table.Column<int>(nullable: true),
                    idtipoVia = table.Column<int>(nullable: true),
                    nombreVia = table.Column<string>(nullable: true),
                    nroVia = table.Column<int>(nullable: true),
                    nroDpto = table.Column<int>(nullable: true),
                    interior = table.Column<int>(nullable: true),
                    manzana = table.Column<int>(nullable: true),
                    nroLote = table.Column<int>(nullable: true),
                    nroKm = table.Column<int>(nullable: true),
                    nroBlock = table.Column<int>(nullable: true),
                    nroEtapa = table.Column<int>(nullable: true),
                    edad = table.Column<int>(nullable: true),
                    idUbigeoNace = table.Column<int>(nullable: true),
                    fotografia = table.Column<string>(nullable: true),
                    idGrdInstruc = table.Column<int>(nullable: true),
                    idReligion = table.Column<int>(nullable: true),
                    centroEduca = table.Column<string>(nullable: true),
                    idEstCivil = table.Column<int>(nullable: true),
                    idOcupacion = table.Column<int>(nullable: true),
                    idgpoSangre = table.Column<int>(nullable: true),
                    idFactorrh = table.Column<int>(nullable: true),
                    nroRuc = table.Column<int>(nullable: true),
                    razonSocial = table.Column<string>(nullable: true),
                    estadoRuc = table.Column<string>(nullable: true),
                    condicionRuc = table.Column<string>(nullable: true),
                    domiFiscal = table.Column<string>(nullable: true),
                    idParentesco = table.Column<int>(nullable: true),
                    telefono = table.Column<string>(nullable: true),
                    celular = table.Column<string>(nullable: true),
                    correo = table.Column<string>(nullable: true),
                    tpPersona = table.Column<int>(nullable: true),
                    iddatoSiteds = table.Column<int>(nullable: true),
                    idemprConvenio = table.Column<int>(nullable: true),
                    idciaSeguro = table.Column<int>(nullable: true),
                    idtipoIafa = table.Column<int>(nullable: true),
                    estado = table.Column<string>(nullable: true),
                    fechabaja = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T000_PERSONA", x => x.idPersona);
                });

            migrationBuilder.CreateTable(
                name: "T001_PACIENTE",
                columns: table => new
                {
                    idPaciente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codPaciente = table.Column<string>(nullable: true),
                    descripcion = table.Column<string>(nullable: true),
                    nrohc = table.Column<string>(nullable: true),
                    nombreAcom = table.Column<string>(nullable: true),
                    edadAcom = table.Column<int>(nullable: true),
                    dniAcom = table.Column<int>(nullable: true),
                    idgpoSangre = table.Column<int>(nullable: true),
                    idFactorrh = table.Column<int>(nullable: true),
                    cobertura = table.Column<string>(nullable: true),
                    ordenAtenMed = table.Column<string>(nullable: true),
                    nomAsegurado = table.Column<string>(nullable: true),
                    codAsegurado = table.Column<string>(nullable: true),
                    poliza = table.Column<string>(nullable: true),
                    parentesco = table.Column<int>(nullable: true),
                    iniVigencia = table.Column<DateTime>(nullable: true),
                    finVigencia = table.Column<DateTime>(nullable: true),
                    tpPlanSalud = table.Column<int>(nullable: true),
                    nroPlanSalud = table.Column<int>(nullable: true),
                    estadoSeguro = table.Column<int>(nullable: true),
                    tpAfiliacion = table.Column<int>(nullable: true),
                    fecAfiliacion = table.Column<string>(nullable: true),
                    codTitular = table.Column<int>(nullable: true),
                    moneda = table.Column<string>(nullable: true),
                    nomContratante = table.Column<string>(nullable: true),
                    tpDocumento = table.Column<int>(nullable: true),
                    dniContratante = table.Column<int>(nullable: true),
                    planSalud = table.Column<string>(nullable: true),
                    codCobertura = table.Column<int>(nullable: true),
                    beneficio = table.Column<string>(nullable: true),
                    restriccion = table.Column<string>(nullable: true),
                    copagoFijo = table.Column<int>(nullable: true),
                    copagoVariable = table.Column<int>(nullable: true),
                    finCarencia = table.Column<int>(nullable: true),
                    convenio = table.Column<string>(nullable: true),
                    descuento = table.Column<double>(nullable: true),
                    codPaConvenio = table.Column<string>(nullable: true),
                    dsPacConv = table.Column<string>(nullable: true),
                    statPaconv = table.Column<string>(nullable: true),
                    codPacSoat = table.Column<string>(nullable: true),
                    dsPacSoat = table.Column<string>(nullable: true),
                    statPacSoat = table.Column<string>(nullable: true),
                    codpacExterno = table.Column<string>(nullable: true),
                    dspacExter = table.Column<string>(nullable: true),
                    stapacexter = table.Column<string>(nullable: true),
                    tpPaciente = table.Column<int>(nullable: false),
                    idPersona = table.Column<int>(nullable: true),
                    hojafiliacion = table.Column<bool>(nullable: true),
                    concienteDato = table.Column<bool>(nullable: true),
                    estado = table.Column<int>(nullable: false),
                    fechabaja = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T001_PACIENTE", x => x.idPaciente);
                });

            migrationBuilder.CreateTable(
                name: "T068_CITA",
                columns: table => new
                {
                    idCita = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codCita = table.Column<int>(nullable: true),
                    nroCita = table.Column<int>(nullable: true),
                    descripcion = table.Column<string>(nullable: true),
                    fechaCita = table.Column<DateTime>(nullable: true),
                    ultCie10 = table.Column<string>(nullable: true),
                    tpAtencion = table.Column<int>(nullable: true),
                    nroHC = table.Column<string>(nullable: true),
                    ejecutado = table.Column<string>(nullable: true),
                    prioridad = table.Column<string>(nullable: true),
                    precio = table.Column<double>(nullable: true),
                    descuento = table.Column<double>(nullable: true),
                    coa = table.Column<double>(nullable: true),
                    igv = table.Column<double>(nullable: true),
                    estadoReprogram = table.Column<string>(nullable: true),
                    tipoCita = table.Column<int>(nullable: true),
                    motivoRepro = table.Column<string>(nullable: true),
                    motivoAnula = table.Column<string>(nullable: true),
                    idEstadoCita = table.Column<int>(nullable: true),
                    idPaciente = table.Column<int>(nullable: true),
                    idEmpleado = table.Column<int>(nullable: true),
                    idConsultorio = table.Column<int>(nullable: true),
                    idProgramMedica = table.Column<int>(nullable: true),
                    idservicioCli = table.Column<int>(nullable: true),
                    estado = table.Column<int>(nullable: true),
                    fechabaja = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T068_CITA", x => x.idCita);
                });

            migrationBuilder.CreateTable(
                name: "T109_ESTADOCITA",
                columns: table => new
                {
                    idEstadoCita = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codEstadoCita = table.Column<string>(nullable: true),
                    estado = table.Column<string>(nullable: true),
                    origen = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T109_ESTADOCITA", x => x.idEstadoCita);
                });

            migrationBuilder.CreateTable(
                name: "T120_EMPLEADO",
                columns: table => new
                {
                    idEmpleado = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codEmpleado = table.Column<string>(nullable: true),
                    descArea = table.Column<string>(nullable: true),
                    cargo = table.Column<string>(nullable: true),
                    fecIngreso = table.Column<DateTime>(nullable: true),
                    salario = table.Column<int>(nullable: true),
                    genero = table.Column<int>(nullable: true),
                    idtpEmpleado = table.Column<int>(nullable: true),
                    idPersona = table.Column<int>(nullable: true),
                    estado = table.Column<int>(nullable: true),
                    fechabaja = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T120_EMPLEADO", x => x.idEmpleado);
                });

            migrationBuilder.CreateTable(
                name: "T212_MEDICO",
                columns: table => new
                {
                    idMedico = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codMedico = table.Column<string>(nullable: true),
                    nroColegio = table.Column<int>(nullable: true),
                    nroRne = table.Column<string>(nullable: true),
                    nroRuc = table.Column<int>(nullable: true),
                    idtpDocumento = table.Column<int>(nullable: true),
                    condicion = table.Column<string>(nullable: true),
                    idEmpleado = table.Column<int>(nullable: true),
                    idEspecialidad = table.Column<int>(nullable: true),
                    idPersona = table.Column<int>(nullable: true),
                    estado = table.Column<int>(nullable: false),
                    fechabaja = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T212_MEDICO", x => x.idMedico);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "D00_TBDETALLE");

            migrationBuilder.DropTable(
                name: "D00_TBGENERAL");

            migrationBuilder.DropTable(
                name: "D001_USUARIO");

            migrationBuilder.DropTable(
                name: "D002_PERFIL");

            migrationBuilder.DropTable(
                name: "D012_CRONOMEDICO");

            migrationBuilder.DropTable(
                name: "D015_PAGO");

            migrationBuilder.DropTable(
                name: "D024_CAJA");

            migrationBuilder.DropTable(
                name: "D025_ASIGNACAJA");

            migrationBuilder.DropTable(
                name: "T000_PERSONA");

            migrationBuilder.DropTable(
                name: "T001_PACIENTE");

            migrationBuilder.DropTable(
                name: "T068_CITA");

            migrationBuilder.DropTable(
                name: "T109_ESTADOCITA");

            migrationBuilder.DropTable(
                name: "T120_EMPLEADO");

            migrationBuilder.DropTable(
                name: "T212_MEDICO");
        }
    }
}
