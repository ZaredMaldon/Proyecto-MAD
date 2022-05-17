create database BD_MAD_1;

use BD_MAD_1;

Create table Usuarios(
idUsuario int IDENTITY (1,1)	NOT NULL,
Usuario varchar(10),
Contraseña varchar(10),
Tipo varchar(10)
CONSTRAINT PK_Usuarios Primary Key(idUsuario)
)

Create table Municipios(
idMunicipio int Primary key,
NombreMunicipio varchar(25)
)

Create table Direcciones(
idDireccion int IDENTITY (1,1)	NOT NULL PRIMARY KEY,
MunicipioFk int					not null,
Cp          varchar(5)			not null,
Colonia     varchar(25)			not null,
Calle       varchar(25)			not null,
NoInterior  smallint			null,
NoExt		smallint			not null,
CONSTRAINT fk_Municipio FOREIGN KEY (Municipiofk) REFERENCES Municipios(idMunicipio)
);

CREATE TABLE Empresa (
idEmpresa		   int IDENTITY (1,1) NOT NULL PRIMARY KEY,
RazonSocial        varchar(50) not null ,
Direccionfk        int NOT NULL, --FOREING KEY
Telefono           int NOT NULL,
Email              varchar(50) NOT NULL,
RegistroPatronal   char(15) NOT NULL,
RFC                varchar(13) NOT NULL,
FechaInicioOp      date NOT NULL,
CONSTRAINT fk_Direcciones FOREIGN KEY (Direccionfk) REFERENCES Direcciones(idDireccion)
);

CREATE TABLE Gerentes (
IdGerente         int IDENTITY (1,1) NOT NULL PRIMARY KEY,
Nombre            varchar(25) NOT NULL,
APaterno          varchar(25) NOT NULL,
AMaterno          varchar(25) NULL DEFAULT('NO TIENE'),
idUsuarios        int NOT NULL,
CONSTRAINT fk_Usuario FOREIGN KEY (idUsuarios) REFERENCES Usuarios(idUsuario)
);

CREATE TABLE Empleados(
NoEmpleado        int           IDENTITY (100000,1)	NOT NULL,
Nombre            varchar(25)	NOT NULL,
APaterno          varchar(25)	NOT NULL,
AMaterno          varchar(25)	NULL DEFAULT('NO TIENE'),
FechaNacimiento   date			NOT NULL,
CURP              char(18)		NOT NULL,
NSS               char(11)		NOT NULL,
RFC               char(13)		NOT NULL,
Email             varchar(50)	NOT NULL,
Telefono1         varchar(11)		NOT NULL,
Telefono2         varchar(11)		NULL DEFAULT('--------'),
Contratacion      date			NOT NULL,
Direccionfk       int	        NOT NULL, --FOREING KEY
Usuariofk         int			NOT NULL,
Banco			  varchar(30),
NoCuenta          int,
CONSTRAINT PK_Empleado PRIMARY KEY (NoEmpleado),
CONSTRAINT fk_Direcciones2 FOREIGN KEY (Direccionfk) REFERENCES Direcciones(idDireccion),
CONSTRAINT fk_Usuario2 FOREIGN KEY (Usuariofk) REFERENCES Usuarios(idUsuario),
constraint UQ_Empleados_RFC UNIQUE (RFC),
constraint UQ_Empleados_CURP UNIQUE (CURP),
constraint UQ_Empleados_NSS UNIQUE(NSS),
constraint UQ_Empleados_NoCuenta UNIQUE (NoCuenta)
);

CREATE TABLE Departamentos(
idDpto				int			IDENTITY (1,1)	NOT NULL,
NombreDpto          varchar(25)	NOT NULL,
SueldoBase			money		NOT NULL,
CONSTRAINT PK_Departamento PRIMARY KEY (idDpto),
constraint UQ_Dpto_Nombre UNIQUE (NombreDpto)
);

CREATE TABLE Puestos(
IdPuesto			int			IDENTITY (1,1)	NOT NULL,
NombrePuesto		varchar(25)	NOT NULL,
NivelSalarial		float			NULL,
CONSTRAINT PK_Puestos PRIMARY KEY(IdPuesto),
constraint UQ_Puestos_Nombre UNIQUE (NombrePuesto)
);

CREATE TABLE PuestoDepartamento(
IdPD								  int IDENTITY (1,1)	NOT NULL,
Departamentofk				  int						NOT NULL,  
Puestofk						  int						NOT NULL,
SalarioDiario					  money	,
CONSTRAINT PK_PuestoDpto PRIMARY KEY(IdPD),
CONSTRAINT FK_Departamento2 FOREIGN KEY(Departamentofk) REFERENCES Departamentos(idDpto),
CONSTRAINT FK_Puesto2 FOREIGN KEY(Puestofk) REFERENCES Puestos(IdPuesto)
);

CREATE TABLE Deducciones(
IdDeduccion				int			IDENTITY (1,1)	NOT NULL,
NombreDeduccion			varchar(25)	NOT NULL,
FechaAplicada			date		NOT NULL,
Descuento				money		    NULL DEFAULT('NO APLICA'),
DescuentoPorcentaje		float			 NULL,
CONSTRAINT PK_Deducciones PRIMARY KEY(IdDeduccion),
constraint UQ_Deducciones_Nombre UNIQUE (NombreDeduccion)
)

CREATE TABLE Percepciones(
IdPercepcion      int			IDENTITY (1,1)	NOT NULL,
NombrePercepcion  varchar(25)	NOT NULL,
FechaAplicada	  date			NOT NULL,	
Bono              money		    NULL DEFAULT('NO APLICA'),
BonoPorcentaje    float			 NULL,
CONSTRAINT PK_Percepciones PRIMARY KEY(IdPercepcion),
constraint UQ_Percepciones_Nombre UNIQUE (NombrePercepcion)
)

CREATE TABLE Percepciones_Empleado(
Empleadofk       int				NOT NULL,
Percepcionfk      int			NOT NULL,
FechaAplicada	date			NOT NULL,
CONSTRAINT PK_PEmp PRIMARY KEY(Empleadofk,Percepcionfk,FechaAplicada),
CONSTRAINT FK_Empleado FOREIGN KEY (Empleadofk) REFERENCES Empleados(NoEmpleado),
CONSTRAINT FK_Percepciones FOREIGN KEY(Percepcionfk) REFERENCES Percepciones(IdPercepcion)
)

CREATE TABLE Deducciones_Empleado(
Empleadofk        int			NOT NULL,
Deduccionfk		  int			NOT NULL,
FechaAplicada	date			NOT NULL,	
CONSTRAINT PK_DEmp PRIMARY KEY(Empleadofk,Deduccionfk,FechaAplicada),
CONSTRAINT FK_Empleado2 FOREIGN KEY (Empleadofk) REFERENCES Empleados(NoEmpleado),
CONSTRAINT FK_Deducciones FOREIGN KEY(Deduccionfk) REFERENCES Deducciones(IdDeduccion) 
)


CREATE TABLE NOMINA(
IdNomina             int IDENTITY (1000000,1)	NOT NULL,
Empleadofk           int				NOT NULL,
Sueldo_bruto         money				NOT NULL,
Sueldo_neto          money				NOT NULL,
Bancofk	             varchar(30)		NOT NULL,
NoCuentafk			 int				NOT NULL,	     
FechaNomina			 date				NOT NULL,
CONSTRAINT PK_Nomina PRIMARY KEY(IdNomina),
CONSTRAINT FK_Empleado3 FOREIGN KEY(Empleadofk) REFERENCES Empleados(NoEmpleado),
)


CREATE TABLE Asiganciones(
IdAsignacion			int IDENTITY (1,1)	NOT NULL,
Empleadofk			int							NOT NULL,       
PuestoDptofk			int,
CONSTRAINT PK_Asignaciones PRIMARY KEY(IdAsignacion),
CONSTRAINT FK_Empleado4 FOREIGN KEY(Empleadofk) REFERENCES Empleados(NoEMpleado),
CONSTRAINT FK_PuestoDeDpto FOREIGN KEY(PuestoDptofk) REFERENCES PuestoDepartamento(IdPD)
)


/*DBCC CHECKIDENT('Empleados',RESEED,0);  /*RESETEAR EL IDENTITY*/*/
