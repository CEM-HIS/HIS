﻿// <auto-generated />
using System;
using Clinica2._0.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Clinica2._0.Migrations
{
    [DbContext(typeof(ClinicaServiceContext))]
    partial class ClinicaServiceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Clinica2._0.Models.CAJA", b =>
                {
                    b.Property<int>("idCaja")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("idEstado")
                        .HasColumnType("int");

                    b.Property<int?>("idTipoCaja")
                        .HasColumnType("int");

                    b.HasKey("idCaja");

                    b.ToTable("CAJA");
                });

            modelBuilder.Entity("Clinica2._0.Models.CAJA_ASIGNADA", b =>
                {
                    b.Property<int>("idCaja")
                        .HasColumnType("int");

                    b.Property<string>("fechaApertura")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("turno")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("fechaCierre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("glosaApertura")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("glosaCierre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("horaApertura")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("horaCierre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idEmpleado")
                        .HasColumnType("int");

                    b.Property<double?>("montoDolaresApertura")
                        .HasColumnType("float");

                    b.Property<double?>("montoDolaresCierre")
                        .HasColumnType("float");

                    b.Property<double?>("montoEurosApertura")
                        .HasColumnType("float");

                    b.Property<double?>("montoEurosCierre")
                        .HasColumnType("float");

                    b.Property<double?>("montoSolesApertura")
                        .HasColumnType("float");

                    b.Property<double?>("montoSolesCierre")
                        .HasColumnType("float");

                    b.Property<bool?>("pos")
                        .HasColumnType("bit");

                    b.HasKey("idCaja", "fechaApertura", "turno");

                    b.ToTable("CAJA_ASIGNADA");
                });

            modelBuilder.Entity("Clinica2._0.Models.CITA", b =>
                {
                    b.Property<int>("idCita")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double?>("coa")
                        .HasColumnType("float");

                    b.Property<int?>("codigoCita")
                        .HasColumnType("int");

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("descuento")
                        .HasColumnType("float");

                    b.Property<string>("ejecutado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estadoReprogramacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("fechaBaja")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("fechaCita")
                        .HasColumnType("datetime2");

                    b.Property<int?>("idConsultorio")
                        .HasColumnType("int");

                    b.Property<int?>("idEmpleado")
                        .HasColumnType("int");

                    b.Property<int?>("idEstadoCita")
                        .HasColumnType("int");

                    b.Property<int?>("idPaciente")
                        .HasColumnType("int");

                    b.Property<int?>("idProgramacionMedica")
                        .HasColumnType("int");

                    b.Property<int?>("idServicioClinica")
                        .HasColumnType("int");

                    b.Property<int?>("idTipoAtencion")
                        .HasColumnType("int");

                    b.Property<int?>("idtipoCita")
                        .HasColumnType("int");

                    b.Property<double?>("igv")
                        .HasColumnType("float");

                    b.Property<string>("motivoAnulacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("motivoReprogramacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("numeroCita")
                        .HasColumnType("int");

                    b.Property<string>("numeroHC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("precio")
                        .HasColumnType("float");

                    b.Property<string>("prioridad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ultCie10")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idCita");

                    b.ToTable("CITA");
                });

            modelBuilder.Entity("Clinica2._0.Models.CRONOGRAMA_MEDICO", b =>
                {
                    b.Property<int>("idProgramMedica")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("dia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fechaBaja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("fechaFin")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("fechaInicio")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("horaFin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("horaInicio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("idConsultorio")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("idEspecialidad")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("idEstado")
                        .HasColumnType("int");

                    b.Property<int?>("idMedico")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("mes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("semana")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idProgramMedica");

                    b.ToTable("CRONOGRAMA_MEDICO");
                });

            modelBuilder.Entity("Clinica2._0.Models.EMPLEADO", b =>
                {
                    b.Property<int>("idEmpleado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cargo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("codigoEmpleado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descripcionArea")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fechaBaja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("fechaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<int?>("idEstado")
                        .HasColumnType("int");

                    b.Property<int?>("idGenero")
                        .HasColumnType("int");

                    b.Property<int?>("idPersona")
                        .HasColumnType("int");

                    b.Property<int?>("idTipoEmpleado")
                        .HasColumnType("int");

                    b.Property<double?>("salario")
                        .HasColumnType("float");

                    b.HasKey("idEmpleado");

                    b.ToTable("EMPLEADO");
                });

            modelBuilder.Entity("Clinica2._0.Models.ESTADO_CITA", b =>
                {
                    b.Property<int>("idEstadoCita")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("codigoEstadoCita")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("origen")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idEstadoCita");

                    b.ToTable("ESTADO_CITA");
                });

            modelBuilder.Entity("Clinica2._0.Models.LICENCIA", b =>
                {
                    b.Property<int>("idLicencia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("fechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("fechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("horaFin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("horaInicio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("idEstado")
                        .HasColumnType("int");

                    b.Property<int>("idMedico")
                        .HasColumnType("int");

                    b.HasKey("idLicencia");

                    b.ToTable("LICENCIA");
                });

            modelBuilder.Entity("Clinica2._0.Models.MEDICO", b =>
                {
                    b.Property<int>("idMedico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("codigoMedico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("condicion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fechaBaja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("idEmpleado")
                        .HasColumnType("int");

                    b.Property<int?>("idEspecialidad")
                        .HasColumnType("int");

                    b.Property<int?>("idEstado")
                        .HasColumnType("int");

                    b.Property<int?>("idPersona")
                        .HasColumnType("int");

                    b.Property<int?>("idTipoDocumento")
                        .HasColumnType("int");

                    b.Property<int?>("numeroColegio")
                        .HasColumnType("int");

                    b.Property<string>("numeroRne")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("numeroRuc")
                        .HasColumnType("int");

                    b.HasKey("idMedico");

                    b.ToTable("MEDICO");
                });

            modelBuilder.Entity("Clinica2._0.Models.PACIENTE", b =>
                {
                    b.Property<int>("idPaciente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("beneficio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cobertura")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("codigoAsegurado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("codigoCobertura")
                        .HasColumnType("int");

                    b.Property<string>("codigoPaciente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("codigoPacienteConvenio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("codigoPacienteExterno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("codigoPacienteSoat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("codigoTitular")
                        .HasColumnType("int");

                    b.Property<bool?>("concienteDato")
                        .HasColumnType("bit");

                    b.Property<string>("convenio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("copagoFijo")
                        .HasColumnType("int");

                    b.Property<int?>("copagoVariable")
                        .HasColumnType("int");

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descripcionPacienteConvenio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descripcionPacienteExterno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descripcionPacienteSoat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("descuento")
                        .HasColumnType("float");

                    b.Property<int?>("dniAcompañante")
                        .HasColumnType("int");

                    b.Property<int?>("dniContratante")
                        .HasColumnType("int");

                    b.Property<int?>("edadAcompañante")
                        .HasColumnType("int");

                    b.Property<string>("estadoPacienteConvenio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estadoPacienteExterno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estadoPacienteSoat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fechaAfiliacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fechaBaja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("finCarencia")
                        .HasColumnType("int");

                    b.Property<DateTime?>("finVigencia")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("hojafiliacion")
                        .HasColumnType("bit");

                    b.Property<int?>("idEstado")
                        .HasColumnType("int");

                    b.Property<int?>("idEstadoSeguro")
                        .HasColumnType("int");

                    b.Property<int?>("idFactorRh")
                        .HasColumnType("int");

                    b.Property<int?>("idGrupoSanguineo")
                        .HasColumnType("int");

                    b.Property<int?>("idParentesco")
                        .HasColumnType("int");

                    b.Property<int?>("idPersona")
                        .HasColumnType("int");

                    b.Property<int?>("idTipoAfiliacion")
                        .HasColumnType("int");

                    b.Property<int?>("idTipoDocumento")
                        .HasColumnType("int");

                    b.Property<int?>("idTipoPaciente")
                        .HasColumnType("int");

                    b.Property<int?>("idTipoPlanSalud")
                        .HasColumnType("int");

                    b.Property<DateTime?>("inicioVigencia")
                        .HasColumnType("datetime2");

                    b.Property<string>("moneda")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombreAcompañante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombreAsegurado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombreContratante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numeroHc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("numeroPlanSalud")
                        .HasColumnType("int");

                    b.Property<string>("ordenAtenMedica")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("planSalud")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("poliza")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("restriccion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idPaciente");

                    b.ToTable("PACIENTE");
                });

            modelBuilder.Entity("Clinica2._0.Models.PAGO", b =>
                {
                    b.Property<int>("idPago")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("codigoTransacccionRetorno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("codigoTransaccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fechaBaja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("fechaOkPasarela")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("fechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int?>("idCita")
                        .HasColumnType("int");

                    b.Property<int?>("idFormaPago")
                        .HasColumnType("int");

                    b.Property<double?>("monto")
                        .HasColumnType("float");

                    b.HasKey("idPago");

                    b.ToTable("PAGO");
                });

            modelBuilder.Entity("Clinica2._0.Models.PERFIL", b =>
                {
                    b.Property<int>("idPerfil")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("codigoPerfil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idUsuario")
                        .HasColumnType("int");

                    b.Property<string>("nombrePerfil")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idPerfil");

                    b.ToTable("PERFIL");
                });

            modelBuilder.Entity("Clinica2._0.Models.PERSONA", b =>
                {
                    b.Property<int>("idPersona")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apellidoMaterno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("apellidoPaterno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("centroEducativo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("condicionRuc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("dniPersona")
                        .HasColumnType("int");

                    b.Property<string>("domicioFiscal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("edad")
                        .HasColumnType("int");

                    b.Property<string>("estadoRuc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fechaBaja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fechaNacimiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fotografia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("idCompañiaSeguro")
                        .HasColumnType("int");

                    b.Property<int?>("idDatoSiteds")
                        .HasColumnType("int");

                    b.Property<int?>("idEmpresaConvenio")
                        .HasColumnType("int");

                    b.Property<int?>("idEstado")
                        .HasColumnType("int");

                    b.Property<int?>("idEstadoCivil")
                        .HasColumnType("int");

                    b.Property<int?>("idEtnico")
                        .HasColumnType("int");

                    b.Property<int?>("idGradoInstruccion")
                        .HasColumnType("int");

                    b.Property<int?>("idOcupacion")
                        .HasColumnType("int");

                    b.Property<int?>("idParentesco")
                        .HasColumnType("int");

                    b.Property<int?>("idReligion")
                        .HasColumnType("int");

                    b.Property<int?>("idSexo")
                        .HasColumnType("int");

                    b.Property<int?>("idTipoDocumento")
                        .HasColumnType("int");

                    b.Property<int?>("idTipoIafa")
                        .HasColumnType("int");

                    b.Property<int?>("idUbigeoNacimiento")
                        .HasColumnType("int");

                    b.Property<int?>("idUbigeoResidencia")
                        .HasColumnType("int");

                    b.Property<int?>("idtipoVia")
                        .HasColumnType("int");

                    b.Property<int?>("interior")
                        .HasColumnType("int");

                    b.Property<int?>("manzana")
                        .HasColumnType("int");

                    b.Property<string>("nombreVia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("numeroBloque")
                        .HasColumnType("int");

                    b.Property<int?>("numeroDepartamento")
                        .HasColumnType("int");

                    b.Property<int?>("numeroEtapa")
                        .HasColumnType("int");

                    b.Property<int?>("numeroKilometro")
                        .HasColumnType("int");

                    b.Property<int?>("numeroLote")
                        .HasColumnType("int");

                    b.Property<int?>("numeroRuc")
                        .HasColumnType("int");

                    b.Property<int?>("numeroVia")
                        .HasColumnType("int");

                    b.Property<string>("razonSocial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idPersona");

                    b.ToTable("PERSONA");
                });

            modelBuilder.Entity("Clinica2._0.Models.TABLA_DETALLE", b =>
                {
                    b.Property<int>("idTablaDetalle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("abreviatura")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("codigoTablaDetalle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("fechaBaja")
                        .HasColumnType("datetime2");

                    b.Property<string>("fuente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("idEstado")
                        .HasColumnType("int");

                    b.Property<int?>("idTablaGeneral")
                        .HasColumnType("int");

                    b.HasKey("idTablaDetalle");

                    b.ToTable("TABLA_DETALLE");
                });

            modelBuilder.Entity("Clinica2._0.Models.TABLA_GENERAL", b =>
                {
                    b.Property<int>("idTablaGeneral")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("codigoTablaGeneral")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("fechaBaja")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("fechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("tipo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("usuarioCreacion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idTablaGeneral");

                    b.ToTable("TABLA_GENERAL");
                });
#pragma warning restore 612, 618
        }
    }
}