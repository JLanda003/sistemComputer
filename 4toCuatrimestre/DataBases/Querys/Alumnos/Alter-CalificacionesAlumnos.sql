drop database if exists CalificacionesAlumnos;
create database CalificacionesAlumnos;

use CalificacionesAlumnos;

create table Alumnos(
	codAlumno integer primary key not null,
	nombre varchar(50) not null,
	apellido varchar(50),
	ingreso datetime
);

create table Ciclos(
	codCiclo integer primary key auto_increment,
	ciclo varchar(30)
);

create table Materias(
	codMateria integer primary key not null,
	materia varchar(30),
	codCiclo int,
	foreign key (codCiclo) references Ciclos(codCiclo)
);

create table Menciones(
	codMencion integer primary key auto_increment,
	mencion varchar(30) not null
);

create table Calificaciones(
	codCalificacion integer primary key auto_increment,
	fecha datetime not null,
	nota integer not null,
	codMencion integer not null,
	foreign key (codMencion) references  Menciones(codMencion)
);

create table AlumnosMateriasCalificaciones(
	codAluMatCal integer primary key auto_increment,
	codAlumno integer,
	codMateria integer,
	codCalificacion integer,
	foreign key (codAlumno) references Alumnos(codAlumno),
	foreign key (codMateria) references Materias(codMateria),
	foreign key (codCalificacion) references Calificaciones(codCalificacion)
);