-- Eliminamos la base de datos si existe
DROP database IF EXISTS Escuela_db;
-- Creacion de la base de datos
CREATE database Escuela_db;

-- Seleccionamos la base de datos
use Escuela_db;

-- Creamos la tabla de Materias
create table Materias(
	idMateria INT primary key AUTO_INCREMENT,
	nombre VARCHAR(50) not null,
	fechaCreacion DATETIME
);

-- Creamos la tabla de alumnos
create table Alumnos(
	idAlumno INT primary key AUTO_INCREMENT,
	nombre VARCHAR(50) not null,
	apellido VARCHAR(50),
	correo VARCHAR(50) not null,
	numeroCelular VARCHAR(11),
	fechaCreacion DATETIME
);

-- Creamos la tabla de relacion entre alumnos y materias
create table AlumnosMaterias(
	idAlumnoMateria INT primary key AUTO_INCREMENT,
	idMateria INT,
	idAlumno INT,
	fechaCursamiento DATETIME,
	calificacion INT,
	fechaCreacion DATETIME,
	foreign key (idMateria) references Materias(idMateria),
	foreign key (idAlumno) references Alumnos(idAlumno)
);

-- Insertamos materias
insert into Materias (
	nombre,
	fechaCreacion
) values (
	'Español',
	NOW()
), (
	'Matematicas',
	NOW()
), (
	'Historia',
	NOW()
), (
	'Quimica',
	NOW()
), (
	'Programación',
	NOW()
);

-- Insertamos los alumnos
insert into Alumnos (
  nombre,
  apellido,
  correo,
  numeroCelular,
  fechaCreacion
) values (
  'Joshua',
  'Landa',
  'jlanda@correo.com',
  '9983041741',
  NOW()
) , (
  'Alejandro',
  'Camarena',
  'acamarena@correo.com',
  '9983041720',
  NOW()
) , (
  'Lili',
  'Miranda',
  'lmiranda@correo.com',
  '9983541741',
  NOW()
) , (
  'Katia',
  'Martinez',
  'kmartinez@correo.com',
  '9983042041',
  NOW()
) , (
  'Carlos',
  'Balam',
  'cbalam@correo.com',
  '9993041741',
  NOW()
);

-- Insertamos los Alumnos que tengan calificación en cada materia
insert into AlumnosMaterias (
  idMateria,
  idAlumno,
  fechaCursamiento,
  calificacion,
  fechaCreacion
) 
select
  idMateria,
  idAlumno,
  '20250801',
  8,
  NOW()
from Materias
join Alumnos;

-- Actualizo datos de calificación para materia de programacion
UPDATE AlumnosMaterias
SET calificacion = 7
WHERE idMateria = (
  select
    idMateria
  FROM Materias
  WHERE nombre = 'Programacion'
);

-- Actualizo datos de calificación para materia de español
UPDATE AlumnosMaterias
SET calificacion = 10
WHERE idMateria = (
  select
    idMateria
  FROM Materias
  WHERE nombre = 'Español'
);

-- Actualizo datos de calificación para materia de Quimica
UPDATE AlumnosMaterias
SET calificacion = 6
WHERE idMateria = (
  select
    idMateria
  FROM Materias
  WHERE nombre = 'Quimica'
);

-- Obtenemos alumnos y materias
select * from Alumnos;
select * from Materias;

-- Obtenemos materia y alumnos y sus calificaciones por materia con calificion mayor a 7
select
  CONCAT(a.nombre, ' ', a.apellido) as nombreAlumno,
  m.nombre as nombreMateria,
  am.calificacion
from AlumnosMaterias am
inner join Materias m
  on m.idMateria = am.idMateria
inner join Alumnos a
  on a.idAlumno = am.idAlumno
where am.calificacion > 7;

-- Obtenemos materia y alumnos y sus calificaciones por materia con calificación menor a 7
select
  CONCAT(a.nombre, ' ', a.apellido) as nombreAlumno,
  m.nombre as nombreMateria,
  am.calificacion
from AlumnosMaterias am
inner join Materias m
  on m.idMateria = am.idMateria
inner join Alumnos a
  on a.idAlumno = am.idAlumno
where am.calificacion < 7;

-- Obtenemos todos los alumnos con todas sus materias y sus calificaciones por materia
select
  CONCAT(a.nombre, ' ', a.apellido) as nombreAlumno,
  m.nombre as nombreMateria,
  am.calificacion
from AlumnosMaterias am
inner join Materias m
  on m.idMateria = am.idMateria
inner join Alumnos a
  on a.idAlumno = am.idAlumno;