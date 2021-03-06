USE [master]
GO
/****** Object:  Database [CntNetCore]    Script Date: 12/12/2021 5:57:19 p. m. ******/
CREATE DATABASE [CntNetCore] ON  PRIMARY 
( NAME = N'CntNetCore', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\CntNetCore.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CntNetCore_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\CntNetCore_log.LDF' , SIZE = 576KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CntNetCore] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CntNetCore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CntNetCore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CntNetCore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CntNetCore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CntNetCore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CntNetCore] SET ARITHABORT OFF 
GO
ALTER DATABASE [CntNetCore] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CntNetCore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CntNetCore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CntNetCore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CntNetCore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CntNetCore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CntNetCore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CntNetCore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CntNetCore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CntNetCore] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CntNetCore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CntNetCore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CntNetCore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CntNetCore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CntNetCore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CntNetCore] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [CntNetCore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CntNetCore] SET RECOVERY FULL 
GO
ALTER DATABASE [CntNetCore] SET  MULTI_USER 
GO
ALTER DATABASE [CntNetCore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CntNetCore] SET DB_CHAINING OFF 
GO
EXEC sys.sp_db_vardecimal_storage_format N'CntNetCore', N'ON'
GO
USE [CntNetCore]
GO
/****** Object:  Table [dbo].[Pacientes]    Script Date: 12/12/2021 5:57:19 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pacientes](
	[Documento] [nvarchar](19) NOT NULL,
	[Nombres] [nvarchar](50) NOT NULL,
	[Apellidos] [nvarchar](50) NOT NULL,
	[Edad] [int] NOT NULL,
	[Direccion] [nvarchar](50) NULL,
	[Sexo] [nvarchar](1) NULL,
	[Peso] [int] NOT NULL,
	[Estatura] [int] NOT NULL,
	[Fumador] [nvarchar](2) NULL,
	[Añosfumador] [int] NOT NULL,
	[Dieta] [nvarchar](2) NULL,
	[PesoEstatura] [int] NOT NULL,
	[Estado] [nvarchar](10) NULL,
	[Riesgo] [float] NOT NULL,
	[Prioridad] [float] NOT NULL,
 CONSTRAINT [PK_Pacientes] PRIMARY KEY CLUSTERED 
(
	[Documento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Pacientes] ([Documento], [Nombres], [Apellidos], [Edad], [Direccion], [Sexo], [Peso], [Estatura], [Fumador], [Añosfumador], [Dieta], [PesoEstatura], [Estado], [Riesgo], [Prioridad]) VALUES (N'1074557920', N'Fredy', N'Real', 27, N'Ubate', N'M', 63, 165, N'NO', 0, N'NO', 1, N'Pendiente', 0.54, 2)
INSERT [dbo].[Pacientes] ([Documento], [Nombres], [Apellidos], [Edad], [Direccion], [Sexo], [Peso], [Estatura], [Fumador], [Añosfumador], [Dieta], [PesoEstatura], [Estado], [Riesgo], [Prioridad]) VALUES (N'1076665236', N'Maria', N'Arevalo', 10, N'Ubate', N'F', 38, 110, N'NO', 0, N'NO', 1, N'Pendiente', 0.3, 3)
INSERT [dbo].[Pacientes] ([Documento], [Nombres], [Apellidos], [Edad], [Direccion], [Sexo], [Peso], [Estatura], [Fumador], [Añosfumador], [Dieta], [PesoEstatura], [Estado], [Riesgo], [Prioridad]) VALUES (N'39752210', N'Pedro', N'Cañon', 35, N'Susa', N'M', 81, 162, N'SI', 3, N'NO', 1, N'Pendiente', 0.9625, 2.75)
INSERT [dbo].[Pacientes] ([Documento], [Nombres], [Apellidos], [Edad], [Direccion], [Sexo], [Peso], [Estatura], [Fumador], [Añosfumador], [Dieta], [PesoEstatura], [Estado], [Riesgo], [Prioridad]) VALUES (N'79134423', N'Juan', N'Rodriguez', 61, N'Susa', N'M', 65, 160, N'NO', 0, N'SI', 1, N'Pendiente', 9.6005, 7.05)
GO
/****** Object:  StoredProcedure [dbo].[editar_Pacientes]    Script Date: 12/12/2021 5:57:19 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[editar_Pacientes]
@Documento As nvarchar(19),
@Nombres As nvarchar(50),
@Apellidos As nvarchar(50),
@Edad As int,
@Direccion As nvarchar(50),
@Sexo As nvarchar(1),
@Peso As int,
@Estatura As int,
@Fumador As nvarchar(2),
@Añosfumador As int,
@Dieta As nvarchar(2),
@PesoEstatura As int,
@Estado As nvarchar(10),
@Riesgo As float,
@Prioridad As float
As
UPDATE Pacientes Set

Nombres=@Nombres,
Apellidos=@Apellidos,
Edad=@Edad,
Direccion=@Direccion,
Sexo=@Sexo,
Peso=@Peso,
Estatura=@Estatura,
Fumador=@Fumador,
Añosfumador=@Añosfumador,
Dieta=@Dieta,
PesoEstatura=@PesoEstatura,
Estado=@Estado,
Riesgo=@Riesgo,
Prioridad=@Prioridad
Where Documento=@Documento
GO
/****** Object:  StoredProcedure [dbo].[insertar_Pacientes]    Script Date: 12/12/2021 5:57:19 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insertar_Pacientes]
@Documento as nvarchar(19),
@Nombres As nvarchar(50),
@Apellidos As nvarchar(50),
@Edad As int,
@Direccion As nvarchar(50),
@Sexo As nvarchar(1),
@Peso As int,
@Estatura As int,
@Fumador As nvarchar(2),
@Añosfumador As int,
@Dieta As nvarchar(2),
@PesoEstatura As int,
@Estado As nvarchar(10),
@Riesgo As float,
@Prioridad As float
As
INSERT INTO Pacientes
Values (
@Documento,
@Nombres,
@Apellidos,
@Edad,
@Direccion,
@Sexo,
@Peso,
@Estatura,
@Fumador,
@Añosfumador,
@Dieta,
@PesoEstatura,
@Estado,
@Riesgo,
@Prioridad)
GO
USE [master]
GO
ALTER DATABASE [CntNetCore] SET  READ_WRITE 
GO
