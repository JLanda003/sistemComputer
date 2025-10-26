-- Eliminamos la base de datos si existe
-- DROP DATABASE IF EXISTS clientes_compras; 
CREATE DATABASE clientes_compras;

SHOW databases;

USE clientes_compras; 

-- Eliminamos las tablas si existen
DROP TABLE IF EXISTS compra;
DROP TABLE IF EXISTS cliente;

-- Creamos la tabla de clientes
CREATE TABLE cliente(
	id_cliente INTEGER PRIMARY KEY AUTO_INCREMENT,
    nombre TEXT NOT NULL,
    ciudad TEXT,
    correo TEXT
);

-- Creamos la tabla de compras
CREATE TABLE compra (
	id_compra INTEGER PRIMARY KEY AUTO_INCREMENT,
    id_cliente INTEGER NOT NULL,
    producto TEXT NOT NULL,
    precio REAL NOT NULL,
    fecha TEXT,
    FOREIGN KEY (id_cliente) REFERENCES cliente(id_cliente)
);

-- Insertamos los clientes
INSERT INTO cliente (nombre, ciudad, correo) VALUES
('Ana Pérez', 'Cancún', 'ana@example.com'),
('Luis Díaz', 'CDMX', 'luis@example.com'),
('Carla Soto', 'Guadalajara', 'carla@example.com'),
('Diego Rey', 'Monterrey', 'diego@example.com');

INSERT INTO compra (id_cliente, producto, precio, fecha) VALUES
(1, 'Refresco 600ml', 18.5, '2025-10-01'),
(1, 'Papas 45g', 15.0, '2025-10-02'),
(2, 'Agua 1L', 12.0, '2025-10-03'),
(3, 'Galletas', 25.0, '2025-10-03'),
(4, 'Cereal', 60.0, '2025-10-05'),
(2, 'Café soluble', 45.0, '2025-10-06');

-- CONSULTAS
-- 1) Ver todos los clientes
SELECT * FROM cliente;

-- 2) Ver todas las compras
SELECT * FROM compra;

-- 3) Mostrar cada cliente con el producto que compró (JOIN)
SELECT
	c.nombre,
    c.ciudad,
    co.producto,
    co.precio
FROM cliente c
JOIN compra co ON co.id_cliente = c.id_cliente;

-- 4) Ver compras realizadas en Cancún
SELECT
	c.nombre,
    co.producto,
    co.precio
FROM cliente c
JOIN compra co ON co.id_cliente = c.id_cliente
WHERE c.ciudad = 'Cancún';

-- 5) Calcular cuánto gastó cada cliente
SELECT
	nombre,
    SUM(precio) AS total_gastado
FROM cliente c
JOIN compra co ON co.id_cliente = c.id_cliente
GROUP BY c.nombre;

-- 6) Clientes que gastaron más de $30
SELECT
	nombre,
    SUM(precio) AS total
FROM cliente c
JOIN compra co ON co.id_cliente = c.id_cliente
GROUP BY c.nombre
HAVING total > 30;

-- 7) Ordenar por el gasto total de mayor a menor
SELECT
	nombre,
    SUM(precio) AS total
FROM cliente c
JOIN compra co ON co.id_cliente = c.id_cliente
GROUP BY c.nombre
ORDER BY total DESC;

-- Extras
-- Creamos dos nuevos clientes
INSERT INTO cliente (nombre, ciudad, correo) VALUES
('Joshua Landa', 'Cd Carmen', 'joshual@correo.com'),
('Katia Martinez', 'Cancun', 'kmatinez@correo.com');
-- Creamos sus compras
INSERT INTO compra (id_cliente, producto, precio, fecha) VALUES
(6, 'Refresco 600ml', 18.5, '2025-10-17'),
(5, 'Papas 45g', 15.0, '2025-10-12'),
(5, 'Refresco 600ml', 18.5, '2025-10-11'),
(6, 'Papas 45g', 15.0, '2025-10-12');

-- Consulta que permite Visualizar todas las compras por cliente
-- y a su vez mostrar el total de estas cuentas
SELECT
	c.nombre,
	GROUP_CONCAT(co.producto SEPARATOR ', ') AS producto,
	SUM(precio) AS total_gastado
FROM cliente c
JOIN compra co ON co.id_cliente = c.id_cliente
GROUP BY c.nombre;
