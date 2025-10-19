insert Colaboradores (nroColaborador, nombre, apellido, titulo) values
(1525, 'JUAN', 'PLANA', 'TECNICO CONSTRUCTOR'),
(1625, 'ALBERTO', 'LOPEZ', 'ARQUITECTO'),
(1635, 'JUAN', 'ALVAREZ', 'INGENIERO CIVIL'),
(1697, 'ALBERTO', 'LEVIN', 'INGENIERO MECANICO'),
(1752, 'MARIA', 'ESTEVEZ', 'DIBUJANTE'),
(1785, 'JOSE', 'GRANA', 'TECNICO MECANICO');

insert into Proyectos (nroProyecto, nombre, nroOficina, codJefe) values
('001', 'CONSTRUCCION PARQUE X', 25352, 1625),
('002', 'CONSTRUCCION VIVIENDAS BARRIO XX', 25652, 1635),
('009', 'CONSTRUCCION VIVIENDAS BARRIO XY', 25652, 1635);

insert into ProyectosColaboradores(nroProyecto, nroColaborador, fecha) values
('001', 1525, '19990530'),
('001', 1625, '19990530'),
('001', 1752, '19990530'),
('002', 1635, '19990530'),
('002', 1697, '19990530'),
('002', 1752, '19990530'),
('009', 1635, '19990530'),
('009', 1785, '19990530'),
('009', 1752, '19990530');