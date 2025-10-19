create database PersonalProyecto;

use PersonalProyecto;

create table Colaboradores(
	nroColaborador integer primary key not null,
	nombre varchar(50) not null,
	apellido varchar(50),
	titulo varchar(50)
);

create table Proyectos(
	nroProyecto varchar(10) primary key not null,
	nombre varchar(50) not null,
	nroOficina integer not null,
  codJefe INT not null,
  foreign key (codJefe) references Colaboradores(nroColaborador)
);

create table ProyectosColaboradores(
	idProyectoColaboradores integer primary key auto_increment,
	nroProyecto varchar(10),
	nroColaborador integer,
	fecha datetime,
	foreign key (nroProyecto) references Proyectos(nroProyecto),
	foreign key (nroColaborador) references Colaboradores(nroColaborador)
);