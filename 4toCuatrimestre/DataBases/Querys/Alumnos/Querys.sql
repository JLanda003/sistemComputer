use calificacionesalumnos;

-- Obtener todos los alumnos registrados
select * from alumnos;

-- Obtener todos los ciclos y las materias asignadas a estos.
select
	c.ciclo,
    GROUP_CONCAT(CONCAT(m.codMateria, '; ', m.materia) SEPARATOR ', ') AS materias_por_ciclo
from Materias m
inner join ciclos c on c.codCiclo = m.codCiclo
group by c.ciclo;

-- Obtener las calificaciones de los alumnos ordenados por MATERIA alfabeticamente, la mejor nota.
select
	CONCAT(a.codAlumno, ' - ', a.nombre, ' - ', a.apellido) as ALUMNO,
	CONCAT(cl.ciclo, ' - ', m.codMateria, '; ', m.materia) as MATERIA,
	c.nota as NOTA,
	c.fecha as FECHA_CALIFICACION
from alumnosmateriascalificaciones amc
inner join alumnos a on a.codAlumno = amc.codAlumno
inner join materias m on m.codMateria = amc.codMateria
inner join ciclos cl on cl.codCiclo = m.codCiclo
inner join calificaciones c on c.codCalificacion = amc.codCalificacion
inner join menciones mc on mc.codMencion = c.codMencion
order by MATERIA asc, c.nota desc;