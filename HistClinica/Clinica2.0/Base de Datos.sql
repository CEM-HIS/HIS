USE [master]
GO
/****** Object:  Database [Clinica]    Script Date: 13/07/2020 02:05:50 PM ******/
CREATE DATABASE [Clinica]
GO
ALTER DATABASE [Clinica] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Clinica].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Clinica] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Clinica] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Clinica] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Clinica] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Clinica] SET ARITHABORT OFF 
GO
ALTER DATABASE [Clinica] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Clinica] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Clinica] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Clinica] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Clinica] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Clinica] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Clinica] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Clinica] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Clinica] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Clinica] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Clinica] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Clinica] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Clinica] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Clinica] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Clinica] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Clinica] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [Clinica] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Clinica] SET RECOVERY FULL 
GO
ALTER DATABASE [Clinica] SET  MULTI_USER 
GO
ALTER DATABASE [Clinica] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Clinica] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Clinica] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Clinica] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Clinica] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Clinica', N'ON'
GO
ALTER DATABASE [Clinica] SET QUERY_STORE = OFF
GO
USE [Clinica]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [Clinica]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 13/07/2020 02:05:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CAJA]    Script Date: 13/07/2020 02:05:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CAJA](
	[idCaja] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](max) NULL,
	[idTipoCaja] [int] NULL,
	[idEstado] [int] NULL,
 CONSTRAINT [PK_CAJA] PRIMARY KEY CLUSTERED 
(
	[idCaja] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CAJA_ASIGNADA]    Script Date: 13/07/2020 02:05:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CAJA_ASIGNADA](
	[idCaja] [int] NOT NULL,
	[fechaApertura] [nvarchar](450) NOT NULL,
	[turno] [nvarchar](450) NOT NULL,
	[idEmpleado] [int] NOT NULL,
	[horaApertura] [nvarchar](max) NULL,
	[fechaCierre] [nvarchar](max) NULL,
	[horaCierre] [nvarchar](max) NULL,
	[pos] [bit] NULL,
	[montoSolesApertura] [float] NULL,
	[montoDolaresApertura] [float] NULL,
	[montoEurosApertura] [float] NULL,
	[montoSolesCierre] [float] NULL,
	[montoDolaresCierre] [float] NULL,
	[montoEurosCierre] [float] NULL,
	[glosaApertura] [nvarchar](max) NULL,
	[glosaCierre] [nvarchar](max) NULL,
 CONSTRAINT [PK_CAJA_ASIGNADA] PRIMARY KEY CLUSTERED 
(
	[idCaja] ASC,
	[fechaApertura] ASC,
	[turno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CITA]    Script Date: 13/07/2020 02:05:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CITA](
	[idCita] [int] IDENTITY(1,1) NOT NULL,
	[codigoCita] [int] NULL,
	[numeroCita] [int] NULL,
	[descripcion] [nvarchar](max) NULL,
	[fechaCita] [datetime2](7) NULL,
	[ultCie10] [nvarchar](max) NULL,
	[idTipoAtencion] [int] NULL,
	[numeroHC] [nvarchar](max) NULL,
	[ejecutado] [nvarchar](max) NULL,
	[prioridad] [nvarchar](max) NULL,
	[precio] [float] NULL,
	[descuento] [float] NULL,
	[coa] [float] NULL,
	[igv] [float] NULL,
	[estadoReprogramacion] [nvarchar](max) NULL,
	[idtipoCita] [int] NULL,
	[motivoReprogramacion] [nvarchar](max) NULL,
	[motivoAnulacion] [nvarchar](max) NULL,
	[idEstadoCita] [int] NULL,
	[idPaciente] [int] NULL,
	[idEmpleado] [int] NULL,
	[idConsultorio] [int] NULL,
	[idProgramacionMedica] [int] NULL,
	[idServicioClinica] [int] NULL,
	[fechaBaja] [datetime2](7) NULL,
 CONSTRAINT [PK_CITA] PRIMARY KEY CLUSTERED 
(
	[idCita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CRONOGRAMA_MEDICO]    Script Date: 13/07/2020 02:05:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CRONOGRAMA_MEDICO](
	[idProgramMedica] [int] IDENTITY(1,1) NOT NULL,
	[mes] [nvarchar](max) NULL,
	[semana] [nvarchar](max) NULL,
	[dia] [nvarchar](max) NULL,
	[fechaInicio] [datetime2](7) NOT NULL,
	[fechaFin] [datetime2](7) NOT NULL,
	[idMedico] [int] NOT NULL,
	[idEspecialidad] [int] NOT NULL,
	[idConsultorio] [int] NOT NULL,
	[horaInicio] [nvarchar](max) NOT NULL,
	[horaFin] [nvarchar](max) NOT NULL,
	[idEstado] [int] NULL,
	[fechaBaja] [nvarchar](max) NULL,
	[intervalo] [nvarchar](max) NULL,
 CONSTRAINT [PK_CRONOGRAMA_MEDICO] PRIMARY KEY CLUSTERED 
(
	[idProgramMedica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMPLEADO]    Script Date: 13/07/2020 02:05:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMPLEADO](
	[idEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[codigoEmpleado] [nvarchar](max) NULL,
	[descripcionArea] [nvarchar](max) NULL,
	[cargo] [nvarchar](max) NULL,
	[fechaIngreso] [datetime2](7) NULL,
	[salario] [float] NULL,
	[idGenero] [int] NULL,
	[idTipoEmpleado] [int] NULL,
	[idPersona] [int] NULL,
	[idEstado] [int] NULL,
	[fechaBaja] [nvarchar](max) NULL,
 CONSTRAINT [PK_EMPLEADO] PRIMARY KEY CLUSTERED 
(
	[idEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMPRESA]    Script Date: 13/07/2020 02:05:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMPRESA](
	[idempresa] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](max) NULL,
 CONSTRAINT [PK_EMPRESA] PRIMARY KEY CLUSTERED 
(
	[idempresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ESTADO_CITA]    Script Date: 13/07/2020 02:05:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ESTADO_CITA](
	[idEstadoCita] [int] IDENTITY(1,1) NOT NULL,
	[codigoEstadoCita] [nvarchar](max) NULL,
	[estado] [nvarchar](max) NULL,
	[origen] [nvarchar](max) NULL,
 CONSTRAINT [PK_ESTADO_CITA] PRIMARY KEY CLUSTERED 
(
	[idEstadoCita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LICENCIA]    Script Date: 13/07/2020 02:05:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LICENCIA](
	[idLicencia] [int] IDENTITY(1,1) NOT NULL,
	[idMedico] [int] NOT NULL,
	[horaInicio] [nvarchar](max) NULL,
	[horaFin] [nvarchar](max) NULL,
	[fechaInicio] [datetime2](7) NULL,
	[fechaFin] [datetime2](7) NULL,
	[idEstado] [int] NULL,
 CONSTRAINT [PK_LICENCIA] PRIMARY KEY CLUSTERED 
(
	[idLicencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MEDICO]    Script Date: 13/07/2020 02:05:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MEDICO](
	[idMedico] [int] IDENTITY(1,1) NOT NULL,
	[codigoMedico] [nvarchar](max) NULL,
	[numeroColegio] [int] NULL,
	[numeroRne] [nvarchar](max) NULL,
	[numeroRuc] [int] NULL,
	[idTipoDocumento] [int] NULL,
	[condicion] [nvarchar](max) NULL,
	[idEmpleado] [int] NULL,
	[idEspecialidad] [int] NULL,
	[idPersona] [int] NULL,
	[idEstado] [int] NULL,
	[fechaBaja] [nvarchar](max) NULL,
 CONSTRAINT [PK_MEDICO] PRIMARY KEY CLUSTERED 
(
	[idMedico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MENU]    Script Date: 13/07/2020 02:05:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MENU](
	[IdMenu] [int] IDENTITY(1,1) NOT NULL,
	[nombreMenu] [nvarchar](max) NULL,
	[linkMenu] [nvarchar](max) NULL,
 CONSTRAINT [PK_MENU] PRIMARY KEY CLUSTERED 
(
	[IdMenu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MODULO]    Script Date: 13/07/2020 02:05:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MODULO](
	[idModulo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](max) NULL,
 CONSTRAINT [PK_MODULO] PRIMARY KEY CLUSTERED 
(
	[idModulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PACIENTE]    Script Date: 13/07/2020 02:05:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PACIENTE](
	[idPaciente] [int] IDENTITY(1,1) NOT NULL,
	[codigoPaciente] [nvarchar](max) NULL,
	[descripcion] [nvarchar](max) NULL,
	[numeroHc] [nvarchar](max) NULL,
	[nombreAcompañante] [nvarchar](max) NULL,
	[edadAcompañante] [int] NULL,
	[dniAcompañante] [int] NULL,
	[idGrupoSanguineo] [int] NULL,
	[idFactorRh] [int] NULL,
	[cobertura] [nvarchar](max) NULL,
	[ordenAtenMedica] [nvarchar](max) NULL,
	[nombreAsegurado] [nvarchar](max) NULL,
	[codigoAsegurado] [nvarchar](max) NULL,
	[poliza] [nvarchar](max) NULL,
	[idParentesco] [int] NULL,
	[inicioVigencia] [datetime2](7) NULL,
	[finVigencia] [datetime2](7) NULL,
	[idTipoPlanSalud] [int] NULL,
	[numeroPlanSalud] [int] NULL,
	[idEstadoSeguro] [int] NULL,
	[idTipoAfiliacion] [int] NULL,
	[fechaAfiliacion] [nvarchar](max) NULL,
	[codigoTitular] [int] NULL,
	[moneda] [nvarchar](max) NULL,
	[nombreContratante] [nvarchar](max) NULL,
	[idTipoDocumento] [int] NULL,
	[dniContratante] [int] NULL,
	[planSalud] [nvarchar](max) NULL,
	[codigoCobertura] [int] NULL,
	[beneficio] [nvarchar](max) NULL,
	[restriccion] [nvarchar](max) NULL,
	[copagoFijo] [int] NULL,
	[copagoVariable] [int] NULL,
	[finCarencia] [int] NULL,
	[convenio] [nvarchar](max) NULL,
	[descuento] [float] NULL,
	[codigoPacienteConvenio] [nvarchar](max) NULL,
	[descripcionPacienteConvenio] [nvarchar](max) NULL,
	[estadoPacienteConvenio] [nvarchar](max) NULL,
	[codigoPacienteSoat] [nvarchar](max) NULL,
	[descripcionPacienteSoat] [nvarchar](max) NULL,
	[estadoPacienteSoat] [nvarchar](max) NULL,
	[codigoPacienteExterno] [nvarchar](max) NULL,
	[descripcionPacienteExterno] [nvarchar](max) NULL,
	[estadoPacienteExterno] [nvarchar](max) NULL,
	[idTipoPaciente] [int] NULL,
	[idPersona] [int] NULL,
	[hojafiliacion] [bit] NULL,
	[concienteDato] [bit] NULL,
	[idEstado] [int] NULL,
	[fechaBaja] [nvarchar](max) NULL,
 CONSTRAINT [PK_PACIENTE] PRIMARY KEY CLUSTERED 
(
	[idPaciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PAGO]    Script Date: 13/07/2020 02:05:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PAGO](
	[idPago] [int] IDENTITY(1,1) NOT NULL,
	[codigoTransaccion] [nvarchar](max) NULL,
	[codigoTransacccionRetorno] [nvarchar](max) NULL,
	[idFormaPago] [int] NULL,
	[monto] [float] NULL,
	[fechaRegistro] [datetime2](7) NULL,
	[fechaOkPasarela] [datetime2](7) NULL,
	[idCita] [int] NULL,
	[estado] [nvarchar](max) NULL,
	[fechaBaja] [nvarchar](max) NULL,
 CONSTRAINT [PK_PAGO] PRIMARY KEY CLUSTERED 
(
	[idPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PERFIL]    Script Date: 13/07/2020 02:05:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PERFIL](
	[idPerfil] [int] IDENTITY(1,1) NOT NULL,
	[codPerfil] [nvarchar](max) NULL,
	[nombrePerfil] [nvarchar](max) NULL,
	[idUsuario] [int] NOT NULL,
	[estado] [nvarchar](max) NULL,
 CONSTRAINT [PK_PERFIL] PRIMARY KEY CLUSTERED 
(
	[idPerfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PERSONA]    Script Date: 13/07/2020 02:05:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PERSONA](
	[idPersona] [int] IDENTITY(1,1) NOT NULL,
	[apellidoPaterno] [nvarchar](max) NULL,
	[apellidoMaterno] [nvarchar](max) NULL,
	[nombres] [nvarchar](max) NULL,
	[idTipoDocumento] [int] NULL,
	[dniPersona] [int] NULL,
	[idSexo] [int] NULL,
	[idEtnico] [int] NULL,
	[fechaNacimiento] [nvarchar](max) NULL,
	[idUbigeoResidencia] [int] NULL,
	[idtipoVia] [int] NULL,
	[nombreVia] [nvarchar](max) NULL,
	[numeroVia] [int] NULL,
	[numeroDepartamento] [int] NULL,
	[interior] [int] NULL,
	[manzana] [int] NULL,
	[numeroLote] [int] NULL,
	[numeroKilometro] [int] NULL,
	[numeroBloque] [int] NULL,
	[numeroEtapa] [int] NULL,
	[edad] [int] NULL,
	[idUbigeoNacimiento] [int] NULL,
	[fotografia] [nvarchar](max) NULL,
	[idGradoInstruccion] [int] NULL,
	[idReligion] [int] NULL,
	[centroEducativo] [nvarchar](max) NULL,
	[idEstadoCivil] [int] NULL,
	[idOcupacion] [int] NULL,
	[numeroRuc] [int] NULL,
	[razonSocial] [nvarchar](max) NULL,
	[estadoRuc] [nvarchar](max) NULL,
	[condicionRuc] [nvarchar](max) NULL,
	[domicioFiscal] [nvarchar](max) NULL,
	[idParentesco] [int] NULL,
	[telefono] [nvarchar](max) NULL,
	[celular] [nvarchar](max) NULL,
	[correo] [nvarchar](max) NULL,
	[idDatoSiteds] [int] NULL,
	[idEmpresaConvenio] [int] NULL,
	[idCompañiaSeguro] [int] NULL,
	[idTipoIafa] [int] NULL,
	[idEstado] [int] NULL,
	[fechaBaja] [nvarchar](max) NULL,
 CONSTRAINT [PK_PERSONA] PRIMARY KEY CLUSTERED 
(
	[idPersona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ROL]    Script Date: 13/07/2020 02:05:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ROL](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[NormalizedName] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_ROL] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ROLCLAIM]    Script Date: 13/07/2020 02:05:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ROLCLAIM](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](max) NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_ROLCLAIM] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SEDE]    Script Date: 13/07/2020 02:05:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SEDE](
	[idSede] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](max) NULL,
 CONSTRAINT [PK_SEDE] PRIMARY KEY CLUSTERED 
(
	[idSede] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TABLA_DETALLE]    Script Date: 13/07/2020 02:05:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TABLA_DETALLE](
	[idTablaDetalle] [int] IDENTITY(1,1) NOT NULL,
	[codigoTablaDetalle] [nvarchar](max) NOT NULL,
	[descripcion] [nvarchar](max) NOT NULL,
	[abreviatura] [nvarchar](max) NULL,
	[fuente] [nvarchar](max) NULL,
	[idEstado] [int] NULL,
	[idTablaGeneral] [int] NULL,
	[fechaBaja] [datetime2](7) NULL,
 CONSTRAINT [PK_TABLA_DETALLE] PRIMARY KEY CLUSTERED 
(
	[idTablaDetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TABLA_GENERAL]    Script Date: 13/07/2020 02:05:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TABLA_GENERAL](
	[idTablaGeneral] [int] IDENTITY(1,1) NOT NULL,
	[codigoTablaGeneral] [nvarchar](max) NOT NULL,
	[descripcion] [nvarchar](max) NOT NULL,
	[tipo] [nvarchar](max) NULL,
	[fechaCreacion] [datetime2](7) NULL,
	[usuarioCreacion] [nvarchar](max) NULL,
	[estado] [nvarchar](max) NULL,
	[fechaBaja] [datetime2](7) NULL,
 CONSTRAINT [PK_TABLA_GENERAL] PRIMARY KEY CLUSTERED 
(
	[idTablaGeneral] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USUARIO]    Script Date: 13/07/2020 02:05:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIO](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](max) NULL,
	[NormalizedUserName] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[NormalizedEmail] [nvarchar](max) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[Discriminator] [nvarchar](max) NOT NULL,
	[idEmpleado] [int] NULL,
	[idEstado] [int] NULL,
	[usuarioCreacion] [nvarchar](max) NULL,
	[fechaCreacion] [nvarchar](max) NULL,
	[usuarioModifica] [nvarchar](max) NULL,
	[fechaModifica] [nvarchar](max) NULL,
	[fechaBaja] [nvarchar](max) NULL,
 CONSTRAINT [PK_USUARIO] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USUARIOCLAIM]    Script Date: 13/07/2020 02:05:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIOCLAIM](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](max) NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_USUARIOCLAIM] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USUARIOLOGIN]    Script Date: 13/07/2020 02:05:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIOLOGIN](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](max) NULL,
 CONSTRAINT [PK_USUARIOLOGIN] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USUARIOROL]    Script Date: 13/07/2020 02:05:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIOROL](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_USUARIOROL] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USUARIOTOKEN]    Script Date: 13/07/2020 02:05:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIOTOKEN](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_USUARIOTOKEN] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [Clinica] SET  READ_WRITE 
GO
