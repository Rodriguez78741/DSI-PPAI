DELETE DATABASE DSI_PPAI2
CREATE DATABASE DSI_PPAI


USE DSI_PPAI

CREATE TABLE Sede (		id_sede INTEGER				NOT NULL PRIMARY KEY IDENTITY(1,1),
						nombre_sede VARCHAR(50)		NOT NULL,
						cant_max_visit INTEGER		NOT NULL,
						cant_max_guias INTEGER		NOT NULL,
						horario_desde TIME		NOT NULL DEFAULT GETDATE(),
						horario_hasta TIME		NOT NULL
				  )

CREATE TABLE Cargo (	id_cargo INTEGER			NOT NULL PRIMARY KEY IDENTITY(1,1),
						descripcion VARCHAR(50)		NOT NULL
				   )

CREATE TABLE Tipo_visita	(	id_tipo_visita INTEGER		NOT NULL PRIMARY KEY IDENTITY(1,1),
								descripcion VARCHAR(50)		NOT NULL
							)

CREATE TABLE Tipo_exposicion	(	id_tipo_expo INTEGER			NOT NULL PRIMARY KEY IDENTITY(1,1),
									nombre_tipo_expo VARCHAR(20)	NOT NULL,
									descripcion VARCHAR(50)			NOT NULL
								)

CREATE TABLE Genero		(	id_genero INTEGER		NOT NULL PRIMARY KEY IDENTITY(1,1),
							descripcion VARCHAR(35)	NOT NULL
						)

CREATE TABLE Provincia	(	id_provincia INTEGER			NOT NULL PRIMARY KEY IDENTITY(1,1),
							nombre_provincia VARCHAR(40)	NOT NULL
						)

CREATE TABLE Departamento	(	id_depto INTEGER			NOT NULL PRIMARY KEY IDENTITY(1,1),
								nombre_depto VARCHAR(40)	NOT NULL,
								id_provincia INTEGER		NOT NULL,

							CONSTRAINT deptoXprov_FK
								FOREIGN KEY (id_provincia)
								REFERENCES Provincia
							)

CREATE TABLE Ciudad		(	id_ciudad INTEGER			NOT NULL PRIMARY KEY IDENTITY(1,1),
							nombre_ciudad VARCHAR(40)	NOT NULL,
							id_depto INTEGER		NOT NULL,

							CONSTRAINT ciudadXdepto_FK
								FOREIGN KEY (id_depto)
								REFERENCES Departamento
						)

CREATE TABLE Barrio		(	id_barrio INTEGER			NOT NULL PRIMARY KEY IDENTITY(1,1),
							nombre_barrio VARCHAR(40)	NOT NULL,
							id_ciudad INTEGER			NOT NULL,

							CONSTRAINT barrioXciudad_FK
								FOREIGN KEY (id_ciudad)
								REFERENCES Ciudad
						)

CREATE TABLE TipoDoc	(	id_tipo_doc INTEGER		NOT NULL PRIMARY KEY IDENTITY(1,1),
							descripcion VARCHAR(40)	NOT NULL
						)

CREATE TABLE Empleado	(	id_empleado INTEGER			NOT NULL PRIMARY KEY IDENTITY(1,1),
							nombre VARCHAR(40)			NOT NULL,
							apellido VARCHAR(30)        NOT NULL,
							id_tipo_doc INTEGER			NOT NULL,
							nro_doc NUMERIC (8,0)		NOT NULL,
							nombre_calle VARCHAR(40)	NOT NULL,
							nro_calle INTEGER			NOT NULL,
							id_sede INTEGER				NOT NULL,
							id_cargo INTEGER			NOT NULL,
							id_genero INTEGER			NOT NULL,
							email VARCHAR(40)			DEFAULT 'default@-mail.com',
							cuit NCHAR (13)				DEFAULT 'XX-XXXXXXXX-X',
							id_barrio INTEGER			NOT NULL,
							telefono NCHAR (15)			DEFAULT '+XX XXX XXXXXXX',
							fecha_nac DATE				NOT NULL,
							fecha_ingreso DATE			DEFAULT GETDATE(),

						CONSTRAINT empleadoXtipoDoc_FK 
							FOREIGN KEY (id_tipo_doc)
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

								

CREATE TABLE Exposicion		(	id_expo INTEGER			NOT NULL PRIMARY KEY IDENTITY(1,1),
								nombre VARCHAR(30)		NOT NULL,
								descripcion VARCHAR(50)	NOT NULL,
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

CREATE TABLE Usuario	(	id_usuario INTEGER			NOT NULL PRIMARY KEY IDENTITY(1,1),
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

CREATE TABLE Escuela	(	id_escuela INTEGER			NOT NULL PRIMARY KEY IDENTITY(1,1), 
							nombre VARCHAR(30)			NOT NULL,
							email VARCHAR(40)			DEFAULT 'default_escuela@-mail.com',
							nombre_calle VARCHAR(30)	NOT NULL,
							nro_calle INTEGER			NOT NULL,
							id_barrio INTEGER			NOT NULL,
							tel_celular NCHAR (15)		DEFAULT '+XX XXX XXXXXXX',
							tel_fijo NCHAR (15)			DEFAULT '+XX XXX XXXXXXX',

						CONSTRAINT escuelaXbarrio_FK
							FOREIGN KEY (id_barrio)
							REFERENCES Barrio
						)

CREATE TABLE Reserva	(	id_reserva INTEGER			NOT NULL PRIMARY KEY IDENTITY(1,1),
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

CREATE TABLE Obra			(	id_obra	 INTEGER		NOT NULL PRIMARY KEY IDENTITY(1,1),
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



--Inserts Sede
INSERT INTO Sede (nombre_sede, cant_max_visit, cant_max_guias, horario_desde,horario_hasta) VALUES ('Caraffa', 100, 30,'8:00:00','17:00:00');

--Inserts Cargo
INSERT INTO Cargo (descripcion) VALUES ('Guia de visitas');
INSERT INTO Cargo (descripcion) VALUES ('Director');

--Inserts Tipo Visita
INSERT INTO Tipo_visita(descripcion) VALUES ('General');
INSERT INTO Tipo_visita(descripcion) VALUES ('Particular');

--Inserts Tipo Exposicion
INSERT INTO Tipo_exposicion (nombre_tipo_expo,descripcion) VALUES ('Renacent.','Exposicion de arte renacentist');

--Inserts Genero
INSERT INTO Genero (descripcion) VALUES ('Masculino');

--Inserts Provincia
INSERT INTO Provincia (nombre_provincia) VALUES ('Cordoba');

--Inserts Departamento
INSERT INTO Departamento (nombre_depto, id_provincia) VALUES ('Marcos Juarez',1);

--Inserts Ciudad
INSERT INTO Ciudad (nombre_ciudad, id_depto) VALUES('Cordoba',1);

--Inserts Barrio
INSERT INTO Barrio(nombre_barrio,id_ciudad) VALUES ('Nueva Cordoba', 1);

--Inserts TipoDoc
INSERT INTO TipoDoc(descripcion) VALUES ('DNI');
INSERT INTO TipoDoc(descripcion) VALUES ('CUIL');
INSERT INTO TipoDoc(descripcion) VALUES ('CUIT');

--Inserts Empleado
INSERT INTO Empleado (nombre, apellido, id_tipo_doc, nro_doc, nombre_calle, nro_calle, id_sede, id_cargo, id_genero, email, cuit, id_barrio, telefono, fecha_nac)
VALUES ('Tito','Puentes', 1,32156324, 'Av. Chaca', 550, 1, 1, 1,'tito@gmail.com', 22-45345234-3, 1, 3516426896, '2008/12/12');

--Inserts HoraEmpleado
INSERT INTO Hora_Empleado( id_empleado, dia, hora_inicio, hora_fin) VALUES (1,'M','8:00:00', '16:00:00');



--Inserts Exposicion
INSERT INTO Exposicion(nombre, descripcion, fecha_inicio, fecha_fin, id_tipo_expo, id_guia) VALUES ('Muestrar', 'Muestra de arte', '2021/06/01', '2021/12/01', 1, 1);


--Inserts Usuario
INSERT INTO Usuario (id_empleado,contraseña,nombre_usuario) VALUES (1,'ADMIN','ADMIN');


--Inserts Sesion
INSERT INTO Sesion (id_usuario, fecha_inicio, fecha_fin) VALUES (1,'2021/12/10 8:00:00','5/5/5 8:00:00');

--Inserts Escuela
INSERT INTO Escuela (nombre, email, nombre_calle, nro_calle, id_barrio, tel_celular, tel_fijo) VALUES('IEC','iec@gmail.com','Av. Velez',685, 1, 351964856, 4856963);

--Insert Reserva
INSERT INTO Reserva (id_tipo_visita, id_escuela,id_guia, fecha_creacion, fecha_reserva, hora_inicio, hora_fin, hora_incio_real, hora_fin_real, cant_alumnos_confirm) 
VALUES (1,1,1,'','2021/7/15', '15:00:00', '17:00:00', '15:17:00', '17:15:00', 150);

--Insert Expo X Reserva
INSERT INTO Expo_X_Reserva (id_reserva, id_exposicion) VALUES(1,1);

--Inserts Obra
INSERT INTO Obra (nombre, alto, ancho, peso, fecha_creacion, fecha_ingreso, valuacion, descripcion, id_empleado) 
VALUES ('La Mona Lisa', 923.99, 199.99, 139.99, '1572/12/6', '2020/10/15', 9.99, 'La mona lisa de DaVinci',1);

--Inserts Expo_X_Obra
INSERT INTO Expo_X_Obra (id_obra, id_expo) VALUES (1,1);