--CREATE DATABASE DSI_PPAI
--DELETE DATABASE DSI_PPAI

USE DSI_PPAI

CREATE TABLE Sede (		id_sede INTEGER				NOT NULL PRIMARY KEY IDENTITY,
						nombre_sede VARCHAR(30)		NOT NULL,
						cant_max_visit INTEGER		NOT NULL,
						cant_max_guias INTEGER		NOT NULL,
						horario_desde DATE			NOT NULL DEFAULT GETDATE(),
						horario_hasta DATE			NOT NULL
				  )

CREATE TABLE Cargo (	id_cargo INTEGER			NOT NULL PRIMARY KEY IDENTITY,
						descripcion VARCHAR(30)		NOT NULL
				   )

CREATE TABLE Tipo_visita	(	id_tipo_visita INTEGER		NOT NULL PRIMARY KEY IDENTITY,
								descripcion VARCHAR(30)		NOT NULL
							)

CREATE TABLE Tipo_exposicion	(	id_tipo_expo INTEGER			NOT NULL PRIMARY KEY IDENTITY,
									nombre_tipo_expo VARCHAR(20)	NOT NULL,
									descripcion VARCHAR(30)			NOT NULL
								)

CREATE TABLE Genero		(	id_genero INTEGER		NOT NULL PRIMARY KEY IDENTITY,
							descripcion VARCHAR(15)	NOT NULL
						)

CREATE TABLE Provincia	(	id_provincia INTEGER			NOT NULL PRIMARY KEY IDENTITY,
							nombre_provincia VARCHAR(20)	NOT NULL
						)

CREATE TABLE Departamento	(	id_depto INTEGER			NOT NULL PRIMARY KEY IDENTITY,
								nombre_depto VARCHAR(20)	NOT NULL,
								id_provincia INTEGER		NOT NULL,

							CONSTRAINT deptoXprov_FK
								FOREIGN KEY (id_provincia)
								REFERENCES Provincia
							)

CREATE TABLE Ciudad		(	id_ciudad INTEGER			NOT NULL PRIMARY KEY IDENTITY,
							nombre_ciudad VARCHAR(20)	NOT NULL,
							id_depto INTEGER		NOT NULL,

							CONSTRAINT ciudadXdepto_FK
								FOREIGN KEY (id_depto)
								REFERENCES Departamento
						)

CREATE TABLE Barrio		(	id_barrio INTEGER			NOT NULL PRIMARY KEY IDENTITY,
							nombre_barrio VARCHAR(20)	NOT NULL,
							id_ciudad INTEGER			NOT NULL,

							CONSTRAINT barrioXciudad_FK
								FOREIGN KEY (id_ciudad)
								REFERENCES Ciudad
						)

CREATE TABLE TipoDoc	(	id_tipo_doc INTEGER		NOT NULL PRIMARY KEY IDENTITY,
							descripcion VARCHAR(10)	NOT NULL
						)

CREATE TABLE Empleado	(	id_empleado INTEGER			NOT NULL PRIMARY KEY IDENTITY,
							nombre VARCHAR(10)			NOT NULL,
							apellido VARCHAR(30)        NOT NULL,
							tipo_doc INTEGER			NOT NULL,
							nro_doc NUMERIC (8,0)			NOT NULL,
							nombre_calle VARCHAR(10)	NOT NULL,
							nro_calle INTEGER			NOT NULL,
							id_sede INTEGER				NOT NULL,
							id_cargo INTEGER			NOT NULL,
							id_genero INTEGER			NOT NULL,
							email VARCHAR(20)			DEFAULT 'default@-mail.com',
							cuit NCHAR (13)				DEFAULT 'XX-XXXXXXXX-X',
							id_barrio INTEGER			NOT NULL,
							telefono NCHAR (15)			DEFAULT '+XX XXX XXXXXXX',
							fecha_nac DATE				NOT NULL,
							fecha_ingreso DATE			DEFAULT GETDATE(),

						CONSTRAINT empleadoXtipoDoc_FK 
							FOREIGN KEY (tipo_doc)
							REFERENCES TipoDoc,
						CONSTRAINT empleadoXsede_FK
							FOREIGN KEY (id_sede)
							REFERENCES Sede,
						CONSTRAINT empleadoXcargo_FK
							FOREIGN KEY (id_cargo)
							REFERENCES Cargo,
						CONSTRAINT empleadoXgenero_FK
							FOREIGN KEY (id_genero)
							REFERENCES Genero,
						CONSTRAINT empleadoXbarrio_FK
							FOREIGN KEY (id_barrio)
							REFERENCES Barrio
						)

CREATE TABLE Hora_Empleado	(	id_empleado INTEGER			NOT NULL,
								dia NCHAR(1)				NOT NULL,
								hora_inicio TIME			NOT NULL,
								hora_fin TIME				NOT NULL,

							CONSTRAINT dia_CK CHECK (dia IN ('L', 'M', 'X', 'J', 'V', 'S', 'D')),
							CONSTRAINT horario_empleado_CK PRIMARY KEY (id_empleado, dia),
							CONSTRAINT horarioXempleado_FK 
								FOREIGN KEY (id_empleado)
								REFERENCES Empleado
							)

								

CREATE TABLE Exposicion		(	id_expo INTEGER			NOT NULL PRIMARY KEY IDENTITY,
								nombre VARCHAR(10)		NOT NULL,
								descripcion VARCHAR(30)	NOT NULL,
								fecha_inicio DATE		NOT NULL,
								fecha_fin DATE			NOT NULL,
								id_tipo_expo INTEGER	NOT NULL,
								id_guia INTEGER			NOT NULL,

							CONSTRAINT expoXtipoExpo_FK
								FOREIGN KEY (id_tipo_expo)
								REFERENCES Tipo_exposicion,
							CONSTRAINT expoXguia_FK
								FOREIGN KEY (id_guia)
								REFERENCES Empleado
							)

CREATE TABLE Usuario	(	id_usuario INTEGER			NOT NULL PRIMARY KEY IDENTITY,
							id_empleado INTEGER			NOT NULL,
							contraseña VARCHAR(16)		NOT NULL,
							nombre_usuario VARCHAR(10)	NOT NULL,

						CONSTRAINT userXempleado_FK
							FOREIGN KEY (id_empleado)
							REFERENCES Empleado
						)

CREATE TABLE Sesion		(	id_usuario INTEGER		NOT NULL,
							fecha_inicio DATETIME	NOT NULL,
							fecha_fin DATETIME		NOT NULL,

						CONSTRAINT sesion_PK PRIMARY KEY (id_usuario, fecha_inicio),
						CONSTRAINT sesionXuser_FK
							FOREIGN KEY (id_usuario)
							REFERENCES Usuario
						)

CREATE TABLE Escuela	(	id_escuela INTEGER			NOT NULL PRIMARY KEY IDENTITY, 
							nombre VARCHAR(12)			NOT NULL,
							email VARCHAR(20)			DEFAULT 'default_escuela@-mail.com',
							nombre_calle VARCHAR(10)	NOT NULL,
							nro_calle INTEGER			NOT NULL,
							id_barrio INTEGER			NOT NULL,
							tel_celular NCHAR (15)		DEFAULT '+XX XXX XXXXXXX',
							tel_fijo NCHAR (15)			DEFAULT '+XX XXX XXXXXXX',

						CONSTRAINT escuelaXbarrio_FK
							FOREIGN KEY (id_barrio)
							REFERENCES Barrio
						)

CREATE TABLE Reserva	(	id_reserva INTEGER			NOT NULL PRIMARY KEY IDENTITY,
							id_tipo_visita INTEGER		NOT NULL,
							id_escuela INTEGER			NOT NULL,
							id_guia	INTEGER				NOT NULL,
							fecha_creacion DATE			DEFAULT GETDATE(),
							fecha_reserva DATE			NOT NULL,
							hora_inicio TIME			NOT NULL,
							hora_fin TIME				NOT NULL,
							hora_incio_real TIME		NULL,
							hora_fin_real TIME			NULL,
							cant_alumnos_confirm INTEGER NULL,

						CONSTRAINT reservaXtipovisita_FK
							FOREIGN KEY (id_tipo_visita)
							REFERENCES Tipo_visita,
						CONSTRAINT reservaXescuela_FK
							FOREIGN KEY (id_escuela)
							REFERENCES Escuela,
						CONSTRAINT reservaXguia_FK
							FOREIGN KEY (id_guia)
							REFERENCES Empleado
						)

CREATE TABLE Expo_X_Reserva	(	id_reserva INTEGER		NOT NULL,
								id_exposicion INTEGER	NOT NULL,
							CONSTRAINT expoXreserva_PK PRIMARY KEY (id_reserva, id_exposicion),
							CONSTRAINT reservaXexpo_FK
								FOREIGN KEY (id_exposicion)
								REFERENCES Exposicion,
							CONSTRAINT expoXreserva_FK
								FOREIGN KEY (id_reserva)
								REFERENCES Reserva
							)

CREATE TABLE Obra			(	id_obra	 INTEGER		NOT NULL PRIMARY KEY IDENTITY,
								nombre VARCHAR(20)		NOT NULL,
								alto NUMERIC (5, 2)		NULL,
								ancho NUMERIC (5,2)		NULL,
								peso NUMERIC (5, 2)		NULL,
								fecha_creacion DATE		NULL,
								fecha_ingreso DATE		DEFAULT GETDATE(),
								valuacion NUMERIC(3,1)	NULL,
								descripcion VARCHAR(30)	NOT NULL,
								id_empleado INTEGER		NOT NULL,

							CONSTRAINT obraXregistrador_FK
								FOREIGN KEY (id_empleado)
								REFERENCES Empleado
							)

CREATE TABLE Expo_X_Obra	(	id_obra INTEGER			NOT NULL,
								id_expo	INTEGER			NOT NULL,

							CONSTRAINT expoXobra_PK	PRIMARY KEY (id_obra, id_expo),
							CONSTRAINT expoXobra_FK
								FOREIGN KEY (id_obra)
								REFERENCES Obra,
							CONSTRAINT obraXexpo_FK
								FOREIGN KEY (id_expo)
								REFERENCES Exposicion
							)