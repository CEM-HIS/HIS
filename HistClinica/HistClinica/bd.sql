USE [master]
GO
/****** Object:  Database [Clinica]    Script Date: 30/06/2020 10:55:47 AM ******/
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
ALTER DATABASE [Clinica] SET READ_COMMITTED_SNAPSHOT OFF 
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
/****** Object:  Table [dbo].[D00_TBDETALLE]    Script Date: 30/06/2020 10:55:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D00_TBDETALLE](
	[idDet] [int] IDENTITY(1,1) NOT NULL,
	[coddetTab] [varchar](9) NULL,
	[descripcion] [varchar](50) NULL,
	[abrev] [varchar](15) NULL,
	[fuente] [varchar](150) NULL,
	[idTab] [int] NULL,
	[estado] [char](12) NULL,
	[fechabaja] [date] NULL,
 CONSTRAINT [PK__D00_TBDE__3E41457F0E519ECB] PRIMARY KEY CLUSTERED 
(
	[idDet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D00_TBGENERAL]    Script Date: 30/06/2020 10:55:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D00_TBGENERAL](
	[idTab] [int] IDENTITY(1,1) NOT NULL,
	[codTab] [varchar](9) NULL,
	[descripcion] [varchar](100) NULL,
	[tipo] [varchar](50) NULL,
	[fechaCreate] [date] NULL,
	[usuCreate] [varchar](35) NULL,
	[estado] [char](12) NULL,
	[fechabaja] [date] NULL,
 CONSTRAINT [PK__D00_TBGE__020FEDB39C762A73] PRIMARY KEY CLUSTERED 
(
	[idTab] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D001_USUARIO]    Script Date: 30/06/2020 10:55:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D001_USUARIO](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[loginUser] [varchar](25) NULL,
	[claveUser] [varchar](25) NULL,
	[idEmpleado] [int] NULL,
	[estado] [char](12) NULL,
	[usuCrea] [varchar](25) NULL,
	[fechaCrea] [varchar](15) NULL,
	[usuMod] [varchar](25) NULL,
	[fechaMod] [varchar](15) NULL,
	[fechabaja] [date] NULL,
 CONSTRAINT [PK__D001_USU__645723A674AE501B] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D002_PERFIL]    Script Date: 30/06/2020 10:55:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D002_PERFIL](
	[idPerfil] [int] IDENTITY(1,1) NOT NULL,
	[codPerfil] [varchar](35) NULL,
	[nombrePerfil] [varchar](35) NULL,
	[idUsuario] [int] NOT NULL,
	[estado] [char](3) NULL,
 CONSTRAINT [PK__D002_PER__40F13B60CFEE3423] PRIMARY KEY CLUSTERED 
(
	[idPerfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D012_CRONOMEDICO]    Script Date: 30/06/2020 10:55:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D012_CRONOMEDICO](
	[idProgramMedica] [int] IDENTITY(1,1) NOT NULL,
	[mes] [varchar](15) NULL,
	[semana] [varchar](15) NULL,
	[dia] [varchar](15) NULL,
	[fechaIni] [datetime] NULL,
	[fechaFin] [datetime] NULL,
	[idMedico] [int] NULL,
	[idEspecialidad] [int] NULL,
	[idConsultorio] [int] NULL,
	[hrInicio] [varchar](6) NULL,
	[hrFin] [varchar](6) NULL,
	[estado] [char](12) NULL,
	[fechabaja] [date] NULL,
 CONSTRAINT [PK__D012_CRO__6BCD0A871829A280] PRIMARY KEY CLUSTERED 
(
	[idProgramMedica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D015_PAGO]    Script Date: 30/06/2020 10:55:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D015_PAGO](
	[idPago] [int] IDENTITY(1,1) NOT NULL,
	[codTransaccion] [varchar](20) NULL,
	[codTransacRetorno] [varchar](20) NULL,
	[idFormaPago] [int] NULL,
	[monto] [decimal](16, 2) NULL,
	[fecRegistro] [datetime] NULL,
	[fecOkPasarela] [datetime] NULL,
	[idCita] [int] NULL,
	[estado] [char](12) NULL,
	[fechabaja] [date] NULL,
 CONSTRAINT [PK__D015_PAG__BD2295ADB8822C59] PRIMARY KEY CLUSTERED 
(
	[idPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D024_CAJA]    Script Date: 30/06/2020 10:55:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D024_CAJA](
	[idCaja] [int] IDENTITY(1,1) NOT NULL,
	[nroCaja] [int] NULL,
	[montoAper] [decimal](18, 0) NULL,
	[divisa] [varchar](35) NULL,
	[turno] [varchar](35) NULL,
	[pos] [bit] NULL,
	[modopago] [varchar](35) NULL,
	[proveedor] [varchar](45) NULL,
	[tipo] [varchar](35) NULL,
	[montoCierre] [decimal](18, 0) NULL,
	[motivo] [varchar](100) NULL,
	[estado] [char](10) NULL,
 CONSTRAINT [PK__D024_CAJ__8BC79B3439D5DC90] PRIMARY KEY CLUSTERED 
(
	[idCaja] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D025_ASIGNACAJA]    Script Date: 30/06/2020 10:55:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D025_ASIGNACAJA](
	[idCaja] [int] NULL,
	[idEmpleado] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T000_PERSONA]    Script Date: 30/06/2020 10:55:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T000_PERSONA](
	[idPersona] [int] IDENTITY(1,1) NOT NULL,
	[apePaterno] [varchar](25) NULL,
	[apeMaterno] [varchar](25) NULL,
	[nombres] [varchar](25) NULL,
	[idtpDocumento] [int] NULL,
	[dniPersona] [int] NULL,
	[idSexo] [int] NULL,
	[idEtnico] [int] NULL,
	[fecNace] [varchar](15) NULL,
	[idUbigeoResi] [int] NULL,
	[idtipoVia] [int] NULL,
	[nombreVia] [varchar](35) NULL,
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
	[fotografia] [varchar](150) NULL,
	[idGrdInstruc] [int] NULL,
	[idReligion] [int] NULL,
	[centroEduca] [varchar](50) NULL,
	[idEstCivil] [int] NULL,
	[idOcupacion] [int] NULL,
	[idgpoSangre] [int] NULL,
	[idFactorrh] [int] NULL,
	[nroRuc] [int] NULL,
	[razonSocial] [varchar](80) NULL,
	[estadoRuc] [varchar](15) NULL,
	[condicionRuc] [varchar](15) NULL,
	[domiFiscal] [varchar](40) NULL,
	[idParentesco] [int] NULL,
	[telefono] [varchar](15) NULL,
	[celular] [varchar](15) NULL,
	[correo] [varchar](150) NULL,
	[tpPersona] [int] NULL,
	[iddatoSiteds] [int] NULL,
	[idemprConvenio] [int] NULL,
	[idciaSeguro] [int] NULL,
	[idtipoIafa] [int] NULL,
	[estado] [char](15) NULL,
	[fechabaja] [date] NULL,
 CONSTRAINT [PK__T001_PAC__F48A08F2EC43D268] PRIMARY KEY CLUSTERED 
(
	[idPersona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T001_PACIENTE]    Script Date: 30/06/2020 10:55:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T001_PACIENTE](
	[idPaciente] [int] IDENTITY(1,1) NOT NULL,
	[codPaciente] [varchar](6) NULL,
	[descripcion] [varchar](50) NULL,
	[nrohc] [varchar](15) NULL,
	[nombreAcom] [varchar](30) NULL,
	[edadAcom] [int] NULL,
	[dniAcom] [int] NULL,
	[idgpoSangre] [int] NULL,
	[idFactorrh] [int] NULL,
	[cobertura] [varchar](25) NULL,
	[ordenAtenMed] [varchar](15) NULL,
	[nomAsegurado] [varchar](30) NULL,
	[codAsegurado] [varchar](15) NULL,
	[poliza] [varchar](20) NULL,
	[parentesco] [int] NULL,
	[iniVigencia] [datetime] NULL,
	[finVigencia] [datetime] NULL,
	[tpPlanSalud] [int] NULL,
	[nroPlanSalud] [int] NULL,
	[estadoSeguro] [char](10) NULL,
	[tpAfiliacion] [int] NULL,
	[fecAfiliacion] [datetime] NULL,
	[codTitular] [int] NULL,
	[moneda] [varchar](25) NULL,
	[nomContratante] [varchar](35) NULL,
	[tpDocumento] [int] NULL,
	[dniContratante] [int] NULL,
	[planSalud] [varchar](40) NULL,
	[codCobertura] [int] NULL,
	[beneficio] [varchar](50) NULL,
	[restriccion] [varchar](50) NULL,
	[copagoFijo] [int] NULL,
	[copagoVariable] [int] NULL,
	[finCarencia] [int] NULL,
	[convenio] [varchar](30) NULL,
	[descuento] [decimal](16, 0) NULL,
	[codPaConvenio] [varchar](9) NULL,
	[dsPacConv] [varchar](40) NULL,
	[statPaconv] [char](10) NULL,
	[codPacSoat] [varchar](9) NULL,
	[dsPacSoat] [varchar](40) NULL,
	[statPacSoat] [char](10) NULL,
	[codpacExterno] [varchar](9) NULL,
	[dspacExter] [varchar](40) NULL,
	[stapacexter] [char](10) NULL,
	[tpPaciente] [varchar](9) NULL,
	[idPersona] [int] NULL,
	[hojafiliacion] [bit] NULL,
	[concienteDato] [bit] NULL,
	[estado] [char](10) NULL,
	[fechabaja] [date] NULL,
 CONSTRAINT [PK__T001_PAC__F48A08F29659AC03] PRIMARY KEY CLUSTERED 
(
	[idPaciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T068_CITA]    Script Date: 30/06/2020 10:55:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T068_CITA](
	[idCita] [int] IDENTITY(1,1) NOT NULL,
	[codCita] [int] NULL,
	[nroCita] [int] NULL,
	[descripcion] [varchar](65) NULL,
	[fechaCita] [datetime] NULL,
	[ultCie10] [varchar](10) NULL,
	[tpAtencion] [int] NULL,
	[nroHC] [varchar](10) NULL,
	[ejecutado] [char](10) NULL,
	[prioridad] [char](10) NULL,
	[precio] [decimal](16, 2) NULL,
	[descuento] [decimal](16, 2) NULL,
	[coa] [decimal](16, 2) NULL,
	[igv] [decimal](16, 2) NULL,
	[estadoReprogram] [char](10) NULL,
	[tipoCita] [int] NULL,
	[motivoRepro] [varchar](80) NULL,
	[motivoAnula] [varchar](80) NULL,
	[idEstadoCita] [int] NULL,
	[idPaciente] [int] NULL,
	[idEmpleado] [int] NULL,
	[idConsultorio] [int] NULL,
	[idProgramMedica] [int] NULL,
	[idservicioCli] [int] NULL,
	[estado] [char](12) NULL,
	[fechabaja] [date] NULL,
 CONSTRAINT [PK__T068_CIT__814F3126E4AA01D5] PRIMARY KEY CLUSTERED 
(
	[idCita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T076_PROCEDIMIENTO]    Script Date: 30/06/2020 10:55:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T076_PROCEDIMIENTO](
	[idProcedimiento] [int] IDENTITY(1,1) NOT NULL,
	[codProc] [varchar](8) NULL,
	[descripcion] [varchar](95) NULL,
	[area] [varchar](35) NULL,
	[dsEspecial] [varchar](35) NULL,
	[codEspecial] [varchar](6) NULL,
	[idEspecialidad] [int] NULL,
 CONSTRAINT [PK__T076_PRO__46A68D8333EA46BC] PRIMARY KEY CLUSTERED 
(
	[idProcedimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T120_EMPLEADO]    Script Date: 30/06/2020 10:55:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T120_EMPLEADO](
	[idEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[codEmpleado] [varchar](6) NULL,
	[descArea] [varchar](35) NULL,
	[cargo] [varchar](30) NULL,
	[fecIngreso] [date] NULL,
	[salario] [int] NULL,
	[genero] [varchar](15) NULL,
	[idtpEmpleado] [int] NULL,
	[idPersona] [int] NULL,
	[estado] [char](12) NULL,
	[fechabaja] [date] NULL,
 CONSTRAINT [PK__T120_EMP__5295297C978D2F8E] PRIMARY KEY CLUSTERED 
(
	[idEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T212_MEDICO]    Script Date: 30/06/2020 10:55:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T212_MEDICO](
	[idMedico] [int] IDENTITY(1,1) NOT NULL,
	[codMedico] [varchar](6) NULL,
	[nroColegio] [int] NULL,
	[nroRne] [varchar](6) NULL,
	[nroRuc] [int] NULL,
	[idtpDocumento] [int] NULL,
	[condicion] [varchar](20) NULL,
	[idEmpleado] [int] NULL,
	[idEspecialidad] [int] NULL,
	[idPersona] [int] NULL,
	[estado] [varchar](12) NULL,
	[fechabaja] [date] NULL,
 CONSTRAINT [PK__T212_MED__4E03DEBAD92F7BA8] PRIMARY KEY CLUSTERED 
(
	[idMedico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[D00_TBDETALLE] ON 
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (1, N'TPD001', N'DNI', N'DNI', N'www.sunat.gob.pe/pdt/pdtModulos/independientes/p695/TipoDoc.htm', 1, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (2, N'TPD002', N'CARNET DE EXTRANJERIA', N'CARNET EXT', N'www.sunat.gob.pe/pdt/pdtModulos/independientes/p695/TipoDoc.htm', 1, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (3, N'TPD003', N'REGISTRO UNICO CONTRIBUYENTES', N'RUC', N'www.sunat.gob.pe/pdt/pdtModulos/independientes/p695/TipoDoc.htm', 1, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (4, N'TPD004', N'PASAPORTE', N'', N'www.sunat.gob.pe/pdt/pdtModulos/independientes/p695/TipoDoc.htm', 1, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (5, N'TPD005', N'PARTIDA NACIMIENTO-IDENTIDAD', N'', N'www.sunat.gob.pe/pdt/pdtModulos/independientes/p695/TipoDoc.htm', 1, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (6, N'TPD006', N'OTROS', N'', N'www.sunat.gob.pe/pdt/pdtModulos/independientes/p695/TipoDoc.htm', 1, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (7, N'SEX0001', N'MASCULINO', N'M', N'', 2, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (8, N'SEX0002', N'FEMENINO', N'F', N'', 2, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (9, N'GRD0001', N'SIN INSTRUCCIÓN', N'SI', N'NTS N° 139 MINSA/2018/DGAIN', 3, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (10, N'GRD0002', N'INICIAL', N'I', N'NTS N° 139 MINSA/2018/DGAIN', 3, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (11, N'GRD0001', N'PRIMARIA COMPLETA', N'PC', N'NTS N° 139 MINSA/2018/DGAIN', 3, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (12, N'GRD0002', N'PRIMARIA INCOMPLETA', N'PI', N'NTS N° 139 MINSA/2018/DGAIN', 3, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (13, N'GRD0001', N'SECUNDARIA COMPLETA', N'SC', N'NTS N° 139 MINSA/2018/DGAIN', 3, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (14, N'GRD0002', N'SECUNDARIA INCOMPLETA', N'SI', N'NTS N° 139 MINSA/2018/DGAIN', 3, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (15, N'GRD0001', N'SUPERIOR COMPLETO	', N'SUC', N'NTS N° 139 MINSA/2018/DGAIN', 3, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (16, N'GRD0001', N'SUPERIOR INCOMPLETO', N'SUI', N'NTS N° 139 MINSA/2018/DGAIN', 3, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (17, N'EDC001', N'SOLTERA/O', N'S', N'NTS N° 139 MINSA/2018/DGAIN', 4, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (18, N'EDC002', N'CONVIVIENTE', N'CO', N'NTS N° 139 MINSA/2018/DGAIN', 4, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (19, N'EDC003', N'CASADA/O', N'C', N'NTS N° 139 MINSA/2018/DGAIN', 4, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (20, N'EDC004', N'SEPARADA/O', N'SP', N'NTS N° 139 MINSA/2018/DGAIN', 4, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (21, N'EDC005', N'DIVORCIADA/O', N'D', N'NTS N° 139 MINSA/2018/DGAIN', 4, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (22, N'EDC006', N'VIUDA/O', N'V', N'NTS N° 139 MINSA/2018/DGAIN', 4, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (23, N'EDC007', N'OTROS', N'O', N'NTS N° 139 MINSA/2018/DGAIN', 4, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (24, N'DHO001', N'TRABAJADOR/A ESTABLE', N'S', N'NTS N° 139 MINSA/2018/DGAIN', 5, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (25, N'DHO002', N'EVENTUAL', N'V', N'NTS N° 139 MINSA/2018/DGAIN', 5, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (26, N'DHO003', N'SIN OCUPACION', N'SO', N'NTS N° 139 MINSA/2018/DGAIN', 5, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (27, N'DHO004', N'JUBILADA/O', N'J', N'NTS N° 139 MINSA/2018/DGAIN', 5, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (28, N'DHO005', N'ESTUDIANTE', N'E', N'NTS N° 139 MINSA/2018/DGAIN', 5, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (29, N'G00001', N'AB POSITIVO', N'AB+', N'', 6, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (30, N'G00002', N'AB NEGATIVO', N'AB-', N'', 6, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (31, N'G00003', N'A POSITIVO', N'A+', N'', 6, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (32, N'G00004', N'A NEGATIVO', N'A-', N'', 6, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (33, N'G00005', N'B POSITIVO', N'B+', N'', 6, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (34, N'G00006', N'B NEGATIVO', N'B-', N'', 6, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (35, N'G00007', N'O POSITIVO', N'O+', N'', 6, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (36, N'G00008', N'O NEGATIVO', N'O-', N'', 6, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (37, N'G00009', N'NO REFIERE', N'', N'', 6, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (38, N'DHC035', N'POSITIVO', N'+', N'NTS N° 139 MINSA/2018/DGAIN', 7, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (39, N'DHC035', N'NEGATIVO', N'-', N'NTS N° 139 MINSA/2018/DGAIN', 7, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (40, N'ANP001', N'PADRE', N'P', N'NTS N° 139 MINSA/2018/DGAIN', 8, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (41, N'ANP002', N'MADRE', N'M', N'NTS N° 139 MINSA/2018/DGAIN', 8, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (42, N'ANP003', N'HIJO/A', N'H', N'NTS N° 139 MINSA/2018/DGAIN', 8, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (43, N'ANP004', N'ABUELA/O', N'A', N'NTS N° 139 MINSA/2018/DGAIN', 8, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (44, N'ANP005', N'TIA/O', N'T', N'NTS N° 139 MINSA/2018/DGAIN', 8, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (45, N'ANP006', N'NIETA/O', N'N', N'NTS N° 139 MINSA/2018/DGAIN', 8, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (46, N'ANP007', N'PADRASTRO', N'PA', N'NTS N° 139 MINSA/2018/DGAIN', 8, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (47, N'ANP008', N'MADRASTRA', N'MA', N'NTS N° 139 MINSA/2018/DGAIN', 8, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (48, N'ANP009', N'SOBRINA/O', N'S', N'NTS N° 139 MINSA/2018/DGAIN', 8, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (49, N'ANP010', N'PRIMA/O', N'PR', N'NTS N° 139 MINSA/2018/DGAIN', 8, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (50, N'ANP011', N'BIS-ABUELA/O', N'BA', N'NTS N° 139 MINSA/2018/DGAIN', 8, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (51, N'ANP012', N'AMIGA/O', N'AMG', N'NTS N° 139 MINSA/2018/DGAIN', 8, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (52, N'ANP013', N'HERMANA/O', N'HM', N'NTS N° 139 MINSA/2018/DGAIN', 8, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (53, N'ANP014', N'YERNO', N'Y', N'NTS N° 139 MINSA/2018/DGAIN', 8, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (54, N'ANP015', N'NUERA', N'NA', N'NTS N° 139 MINSA/2018/DGAIN', 8, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (55, N'TPV001', N'ALAMEDA', N'AL', N'', 9, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (56, N'TPV002', N'AVENIDA', N'AV', N'', 9, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (57, N'TPV003', N'BAJADA', N'BA', N'', 9, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (58, N'TPV004', N'BOULEVARD', N'BO', N'', 9, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (59, N'TPV005', N'CALLE', N'CA', N'', 9, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (60, N'TPV006', N'CALLEJON', N'CLL', N'', 9, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (61, N'TPV07', N'CAMINO', N'CM', N'', 9, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (62, N'TPV008', N'CARRETERA', N'CR', N'', 9, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (63, N'TPV009', N'CUESTA', N'CU', N'', 9, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (64, N'TPV010', N'GALERIA', N'GA', N'', 9, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (65, N'TPV011', N'JIRON', N'JR', N'', 9, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (66, N'TPV012', N'MALECON', N'ML', N'', 9, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (68, N'TPV013', N'OVALO', N'OV', N'', 9, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (69, N'TPV014', N'PASAJE', N'PJE', N'', 9, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (70, N'TPV015', N'PARQUE', N'PQ', N'', 9, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (71, N'TPV016', N'PASEO', N'PAS', N'', 9, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (72, N'TPV017', N'PLAZA', N'PL', N'', 9, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (73, N'TPV018', N'PLAZUELA', N'PZ', N'', 9, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (74, N'TPV019', N'PROLONGACION', N'PRO', N'', 9, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (75, N'TPV020', N'PUENTE', N'PU', N'', 9, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (76, N'TPV021', N'SENDERO', N'SE', N'', 9, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (77, N'DOE01', N'ASIATICO', N'', N'', 10, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (78, N'DOE02', N'NEGRO', N'', N'', 10, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (79, N'DOE03', N'HISPANO', N'', N'', 10, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (80, N'DOE04', N'BLANCO', N'', N'', 10, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (81, N'DOE05', N'OTROS', N'', N'', 10, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (82, N'DHR001', N'JUDAISMO', N'', N'RM N° 329, 2011/MINSA', 11, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (83, N'DHR002', N'ISLAMISMO', N'', N'RM N° 329, 2011/MINSA', 11, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (84, N'DHR003', N'CRISTIANISMO', N'', N'RM N° 329, 2011/MINSA', 11, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (85, N'DHR004', N'HINDUISMO', N'', N'RM N° 329, 2011/MINSA', 11, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (86, N'DHR005', N'BUDISMO', N'', N'RM N° 329, 2011/MINSA', 11, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (87, N'DHR006', N'RELIGION TRADICIONAL CHINA', N'', N'RM N° 329, 2011/MINSA', 11, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (88, N'DHR007', N'ESPIRITISMO', N'', N'RM N° 329, 2011/MINSA', 11, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (89, N'DHR008', N'HELENISMO', N'', N'RM N° 329, 2011/MINSA', 11, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (90, N'DHR009', N'INDIGENAS', N'', N'RM N° 329, 2011/MINSA', 11, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (91, N'DHR010', N'NEOPAGANISMO', N'', N'RM N° 329, 2011/MINSA', 11, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (92, N'DHR011', N'TAOISMO', N'', N'329, 2011/MINSA', 11, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (93, N'DHR012', N'OTROS', N'', N'329, 2011/MINSA', 11, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (94, N'CONS01', N'CONSULTORIO1', N'', N'', 12, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (95, N'CONS02', N'CONSULTORIO2', N'', N'', 12, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (96, N'CONS03', N'CONSULTORIO3', N'', N'', 12, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (97, N'CONS04', N'CONSULTORIO4', N'', N'', 12, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (98, N'CONS05', N'CONSULTORIO5', N'', N'', 12, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (99, N'CONS06', N'CONSULTORIO6', N'', N'', 12, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (100, N'CONS07', N'CONSULTORIO7', N'', N'', 12, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (101, N'CONS08', N'CONSULTORIO8', N'', N'', 12, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (102, N'CONS09', N'CONSULTORIO9', N'', N'', 12, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (103, N'CONS10', N'CONSULTORIO10', N'', N'', 12, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (104, N'CONS11', N'CONSULTORIO11', N'', N'', 12, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (105, N'CONS12', N'CONSULTORIO12', N'', N'', 12, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (106, N'CONS13', N'CONSULTORIO13', N'', N'', 12, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (107, N'CONS14', N'CONSULTORIO14', N'', N'', 12, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (108, N'CONS15', N'CONSULTORIO15', N'', N'', 12, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (109, N'EMP001', N'ADMINISIONISTA', N'', N'', 13, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (110, N'EMP002', N'MEDICA/O', N'', N'', 13, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (111, N'EMP003', N'ENFERMERA/O', N'', N'', 13, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (112, N'EMP004', N'LABORATORISTA', N'', N'', 13, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (113, N'EMP05', N'FARMACEUTICA/O', N'', N'', 13, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (114, N'EMP006', N'TECNICO', N'', N'', 13, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (115, N'EMP007', N'DELIVERY', N'', N'', 13, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (116, N'EMP008', N'ARCHIVERO', N'', N'', 13, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (117, N'EMP009', N'SEGURIDAD', N'', N'', 13, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (118, N'EMP010', N'SERVICIOS', N'', N'', 13, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (119, N'EMP011', N'MED. TEMPORAL', N'', N'', 13, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (120, N'TPAC01', N'PARTICULAR', N'', N'', 14, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (121, N'TPAC02', N'ASEGURADO', N'', N'', 14, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (122, N'TPAC03', N'CONVENIO', N'', N'', 14, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (123, N'TPAC04', N'SOAT', N'', N'', 14, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (124, N'TPAC05', N'EXTERNO', N'', N'', 14, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (125, N'TPAC06', N'EMUSA', N'', N'', 14, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (126, N'E001', N'ALERGIA E INMUNOLOGIA', N'', N'', 15, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (127, N'E002', N'CARDIOLOGIA', N'', N'', 15, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (128, N'E003', N'CIRUGIA ONCOLOGICA DE CABEZA Y CUELLO', N'', N'', 15, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (129, N'E004', N'CIRUGIA DE TORAX Y CARDIOVASCULAR', N'', N'', 15, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (130, N'E005', N'CIRUGIA GENERAL Y LAPAROSCOPICA', N'', N'', 15, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (131, N'E006', N'CIRUGIA GENERAL Y ONCOLOGICA', N'', N'', 15, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (132, N'E007', N'DERMATOLOGIA', N'', N'', 15, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (133, N'E008', N'RADIOLOGIA', N'', N'', 15, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (134, N'E009', N'ENDOCRINOLOGIA', N'', N'', 15, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (135, N'E0010', N'ENFERMERIA', N'', N'', 15, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (136, N'E0011', N'GASTROENTEROLOGIA', N'', N'', 15, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (137, N'E0012', N'GERIATRIA', N'', N'', 15, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (138, N'E0013', N'GINECOLOGIA Y OBSTETRICIA', N'', N'', 15, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (139, N'E0014', N'GINECOLOGIA ONCOLOGICA', N'', N'', 15, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (140, N'E0015', N'HEMATOLOGIA', N'', N'', 15, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (141, N'E0016', N'MASTOLOGIA ', N'', N'', 15, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (142, N'E0017', N'MEDICINA FISICA Y REHABILITACION', N'', N'', 15, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (143, N'E0018', N'MEDICINA GENERAL', N'', N'', 15, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (144, N'E0019', N'MEDICINA INTERNA', N'', N'', 15, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (145, N'E0020', N'NEFROLOGIA', N'', N'', 15, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (146, N'E0021', N'NEUMOLOGIA', N'', N'', 15, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (147, N'E0022', N'NEUROCIRUGIA', N'', N'', 15, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (148, N'E0023', N'NEUROLOGIA', N'', N'', 15, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (149, N'E0024', N'NUTRICION Y DIETETICA', N'', N'', 15, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (150, N'E0025', N'ODONTOLOGIA INTEGRAL', N'', N'', 15, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (151, N'SE001', N'CENTRO QUIRURGICO', N'', N'', 16, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (152, N'SE002', N'CONSULTA AMBULATORIA', N'', N'', 16, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (153, N'SE003', N'DENSITOMETRIA', N'', N'', 16, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (154, N'SE004', N'ECOGRAFIAS', N'', N'', 16, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (155, N'SE005', N'EMERGENCIA', N'', N'', 16, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (156, N'SE006', N'HOSPITALIZACION', N'', N'', 16, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (157, N'SE007', N'LABORATORIO', N'', N'', 16, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (158, N'SE008', N'OD. CIRUGIA DENTAL', N'', N'', 16, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (159, N'SE009', N'COD. INTEGRAL', N'', N'', 16, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (160, N'SE010', N'OD. ORTODONCIA', N'', N'', 16, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (161, N'SE011', N'OD. PROTESIS', N'', N'', 16, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (162, N'SE012', N'ODONTOLOGIA', N'', N'', 16, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (163, N'SE013', N'PEDIATRIA PD', N'', N'', 16, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (164, N'SE014', N'RAYOS X', N'', N'', 16, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (165, N'SE015', N'SALA DE PROCEDIMIENTOS', N'', N'', 16, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (166, N'SE016', N'SANIDAD', N'', N'', 16, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (167, N'SE017', N'TOMOGRAFIA Y RESONANCIAS', N'', N'', 16, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (168, N'SE018', N'TOPICO', N'', N'', 16, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (169, N'CIT001', N'CONSULTA', N'', N'', 17, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (170, N'CIT002', N'EXAMEN', N'', N'', 17, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (171, N'CIT003', N'PROCEDIMIENTO', N'', N'', 17, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (172, N'CRON01', N'ACTIVO', N'', N'', 18, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (173, N'CRON02', N'INACTIVO', N'', N'', 18, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (174, N'CONS16', N'CONSULTORIO16', N'', N'', 12, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (175, N'CONS17', N'CONSULTORIO17', N'', N'', 12, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (176, N'CONS18', N'CONSULTORIO18', N'', N'', 12, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (177, N'CONS19', N'CONSULTORIO19', N'', N'', 12, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (178, N'CONS20', N'CONSULTORIO20', N'', N'', 12, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (179, N'CONS21', N'CONSULTORIO21', N'', N'', 12, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (180, N'CONS22', N'CONSULTORIO22', N'', N'', 12, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (181, N'CONS23', N'CONSULTORIO23', N'', N'', 12, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (182, N'CONS24', N'CONSULTORIO24', N'', N'', 12, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (183, N'CONS25', N'CONSULTORIO25', N'', N'', 12, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (184, N'CONS26', N'CONSULTORIO26', N'', N'', 12, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (185, N'CONS27', N'CONSULTORIO27', N'', N'', 12, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (186, N'CONS28', N'CONSULTORIO28', N'', N'', 12, N'            ', NULL)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [idTab], [estado], [fechabaja]) VALUES (187, N'CONS29', N'CONSULTORIO29', N'', N'', 12, N'            ', NULL)
GO
SET IDENTITY_INSERT [dbo].[D00_TBDETALLE] OFF
GO
SET IDENTITY_INSERT [dbo].[D00_TBGENERAL] ON 
GO
INSERT [dbo].[D00_TBGENERAL] ([idTab], [codTab], [descripcion], [tipo], [fechaCreate], [usuCreate], [estado], [fechabaja]) VALUES (1, N'1', N'Tipo Documento', N'tpdoc01', CAST(N'1900-01-01' AS Date), N'', NULL, NULL)
GO
INSERT [dbo].[D00_TBGENERAL] ([idTab], [codTab], [descripcion], [tipo], [fechaCreate], [usuCreate], [estado], [fechabaja]) VALUES (2, N'2', N'sexo', N'sex001', CAST(N'1900-01-01' AS Date), N'', NULL, NULL)
GO
INSERT [dbo].[D00_TBGENERAL] ([idTab], [codTab], [descripcion], [tipo], [fechaCreate], [usuCreate], [estado], [fechabaja]) VALUES (3, N'3', N'grado instruccion', N'grd001', CAST(N'1900-01-01' AS Date), N'', NULL, NULL)
GO
INSERT [dbo].[D00_TBGENERAL] ([idTab], [codTab], [descripcion], [tipo], [fechaCreate], [usuCreate], [estado], [fechabaja]) VALUES (4, N'4', N'Estado Civil', N'cvl001', CAST(N'1900-01-01' AS Date), N'', NULL, NULL)
GO
INSERT [dbo].[D00_TBGENERAL] ([idTab], [codTab], [descripcion], [tipo], [fechaCreate], [usuCreate], [estado], [fechabaja]) VALUES (5, N'5', N'Ocupacion', N'ocu001', CAST(N'1900-01-01' AS Date), N'', NULL, NULL)
GO
INSERT [dbo].[D00_TBGENERAL] ([idTab], [codTab], [descripcion], [tipo], [fechaCreate], [usuCreate], [estado], [fechabaja]) VALUES (6, N'6', N'Grupo Sangre', N'sang001', CAST(N'1900-01-01' AS Date), N'', NULL, NULL)
GO
INSERT [dbo].[D00_TBGENERAL] ([idTab], [codTab], [descripcion], [tipo], [fechaCreate], [usuCreate], [estado], [fechabaja]) VALUES (7, N'7', N'Factor RH', N'fh001', CAST(N'1900-01-01' AS Date), N'', NULL, NULL)
GO
INSERT [dbo].[D00_TBGENERAL] ([idTab], [codTab], [descripcion], [tipo], [fechaCreate], [usuCreate], [estado], [fechabaja]) VALUES (8, N'8', N'Parentesco', N'par001', CAST(N'1900-01-01' AS Date), N'', NULL, NULL)
GO
INSERT [dbo].[D00_TBGENERAL] ([idTab], [codTab], [descripcion], [tipo], [fechaCreate], [usuCreate], [estado], [fechabaja]) VALUES (9, N'9', N'Tipo Via', N'tpv01', CAST(N'1900-01-01' AS Date), N'', NULL, NULL)
GO
INSERT [dbo].[D00_TBGENERAL] ([idTab], [codTab], [descripcion], [tipo], [fechaCreate], [usuCreate], [estado], [fechabaja]) VALUES (10, N'10', N'Etnico', N'etn01', CAST(N'1900-01-01' AS Date), N'', NULL, NULL)
GO
INSERT [dbo].[D00_TBGENERAL] ([idTab], [codTab], [descripcion], [tipo], [fechaCreate], [usuCreate], [estado], [fechabaja]) VALUES (11, N'11', N'Religion', N'rel01', CAST(N'1900-01-01' AS Date), N'', NULL, NULL)
GO
INSERT [dbo].[D00_TBGENERAL] ([idTab], [codTab], [descripcion], [tipo], [fechaCreate], [usuCreate], [estado], [fechabaja]) VALUES (12, N'12', N'Consultorio', N'consu01', CAST(N'1900-01-01' AS Date), N'', NULL, NULL)
GO
INSERT [dbo].[D00_TBGENERAL] ([idTab], [codTab], [descripcion], [tipo], [fechaCreate], [usuCreate], [estado], [fechabaja]) VALUES (13, N'13', N'Tipo Empleado', N'emp01', CAST(N'1900-01-01' AS Date), N'', NULL, NULL)
GO
INSERT [dbo].[D00_TBGENERAL] ([idTab], [codTab], [descripcion], [tipo], [fechaCreate], [usuCreate], [estado], [fechabaja]) VALUES (14, N'14', N'Tipo Paciente', N'tpac01', CAST(N'1900-01-01' AS Date), N'', NULL, NULL)
GO
INSERT [dbo].[D00_TBGENERAL] ([idTab], [codTab], [descripcion], [tipo], [fechaCreate], [usuCreate], [estado], [fechabaja]) VALUES (15, N'15', N'Especialidad', N'esp01', CAST(N'1900-01-01' AS Date), N'', NULL, NULL)
GO
INSERT [dbo].[D00_TBGENERAL] ([idTab], [codTab], [descripcion], [tipo], [fechaCreate], [usuCreate], [estado], [fechabaja]) VALUES (16, N'16', N'Servicio Clinica', N'srv001', CAST(N'1900-01-01' AS Date), N'', NULL, NULL)
GO
INSERT [dbo].[D00_TBGENERAL] ([idTab], [codTab], [descripcion], [tipo], [fechaCreate], [usuCreate], [estado], [fechabaja]) VALUES (17, N'17', N'Tipo Cita', N'cit01', CAST(N'1900-01-01' AS Date), N'', NULL, NULL)
GO
INSERT [dbo].[D00_TBGENERAL] ([idTab], [codTab], [descripcion], [tipo], [fechaCreate], [usuCreate], [estado], [fechabaja]) VALUES (18, N'18', N'Cronograma stat', N'cron01', CAST(N'1900-01-01' AS Date), N'', NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[D00_TBGENERAL] OFF
GO
SET IDENTITY_INSERT [dbo].[D001_USUARIO] ON 
GO
INSERT [dbo].[D001_USUARIO] ([idUsuario], [loginUser], [claveUser], [idEmpleado], [estado], [usuCrea], [fechaCrea], [usuMod], [fechaMod], [fechabaja]) VALUES (1, N'admin', N'admin', 1, N'1           ', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[D001_USUARIO] ([idUsuario], [loginUser], [claveUser], [idEmpleado], [estado], [usuCrea], [fechaCrea], [usuMod], [fechaMod], [fechabaja]) VALUES (2, N'sa', N'sa', 2, N'1           ', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[D001_USUARIO] ([idUsuario], [loginUser], [claveUser], [idEmpleado], [estado], [usuCrea], [fechaCrea], [usuMod], [fechaMod], [fechabaja]) VALUES (3, N'demo', N'demo', 3, N'1           ', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[D001_USUARIO] ([idUsuario], [loginUser], [claveUser], [idEmpleado], [estado], [usuCrea], [fechaCrea], [usuMod], [fechaMod], [fechabaja]) VALUES (4, N'test', N'test123', 4, N'2           ', NULL, NULL, NULL, NULL, CAST(N'2020-06-27' AS Date))
GO
INSERT [dbo].[D001_USUARIO] ([idUsuario], [loginUser], [claveUser], [idEmpleado], [estado], [usuCrea], [fechaCrea], [usuMod], [fechaMod], [fechabaja]) VALUES (5, N'vlarosa20', N'123456', 1, N'1           ', N'', N'', N'', N'', NULL)
GO
SET IDENTITY_INSERT [dbo].[D001_USUARIO] OFF
GO
SET IDENTITY_INSERT [dbo].[D012_CRONOMEDICO] ON 
GO
INSERT [dbo].[D012_CRONOMEDICO] ([idProgramMedica], [mes], [semana], [dia], [fechaIni], [fechaFin], [idMedico], [idEspecialidad], [idConsultorio], [hrInicio], [hrFin], [estado], [fechabaja]) VALUES (1, N'junio', N'25', N'180', CAST(N'2020-06-20T00:00:00.000' AS DateTime), NULL, 1, 126, 1, N'07:00', N'07:20', N'1           ', NULL)
GO
INSERT [dbo].[D012_CRONOMEDICO] ([idProgramMedica], [mes], [semana], [dia], [fechaIni], [fechaFin], [idMedico], [idEspecialidad], [idConsultorio], [hrInicio], [hrFin], [estado], [fechabaja]) VALUES (2, N'junio', N'25', N'181', CAST(N'2020-06-25T00:00:00.000' AS DateTime), NULL, 2, 127, 2, N'14:20', N'14:40', N'1           ', NULL)
GO
INSERT [dbo].[D012_CRONOMEDICO] ([idProgramMedica], [mes], [semana], [dia], [fechaIni], [fechaFin], [idMedico], [idEspecialidad], [idConsultorio], [hrInicio], [hrFin], [estado], [fechabaja]) VALUES (3, N'mayo', N'20', N'190', CAST(N'2020-06-25T00:00:00.000' AS DateTime), NULL, 3, 128, 3, N'09:00', N'10:00', N'1           ', NULL)
GO
INSERT [dbo].[D012_CRONOMEDICO] ([idProgramMedica], [mes], [semana], [dia], [fechaIni], [fechaFin], [idMedico], [idEspecialidad], [idConsultorio], [hrInicio], [hrFin], [estado], [fechabaja]) VALUES (4, N'julio', N'28', N'195', CAST(N'2020-07-20T00:00:00.000' AS DateTime), NULL, 4, 129, 4, N'13:20', N'13:40', N'1           ', NULL)
GO
SET IDENTITY_INSERT [dbo].[D012_CRONOMEDICO] OFF
GO
SET IDENTITY_INSERT [dbo].[D015_PAGO] ON 
GO
INSERT [dbo].[D015_PAGO] ([idPago], [codTransaccion], [codTransacRetorno], [idFormaPago], [monto], [fecRegistro], [fecOkPasarela], [idCita], [estado], [fechabaja]) VALUES (3, N'1234', N'123460', NULL, CAST(666.00 AS Decimal(16, 2)), NULL, NULL, 3, N'1           ', NULL)
GO
SET IDENTITY_INSERT [dbo].[D015_PAGO] OFF
GO
SET IDENTITY_INSERT [dbo].[T000_PERSONA] ON 
GO
INSERT [dbo].[T000_PERSONA] ([idPersona], [apePaterno], [apeMaterno], [nombres], [idtpDocumento], [dniPersona], [idSexo], [idEtnico], [fecNace], [idUbigeoResi], [idtipoVia], [nombreVia], [nroVia], [nroDpto], [interior], [manzana], [nroLote], [nroKm], [nroBlock], [nroEtapa], [edad], [idUbigeoNace], [fotografia], [idGrdInstruc], [idReligion], [centroEduca], [idEstCivil], [idOcupacion], [idgpoSangre], [idFactorrh], [nroRuc], [razonSocial], [estadoRuc], [condicionRuc], [domiFiscal], [idParentesco], [telefono], [celular], [correo], [tpPersona], [iddatoSiteds], [idemprConvenio], [idciaSeguro], [idtipoIafa], [estado], [fechabaja]) VALUES (1, N'saens', N'galvez', N'xavi', 1, 10887658, 7, 77, N'15-06-2000', NULL, 56, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 26, NULL, NULL, 10, 82, NULL, 17, 24, 29, 38, NULL, NULL, NULL, NULL, NULL, 40, NULL, NULL, N'gabrilg@gmail.com', NULL, NULL, NULL, NULL, NULL, N'1              ', NULL)
GO
INSERT [dbo].[T000_PERSONA] ([idPersona], [apePaterno], [apeMaterno], [nombres], [idtpDocumento], [dniPersona], [idSexo], [idEtnico], [fecNace], [idUbigeoResi], [idtipoVia], [nombreVia], [nroVia], [nroDpto], [interior], [manzana], [nroLote], [nroKm], [nroBlock], [nroEtapa], [edad], [idUbigeoNace], [fotografia], [idGrdInstruc], [idReligion], [centroEduca], [idEstCivil], [idOcupacion], [idgpoSangre], [idFactorrh], [nroRuc], [razonSocial], [estadoRuc], [condicionRuc], [domiFiscal], [idParentesco], [telefono], [celular], [correo], [tpPersona], [iddatoSiteds], [idemprConvenio], [idciaSeguro], [idtipoIafa], [estado], [fechabaja]) VALUES (2, N'Mendoza', N'Mendoza', N'john', 1, 12345678, 7, 78, N'15-06-2001', NULL, 57, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 19, NULL, NULL, 11, 83, NULL, 18, 25, 30, 39, NULL, NULL, NULL, NULL, NULL, 41, NULL, NULL, N'juang@gmail.com', NULL, NULL, NULL, NULL, NULL, N'1              ', NULL)
GO
INSERT [dbo].[T000_PERSONA] ([idPersona], [apePaterno], [apeMaterno], [nombres], [idtpDocumento], [dniPersona], [idSexo], [idEtnico], [fecNace], [idUbigeoResi], [idtipoVia], [nombreVia], [nroVia], [nroDpto], [interior], [manzana], [nroLote], [nroKm], [nroBlock], [nroEtapa], [edad], [idUbigeoNace], [fotografia], [idGrdInstruc], [idReligion], [centroEduca], [idEstCivil], [idOcupacion], [idgpoSangre], [idFactorrh], [nroRuc], [razonSocial], [estadoRuc], [condicionRuc], [domiFiscal], [idParentesco], [telefono], [celular], [correo], [tpPersona], [iddatoSiteds], [idemprConvenio], [idciaSeguro], [idtipoIafa], [estado], [fechabaja]) VALUES (3, N'Ruiz', N'Ruiz', N'sophia', 1, 12345671, 8, 79, N'15-06-1990', NULL, 58, N'Av Exercito', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 30, NULL, NULL, 12, 84, NULL, 19, 26, 31, 38, NULL, NULL, NULL, NULL, N'Av Casas n°404', 42, NULL, NULL, N'ruizsophi@gmail.com', NULL, NULL, NULL, NULL, NULL, N'1              ', NULL)
GO
INSERT [dbo].[T000_PERSONA] ([idPersona], [apePaterno], [apeMaterno], [nombres], [idtpDocumento], [dniPersona], [idSexo], [idEtnico], [fecNace], [idUbigeoResi], [idtipoVia], [nombreVia], [nroVia], [nroDpto], [interior], [manzana], [nroLote], [nroKm], [nroBlock], [nroEtapa], [edad], [idUbigeoNace], [fotografia], [idGrdInstruc], [idReligion], [centroEduca], [idEstCivil], [idOcupacion], [idgpoSangre], [idFactorrh], [nroRuc], [razonSocial], [estadoRuc], [condicionRuc], [domiFiscal], [idParentesco], [telefono], [celular], [correo], [tpPersona], [iddatoSiteds], [idemprConvenio], [idciaSeguro], [idtipoIafa], [estado], [fechabaja]) VALUES (4, N'Hidalgo', N'Hidalgo', N'Lady', 1, 10345600, 8, 80, N'15-06-1995', NULL, 59, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 25, NULL, NULL, 13, 85, NULL, 20, 27, 32, 39, NULL, NULL, NULL, NULL, NULL, 43, NULL, NULL, N'hilay@gmail.com', NULL, NULL, NULL, NULL, NULL, N'1              ', NULL)
GO
INSERT [dbo].[T000_PERSONA] ([idPersona], [apePaterno], [apeMaterno], [nombres], [idtpDocumento], [dniPersona], [idSexo], [idEtnico], [fecNace], [idUbigeoResi], [idtipoVia], [nombreVia], [nroVia], [nroDpto], [interior], [manzana], [nroLote], [nroKm], [nroBlock], [nroEtapa], [edad], [idUbigeoNace], [fotografia], [idGrdInstruc], [idReligion], [centroEduca], [idEstCivil], [idOcupacion], [idgpoSangre], [idFactorrh], [nroRuc], [razonSocial], [estadoRuc], [condicionRuc], [domiFiscal], [idParentesco], [telefono], [celular], [correo], [tpPersona], [iddatoSiteds], [idemprConvenio], [idciaSeguro], [idtipoIafa], [estado], [fechabaja]) VALUES (5, N'franco', N'net', N'julius', 1, 12346789, 7, 81, N'15-06-1990', NULL, 60, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 18, NULL, NULL, 14, 86, NULL, 17, 28, 33, 38, 20201010, N'especial medica', NULL, N'ok', N'av herores 600', 44, NULL, NULL, N'jotace.11.01.03@gmail.com', NULL, NULL, NULL, NULL, NULL, N'1              ', NULL)
GO
INSERT [dbo].[T000_PERSONA] ([idPersona], [apePaterno], [apeMaterno], [nombres], [idtpDocumento], [dniPersona], [idSexo], [idEtnico], [fecNace], [idUbigeoResi], [idtipoVia], [nombreVia], [nroVia], [nroDpto], [interior], [manzana], [nroLote], [nroKm], [nroBlock], [nroEtapa], [edad], [idUbigeoNace], [fotografia], [idGrdInstruc], [idReligion], [centroEduca], [idEstCivil], [idOcupacion], [idgpoSangre], [idFactorrh], [nroRuc], [razonSocial], [estadoRuc], [condicionRuc], [domiFiscal], [idParentesco], [telefono], [celular], [correo], [tpPersona], [iddatoSiteds], [idemprConvenio], [idciaSeguro], [idtipoIafa], [estado], [fechabaja]) VALUES (6, N'franco', N'palacios', N'bertol', 1, 74446454, 7, 77, N'1020204', NULL, 61, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 21, NULL, NULL, 15, 87, NULL, 18, 24, 34, 39, NULL, NULL, NULL, NULL, NULL, 45, NULL, NULL, N'abc@especialmedica.org', NULL, NULL, NULL, NULL, NULL, N'1              ', NULL)
GO
INSERT [dbo].[T000_PERSONA] ([idPersona], [apePaterno], [apeMaterno], [nombres], [idtpDocumento], [dniPersona], [idSexo], [idEtnico], [fecNace], [idUbigeoResi], [idtipoVia], [nombreVia], [nroVia], [nroDpto], [interior], [manzana], [nroLote], [nroKm], [nroBlock], [nroEtapa], [edad], [idUbigeoNace], [fotografia], [idGrdInstruc], [idReligion], [centroEduca], [idEstCivil], [idOcupacion], [idgpoSangre], [idFactorrh], [nroRuc], [razonSocial], [estadoRuc], [condicionRuc], [domiFiscal], [idParentesco], [telefono], [celular], [correo], [tpPersona], [iddatoSiteds], [idemprConvenio], [idciaSeguro], [idtipoIafa], [estado], [fechabaja]) VALUES (7, N'palacios', N'franco', N'erick', 1, 74446100, 7, 78, N'1020202', NULL, 62, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 22, NULL, NULL, 10, 82, NULL, 19, 25, 35, 38, NULL, NULL, NULL, NULL, NULL, 46, NULL, NULL, N'jotace.11.01.03@gmail.com', NULL, NULL, NULL, NULL, NULL, N'1              ', NULL)
GO
INSERT [dbo].[T000_PERSONA] ([idPersona], [apePaterno], [apeMaterno], [nombres], [idtpDocumento], [dniPersona], [idSexo], [idEtnico], [fecNace], [idUbigeoResi], [idtipoVia], [nombreVia], [nroVia], [nroDpto], [interior], [manzana], [nroLote], [nroKm], [nroBlock], [nroEtapa], [edad], [idUbigeoNace], [fotografia], [idGrdInstruc], [idReligion], [centroEduca], [idEstCivil], [idOcupacion], [idgpoSangre], [idFactorrh], [nroRuc], [razonSocial], [estadoRuc], [condicionRuc], [domiFiscal], [idParentesco], [telefono], [celular], [correo], [tpPersona], [iddatoSiteds], [idemprConvenio], [idciaSeguro], [idtipoIafa], [estado], [fechabaja]) VALUES (8, N'tomcat', N'guerra', N'tom', 1, 74446450, 7, 79, N'10301030', NULL, 63, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 23, NULL, NULL, 11, 83, NULL, 20, 26, 29, 39, NULL, NULL, NULL, NULL, NULL, 47, NULL, NULL, N'tomcat@gmail.com', NULL, NULL, NULL, NULL, NULL, N'1              ', NULL)
GO
INSERT [dbo].[T000_PERSONA] ([idPersona], [apePaterno], [apeMaterno], [nombres], [idtpDocumento], [dniPersona], [idSexo], [idEtnico], [fecNace], [idUbigeoResi], [idtipoVia], [nombreVia], [nroVia], [nroDpto], [interior], [manzana], [nroLote], [nroKm], [nroBlock], [nroEtapa], [edad], [idUbigeoNace], [fotografia], [idGrdInstruc], [idReligion], [centroEduca], [idEstCivil], [idOcupacion], [idgpoSangre], [idFactorrh], [nroRuc], [razonSocial], [estadoRuc], [condicionRuc], [domiFiscal], [idParentesco], [telefono], [celular], [correo], [tpPersona], [iddatoSiteds], [idemprConvenio], [idciaSeguro], [idtipoIafa], [estado], [fechabaja]) VALUES (9, N'pierre', N'santos', N'zodiac', 1, 74446451, 8, 80, N'10401040', NULL, 64, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 24, NULL, NULL, 12, 84, NULL, 17, 27, 30, 38, NULL, NULL, NULL, NULL, NULL, 40, NULL, NULL, N'pierresantosg@gmail.com', NULL, NULL, NULL, NULL, NULL, N'1              ', NULL)
GO
INSERT [dbo].[T000_PERSONA] ([idPersona], [apePaterno], [apeMaterno], [nombres], [idtpDocumento], [dniPersona], [idSexo], [idEtnico], [fecNace], [idUbigeoResi], [idtipoVia], [nombreVia], [nroVia], [nroDpto], [interior], [manzana], [nroLote], [nroKm], [nroBlock], [nroEtapa], [edad], [idUbigeoNace], [fotografia], [idGrdInstruc], [idReligion], [centroEduca], [idEstCivil], [idOcupacion], [idgpoSangre], [idFactorrh], [nroRuc], [razonSocial], [estadoRuc], [condicionRuc], [domiFiscal], [idParentesco], [telefono], [celular], [correo], [tpPersona], [iddatoSiteds], [idemprConvenio], [idciaSeguro], [idtipoIafa], [estado], [fechabaja]) VALUES (10, N'Cardenas', N'Malca', N'marcelo', 1, 173945, 7, 81, N'01031997', NULL, 65, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 25, NULL, NULL, 13, 85, NULL, 17, 28, 31, 39, NULL, NULL, NULL, NULL, NULL, 41, NULL, NULL, N'luis_3@gmail.com', NULL, NULL, NULL, NULL, NULL, N'1              ', NULL)
GO
INSERT [dbo].[T000_PERSONA] ([idPersona], [apePaterno], [apeMaterno], [nombres], [idtpDocumento], [dniPersona], [idSexo], [idEtnico], [fecNace], [idUbigeoResi], [idtipoVia], [nombreVia], [nroVia], [nroDpto], [interior], [manzana], [nroLote], [nroKm], [nroBlock], [nroEtapa], [edad], [idUbigeoNace], [fotografia], [idGrdInstruc], [idReligion], [centroEduca], [idEstCivil], [idOcupacion], [idgpoSangre], [idFactorrh], [nroRuc], [razonSocial], [estadoRuc], [condicionRuc], [domiFiscal], [idParentesco], [telefono], [celular], [correo], [tpPersona], [iddatoSiteds], [idemprConvenio], [idciaSeguro], [idtipoIafa], [estado], [fechabaja]) VALUES (11, N'Ramirez', N'Salgado', N'luis', 1, 70452946, 7, 77, N'01031998', NULL, 66, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 20, NULL, NULL, 14, 86, NULL, 17, 24, 32, 38, NULL, NULL, NULL, NULL, NULL, 42, NULL, NULL, N'luis_3@gmail.com', NULL, NULL, NULL, NULL, NULL, N'1              ', NULL)
GO
INSERT [dbo].[T000_PERSONA] ([idPersona], [apePaterno], [apeMaterno], [nombres], [idtpDocumento], [dniPersona], [idSexo], [idEtnico], [fecNace], [idUbigeoResi], [idtipoVia], [nombreVia], [nroVia], [nroDpto], [interior], [manzana], [nroLote], [nroKm], [nroBlock], [nroEtapa], [edad], [idUbigeoNace], [fotografia], [idGrdInstruc], [idReligion], [centroEduca], [idEstCivil], [idOcupacion], [idgpoSangre], [idFactorrh], [nroRuc], [razonSocial], [estadoRuc], [condicionRuc], [domiFiscal], [idParentesco], [telefono], [celular], [correo], [tpPersona], [iddatoSiteds], [idemprConvenio], [idciaSeguro], [idtipoIafa], [estado], [fechabaja]) VALUES (12, N'sanjohn', N'vias', N'antoni', 1, 70701000, 7, 82, N'01031944', NULL, 67, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 22, NULL, NULL, 12, 86, NULL, 17, 24, 33, 39, NULL, NULL, NULL, NULL, NULL, 44, NULL, NULL, N'jotace.11.01.03@gmail.com', NULL, NULL, NULL, NULL, NULL, N'1              ', NULL)
GO
INSERT [dbo].[T000_PERSONA] ([idPersona], [apePaterno], [apeMaterno], [nombres], [idtpDocumento], [dniPersona], [idSexo], [idEtnico], [fecNace], [idUbigeoResi], [idtipoVia], [nombreVia], [nroVia], [nroDpto], [interior], [manzana], [nroLote], [nroKm], [nroBlock], [nroEtapa], [edad], [idUbigeoNace], [fotografia], [idGrdInstruc], [idReligion], [centroEduca], [idEstCivil], [idOcupacion], [idgpoSangre], [idFactorrh], [nroRuc], [razonSocial], [estadoRuc], [condicionRuc], [domiFiscal], [idParentesco], [telefono], [celular], [correo], [tpPersona], [iddatoSiteds], [idemprConvenio], [idciaSeguro], [idtipoIafa], [estado], [fechabaja]) VALUES (13, N'castel', N'casas', N'mesalas', 1, 10103030, 7, 83, N'01031900', NULL, 68, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 24, NULL, NULL, 14, 86, NULL, 17, 24, 31, 38, NULL, NULL, NULL, NULL, NULL, 44, NULL, NULL, N'jotace.11.01.03@gmail.com', NULL, NULL, NULL, NULL, NULL, N'1              ', NULL)
GO
SET IDENTITY_INSERT [dbo].[T000_PERSONA] OFF
GO
SET IDENTITY_INSERT [dbo].[T001_PACIENTE] ON 
GO
INSERT [dbo].[T001_PACIENTE] ([idPaciente], [codPaciente], [descripcion], [nrohc], [nombreAcom], [edadAcom], [dniAcom], [idgpoSangre], [idFactorrh], [cobertura], [ordenAtenMed], [nomAsegurado], [codAsegurado], [poliza], [parentesco], [iniVigencia], [finVigencia], [tpPlanSalud], [nroPlanSalud], [estadoSeguro], [tpAfiliacion], [fecAfiliacion], [codTitular], [moneda], [nomContratante], [tpDocumento], [dniContratante], [planSalud], [codCobertura], [beneficio], [restriccion], [copagoFijo], [copagoVariable], [finCarencia], [convenio], [descuento], [codPaConvenio], [dsPacConv], [statPaconv], [codPacSoat], [dsPacSoat], [statPacSoat], [codpacExterno], [dspacExter], [stapacexter], [tpPaciente], [idPersona], [hojafiliacion], [concienteDato], [estado], [fechabaja]) VALUES (1, N'pa0001', N'pac particular', N'100010', N'ninguno', 18, NULL, 29, 38, NULL, N'no', N'pacifico', N'aseg001', N'poli001', 40, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'soles', NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'120', 12, NULL, NULL, N'1         ', NULL)
GO
INSERT [dbo].[T001_PACIENTE] ([idPaciente], [codPaciente], [descripcion], [nrohc], [nombreAcom], [edadAcom], [dniAcom], [idgpoSangre], [idFactorrh], [cobertura], [ordenAtenMed], [nomAsegurado], [codAsegurado], [poliza], [parentesco], [iniVigencia], [finVigencia], [tpPlanSalud], [nroPlanSalud], [estadoSeguro], [tpAfiliacion], [fecAfiliacion], [codTitular], [moneda], [nomContratante], [tpDocumento], [dniContratante], [planSalud], [codCobertura], [beneficio], [restriccion], [copagoFijo], [copagoVariable], [finCarencia], [convenio], [descuento], [codPaConvenio], [dsPacConv], [statPaconv], [codPacSoat], [dsPacSoat], [statPacSoat], [codpacExterno], [dspacExter], [stapacexter], [tpPaciente], [idPersona], [hojafiliacion], [concienteDato], [estado], [fechabaja]) VALUES (2, N'pa0002', N'pac particular', N'10020', N'ninguno', 20, NULL, 30, 39, NULL, N'no', N'positiva', N'aseg002,', N'poli001', 40, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'soles', NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'121', 13, NULL, NULL, N'1         ', NULL)
GO
SET IDENTITY_INSERT [dbo].[T001_PACIENTE] OFF
GO
SET IDENTITY_INSERT [dbo].[T068_CITA] ON 
GO
INSERT [dbo].[T068_CITA] ([idCita], [codCita], [nroCita], [descripcion], [fechaCita], [ultCie10], [tpAtencion], [nroHC], [ejecutado], [prioridad], [precio], [descuento], [coa], [igv], [estadoReprogram], [tipoCita], [motivoRepro], [motivoAnula], [idEstadoCita], [idPaciente], [idEmpleado], [idConsultorio], [idProgramMedica], [idservicioCli], [estado], [fechabaja]) VALUES (3, 12121, 1200, N'general', CAST(N'2020-06-20T00:00:00.000' AS DateTime), N'12', 0, N'2345', N'12345     ', N'12345     ', CAST(200.00 AS Decimal(16, 2)), CAST(5.00 AS Decimal(16, 2)), CAST(0.00 AS Decimal(16, 2)), CAST(0.00 AS Decimal(16, 2)), N'12345     ', 169, NULL, NULL, 1, 1, 1, 94, 1, 1, N'1           ', NULL)
GO
INSERT [dbo].[T068_CITA] ([idCita], [codCita], [nroCita], [descripcion], [fechaCita], [ultCie10], [tpAtencion], [nroHC], [ejecutado], [prioridad], [precio], [descuento], [coa], [igv], [estadoReprogram], [tipoCita], [motivoRepro], [motivoAnula], [idEstadoCita], [idPaciente], [idEmpleado], [idConsultorio], [idProgramMedica], [idservicioCli], [estado], [fechabaja]) VALUES (4, 12122, 1204, N'extraordinaria', CAST(N'2020-06-21T00:00:00.000' AS DateTime), N'11', 0, N'2345', N'12345     ', N'12345     ', CAST(150.00 AS Decimal(16, 2)), CAST(5.00 AS Decimal(16, 2)), CAST(0.00 AS Decimal(16, 2)), CAST(0.00 AS Decimal(16, 2)), N'12345     ', 170, NULL, NULL, 1, 2, 1, 95, 2, 2, N'1           ', NULL)
GO
SET IDENTITY_INSERT [dbo].[T068_CITA] OFF
GO
SET IDENTITY_INSERT [dbo].[T109_ESTADOCITA] ON 
GO
INSERT [dbo].[T109_ESTADOCITA] ([idEstadoCita], [codEstadoCita], [estado], [origen]) VALUES (1, N'E1', N'RESERVADO', N'se genera cuando el paciente realiza una reserva telefónica de una cita (solo consulta)')
GO
INSERT [dbo].[T109_ESTADOCITA] ([idEstadoCita], [codEstadoCita], [estado], [origen]) VALUES (2, N'E2', N'REPROGRAMADO', N'se genera cuando el paciente reprograma su cita (consulta o procedimiento)')
GO
INSERT [dbo].[T109_ESTADOCITA] ([idEstadoCita], [codEstadoCita], [estado], [origen]) VALUES (3, N'E3', N'ATENDIDO', N'se genera luego de guardar el registro la cita (consulta o procedimiento)')
GO
INSERT [dbo].[T109_ESTADOCITA] ([idEstadoCita], [codEstadoCita], [estado], [origen]) VALUES (4, N'E4', N'EN ESPERA', N'se genera luego de realizado el pago de la cita en admisión (consulta o procedimiento)')
GO
INSERT [dbo].[T109_ESTADOCITA] ([idEstadoCita], [codEstadoCita], [estado], [origen]) VALUES (5, N'E5', N'FINALIZADO', N'se genera al generar  el informe final del procedimiento (neurologia, cardiologia)')
GO
INSERT [dbo].[T109_ESTADOCITA] ([idEstadoCita], [codEstadoCita], [estado], [origen]) VALUES (6, N'E6', N'ANULADO', N'se genera cuando el paciente no asiste a su cita (consulta) y no ha realizado pago)')
GO
INSERT [dbo].[T109_ESTADOCITA] ([idEstadoCita], [codEstadoCita], [estado], [origen]) VALUES (7, N'E7', N'ABANDONADO', N'se genera cuando el paciente no asiste a su cita (consulta) pese a haberla pagado)')
GO
SET IDENTITY_INSERT [dbo].[T109_ESTADOCITA] OFF
GO
SET IDENTITY_INSERT [dbo].[T120_EMPLEADO] ON 
GO
INSERT [dbo].[T120_EMPLEADO] ([idEmpleado], [codEmpleado], [descArea], [cargo], [fecIngreso], [salario], [genero], [idtpEmpleado], [idPersona], [estado], [fechabaja]) VALUES (1, N'10', N'Admision', N'Admisionista', CAST(N'2020-01-02' AS Date), 2500, N'7', 109, 1, N'1           ', NULL)
GO
INSERT [dbo].[T120_EMPLEADO] ([idEmpleado], [codEmpleado], [descArea], [cargo], [fecIngreso], [salario], [genero], [idtpEmpleado], [idPersona], [estado], [fechabaja]) VALUES (2, N'110', N'Medicina', N'Med Gral', CAST(N'2020-06-17' AS Date), 2000, N'7', 110, 2, N'1           ', NULL)
GO
INSERT [dbo].[T120_EMPLEADO] ([idEmpleado], [codEmpleado], [descArea], [cargo], [fecIngreso], [salario], [genero], [idtpEmpleado], [idPersona], [estado], [fechabaja]) VALUES (3, N'110', N'Medicina', N'Med Triaje', CAST(N'2020-06-17' AS Date), 1500, N'8', 111, 3, N'1           ', NULL)
GO
INSERT [dbo].[T120_EMPLEADO] ([idEmpleado], [codEmpleado], [descArea], [cargo], [fecIngreso], [salario], [genero], [idtpEmpleado], [idPersona], [estado], [fechabaja]) VALUES (4, N'110', N'Medicina', N'Med Laboratorio', CAST(N'2020-06-17' AS Date), 1000, N'8', 112, 4, N'1           ', NULL)
GO
INSERT [dbo].[T120_EMPLEADO] ([idEmpleado], [codEmpleado], [descArea], [cargo], [fecIngreso], [salario], [genero], [idtpEmpleado], [idPersona], [estado], [fechabaja]) VALUES (5, N'11', N'Medicina', N'Med Psicologic', CAST(N'2020-06-17' AS Date), 1500, N'7', 109, 5, N'1           ', NULL)
GO
INSERT [dbo].[T120_EMPLEADO] ([idEmpleado], [codEmpleado], [descArea], [cargo], [fecIngreso], [salario], [genero], [idtpEmpleado], [idPersona], [estado], [fechabaja]) VALUES (6, N'110', N'Medicina', N'Med Ambulance', CAST(N'2020-06-17' AS Date), 1500, N'7', 110, 6, N'1           ', NULL)
GO
INSERT [dbo].[T120_EMPLEADO] ([idEmpleado], [codEmpleado], [descArea], [cargo], [fecIngreso], [salario], [genero], [idtpEmpleado], [idPersona], [estado], [fechabaja]) VALUES (7, N'7', N'Medicina', N'Med Auxiliar', CAST(N'2020-06-22' AS Date), 1000, N'7', 111, 7, N'1           ', NULL)
GO
INSERT [dbo].[T120_EMPLEADO] ([idEmpleado], [codEmpleado], [descArea], [cargo], [fecIngreso], [salario], [genero], [idtpEmpleado], [idPersona], [estado], [fechabaja]) VALUES (8, N'8', N'Medicina', N'Med Ambulancia', CAST(N'2020-06-22' AS Date), 1500, N'7', 112, 8, N'2           ', CAST(N'2020-06-27' AS Date))
GO
SET IDENTITY_INSERT [dbo].[T120_EMPLEADO] OFF
GO
SET IDENTITY_INSERT [dbo].[T212_MEDICO] ON 
GO
INSERT [dbo].[T212_MEDICO] ([idMedico], [codMedico], [nroColegio], [nroRne], [nroRuc], [idtpDocumento], [condicion], [idEmpleado], [idEspecialidad], [idPersona], [estado], [fechabaja]) VALUES (1, N'1', 13450, N'12445', 109399391, 1, NULL, 1, 126, 1, N'1', NULL)
GO
INSERT [dbo].[T212_MEDICO] ([idMedico], [codMedico], [nroColegio], [nroRne], [nroRuc], [idtpDocumento], [condicion], [idEmpleado], [idEspecialidad], [idPersona], [estado], [fechabaja]) VALUES (2, N'2', 32342, N'23232', 209399002, 1, NULL, 2, 127, 2, N'1', NULL)
GO
INSERT [dbo].[T212_MEDICO] ([idMedico], [codMedico], [nroColegio], [nroRne], [nroRuc], [idtpDocumento], [condicion], [idEmpleado], [idEspecialidad], [idPersona], [estado], [fechabaja]) VALUES (3, N'3', 32343, N'23453', 109399392, 1, NULL, 3, 128, 3, N'1', NULL)
GO
INSERT [dbo].[T212_MEDICO] ([idMedico], [codMedico], [nroColegio], [nroRne], [nroRuc], [idtpDocumento], [condicion], [idEmpleado], [idEspecialidad], [idPersona], [estado], [fechabaja]) VALUES (4, N'4', 34345, N'23254', 209302393, 1, NULL, 4, 129, 4, N'1', NULL)
GO
INSERT [dbo].[T212_MEDICO] ([idMedico], [codMedico], [nroColegio], [nroRne], [nroRuc], [idtpDocumento], [condicion], [idEmpleado], [idEspecialidad], [idPersona], [estado], [fechabaja]) VALUES (5, N'5', 12345, N'10010', 106789454, 1, NULL, 5, 130, 5, N'1', NULL)
GO
INSERT [dbo].[T212_MEDICO] ([idMedico], [codMedico], [nroColegio], [nroRne], [nroRuc], [idtpDocumento], [condicion], [idEmpleado], [idEspecialidad], [idPersona], [estado], [fechabaja]) VALUES (6, N'6', 13231, N'10011', 203213235, 1, NULL, 6, 131, 6, N'1', NULL)
GO
INSERT [dbo].[T212_MEDICO] ([idMedico], [codMedico], [nroColegio], [nroRne], [nroRuc], [idtpDocumento], [condicion], [idEmpleado], [idEspecialidad], [idPersona], [estado], [fechabaja]) VALUES (7, N'7', 12346, N'10012', 106789456, 1, NULL, 7, 132, 7, N'1', NULL)
GO
INSERT [dbo].[T212_MEDICO] ([idMedico], [codMedico], [nroColegio], [nroRne], [nroRuc], [idtpDocumento], [condicion], [idEmpleado], [idEspecialidad], [idPersona], [estado], [fechabaja]) VALUES (8, N'8', 12312, N'20000', 202312007, 1, NULL, 8, 133, 8, N'1', NULL)
GO
INSERT [dbo].[T212_MEDICO] ([idMedico], [codMedico], [nroColegio], [nroRne], [nroRuc], [idtpDocumento], [condicion], [idEmpleado], [idEspecialidad], [idPersona], [estado], [fechabaja]) VALUES (9, N'9', 56470, N'20005', 107045298, 1, NULL, 1, 134, 9, N'1', NULL)
GO
INSERT [dbo].[T212_MEDICO] ([idMedico], [codMedico], [nroColegio], [nroRne], [nroRuc], [idtpDocumento], [condicion], [idEmpleado], [idEspecialidad], [idPersona], [estado], [fechabaja]) VALUES (10, N'10', 12312, N'20010', 203123120, 1, NULL, 2, 135, 10, N'1', NULL)
GO
SET IDENTITY_INSERT [dbo].[T212_MEDICO] OFF
GO
USE [master]
GO
ALTER DATABASE [Clinica] SET  READ_WRITE 
GO
