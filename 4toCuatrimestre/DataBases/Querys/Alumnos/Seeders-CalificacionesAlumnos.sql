use CalificacionesAlumnos;

insert into Alumnos (codAlumno, nombre, apellido, ingreso) values
(080845, 'Jesús', 'Lopez', '19700313'),
(126543, 'Juan', 'García', '19800326'),
(110835, 'Luis', 'Alvarez', '19810606'),
(140000, 'Ana', 'Pool', '19820601'),
(111022, 'Sol', 'Ruiz', '19830401');

insert into Ciclos (ciclo)values
('Matemático'),
('Humanidades'),
('Jurídico');

insert into Materias (codMateria, materia, codCiclo) values
(133, 'Análisis 1', 1),
(135, 'Estadistica', 1),
(148, 'Historia 1', 2),
(157, 'Der. Público', 3),
(158, 'Privado', 3);

insert into Menciones (mencion) values
('INSUF.'),
('BUENO.'),
('APROB.'),
('M. BUENO');

insert into Calificaciones (fecha, nota, codMencion) values
('19800315', 2, 1),
('19800730', 5, 2),
('19801223', 2, 1),
('19810312', 4, 3),
('19810612', 2, 1),
('19810912', 7, 4),
('19820604', 6, 2),
('19810725', 1, 1),
('19811011', 4, 3),
('19810725', 1, 1),
('19821024', 6, 2),
('19821109', 8, 4),
('19821215', 4, 3),
('19830711', 4, 3),
('19830702', 6, 2);


insert into AlumnosMateriasCalificaciones (
	codAlumno,
	codMateria,
	codCalificacion
) values
(080845, 133, 1),
(080845, 148, 2),
(080845, 157, 3),
(080845, 133, 4),
(126543, 157, 5),
(126543, 133, 6),
(126543, 135, 7),
(110835, 158, 8),
(110835, 133, 9),
(110835, 135, 10),
(140000, 148, 11),
(140000, 135, 12),
(140000, 133, 13),
(111022, 157, 14),
(111022, 148, 15);