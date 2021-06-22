USE [master]
GO
/****** Object:  Database [DSI_PPAI]    Script Date: 22/6/2021 18:18:20 ******/
CREATE DATABASE [DSI_PPAI]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DSI_PPAI', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS01\MSSQL\DATA\DSI_PPAI.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DSI_PPAI_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS01\MSSQL\DATA\DSI_PPAI_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DSI_PPAI] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DSI_PPAI].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DSI_PPAI] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DSI_PPAI] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DSI_PPAI] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DSI_PPAI] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DSI_PPAI] SET ARITHABORT OFF 
GO
ALTER DATABASE [DSI_PPAI] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DSI_PPAI] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DSI_PPAI] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DSI_PPAI] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DSI_PPAI] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DSI_PPAI] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DSI_PPAI] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DSI_PPAI] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DSI_PPAI] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DSI_PPAI] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DSI_PPAI] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DSI_PPAI] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DSI_PPAI] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DSI_PPAI] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DSI_PPAI] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DSI_PPAI] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DSI_PPAI] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DSI_PPAI] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DSI_PPAI] SET  MULTI_USER 
GO
ALTER DATABASE [DSI_PPAI] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DSI_PPAI] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DSI_PPAI] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DSI_PPAI] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DSI_PPAI] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DSI_PPAI] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DSI_PPAI] SET QUERY_STORE = OFF
GO
USE [DSI_PPAI]
GO
/****** Object:  Table [dbo].[Barrio]    Script Date: 22/6/2021 18:18:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Barrio](
	[id_barrio] [int] IDENTITY(1,1) NOT NULL,
	[nombre_barrio] [varchar](40) NOT NULL,
	[id_ciudad] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_barrio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cargo]    Script Date: 22/6/2021 18:18:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cargo](
	[id_cargo] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_cargo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ciudad]    Script Date: 22/6/2021 18:18:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ciudad](
	[id_ciudad] [int] IDENTITY(1,1) NOT NULL,
	[nombre_ciudad] [varchar](40) NOT NULL,
	[id_depto] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_ciudad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departamento]    Script Date: 22/6/2021 18:18:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departamento](
	[id_depto] [int] IDENTITY(1,1) NOT NULL,
	[nombre_depto] [varchar](40) NOT NULL,
	[id_provincia] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_depto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 22/6/2021 18:18:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[id_empleado] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](40) NOT NULL,
	[apellido] [varchar](30) NOT NULL,
	[id_tipo_doc] [int] NOT NULL,
	[nro_doc] [numeric](8, 0) NOT NULL,
	[nombre_calle] [varchar](40) NOT NULL,
	[nro_calle] [int] NOT NULL,
	[id_sede] [int] NOT NULL,
	[id_cargo] [int] NOT NULL,
	[id_genero] [int] NOT NULL,
	[email] [varchar](40) NULL,
	[cuit] [nchar](13) NULL,
	[id_barrio] [int] NOT NULL,
	[telefono] [nchar](15) NULL,
	[fecha_nac] [date] NOT NULL,
	[fecha_ingreso] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Escuela]    Script Date: 22/6/2021 18:18:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Escuela](
	[id_escuela] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[email] [varchar](40) NULL,
	[nombre_calle] [varchar](30) NOT NULL,
	[nro_calle] [int] NOT NULL,
	[id_barrio] [int] NOT NULL,
	[tel_celular] [nchar](15) NULL,
	[tel_fijo] [nchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_escuela] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Expo_X_Obra]    Script Date: 22/6/2021 18:18:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Expo_X_Obra](
	[id_obra] [int] NOT NULL,
	[id_expo] [int] NOT NULL,
 CONSTRAINT [expoXobra_PK] PRIMARY KEY CLUSTERED 
(
	[id_obra] ASC,
	[id_expo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Expo_X_Reserva]    Script Date: 22/6/2021 18:18:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Expo_X_Reserva](
	[id_reserva] [int] NOT NULL,
	[id_exposicion] [int] NOT NULL,
 CONSTRAINT [expoXreserva_PK] PRIMARY KEY CLUSTERED 
(
	[id_reserva] ASC,
	[id_exposicion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Exposicion]    Script Date: 22/6/2021 18:18:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exposicion](
	[id_expo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[fecha_inicio] [date] NOT NULL,
	[fecha_fin] [date] NOT NULL,
	[id_tipo_expo] [int] NOT NULL,
	[id_guia] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_expo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genero]    Script Date: 22/6/2021 18:18:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genero](
	[id_genero] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](35) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_genero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Guia_X_Reserva]    Script Date: 22/6/2021 18:18:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Guia_X_Reserva](
	[idGuia] [int] NOT NULL,
	[idReserva] [int] NOT NULL,
 CONSTRAINT [PK_Guia_X_Reserva] PRIMARY KEY CLUSTERED 
(
	[idGuia] ASC,
	[idReserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hora_Empleado]    Script Date: 22/6/2021 18:18:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hora_Empleado](
	[id_empleado] [int] NOT NULL,
	[dia] [nchar](1) NOT NULL,
	[hora_inicio] [time](7) NOT NULL,
	[hora_fin] [time](7) NOT NULL,
 CONSTRAINT [horario_empleado_CK] PRIMARY KEY CLUSTERED 
(
	[id_empleado] ASC,
	[dia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Obra]    Script Date: 22/6/2021 18:18:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Obra](
	[id_obra] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[alto] [numeric](5, 2) NULL,
	[ancho] [numeric](5, 2) NULL,
	[peso] [numeric](5, 2) NULL,
	[fecha_creacion] [date] NULL,
	[fecha_ingreso] [date] NULL,
	[valuacion] [numeric](3, 1) NULL,
	[descripcion] [varchar](30) NOT NULL,
	[id_empleado] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_obra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provincia]    Script Date: 22/6/2021 18:18:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincia](
	[id_provincia] [int] IDENTITY(1,1) NOT NULL,
	[nombre_provincia] [varchar](40) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_provincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reserva]    Script Date: 22/6/2021 18:18:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reserva](
	[id_reserva] [int] IDENTITY(1,1) NOT NULL,
	[id_tipo_visita] [int] NOT NULL,
	[id_escuela] [int] NOT NULL,
	[fecha_creacion] [date] NULL,
	[fecha_reserva] [date] NOT NULL,
	[hora_inicio] [time](7) NOT NULL,
	[hora_fin] [time](7) NOT NULL,
	[hora_incio_real] [time](7) NULL,
	[hora_fin_real] [time](7) NULL,
	[cant_alumnos_confirm] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_reserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sede]    Script Date: 22/6/2021 18:18:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sede](
	[id_sede] [int] IDENTITY(1,1) NOT NULL,
	[nombre_sede] [varchar](50) NOT NULL,
	[cant_max_visit] [int] NOT NULL,
	[cant_max_guias] [int] NOT NULL,
	[horario_desde] [time](7) NOT NULL,
	[horario_hasta] [time](7) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_sede] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sesion]    Script Date: 22/6/2021 18:18:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sesion](
	[id_usuario] [int] NOT NULL,
	[fecha_inicio] [datetime] NOT NULL,
	[fecha_fin] [datetime] NOT NULL,
 CONSTRAINT [sesion_PK] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC,
	[fecha_inicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_exposicion]    Script Date: 22/6/2021 18:18:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_exposicion](
	[id_tipo_expo] [int] IDENTITY(1,1) NOT NULL,
	[nombre_tipo_expo] [varchar](20) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tipo_expo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_visita]    Script Date: 22/6/2021 18:18:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_visita](
	[id_tipo_visita] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tipo_visita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoDoc]    Script Date: 22/6/2021 18:18:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDoc](
	[id_tipo_doc] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](40) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tipo_doc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 22/6/2021 18:18:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[id_empleado] [int] NOT NULL,
	[contraseña] [varchar](16) NOT NULL,
	[nombre_usuario] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Empleado] ADD  DEFAULT ('default@-mail.com') FOR [email]
GO
ALTER TABLE [dbo].[Empleado] ADD  DEFAULT ('XX-XXXXXXXX-X') FOR [cuit]
GO
ALTER TABLE [dbo].[Empleado] ADD  DEFAULT ('+XX XXX XXXXXXX') FOR [telefono]
GO
ALTER TABLE [dbo].[Empleado] ADD  DEFAULT (getdate()) FOR [fecha_ingreso]
GO
ALTER TABLE [dbo].[Escuela] ADD  DEFAULT ('default_escuela@-mail.com') FOR [email]
GO
ALTER TABLE [dbo].[Escuela] ADD  DEFAULT ('+XX XXX XXXXXXX') FOR [tel_celular]
GO
ALTER TABLE [dbo].[Escuela] ADD  DEFAULT ('+XX XXX XXXXXXX') FOR [tel_fijo]
GO
ALTER TABLE [dbo].[Obra] ADD  DEFAULT (getdate()) FOR [fecha_ingreso]
GO
ALTER TABLE [dbo].[Reserva] ADD  DEFAULT (getdate()) FOR [fecha_creacion]
GO
ALTER TABLE [dbo].[Sede] ADD  DEFAULT (getdate()) FOR [horario_desde]
GO
ALTER TABLE [dbo].[Barrio]  WITH CHECK ADD  CONSTRAINT [barrioXciudad_FK] FOREIGN KEY([id_ciudad])
REFERENCES [dbo].[Ciudad] ([id_ciudad])
GO
ALTER TABLE [dbo].[Barrio] CHECK CONSTRAINT [barrioXciudad_FK]
GO
ALTER TABLE [dbo].[Ciudad]  WITH CHECK ADD  CONSTRAINT [ciudadXdepto_FK] FOREIGN KEY([id_depto])
REFERENCES [dbo].[Departamento] ([id_depto])
GO
ALTER TABLE [dbo].[Ciudad] CHECK CONSTRAINT [ciudadXdepto_FK]
GO
ALTER TABLE [dbo].[Departamento]  WITH CHECK ADD  CONSTRAINT [deptoXprov_FK] FOREIGN KEY([id_provincia])
REFERENCES [dbo].[Provincia] ([id_provincia])
GO
ALTER TABLE [dbo].[Departamento] CHECK CONSTRAINT [deptoXprov_FK]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [empleadoXbarrio_FK] FOREIGN KEY([id_barrio])
REFERENCES [dbo].[Barrio] ([id_barrio])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [empleadoXbarrio_FK]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [empleadoXcargo_FK] FOREIGN KEY([id_cargo])
REFERENCES [dbo].[Cargo] ([id_cargo])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [empleadoXcargo_FK]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [empleadoXgenero_FK] FOREIGN KEY([id_genero])
REFERENCES [dbo].[Genero] ([id_genero])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [empleadoXgenero_FK]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [empleadoXsede_FK] FOREIGN KEY([id_sede])
REFERENCES [dbo].[Sede] ([id_sede])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [empleadoXsede_FK]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [empleadoXtipoDoc_FK] FOREIGN KEY([id_tipo_doc])
REFERENCES [dbo].[TipoDoc] ([id_tipo_doc])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [empleadoXtipoDoc_FK]
GO
ALTER TABLE [dbo].[Escuela]  WITH CHECK ADD  CONSTRAINT [escuelaXbarrio_FK] FOREIGN KEY([id_barrio])
REFERENCES [dbo].[Barrio] ([id_barrio])
GO
ALTER TABLE [dbo].[Escuela] CHECK CONSTRAINT [escuelaXbarrio_FK]
GO
ALTER TABLE [dbo].[Expo_X_Obra]  WITH CHECK ADD  CONSTRAINT [expoXobra_FK] FOREIGN KEY([id_obra])
REFERENCES [dbo].[Obra] ([id_obra])
GO
ALTER TABLE [dbo].[Expo_X_Obra] CHECK CONSTRAINT [expoXobra_FK]
GO
ALTER TABLE [dbo].[Expo_X_Obra]  WITH CHECK ADD  CONSTRAINT [obraXexpo_FK] FOREIGN KEY([id_expo])
REFERENCES [dbo].[Exposicion] ([id_expo])
GO
ALTER TABLE [dbo].[Expo_X_Obra] CHECK CONSTRAINT [obraXexpo_FK]
GO
ALTER TABLE [dbo].[Expo_X_Reserva]  WITH CHECK ADD  CONSTRAINT [expoXreserva_FK] FOREIGN KEY([id_reserva])
REFERENCES [dbo].[Reserva] ([id_reserva])
GO
ALTER TABLE [dbo].[Expo_X_Reserva] CHECK CONSTRAINT [expoXreserva_FK]
GO
ALTER TABLE [dbo].[Expo_X_Reserva]  WITH CHECK ADD  CONSTRAINT [reservaXexpo_FK] FOREIGN KEY([id_exposicion])
REFERENCES [dbo].[Exposicion] ([id_expo])
GO
ALTER TABLE [dbo].[Expo_X_Reserva] CHECK CONSTRAINT [reservaXexpo_FK]
GO
ALTER TABLE [dbo].[Exposicion]  WITH CHECK ADD  CONSTRAINT [expoXguia_FK] FOREIGN KEY([id_guia])
REFERENCES [dbo].[Empleado] ([id_empleado])
GO
ALTER TABLE [dbo].[Exposicion] CHECK CONSTRAINT [expoXguia_FK]
GO
ALTER TABLE [dbo].[Exposicion]  WITH CHECK ADD  CONSTRAINT [expoXtipoExpo_FK] FOREIGN KEY([id_tipo_expo])
REFERENCES [dbo].[Tipo_exposicion] ([id_tipo_expo])
GO
ALTER TABLE [dbo].[Exposicion] CHECK CONSTRAINT [expoXtipoExpo_FK]
GO
ALTER TABLE [dbo].[Guia_X_Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Guia_X_Reserva_Empleado] FOREIGN KEY([idGuia])
REFERENCES [dbo].[Empleado] ([id_empleado])
GO
ALTER TABLE [dbo].[Guia_X_Reserva] CHECK CONSTRAINT [FK_Guia_X_Reserva_Empleado]
GO
ALTER TABLE [dbo].[Guia_X_Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Guia_X_Reserva_Reserva] FOREIGN KEY([idReserva])
REFERENCES [dbo].[Reserva] ([id_reserva])
GO
ALTER TABLE [dbo].[Guia_X_Reserva] CHECK CONSTRAINT [FK_Guia_X_Reserva_Reserva]
GO
ALTER TABLE [dbo].[Hora_Empleado]  WITH CHECK ADD  CONSTRAINT [horarioXempleado_FK] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[Empleado] ([id_empleado])
GO
ALTER TABLE [dbo].[Hora_Empleado] CHECK CONSTRAINT [horarioXempleado_FK]
GO
ALTER TABLE [dbo].[Obra]  WITH CHECK ADD  CONSTRAINT [obraXregistrador_FK] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[Empleado] ([id_empleado])
GO
ALTER TABLE [dbo].[Obra] CHECK CONSTRAINT [obraXregistrador_FK]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [reservaXescuela_FK] FOREIGN KEY([id_escuela])
REFERENCES [dbo].[Escuela] ([id_escuela])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [reservaXescuela_FK]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [reservaXtipovisita_FK] FOREIGN KEY([id_tipo_visita])
REFERENCES [dbo].[Tipo_visita] ([id_tipo_visita])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [reservaXtipovisita_FK]
GO
ALTER TABLE [dbo].[Sesion]  WITH CHECK ADD  CONSTRAINT [sesionXuser_FK] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Sesion] CHECK CONSTRAINT [sesionXuser_FK]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [userXempleado_FK] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[Empleado] ([id_empleado])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [userXempleado_FK]
GO
ALTER TABLE [dbo].[Hora_Empleado]  WITH CHECK ADD  CONSTRAINT [dia_CK] CHECK  (([dia]='D' OR [dia]='S' OR [dia]='V' OR [dia]='J' OR [dia]='X' OR [dia]='M' OR [dia]='L'))
GO
ALTER TABLE [dbo].[Hora_Empleado] CHECK CONSTRAINT [dia_CK]
GO
USE [master]
GO
ALTER DATABASE [DSI_PPAI] SET  READ_WRITE 
GO
