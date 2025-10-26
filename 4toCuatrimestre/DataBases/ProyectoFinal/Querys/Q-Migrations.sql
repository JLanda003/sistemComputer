-- ** ESTE ESCRIPT UNICAMENTE DEBE CORRERSE AL LEVANTAR POR PRIMERA VEZ LA BASE DE DATOS ** --

-- Inicializamos la coneccion con la db
USE tecnologiamundo_db;
-- sirve para configurar la funcionalidad de uso de archivos locales
SET GLOBAL local_infile = 1;

-- Elimina la tabla de MG_Ventas
DROP TABLE IF EXISTS MG_Ventas;

-- Creamos tabla temporal la cual debe tener la misma estructura del fichero CSV
CREATE TEMPORARY TABLE `MG_Ventas` (
  `No. de venta` INT NULL,
  `Fecha de venta` DATETIME NULL,
  `Nombre del cliente` VARCHAR(45) NULL,
  `Apellido del Cliente` VARCHAR(45) NULL,
  `Correo del cliente` VARCHAR(45) NULL,
  `Tipo del producto` VARCHAR(45) NULL,
  `Marca del producto` VARCHAR(45) NULL,
  `Modelo del producto` VARCHAR(45) NULL,
  `Categoria` VARCHAR(45) NULL,
  `Precio unitario` INT NULL,
  `Cantidad` VARCHAR(45) NULL,
  `Nombre del vendedor` VARCHAR(45) NULL,
  `Apellido del vendedor` VARCHAR(45) NULL,
  `Sucursal` VARCHAR(45) NULL,
  `Ciudad de la sucursal` VARCHAR(45) NULL
);

-- Cargamos los datos del fichero CSV y lo insetarmos en la tabla temporal
LOAD DATA LOCAL INFILE 'C:/ProgramData/MySQL/MySQL Server 8.0/Uploads/ventas_Septiembre-2024_atomico.csv'
INTO TABLE MG_Ventas
FIELDS TERMINATED BY ','
ENCLOSED BY '"'
LINES TERMINATED BY '\n'
IGNORE 1 LINES;

/*
	A continuacion se realiza la insercion de
	los datos existentes en la tabla temporal a las tablas adecuadas
*/

-- Insertamos los clientes
insert into clientes (
	nombre,
	apellido,
	correo,
	fechaCreacion
)
select
	distinct 
	`Nombre del cliente`,
	`Apellido del Cliente`,
	`Correo del cliente`,
	NOW() as fechaCreacion
from MG_Ventas;

-- Insertamos las sucursales
insert into sucursales(
	nombre,
	ciudad,
	fechaCreacion
)
select
	distinct
	`Sucursal`,
	`Ciudad de la sucursal`,
	NOW() as fechaCreacion
from mg_ventas;

-- Insertamos los vendedores
insert into vendedores(
	idSucursal,
	nombre,
	apellido,
	fechaCreacion
)
select
	distinct
	s.idSucursal,
	`Nombre del vendedor`,
	`Apellido del vendedor`,
	NOW() as fechaCreacion	
from mg_ventas mv
inner join sucursales s on s.nombre =mv.`Sucursal`
and s.ciudad = mv.`Ciudad de la sucursal`;

-- Insertamos las ventas
insert into ventas(
	fechaVenta,
	idCliente,
	idVendedor,
	fechaCreacion
)
select
	distinct 
	`Fecha de venta`,
	c.idCliente,
	v.idVendedor,
	NOW() as fechaCreacion
from mg_ventas mv
inner join clientes c on c.nombre = mv.`Nombre del cliente`
	and c.apellido = mv.`Apellido del Cliente`
inner join vendedores v on v.nombre = mv.`Nombre del vendedor`
	and v.apellido = mv.`Apellido del vendedor`;

-- Insertamos las categorias
insert into categorias(
	nombre,
	fechaCreacion
)
select
	distinct
	`Categoria`,
	NOW() as fechaCreacion
from mg_ventas;

-- Insertamos los productos
insert into productos(
	idCategoria,
	tipo,
	marca,
	modelo,
	precioUnitario,
	fechaCreacion
)
select
	distinct
	c.idCategoria,
	`Tipo del producto`,
	`Marca del producto`,
	`Modelo del producto`,
	`Precio unitario`,
	NOW() as fechaCreacion
from mg_ventas mv
inner join categorias c on c.nombre = mv.`Categoria`;

-- Insertamos los detalles de las ventas
insert into detalleventas(
	idProducto,
	cantidad,
	idVenta,
	fechaCreacion
)
select
	p.idProducto,
	mv.`Cantidad`,
	vcv.idventa,
	NOW() as fechaCreacion
from mg_ventas mv
inner join productos p on p.tipo = mv.`Tipo del producto`
	and p.marca = mv.`Marca del producto`
	and p.modelo = mv.`Modelo del producto`
inner join (
	select
		v.idVenta,
		c.nombre as nombreCliente,
		c.apellido as apellidoCliente,
		vd.nombre as nombreVendedor,
		vd.apellido as apellidoVendedor
	from ventas v
	inner join clientes c on c.idCliente = v.idCliente
	inner join vendedores vd on vd.idVendedor = v.idVendedor
) vcv 
	on vcv.nombrecliente = mv.`Nombre del cliente`
	and vcv.apellidocliente = mv.`Apellido del Cliente`
	and vcv.vcv.nombrevendedor = mv.`Nombre del vendedor`
	and vcv.apellidoVendedor = mv.`Apellido del vendedor`
order by `No. de venta` asc;

-- ELiminaremos la tabla de migraciones ya que no es necesario que exista.
DROP TABLE IF EXISTS MG_Ventas;