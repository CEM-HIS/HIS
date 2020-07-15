Use Clinica
GO

SET IDENTITY_INSERT [dbo].[TABLA_DETALLE] ON 
GO
INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (1, N'TPD001', N'DNI', N'DNI', N'www.sunat.gob.pe/pdt/pdtModulos/independientes/p695/TipoDoc.htm', 1, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (2, N'TPD002', N'CARNET DE EXTRANJERIA', N'CARNET EXT', N'www.sunat.gob.pe/pdt/pdtModulos/independientes/p695/TipoDoc.htm', 1, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (3, N'TPD003', N'REGISTRO UNICO CONTRIBUYENTES', N'RUC', N'www.sunat.gob.pe/pdt/pdtModulos/independientes/p695/TipoDoc.htm', 1, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (4, N'TPD004', N'PASAPORTE', N'', N'www.sunat.gob.pe/pdt/pdtModulos/independientes/p695/TipoDoc.htm', 1, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (5, N'TPD005', N'PARTIDA NACIMIENTO-IDENTIDAD', N'', N'www.sunat.gob.pe/pdt/pdtModulos/independientes/p695/TipoDoc.htm', 1, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (6, N'TPD006', N'OTROS', N'', N'www.sunat.gob.pe/pdt/pdtModulos/independientes/p695/TipoDoc.htm', 1, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (7, N'SEX0001', N'MASCULINO', N'M', N'', 2, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (8, N'SEX0002', N'FEMENINO', N'F', N'', 2, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (9, N'GRD0001', N'SIN INSTRUCCIÓN', N'SI', N'NTS N° 139 MINSA/2018/DGAIN', 3, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (10, N'GRD0002', N'INICIAL', N'I', N'NTS N° 139 MINSA/2018/DGAIN', 3, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (11, N'GRD0001', N'PRIMARIA COMPLETA', N'PC', N'NTS N° 139 MINSA/2018/DGAIN', 3, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (12, N'GRD0002', N'PRIMARIA INCOMPLETA', N'PI', N'NTS N° 139 MINSA/2018/DGAIN', 3, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (13, N'GRD0001', N'SECUNDARIA COMPLETA', N'SC', N'NTS N° 139 MINSA/2018/DGAIN', 3, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (14, N'GRD0002', N'SECUNDARIA INCOMPLETA', N'SI', N'NTS N° 139 MINSA/2018/DGAIN', 3, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (15, N'GRD0001', N'SUPERIOR COMPLETO	', N'SUC', N'NTS N° 139 MINSA/2018/DGAIN', 3, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (16, N'GRD0001', N'SUPERIOR INCOMPLETO', N'SUI', N'NTS N° 139 MINSA/2018/DGAIN', 3, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (17, N'EDC001', N'SOLTERA/O', N'S', N'NTS N° 139 MINSA/2018/DGAIN', 4, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (18, N'EDC002', N'CONVIVIENTE', N'CO', N'NTS N° 139 MINSA/2018/DGAIN', 4, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (19, N'EDC003', N'CASADA/O', N'C', N'NTS N° 139 MINSA/2018/DGAIN', 4, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (20, N'EDC004', N'SEPARADA/O', N'SP', N'NTS N° 139 MINSA/2018/DGAIN', 4, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (21, N'EDC005', N'DIVORCIADA/O', N'D', N'NTS N° 139 MINSA/2018/DGAIN', 4, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (22, N'EDC006', N'VIUDA/O', N'V', N'NTS N° 139 MINSA/2018/DGAIN', 4, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (23, N'EDC007', N'OTROS', N'O', N'NTS N° 139 MINSA/2018/DGAIN', 4, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (24, N'DHO001', N'TRABAJADOR/A ESTABLE', N'S', N'NTS N° 139 MINSA/2018/DGAIN', 5, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (25, N'DHO002', N'EVENTUAL', N'V', N'NTS N° 139 MINSA/2018/DGAIN', 5, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (26, N'DHO003', N'SIN OCUPACION', N'SO', N'NTS N° 139 MINSA/2018/DGAIN', 5, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (27, N'DHO004', N'JUBILADA/O', N'J', N'NTS N° 139 MINSA/2018/DGAIN', 5, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (28, N'DHO005', N'ESTUDIANTE', N'E', N'NTS N° 139 MINSA/2018/DGAIN', 5, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (29, N'G00001', N'AB POSITIVO', N'AB+', N'', 6, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (30, N'G00002', N'AB NEGATIVO', N'AB-', N'', 6, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (31, N'G00003', N'A POSITIVO', N'A+', N'', 6, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (32, N'G00004', N'A NEGATIVO', N'A-', N'', 6, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (33, N'G00005', N'B POSITIVO', N'B+', N'', 6, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (34, N'G00006', N'B NEGATIVO', N'B-', N'', 6, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (35, N'G00007', N'O POSITIVO', N'O+', N'', 6, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (36, N'G00008', N'O NEGATIVO', N'O-', N'', 6, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (37, N'G00009', N'NO REFIERE', N'', N'', 6, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (38, N'DHC035', N'POSITIVO', N'+', N'NTS N° 139 MINSA/2018/DGAIN', 7, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (39, N'DHC035', N'NEGATIVO', N'-', N'NTS N° 139 MINSA/2018/DGAIN', 7, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (40, N'ANP001', N'PADRE', N'P', N'NTS N° 139 MINSA/2018/DGAIN', 8, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (41, N'ANP002', N'MADRE', N'M', N'NTS N° 139 MINSA/2018/DGAIN', 8, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (42, N'ANP003', N'HIJO/A', N'H', N'NTS N° 139 MINSA/2018/DGAIN', 8, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (43, N'ANP004', N'ABUELA/O', N'A', N'NTS N° 139 MINSA/2018/DGAIN', 8, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (44, N'ANP005', N'TIA/O', N'T', N'NTS N° 139 MINSA/2018/DGAIN', 8, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (45, N'ANP006', N'NIETA/O', N'N', N'NTS N° 139 MINSA/2018/DGAIN', 8, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (46, N'ANP007', N'PADRASTRO', N'PA', N'NTS N° 139 MINSA/2018/DGAIN', 8, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (47, N'ANP008', N'MADRASTRA', N'MA', N'NTS N° 139 MINSA/2018/DGAIN', 8, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (48, N'ANP009', N'SOBRINA/O', N'S', N'NTS N° 139 MINSA/2018/DGAIN', 8, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (49, N'ANP010', N'PRIMA/O', N'PR', N'NTS N° 139 MINSA/2018/DGAIN', 8, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (50, N'ANP011', N'BIS-ABUELA/O', N'BA', N'NTS N° 139 MINSA/2018/DGAIN', 8, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (51, N'ANP012', N'AMIGA/O', N'AMG', N'NTS N° 139 MINSA/2018/DGAIN', 8, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (52, N'ANP013', N'HERMANA/O', N'HM', N'NTS N° 139 MINSA/2018/DGAIN', 8, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (53, N'ANP014', N'YERNO', N'Y', N'NTS N° 139 MINSA/2018/DGAIN', 8, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (54, N'ANP015', N'NUERA', N'NA', N'NTS N° 139 MINSA/2018/DGAIN', 8, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (55, N'TPV001', N'ALAMEDA', N'AL', N'', 9, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (56, N'TPV002', N'AVENIDA', N'AV', N'', 9, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (57, N'TPV003', N'BAJADA', N'BA', N'', 9, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (58, N'TPV004', N'BOULEVARD', N'BO', N'', 9, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (59, N'TPV005', N'CALLE', N'CA', N'', 9, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (60, N'TPV006', N'CALLEJON', N'CLL', N'', 9, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (61, N'TPV07', N'CAMINO', N'CM', N'', 9, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (62, N'TPV008', N'CARRETERA', N'CR', N'', 9, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (63, N'TPV009', N'CUESTA', N'CU', N'', 9, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (64, N'TPV010', N'GALERIA', N'GA', N'', 9, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (65, N'TPV011', N'JIRON', N'JR', N'', 9, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (66, N'TPV012', N'MALECON', N'ML', N'', 9, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (68, N'TPV013', N'OVALO', N'OV', N'', 9, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (69, N'TPV014', N'PASAJE', N'PJE', N'', 9, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (70, N'TPV015', N'PARQUE', N'PQ', N'', 9, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (71, N'TPV016', N'PASEO', N'PAS', N'', 9, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (72, N'TPV017', N'PLAZA', N'PL', N'', 9, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (73, N'TPV018', N'PLAZUELA', N'PZ', N'', 9, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (74, N'TPV019', N'PROLONGACION', N'PRO', N'', 9, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (75, N'TPV020', N'PUENTE', N'PU', N'', 9, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (76, N'TPV021', N'SENDERO', N'SE', N'', 9, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (77, N'DOE01', N'ASIATICO', N'', N'', 10, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (78, N'DOE02', N'NEGRO', N'', N'', 10, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (79, N'DOE03', N'HISPANO', N'', N'', 10, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (80, N'DOE04', N'BLANCO', N'', N'', 10, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (81, N'DOE05', N'OTROS', N'', N'', 10, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (82, N'DHR001', N'JUDAISMO', N'', N'RM N° 329, 2011/MINSA', 11, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (83, N'DHR002', N'ISLAMISMO', N'', N'RM N° 329, 2011/MINSA', 11, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (84, N'DHR003', N'CRISTIANISMO', N'', N'RM N° 329, 2011/MINSA', 11, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (85, N'DHR004', N'HINDUISMO', N'', N'RM N° 329, 2011/MINSA', 11, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (86, N'DHR005', N'BUDISMO', N'', N'RM N° 329, 2011/MINSA', 11, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (87, N'DHR006', N'RELIGION TRADICIONAL CHINA', N'', N'RM N° 329, 2011/MINSA', 11, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (88, N'DHR007', N'ESPIRITISMO', N'', N'RM N° 329, 2011/MINSA', 11, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (89, N'DHR008', N'HELENISMO', N'', N'RM N° 329, 2011/MINSA', 11, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (90, N'DHR009', N'INDIGENAS', N'', N'RM N° 329, 2011/MINSA', 11, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (91, N'DHR010', N'NEOPAGANISMO', N'', N'RM N° 329, 2011/MINSA', 11, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (92, N'DHR011', N'TAOISMO', N'', N'329, 2011/MINSA', 11, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (93, N'DHR012', N'OTROS', N'', N'329, 2011/MINSA', 11, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (94, N'CONS01', N'CONSULTORIO1', N'', N'', 12, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (95, N'CONS02', N'CONSULTORIO2', N'', N'', 12, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (96, N'CONS03', N'CONSULTORIO3', N'', N'', 12, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (97, N'CONS04', N'CONSULTORIO4', N'', N'', 12, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (98, N'CONS05', N'CONSULTORIO5', N'', N'', 12, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (99, N'CONS06', N'CONSULTORIO6', N'', N'', 12, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (100, N'CONS07', N'CONSULTORIO7', N'', N'', 12, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (101, N'CONS08', N'CONSULTORIO8', N'', N'', 12, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (102, N'CONS09', N'CONSULTORIO9', N'', N'', 12, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (103, N'CONS10', N'CONSULTORIO10', N'', N'', 12, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (104, N'CONS11', N'CONSULTORIO11', N'', N'', 12, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (105, N'CONS12', N'CONSULTORIO12', N'', N'', 12, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (106, N'CONS13', N'CONSULTORIO13', N'', N'', 12, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (107, N'CONS14', N'CONSULTORIO14', N'', N'', 12, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (108, N'CONS15', N'CONSULTORIO15', N'', N'', 12, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (109, N'EMP001', N'ADMINISIONISTA', N'', N'', 13, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (110, N'EMP002', N'MEDICA/O', N'', N'', 13, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (111, N'EMP003', N'ENFERMERA/O', N'', N'', 13, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (112, N'EMP004', N'LABORATORISTA', N'', N'', 13, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (113, N'EMP05', N'FARMACEUTICA/O', N'', N'', 13, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (114, N'EMP006', N'TECNICO', N'', N'', 13, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (115, N'EMP007', N'DELIVERY', N'', N'', 13, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (116, N'EMP008', N'ARCHIVERO', N'', N'', 13, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (117, N'EMP009', N'SEGURIDAD', N'', N'', 13, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (118, N'EMP010', N'SERVICIOS', N'', N'', 13, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (119, N'EMP011', N'MED. TEMPORAL', N'', N'', 13, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (120, N'TPAC01', N'PARTICULAR', N'', N'', 14, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (121, N'TPAC02', N'ASEGURADO', N'', N'', 14, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (122, N'TPAC03', N'CONVENIO', N'', N'', 14, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (123, N'TPAC04', N'SOAT', N'', N'', 14, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (124, N'TPAC05', N'EXTERNO', N'', N'', 14, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (125, N'TPAC06', N'EMUSA', N'', N'', 14, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (126, N'E001', N'ALERGIA E INMUNOLOGIA', N'', N'', 15, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (127, N'E002', N'CARDIOLOGIA', N'', N'', 15, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (128, N'E003', N'CIRUGIA ONCOLOGICA DE CABEZA Y CUELLO', N'', N'', 15, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (129, N'E004', N'CIRUGIA DE TORAX Y CARDIOVASCULAR', N'', N'', 15, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (130, N'E005', N'CIRUGIA GENERAL Y LAPAROSCOPICA', N'', N'', 15, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (131, N'E006', N'CIRUGIA GENERAL Y ONCOLOGICA', N'', N'', 15, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (132, N'E007', N'DERMATOLOGIA', N'', N'', 15, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (133, N'E008', N'RADIOLOGIA', N'', N'', 15, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (134, N'E009', N'ENDOCRINOLOGIA', N'', N'', 15, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (135, N'E0010', N'ENFERMERIA', N'', N'', 15, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (136, N'E0011', N'GASTROENTEROLOGIA', N'', N'', 15, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (137, N'E0012', N'GERIATRIA', N'', N'', 15, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (138, N'E0013', N'GINECOLOGIA Y OBSTETRICIA', N'', N'', 15, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (139, N'E0014', N'GINECOLOGIA ONCOLOGICA', N'', N'', 15, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (140, N'E0015', N'HEMATOLOGIA', N'', N'', 15, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (141, N'E0016', N'MASTOLOGIA ', N'', N'', 15, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (142, N'E0017', N'MEDICINA FISICA Y REHABILITACION', N'', N'', 15, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (143, N'E0018', N'MEDICINA GENERAL', N'', N'', 15, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (144, N'E0019', N'MEDICINA INTERNA', N'', N'', 15, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (145, N'E0020', N'NEFROLOGIA', N'', N'', 15, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (146, N'E0021', N'NEUMOLOGIA', N'', N'', 15, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (147, N'E0022', N'NEUROCIRUGIA', N'', N'', 15, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (148, N'E0023', N'NEUROLOGIA', N'', N'', 15, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (149, N'E0024', N'NUTRICION Y DIETETICA', N'', N'', 15, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (150, N'E0025', N'ODONTOLOGIA INTEGRAL', N'', N'', 15, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (151, N'SE001', N'CENTRO QUIRURGICO', N'', N'', 16, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (152, N'SE002', N'CONSULTA AMBULATORIA', N'', N'', 16, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (153, N'SE003', N'DENSITOMETRIA', N'', N'', 16, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (154, N'SE004', N'ECOGRAFIAS', N'', N'', 16, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (155, N'SE005', N'EMERGENCIA', N'', N'', 16, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (156, N'SE006', N'HOSPITALIZACION', N'', N'', 16, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (157, N'SE007', N'LABORATORIO', N'', N'', 16, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (158, N'SE008', N'OD. CIRUGIA DENTAL', N'', N'', 16, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (159, N'SE009', N'COD. INTEGRAL', N'', N'', 16, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (160, N'SE010', N'OD. ORTODONCIA', N'', N'', 16, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (161, N'SE011', N'OD. PROTESIS', N'', N'', 16, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (162, N'SE012', N'ODONTOLOGIA', N'', N'', 16, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (163, N'SE013', N'PEDIATRIA PD', N'', N'', 16, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (164, N'SE014', N'RAYOS X', N'', N'', 16, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (165, N'SE015', N'SALA DE PROCEDIMIENTOS', N'', N'', 16, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (166, N'SE016', N'SANIDAD', N'', N'', 16, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (167, N'SE017', N'TOMOGRAFIA Y RESONANCIAS', N'', N'', 16, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (168, N'SE018', N'TOPICO', N'', N'', 16, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (169, N'CIT001', N'CONSULTA', N'', N'', 17, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (170, N'CIT002', N'EXAMEN', N'', N'', 17, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (171, N'CIT003', N'PROCEDIMIENTO', N'', N'', 17, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (172, N'CRON01', N'ACTIVO', N'', N'', 18, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (173, N'CRON02', N'INACTIVO', N'', N'', 18, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (174, N'CONS16', N'CONSULTORIO16', N'', N'', 12, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (175, N'CONS17', N'CONSULTORIO17', N'', N'', 12, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (176, N'CONS18', N'CONSULTORIO18', N'', N'', 12, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (177, N'CONS19', N'CONSULTORIO19', N'', N'', 12, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (178, N'CONS20', N'CONSULTORIO20', N'', N'', 12, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (179, N'CONS21', N'CONSULTORIO21', N'', N'', 12, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (180, N'CONS22', N'CONSULTORIO22', N'', N'', 12, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (181, N'CONS23', N'CONSULTORIO23', N'', N'', 12, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (182, N'CONS24', N'CONSULTORIO24', N'', N'', 12, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (183, N'CONS25', N'CONSULTORIO25', N'', N'', 12, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (184, N'CONS26', N'CONSULTORIO26', N'', N'', 12, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (185, N'CONS27', N'CONSULTORIO27', N'', N'', 12, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (186, N'CONS28', N'CONSULTORIO28', N'', N'', 12, 1, NULL)
GO

INSERT INTO [dbo].[TABLA_DETALLE] ([idTablaDetalle],[codigoTablaDetalle],[descripcion],[abreviatura],[fuente],[idTablaGeneral],[idEstado],[fechaBaja]) 
VALUES (187, N'CONS29', N'CONSULTORIO29', N'', N'', 12, 1, NULL)
GO
SET IDENTITY_INSERT [dbo].[TABLA_DETALLE] OFF
GO
SET IDENTITY_INSERT [dbo].[TABLA_GENERAL] ON 
GO
INSERT INTO [dbo].[TABLA_GENERAL]([idTablaGeneral],[codigoTablaGeneral],[descripcion],[tipo],[fechaCreacion],[usuarioCreacion],[estado],[fechaBaja])  
VALUES (1, N'1', N'Tipo Documento', N'tpdoc01', CAST(N'1900-01-01' AS Date), N'', 1, NULL)
GO

INSERT INTO [dbo].[TABLA_GENERAL]([idTablaGeneral],[codigoTablaGeneral],[descripcion],[tipo],[fechaCreacion],[usuarioCreacion],[estado],[fechaBaja])  
VALUES (2, N'2', N'sexo', N'sex001', CAST(N'1900-01-01' AS Date), N'', 1, NULL)
GO

INSERT INTO [dbo].[TABLA_GENERAL]([idTablaGeneral],[codigoTablaGeneral],[descripcion],[tipo],[fechaCreacion],[usuarioCreacion],[estado],[fechaBaja])  
VALUES (3, N'3', N'grado instruccion', N'grd001', CAST(N'1900-01-01' AS Date), N'', 1, NULL)
GO

INSERT INTO [dbo].[TABLA_GENERAL]([idTablaGeneral],[codigoTablaGeneral],[descripcion],[tipo],[fechaCreacion],[usuarioCreacion],[estado],[fechaBaja])  
VALUES (4, N'4', N'Estado Civil', N'cvl001', CAST(N'1900-01-01' AS Date), N'', 1, NULL)
GO

INSERT INTO [dbo].[TABLA_GENERAL]([idTablaGeneral],[codigoTablaGeneral],[descripcion],[tipo],[fechaCreacion],[usuarioCreacion],[estado],[fechaBaja])  
VALUES (5, N'5', N'Ocupacion', N'ocu001', CAST(N'1900-01-01' AS Date), N'', 1, NULL)
GO

INSERT INTO [dbo].[TABLA_GENERAL]([idTablaGeneral],[codigoTablaGeneral],[descripcion],[tipo],[fechaCreacion],[usuarioCreacion],[estado],[fechaBaja])  
VALUES (6, N'6', N'Grupo Sanguineo', N'sang001', CAST(N'1900-01-01' AS Date), N'', 1, NULL)
GO

INSERT INTO [dbo].[TABLA_GENERAL]([idTablaGeneral],[codigoTablaGeneral],[descripcion],[tipo],[fechaCreacion],[usuarioCreacion],[estado],[fechaBaja])  
VALUES (7, N'7', N'Factor RH', N'fh001', CAST(N'1900-01-01' AS Date), N'', 1, NULL)
GO

INSERT INTO [dbo].[TABLA_GENERAL]([idTablaGeneral],[codigoTablaGeneral],[descripcion],[tipo],[fechaCreacion],[usuarioCreacion],[estado],[fechaBaja])  
VALUES (8, N'8', N'Parentesco', N'par001', CAST(N'1900-01-01' AS Date), N'', 1, NULL)
GO

INSERT INTO [dbo].[TABLA_GENERAL]([idTablaGeneral],[codigoTablaGeneral],[descripcion],[tipo],[fechaCreacion],[usuarioCreacion],[estado],[fechaBaja])  
VALUES (9, N'9', N'Tipo Via', N'tpv01', CAST(N'1900-01-01' AS Date), N'', 1, NULL)
GO

INSERT INTO [dbo].[TABLA_GENERAL]([idTablaGeneral],[codigoTablaGeneral],[descripcion],[tipo],[fechaCreacion],[usuarioCreacion],[estado],[fechaBaja])  
VALUES (10, N'10', N'Etnico', N'etn01', CAST(N'1900-01-01' AS Date), N'', 1, NULL)
GO

INSERT INTO [dbo].[TABLA_GENERAL]([idTablaGeneral],[codigoTablaGeneral],[descripcion],[tipo],[fechaCreacion],[usuarioCreacion],[estado],[fechaBaja])  
VALUES (11, N'11', N'Religion', N'rel01', CAST(N'1900-01-01' AS Date), N'', 1, NULL)
GO

INSERT INTO [dbo].[TABLA_GENERAL]([idTablaGeneral],[codigoTablaGeneral],[descripcion],[tipo],[fechaCreacion],[usuarioCreacion],[estado],[fechaBaja])  
VALUES (12, N'12', N'Consultorio', N'consu01', CAST(N'1900-01-01' AS Date), N'', 1, NULL)
GO

INSERT INTO [dbo].[TABLA_GENERAL]([idTablaGeneral],[codigoTablaGeneral],[descripcion],[tipo],[fechaCreacion],[usuarioCreacion],[estado],[fechaBaja])  
VALUES (13, N'13', N'Tipo Empleado', N'emp01', CAST(N'1900-01-01' AS Date), N'', 1, NULL)
GO

INSERT INTO [dbo].[TABLA_GENERAL]([idTablaGeneral],[codigoTablaGeneral],[descripcion],[tipo],[fechaCreacion],[usuarioCreacion],[estado],[fechaBaja])  
VALUES (14, N'14', N'Tipo Paciente', N'tpac01', CAST(N'1900-01-01' AS Date), N'', 1, NULL)
GO

INSERT INTO [dbo].[TABLA_GENERAL]([idTablaGeneral],[codigoTablaGeneral],[descripcion],[tipo],[fechaCreacion],[usuarioCreacion],[estado],[fechaBaja])  
VALUES (15, N'15', N'Especialidad', N'esp01', CAST(N'1900-01-01' AS Date), N'', 1, NULL)
GO

INSERT INTO [dbo].[TABLA_GENERAL]([idTablaGeneral],[codigoTablaGeneral],[descripcion],[tipo],[fechaCreacion],[usuarioCreacion],[estado],[fechaBaja])  
VALUES (16, N'16', N'Servicio Clinica', N'srv001', CAST(N'1900-01-01' AS Date), N'', 1, NULL)
GO

INSERT INTO [dbo].[TABLA_GENERAL]([idTablaGeneral],[codigoTablaGeneral],[descripcion],[tipo],[fechaCreacion],[usuarioCreacion],[estado],[fechaBaja])  
VALUES (17, N'17', N'Tipo Cita', N'cit01', CAST(N'1900-01-01' AS Date), N'', 1, NULL)
GO

INSERT INTO [dbo].[TABLA_GENERAL]([idTablaGeneral],[codigoTablaGeneral],[descripcion],[tipo],[fechaCreacion],[usuarioCreacion],[estado],[fechaBaja])  
VALUES (18, N'18', N'Cronograma stat', N'cron01', CAST(N'1900-01-01' AS Date), N'', 1, NULL)
GO
SET IDENTITY_INSERT [dbo].[TABLA_GENERAL] OFF
GO

INSERT [dbo].[USER] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], 
[PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [idEmployee], [idState], [creationUser], [creationDate], 
[modifyUser], [modifyDate], [DropDate]) 
VALUES (N'be108687-fdf0-447a-bb92-48520759d24d', N'vlarosa', N'VLAROSA', N'victor_379_1@hotmail.com', N'VICTOR_379_1@HOTMAIL.COM', 1, 
N'AQAAAAEAACcQAAAAEF+opiX10tpf4E08UvzTIo5KCKubnHnBrRE8QorYAUy1g79UOsZ4kMZLQlKEQ5Qplw==', N'BWAZEM325SPCUDIW6NG553TONI7CGIM7', N'fbf6aee8-7215-4d1c-b4d5-0af139c87d18', NULL, 0,
0, NULL, 1, 0, N'USER', 1, NULL, NULL, NULL, NULL, NULL, NULL)
GO

INSERT INTO [dbo].[ROLE] ([Id],[Name],[NormalizedName],[ConcurrencyStamp])
VALUES (N'be108687-fdf0-447a-bb92-48520759d24d',N'total',N'TOTAL',NULL)
GO

INSERT INTO [dbo].[COMPANY] ([name])
VALUES (N'Clinica Especialidades Medicas')
GO

INSERT INTO [dbo].[CAMPUS] ([description],[idCompany])
VALUES (N'Av Aviacion',1)
GO

INSERT INTO [dbo].[PROFILE] ([profileCode],[profileName],[idState])
VALUES (N'Adm',N'Admicionista',1)
GO

INSERT INTO [dbo].[USERROL] ([UserId],[RoleId])
VALUES (N'be108687-fdf0-447a-bb92-48520759d24d',N'be108687-fdf0-447a-bb92-48520759d24d')
GO

INSERT INTO [dbo].[USERPROFILE] ([idUser],[idProfile])
VALUES (N'be108687-fdf0-447a-bb92-48520759d24d',1)
GO

INSERT INTO [dbo].[MODULE] ([name])
VALUES (N'Atencion Ambulatoria')
GO

INSERT INTO [dbo].[MENU] ([menuName],[menuLink])
VALUES (N'Listado de Pacientes',NULL)
GO

SET IDENTITY_INSERT [dbo].[CRONOGRAMA_MEDICO] ON 
GO
INSERT INTO [dbo].[CRONOGRAMA_MEDICO]([idProgramMedica],[mes],[semana],[dia],[fechaInicio],[fechaFin],[idMedico],[idEspecialidad],[idConsultorio],[horaInicio],[horaFin],
[idEstado],[fechaBaja]) 
VALUES (1, N'junio', N'25', N'180', CAST(N'2020-06-20T00:00:00.000' AS DateTime), CAST(N'2020-06-20T10:00:00.000' AS DateTime), 1, 126, 1, N'07:00', N'07:20', 1, NULL)
GO																																																																														
INSERT INTO [dbo].[CRONOGRAMA_MEDICO]([idProgramMedica],[mes],[semana],[dia],[fechaInicio],[fechaFin],[idMedico],[idEspecialidad],[idConsultorio],[horaInicio],[horaFin],
[idEstado],[fechaBaja]) 
VALUES (2, N'junio', N'25', N'181', CAST(N'2020-06-25T00:00:00.000' AS DateTime), CAST(N'2020-06-20T10:00:00.000' AS DateTime), 2, 127, 2, N'14:20', N'14:40', 1, NULL)
GO
INSERT INTO [dbo].[CRONOGRAMA_MEDICO]([idProgramMedica],[mes],[semana],[dia],[fechaInicio],[fechaFin],[idMedico],[idEspecialidad],[idConsultorio],[horaInicio],[horaFin],
[idEstado],[fechaBaja]) 
VALUES (3, N'mayo', N'20', N'190', CAST(N'2020-06-25T00:00:00.000' AS DateTime), CAST(N'2020-06-20T10:00:00.000' AS DateTime), 3, 128, 3, N'09:00', N'10:00', 1, NULL)
GO																																																																													   
INSERT INTO [dbo].[CRONOGRAMA_MEDICO]([idProgramMedica],[mes],[semana],[dia],[fechaInicio],[fechaFin],[idMedico],[idEspecialidad],[idConsultorio],[horaInicio],[horaFin],
[idEstado],[fechaBaja]) 
VALUES (4, N'julio', N'28', N'195', CAST(N'2020-07-20T00:00:00.000' AS DateTime), CAST(N'2020-06-20T10:00:00.000' AS DateTime), 4, 129, 4, N'13:20', N'13:40',1, NULL)
GO
SET IDENTITY_INSERT [dbo].[CRONOGRAMA_MEDICO] OFF
GO
SET IDENTITY_INSERT [dbo].[PAGO] ON 
GO
INSERT INTO [dbo].[PAGO]([idPago],[codigoTransacccionRetorno],[idFormaPago],[monto],[fechaRegistro],[fechaOkPasarela],[idCita],[estado],[fechaBaja])  
VALUES (1, N'1234', N'123460', CAST(666.00 AS Decimal(16, 2)), NULL, NULL, 3, 1, NULL)
GO
SET IDENTITY_INSERT [dbo].[PAGO] OFF
GO
SET IDENTITY_INSERT [dbo].[PERSONA] ON 
GO
INSERT INTO [dbo].[PERSONA]([idPersona],[apellidoPaterno],[apellidoMaterno],[nombres],[idTipoDocumento],[dniPersona],[idSexo],[idEtnico],[fechaNacimiento],[idUbigeoResidencia],
[idtipoVia],[nombreVia],[numeroVia],[numeroDepartamento],[interior],[manzana] ,[numeroLote],[numeroKilometro],[numeroBloque],[numeroEtapa],[edad],[idUbigeoNacimiento],[fotografia],
[idGradoInstruccion],[idReligion],[centroEducativo],[idEstadoCivil],[idOcupacion],[numeroRuc],[razonSocial],[estadoRuc],[condicionRuc],[domicioFiscal],[idParentesco],[telefono],
[celular],[correo],[idDatoSiteds],[idEmpresaConvenio],[idCompañiaSeguro],[idTipoIafa],[idEstado],[fechaBaja])
VALUES (1, N'saens', N'galvez', N'xavi', 1, 10887658, 7, 77, N'15-06-2000', NULL, 56, NULL, NULL, NULL, NULL, NULL,
NULL, NULL, NULL, NULL, 26, NULL, NULL, 10, 82, NULL, 17, 24, NULL, NULL, NULL, NULL, 
NULL, 40, NULL, NULL, N'gabrilg@gmail.com', NULL, NULL, NULL, NULL,1, NULL)
GO
INSERT INTO [dbo].[PERSONA]([idPersona],[apellidoPaterno],[apellidoMaterno],[nombres],[idTipoDocumento],[dniPersona],[idSexo],[idEtnico],[fechaNacimiento],[idUbigeoResidencia],
[idtipoVia],[nombreVia],[numeroVia],[numeroDepartamento],[interior],[manzana] ,[numeroLote],[numeroKilometro],[numeroBloque],[numeroEtapa],[edad],[idUbigeoNacimiento],[fotografia],
[idGradoInstruccion],[idReligion],[centroEducativo],[idEstadoCivil],[idOcupacion],[numeroRuc],[razonSocial],[estadoRuc],[condicionRuc],[domicioFiscal],[idParentesco],[telefono],
[celular],[correo],[idDatoSiteds],[idEmpresaConvenio],[idCompañiaSeguro],[idTipoIafa],[idEstado],[fechaBaja])
VALUES (2, N'Mendoza', N'Mendoza', N'john', 1, 12345678, 7, 78, N'15-06-2001', NULL, 57, NULL, NULL, NULL, NULL, NULL, 
NULL, NULL, NULL, NULL, 19, NULL, NULL, 11, 83, NULL, 18, 25, NULL, NULL, NULL, NULL, 
NULL, 41, NULL, NULL, N'juang@gmail.com', NULL, NULL, NULL, NULL, 1, NULL)
GO
INSERT INTO [dbo].[PERSONA]([idPersona],[apellidoPaterno],[apellidoMaterno],[nombres],[idTipoDocumento],[dniPersona],[idSexo],[idEtnico],[fechaNacimiento],[idUbigeoResidencia],
[idtipoVia],[nombreVia],[numeroVia],[numeroDepartamento],[interior],[manzana] ,[numeroLote],[numeroKilometro],[numeroBloque],[numeroEtapa],[edad],[idUbigeoNacimiento],[fotografia],
[idGradoInstruccion],[idReligion],[centroEducativo],[idEstadoCivil],[idOcupacion],[numeroRuc],[razonSocial],[estadoRuc],[condicionRuc],[domicioFiscal],[idParentesco],[telefono],
[celular],[correo],[idDatoSiteds],[idEmpresaConvenio],[idCompañiaSeguro],[idTipoIafa],[idEstado],[fechaBaja])
VALUES (3, N'Ruiz', N'Ruiz', N'sophia', 1, 12345671, 8, 79, N'15-06-1990', NULL, 58, N'Av Exercito', NULL, NULL, NULL, NULL, 
NULL, NULL, NULL, NULL, 30, NULL, NULL, 12, 84, NULL, 19, 26, NULL, NULL, NULL, NULL, 
N'Av Casas n°404', 42, NULL, NULL, N'ruizsophi@gmail.com', NULL, NULL, NULL, NULL, 1, NULL)
GO
SET IDENTITY_INSERT [dbo].[PERSONA] OFF
GO
SET IDENTITY_INSERT [dbo].[PACIENTE] ON 
GO
INSERT INTO [dbo].[PACIENTE]([idPaciente],[codigoPaciente],[descripcion],[numeroHc],[nombreAcompañante],[edadAcompañante],[dniAcompañante],[idGrupoSanguineo],[idFactorRh],[cobertura],
[ordenAtenMedica],[nombreAsegurado],[codigoAsegurado],[poliza] ,[idParentesco],[inicioVigencia],[finVigencia],[idTipoPlanSalud],[numeroPlanSalud],[idEstadoSeguro],[idTipoAfiliacion],
[fechaAfiliacion],[codigoTitular],[moneda],[nombreContratante],[idTipoDocumento],[dniContratante],[planSalud],[codigoCobertura],[beneficio],[restriccion],[copagoFijo],[copagoVariable],
[finCarencia],[convenio],[descuento],[codigoPacienteConvenio],[descripcionPacienteConvenio],[estadoPacienteConvenio],[codigoPacienteSoat] ,[descripcionPacienteSoat],
[estadoPacienteSoat],[codigoPacienteExterno],[descripcionPacienteExterno],[estadoPacienteExterno],[idTipoPaciente],[idPersona],[hojafiliacion],[concienteDato],[idEstado],[fechaBaja])
VALUES (1, N'pa0001', N'pac particular', N'100010', N'ninguno', 18, NULL, 29, 38, NULL, N'no', N'pacifico', N'aseg001', N'poli001', 40, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 
N'soles', NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'120', 12, NULL, NULL, N'1         ', NULL)
GO
INSERT INTO [dbo].[PACIENTE]([idPaciente],[codigoPaciente],[descripcion],[numeroHc],[nombreAcompañante],[edadAcompañante],[dniAcompañante],[idGrupoSanguineo],[idFactorRh],[cobertura],
[ordenAtenMedica],[nombreAsegurado],[codigoAsegurado],[poliza] ,[idParentesco],[inicioVigencia],[finVigencia],[idTipoPlanSalud],[numeroPlanSalud],[idEstadoSeguro],[idTipoAfiliacion],
[fechaAfiliacion],[codigoTitular],[moneda],[nombreContratante],[idTipoDocumento],[dniContratante],[planSalud],[codigoCobertura],[beneficio],[restriccion],[copagoFijo],[copagoVariable],
[finCarencia],[convenio],[descuento],[codigoPacienteConvenio],[descripcionPacienteConvenio],[estadoPacienteConvenio],[codigoPacienteSoat] ,[descripcionPacienteSoat],
[estadoPacienteSoat],[codigoPacienteExterno],[descripcionPacienteExterno],[estadoPacienteExterno],[idTipoPaciente],[idPersona],[hojafiliacion],[concienteDato],[idEstado],[fechaBaja])
VALUES (2, N'pa0002', N'pac particular', N'10020', N'ninguno', 20, NULL, 30, 39, NULL, N'no', N'positiva', N'aseg002,', N'poli001', 40, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 
N'soles', NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'121', 13, NULL, NULL, N'1         ', NULL)
GO
SET IDENTITY_INSERT [dbo].[PACIENTE] OFF
GO
SET IDENTITY_INSERT [dbo].[CITA] ON 
GO
INSERT INTO [dbo].[CITA]([idCita],[codigoCita],[numeroCita],[descripcion],[fechaCita],[ultCie10],[idTipoAtencion],[numeroHC],[ejecutado],[prioridad],[precio],[descuento],[coa],[igv],
[estadoReprogramacion],[idtipoCita],[motivoReprogramacion],[motivoAnulacion],[idEstadoCita],[idPaciente] ,[idEmpleado],[idConsultorio],[idProgramacionMedica],[idServicioClinica],
[fechaBaja])
VALUES (3, 12121, 1200, N'general', CAST(N'2020-06-20T00:00:00.000' AS DateTime), N'12', 0, N'2345', N'12345     ', N'12345     ', CAST(200.00 AS Decimal(16, 2)), 
CAST(5.00 AS Decimal(16, 2)), CAST(0.00 AS Decimal(16, 2)), CAST(0.00 AS Decimal(16, 2)), 
N'12345     ', 169, NULL, NULL, 1, 1, 1, 94, 1, 1, NULL)
GO
INSERT INTO [dbo].[CITA]([idCita],[codigoCita],[numeroCita],[descripcion],[fechaCita],[ultCie10],[idTipoAtencion],[numeroHC],[ejecutado],[prioridad],[precio],[descuento],[coa],[igv],
[estadoReprogramacion],[idtipoCita],[motivoReprogramacion],[motivoAnulacion],[idEstadoCita],[idPaciente] ,[idEmpleado],[idConsultorio],[idProgramacionMedica],[idServicioClinica],
[fechaBaja]) 
VALUES (4, 12122, 1204, N'extraordinaria', CAST(N'2020-06-21T00:00:00.000' AS DateTime), N'11', 0, N'2345', N'12345     ', N'12345     ', CAST(150.00 AS Decimal(16, 2)), 
CAST(5.00 AS Decimal(16, 2)), CAST(0.00 AS Decimal(16, 2)), CAST(0.00 AS Decimal(16, 2)), 
N'12345     ', 170, NULL, NULL, 1, 2, 1, 95, 2, 2, NULL)
GO
SET IDENTITY_INSERT [dbo].[CITA] OFF
GO
SET IDENTITY_INSERT [dbo].[ESTADO_CITA] ON 
GO
INSERT INTO [dbo].[ESTADO_CITA]([idEstadoCita],[codigoEstadoCita],[estado],[origen])
VALUES (1, N'E1', N'RESERVADO', N'se genera cuando el paciente realiza una reserva telefónica de una cita (solo consulta)')
GO

INSERT INTO [dbo].[ESTADO_CITA]([idEstadoCita],[codigoEstadoCita],[estado],[origen])
VALUES (2, N'E2', N'REPROGRAMADO', N'se genera cuando el paciente reprograma su cita (consulta o procedimiento)')
GO

INSERT INTO [dbo].[ESTADO_CITA]([idEstadoCita],[codigoEstadoCita],[estado],[origen]) 
VALUES (3, N'E3', N'ATENDIDO', N'se genera luego de guardar el registro la cita (consulta o procedimiento)')
GO

INSERT INTO [dbo].[ESTADO_CITA]([idEstadoCita],[codigoEstadoCita],[estado],[origen])
VALUES (4, N'E4', N'EN ESPERA', N'se genera luego de realizado el pago de la cita en admisión (consulta o procedimiento)')
GO

INSERT INTO [dbo].[ESTADO_CITA]([idEstadoCita],[codigoEstadoCita],[estado],[origen]) 
VALUES (5, N'E5', N'FINALIZADO', N'se genera al generar  el informe final del procedimiento (neurologia, cardiologia)')
GO

INSERT INTO [dbo].[ESTADO_CITA]([idEstadoCita],[codigoEstadoCita],[estado],[origen]) 
VALUES (6, N'E6', N'ANULADO', N'se genera cuando el paciente no asiste a su cita (consulta) y no ha realizado pago)')
GO

INSERT INTO [dbo].[ESTADO_CITA]([idEstadoCita],[codigoEstadoCita],[estado],[origen]) 
VALUES (7, N'E7', N'ABANDONADO', N'se genera cuando el paciente no asiste a su cita (consulta) pese a haberla pagado)')
GO
SET IDENTITY_INSERT [dbo].[ESTADO_CITA] OFF
GO
SET IDENTITY_INSERT [dbo].[EMPLEADO] ON 
GO
INSERT INTO [dbo].[EMPLEADO]([idEmpleado],[codigoEmpleado],[descripcionArea],[cargo],[fechaIngreso],[salario],[idGenero],[idTipoEmpleado],[idPersona],[idEstado],[fechaBaja])
VALUES (1, N'10', N'Admision', N'Admisionista', CAST(N'2020-01-02' AS Date), 2500, N'7', 109, 1, 1, NULL)
GO					

INSERT INTO [dbo].[EMPLEADO]([idEmpleado],[codigoEmpleado],[descripcionArea],[cargo],[fechaIngreso],[salario],[idGenero],[idTipoEmpleado],[idPersona],[idEstado],[fechaBaja])
VALUES (2, N'110', N'Medicina', N'Med Gral', CAST(N'2020-06-17' AS Date), 2000, N'7', 110, 2, 1, NULL)
GO					

INSERT INTO [dbo].[EMPLEADO]([idEmpleado],[codigoEmpleado],[descripcionArea],[cargo],[fechaIngreso],[salario],[idGenero],[idTipoEmpleado],[idPersona],[idEstado],[fechaBaja])
VALUES (3, N'110', N'Medicina', N'Med Triaje', CAST(N'2020-06-17' AS Date), 1500, N'8', 111, 3, 1, NULL)
GO					

INSERT INTO [dbo].[EMPLEADO]([idEmpleado],[codigoEmpleado],[descripcionArea],[cargo],[fechaIngreso],[salario],[idGenero],[idTipoEmpleado],[idPersona],[idEstado],[fechaBaja])
VALUES (4, N'110', N'Medicina', N'Med Laboratorio', CAST(N'2020-06-17' AS Date), 1000, N'8', 112, 4, 1, NULL)
GO					

INSERT INTO [dbo].[EMPLEADO]([idEmpleado],[codigoEmpleado],[descripcionArea],[cargo],[fechaIngreso],[salario],[idGenero],[idTipoEmpleado],[idPersona],[idEstado],[fechaBaja])
VALUES (5, N'11', N'Medicina', N'Med Psicologic', CAST(N'2020-06-17' AS Date), 1500, N'7', 109, 5, 1, NULL)
GO					

INSERT INTO [dbo].[EMPLEADO]([idEmpleado],[codigoEmpleado],[descripcionArea],[cargo],[fechaIngreso],[salario],[idGenero],[idTipoEmpleado],[idPersona],[idEstado],[fechaBaja])
VALUES (6, N'110', N'Medicina', N'Med Ambulance', CAST(N'2020-06-17' AS Date), 1500, N'7', 110, 6, 1, NULL)
GO					

INSERT INTO [dbo].[EMPLEADO]([idEmpleado],[codigoEmpleado],[descripcionArea],[cargo],[fechaIngreso],[salario],[idGenero],[idTipoEmpleado],[idPersona],[idEstado],[fechaBaja]) 
VALUES (7, N'7', N'Medicina', N'Med Auxiliar', CAST(N'2020-06-22' AS Date), 1000, N'7', 111, 7, 1, NULL)
GO					

INSERT INTO [dbo].[EMPLEADO]([idEmpleado],[codigoEmpleado],[descripcionArea],[cargo],[fechaIngreso],[salario],[idGenero],[idTipoEmpleado],[idPersona],[idEstado],[fechaBaja]) 
VALUES (8, N'8', N'Medicina', N'Med Ambulancia', CAST(N'2020-06-22' AS Date), 1500, N'7', 112, 8, 1, CAST(N'2020-06-27' AS Date))
GO
SET IDENTITY_INSERT [dbo].[EMPLEADO] OFF
GO
SET IDENTITY_INSERT [dbo].[MEDICO] ON 
GO
INSERT INTO [dbo].[MEDICO]([idMedico],[codigoMedico],[numeroColegio] ,[numeroRne],[numeroRuc],[idTipoDocumento],[condicion],[idEmpleado],[idEspecialidad],[idPersona],
[idEstado],[fechaBaja])
VALUES (1, N'1', 13450, N'12445', 109399391, 1, NULL, 1, 126, 1, 1, NULL)
GO

INSERT INTO [dbo].[MEDICO]([idMedico],[codigoMedico],[numeroColegio] ,[numeroRne],[numeroRuc],[idTipoDocumento],[condicion],[idEmpleado],[idEspecialidad],[idPersona],
[idEstado],[fechaBaja])
VALUES (2, N'2', 32342, N'23232', 209399002, 1, NULL, 2, 127, 2, 1, NULL)
GO

INSERT INTO [dbo].[MEDICO]([idMedico],[codigoMedico],[numeroColegio] ,[numeroRne],[numeroRuc],[idTipoDocumento],[condicion],[idEmpleado],[idEspecialidad],[idPersona],
[idEstado],[fechaBaja])
VALUES (3, N'3', 32343, N'23453', 109399392, 1, NULL, 3, 128, 3, 1, NULL)
GO

INSERT INTO [dbo].[MEDICO]([idMedico],[codigoMedico],[numeroColegio] ,[numeroRne],[numeroRuc],[idTipoDocumento],[condicion],[idEmpleado],[idEspecialidad],[idPersona],
[idEstado],[fechaBaja]) 
VALUES (4, N'4', 34345, N'23254', 209302393, 1, NULL, 4, 129, 4, 1, NULL)
GO

INSERT INTO [dbo].[MEDICO]([idMedico],[codigoMedico],[numeroColegio] ,[numeroRne],[numeroRuc],[idTipoDocumento],[condicion],[idEmpleado],[idEspecialidad],[idPersona],
[idEstado],[fechaBaja])
VALUES (5, N'5', 12345, N'10010', 106789454, 1, NULL, 5, 130, 5, 1, NULL)
GO

INSERT INTO [dbo].[MEDICO]([idMedico],[codigoMedico],[numeroColegio] ,[numeroRne],[numeroRuc],[idTipoDocumento],[condicion],[idEmpleado],[idEspecialidad],[idPersona],
[idEstado],[fechaBaja]) 
VALUES (6, N'6', 13231, N'10011', 203213235, 1, NULL, 6, 131, 6, 1, NULL)
GO

INSERT INTO [dbo].[MEDICO]([idMedico],[codigoMedico],[numeroColegio] ,[numeroRne],[numeroRuc],[idTipoDocumento],[condicion],[idEmpleado],[idEspecialidad],[idPersona],
[idEstado],[fechaBaja]) 
VALUES (7, N'7', 12346, N'10012', 106789456, 1, NULL, 7, 132, 7, 1, NULL)
GO

INSERT INTO [dbo].[MEDICO]([idMedico],[codigoMedico],[numeroColegio] ,[numeroRne],[numeroRuc],[idTipoDocumento],[condicion],[idEmpleado],[idEspecialidad],[idPersona],
[idEstado],[fechaBaja]) 
VALUES (8, N'8', 12312, N'20000', 202312007, 1, NULL, 8, 133, 8, 1, NULL)
GO

INSERT INTO [dbo].[MEDICO]([idMedico],[codigoMedico],[numeroColegio] ,[numeroRne],[numeroRuc],[idTipoDocumento],[condicion],[idEmpleado],[idEspecialidad],[idPersona],
[idEstado],[fechaBaja]) 
VALUES (9, N'9', 56470, N'20005', 107045298, 1, NULL, 1, 134, 9, 1, NULL)
GO

INSERT INTO [dbo].[MEDICO]([idMedico],[codigoMedico],[numeroColegio] ,[numeroRne],[numeroRuc],[idTipoDocumento],[condicion],[idEmpleado],[idEspecialidad],[idPersona],
[idEstado],[fechaBaja]) 
VALUES (10, N'10', 12312, N'20010', 203123120, 1, NULL, 2, 135, 10, 1, NULL)
GO
SET IDENTITY_INSERT [dbo].[MEDICO] OFF
GO
USE [master]
GO
ALTER DATABASE [Clinica] SET  READ_WRITE 
GO
