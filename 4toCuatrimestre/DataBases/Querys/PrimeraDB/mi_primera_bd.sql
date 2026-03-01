-- Eliminamos la base de datos si existe una previamente se mantiene comentado
-- DROP DATABASE IF EXISTS mi_primera_db;
-- Creamos la Base de datos (DB) si no existe
CREATE DATABASE IF NOT EXISTS mi_primera_db;

-- Permite visualizar las BD existentes
SHOW databases;
-- Seleccionamos para uso la DB previamente creada
USE mi_primera_db;

-- Si existe xiste la tabla la eliminamos
DROP TABLE IF EXISTS contacto;
-- Creamos la tabla
CREATE TABLE contacto(
	id INTEGER PRIMARY KEY AUTO_INCREMENT,
    nombre TEXT NOT NULL,
    ciudad TEXT,
    telefono TEXT,
    categoria TEXT
);

-- Insertamos datos en la tabla
INSERT INTO contacto(nombre, ciudad, telefono, categoria) VALUES
('Ana Pérez', 'Cancún', '9981112233', 'Amigos'), 
('Luis Díaz', 'CDMX', '5512345678', 'Trabajo'), 
('Carla Soto','Cancún','9982223344','Familia'), 
('Diego Rey','Monterrey','8111112222','Trabajo'), 
('Elena Gil','Guadalajara','3312345678','Amigos'), 
('Juan Sol','Cancún','9983334455','Trabajo'), 
('Nora Paz','Mérida','9998887766','Familia'), 
('Oscar Kay','Cancún','9985556677','Amigos'); 

-- Consultas
-- 1) Ver todos los contatos
SELECT * FROM contacto;

-- 2) Ver solo nombres y ciudades
SELECT
	nombre,
	ciudad
FROM contacto;

-- 3) Contactos que viven en Cancún
SELECT * FROM contacto
WHERE ciudad = 'Cancún';

-- 4) Contactos de la categoría Trabajo, ordenados por nombre
SELECT
	nombre,
    categoria
FROM contacto
WHERE categoria = 'Trabajo'
ORDER BY nombre ASC;

-- 5) ¿Cuántos contactos hay por ciudad?
SELECT
	ciudad,
    COUNT(*) AS total
FROM contacto
GROUP BY ciudad
ORDER BY total DESC;

-- 6) Busca nombres que contenga la letra "a"
SELECT
	*
FROM contacto
WHERE nombre LIKE '%a%';

-- 7) Teléfonos que comienzan con 998
SELECT
	nombre,
    telefono
FROM contacto
WHERE telefono LIKE '998%';

-- Parte Opcional
-- Todos los "Amigos" que no sean de Cancún
SELECT
	nombre,
    ciudad,
    categoria 
FROM contacto
WHERE categoria = 'Amigos' AND ciudad != 'Cancún';

-- Contactos cuyo teléfono termina en "78"
SELECT
	nombre,
    telefono
FROM contacto
WHERE telefono LIKE '%78';