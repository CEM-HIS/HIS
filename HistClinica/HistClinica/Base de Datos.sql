USE [master]
GO
/****** Object:  Database [Clinica]    Script Date: 08/07/2020 10:16:23 AM ******/
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
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 08/07/2020 10:16:23 AM ******/
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
/****** Object:  Table [dbo].[CAJA]    Script Date: 08/07/2020 10:16:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CAJA](
	[idCaja] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](max) NULL,
	[tipo] [int] NOT NULL,
	[estado] [int] NOT NULL,
 CONSTRAINT [PK_CAJA] PRIMARY KEY CLUSTERED 
(
	[idCaja] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CAJA_ASIGNADA]    Script Date: 08/07/2020 10:16:23 AM ******/
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
	[glosa] [nvarchar](max) NULL,
 CONSTRAINT [PK_CAJA_ASIGNADA] PRIMARY KEY CLUSTERED 
(
	[idCaja] ASC,
	[fechaApertura] ASC,
	[turno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CITA]    Script Date: 08/07/2020 10:16:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CITA](
	[idCita] [int] IDENTITY(1,1) NOT NULL,
	[codCita] [int] NULL,
	[nroCita] [int] NULL,
	[descripcion] [nvarchar](max) NULL,
	[fechaCita] [datetime2](7) NULL,
	[ultCie10] [nvarchar](max) NULL,
	[tpAtencion] [int] NULL,
	[nroHC] [nvarchar](max) NULL,
	[ejecutado] [nvarchar](max) NULL,
	[prioridad] [nvarchar](max) NULL,
	[precio] [float] NULL,
	[descuento] [float] NULL,
	[coa] [float] NULL,
	[igv] [float] NULL,
	[estadoReprogram] [nvarchar](max) NULL,
	[tipoCita] [int] NULL,
	[motivoRepro] [nvarchar](max) NULL,
	[motivoAnula] [nvarchar](max) NULL,
	[idEstadoCita] [int] NULL,
	[idPaciente] [int] NULL,
	[idEmpleado] [int] NULL,
	[idConsultorio] [int] NULL,
	[idProgramMedica] [int] NULL,
	[idservicioCli] [int] NULL,
	[estado] [int] NULL,
	[fechabaja] [datetime2](7) NULL,
 CONSTRAINT [PK_CITA] PRIMARY KEY CLUSTERED 
(
	[idCita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CRONOGRAMA_MEDICO]    Script Date: 08/07/2020 10:16:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CRONOGRAMA_MEDICO](
	[idProgramMedica] [int] IDENTITY(1,1) NOT NULL,
	[mes] [nvarchar](max) NULL,
	[semana] [nvarchar](max) NULL,
	[dia] [nvarchar](max) NULL,
	[fechaIni] [datetime2](7) NOT NULL,
	[fechaFin] [datetime2](7) NOT NULL,
	[idMedico] [int] NOT NULL,
	[idEspecialidad] [int] NOT NULL,
	[idConsultorio] [int] NOT NULL,
	[hrInicio] [nvarchar](max) NOT NULL,
	[hrFin] [nvarchar](max) NOT NULL,
	[idEstado] [int] NULL,
	[fechaBaja] [nvarchar](max) NULL,
 CONSTRAINT [PK_CRONOGRAMA_MEDICO] PRIMARY KEY CLUSTERED 
(
	[idProgramMedica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMPLEADO]    Script Date: 08/07/2020 10:16:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMPLEADO](
	[idEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[codEmpleado] [nvarchar](max) NULL,
	[descArea] [nvarchar](max) NULL,
	[cargo] [nvarchar](max) NULL,
	[fecIngreso] [datetime2](7) NULL,
	[salario] [int] NULL,
	[genero] [int] NULL,
	[idtpEmpleado] [int] NULL,
	[idPersona] [int] NULL,
	[estado] [int] NULL,
	[fechabaja] [nvarchar](max) NULL,
 CONSTRAINT [PK_EMPLEADO] PRIMARY KEY CLUSTERED 
(
	[idEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ESTADO_CITA]    Script Date: 08/07/2020 10:16:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ESTADO_CITA](
	[idEstadoCita] [int] IDENTITY(1,1) NOT NULL,
	[codEstadoCita] [nvarchar](max) NULL,
	[estado] [nvarchar](max) NULL,
	[origen] [nvarchar](max) NULL,
 CONSTRAINT [PK_ESTADO_CITA] PRIMARY KEY CLUSTERED 
(
	[idEstadoCita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MEDICO]    Script Date: 08/07/2020 10:16:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MEDICO](
	[idMedico] [int] IDENTITY(1,1) NOT NULL,
	[codMedico] [nvarchar](max) NULL,
	[nroColegio] [int] NULL,
	[nroRne] [nvarchar](max) NULL,
	[nroRuc] [int] NULL,
	[idtpDocumento] [int] NULL,
	[condicion] [nvarchar](max) NULL,
	[idEmpleado] [int] NULL,
	[idEspecialidad] [int] NULL,
	[idPersona] [int] NULL,
	[estado] [int] NOT NULL,
	[fechabaja] [nvarchar](max) NULL,
 CONSTRAINT [PK_MEDICO] PRIMARY KEY CLUSTERED 
(
	[idMedico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PACIENTE]    Script Date: 08/07/2020 10:16:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PACIENTE](
	[idPaciente] [int] IDENTITY(1,1) NOT NULL,
	[codPaciente] [nvarchar](max) NULL,
	[descripcion] [nvarchar](max) NULL,
	[nrohc] [nvarchar](max) NULL,
	[nombreAcom] [nvarchar](max) NULL,
	[edadAcom] [int] NULL,
	[dniAcom] [int] NULL,
	[idgpoSangre] [int] NULL,
	[idFactorrh] [int] NULL,
	[cobertura] [nvarchar](max) NULL,
	[ordenAtenMed] [nvarchar](max) NULL,
	[nomAsegurado] [nvarchar](max) NULL,
	[codAsegurado] [nvarchar](max) NULL,
	[poliza] [nvarchar](max) NULL,
	[parentesco] [int] NULL,
	[iniVigencia] [datetime2](7) NULL,
	[finVigencia] [datetime2](7) NULL,
	[tpPlanSalud] [int] NULL,
	[nroPlanSalud] [int] NULL,
	[estadoSeguro] [int] NULL,
	[tpAfiliacion] [int] NULL,
	[fecAfiliacion] [nvarchar](max) NULL,
	[codTitular] [int] NULL,
	[moneda] [nvarchar](max) NULL,
	[nomContratante] [nvarchar](max) NULL,
	[tpDocumento] [int] NULL,
	[dniContratante] [int] NULL,
	[planSalud] [nvarchar](max) NULL,
	[codCobertura] [int] NULL,
	[beneficio] [nvarchar](max) NULL,
	[restriccion] [nvarchar](max) NULL,
	[copagoFijo] [int] NULL,
	[copagoVariable] [int] NULL,
	[finCarencia] [int] NULL,
	[convenio] [nvarchar](max) NULL,
	[descuento] [float] NULL,
	[codPaConvenio] [nvarchar](max) NULL,
	[dsPacConv] [nvarchar](max) NULL,
	[statPaconv] [nvarchar](max) NULL,
	[codPacSoat] [nvarchar](max) NULL,
	[dsPacSoat] [nvarchar](max) NULL,
	[statPacSoat] [nvarchar](max) NULL,
	[codpacExterno] [nvarchar](max) NULL,
	[dspacExter] [nvarchar](max) NULL,
	[stapacexter] [nvarchar](max) NULL,
	[tpPaciente] [int] NULL,
	[idPersona] [int] NULL,
	[hojafiliacion] [bit] NULL,
	[concienteDato] [bit] NULL,
	[estado] [int] NULL,
	[fechabaja] [nvarchar](max) NULL,
 CONSTRAINT [PK_PACIENTE] PRIMARY KEY CLUSTERED 
(
	[idPaciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PAGO]    Script Date: 08/07/2020 10:16:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PAGO](
	[idPago] [int] IDENTITY(1,1) NOT NULL,
	[codTransaccion] [nvarchar](max) NULL,
	[codTransacRetorno] [nvarchar](max) NULL,
	[idFormaPago] [int] NULL,
	[monto] [float] NULL,
	[fecRegistro] [datetime2](7) NULL,
	[fecOkPasarela] [datetime2](7) NULL,
	[idCita] [int] NULL,
	[estado] [nvarchar](max) NULL,
	[fechaBaja] [nvarchar](max) NULL,
 CONSTRAINT [PK_PAGO] PRIMARY KEY CLUSTERED 
(
	[idPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PERFIL]    Script Date: 08/07/2020 10:16:23 AM ******/
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
/****** Object:  Table [dbo].[PERSONA]    Script Date: 08/07/2020 10:16:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PERSONA](
	[idPersona] [int] IDENTITY(1,1) NOT NULL,
	[apePaterno] [nvarchar](max) NULL,
	[apeMaterno] [nvarchar](max) NULL,
	[nombres] [nvarchar](max) NULL,
	[idtpDocumento] [int] NULL,
	[dniPersona] [int] NULL,
	[idSexo] [int] NULL,
	[idEtnico] [int] NULL,
	[fecNace] [nvarchar](max) NULL,
	[idUbigeoResi] [int] NULL,
	[idtipoVia] [int] NULL,
	[nombreVia] [nvarchar](max) NULL,
	[nroVia] [int] NULL,
	[nroDpto] [int] NULL,
	[interior] [int] NULL,
	[manzana] [int] NULL,
	[nroLote] [int] NULL,
	[nroKm] [int] NULL,
	[nroBlock] [int] NULL,
	[nroEtapa] [int] NULL,
	[edad] [int] NULL,
	[idUbigeoNace] [int] NULL,
	[fotografia] [nvarchar](max) NULL,
	[idGrdInstruc] [int] NULL,
	[idReligion] [int] NULL,
	[centroEduca] [nvarchar](max) NULL,
	[idEstCivil] [int] NULL,
	[idOcupacion] [int] NULL,
	[idgpoSangre] [int] NULL,
	[idFactorrh] [int] NULL,
	[nroRuc] [int] NULL,
	[razonSocial] [nvarchar](max) NULL,
	[estadoRuc] [nvarchar](max) NULL,
	[condicionRuc] [nvarchar](max) NULL,
	[domiFiscal] [nvarchar](max) NULL,
	[idParentesco] [int] NULL,
	[telefono] [nvarchar](max) NULL,
	[celular] [nvarchar](max) NULL,
	[correo] [nvarchar](max) NULL,
	[tpPersona] [int] NULL,
	[iddatoSiteds] [int] NULL,
	[idemprConvenio] [int] NULL,
	[idciaSeguro] [int] NULL,
	[idtipoIafa] [int] NULL,
	[estado] [nvarchar](max) NULL,
	[fechabaja] [nvarchar](max) NULL,
 CONSTRAINT [PK_PERSONA] PRIMARY KEY CLUSTERED 
(
	[idPersona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TABLA_DETALLE]    Script Date: 08/07/2020 10:16:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TABLA_DETALLE](
	[idDet] [int] IDENTITY(1,1) NOT NULL,
	[coddetTab] [nvarchar](max) NOT NULL,
	[descripcion] [nvarchar](max) NOT NULL,
	[abrev] [nvarchar](max) NULL,
	[fuente] [nvarchar](max) NULL,
	[estado] [nvarchar](max) NULL,
	[idTab] [int] NULL,
	[fechabaja] [datetime2](7) NULL,
 CONSTRAINT [PK_TABLA_DETALLE] PRIMARY KEY CLUSTERED 
(
	[idDet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TABLA_GENERAL]    Script Date: 08/07/2020 10:16:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TABLA_GENERAL](
	[idTab] [int] IDENTITY(1,1) NOT NULL,
	[codTab] [nvarchar](max) NOT NULL,
	[descripcion] [nvarchar](max) NOT NULL,
	[tipo] [nvarchar](max) NULL,
	[fechaCreate] [datetime2](7) NULL,
	[usuCreate] [nvarchar](max) NULL,
	[estado] [nvarchar](max) NULL,
	[fechabaja] [datetime2](7) NULL,
 CONSTRAINT [PK_TABLA_GENERAL] PRIMARY KEY CLUSTERED 
(
	[idTab] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USUARIO]    Script Date: 08/07/2020 10:16:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIO](
	[idEmpleado] [int] NOT NULL,
	[loginUser] [nvarchar](450) NOT NULL,
	[claveUser] [nvarchar](max) NULL,
	[estado] [nvarchar](max) NULL,
	[usuCrea] [nvarchar](max) NULL,
	[fechaCrea] [nvarchar](max) NULL,
	[usuMod] [nvarchar](max) NULL,
	[fechaMod] [nvarchar](max) NULL,
	[fechaBaja] [nvarchar](max) NULL,
 CONSTRAINT [PK_USUARIO] PRIMARY KEY CLUSTERED 
(
	[idEmpleado] ASC,
	[loginUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [Clinica] SET  READ_WRITE 
GO
