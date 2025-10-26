/*
  !La empresa solicito lo siguinte

  * Poder insertar un nuevo cliente con nombre Katia, apellido Martinez,
  * correo kmartinez@correo.com

  * Al cliente de Katia se le vendio el dia 25 de marzo del 2025 un Monitor Samsung 24,
  * una Laptop Lenovo IdeaPad 3
  * un Mouse Logitech G502 - produto nuevo con coste de unidad 750
  * y un teclado Logitech G213 - produto nuevo con coste de unidad 1200

  * Requiere crear una nueva sucursal para Cancun con nombre Principal
  * Agregar un nuevo vendedor con nombre Anna y apellido Montez
  * a esta sucursal y se le asigne la venta de Katia Martinez

*/

-- Creamos la nueva sucursal
insert into sucursales (
  nombre,
  ciudad,
  fechaCreacion
) values (
  'Principal',
  'Cancun',
  NOW()
);

-- Creamos al nuevo vendedor
insert into vendedores (
  idSucursal,
  nombre,
  apellido,
  fechaCreacion
)
select
  idSucursal,
  'Anna',
  'Montez',
  NOW()
from sucursales
where ciudad = 'cancun'
  and nombre = 'Principal';

-- Creamos al nuevo cliente
insert into clientes (
  nombre,
  apellido,
  correo,
  fechaCreacion
) values (
  'Katia',
  'Martinez',
  'kmartinez@correo.com',
  NOW()
);

-- Creamos los nuevos productos
insert into productos (
  idCategoria,
  tipo,
  marca,
  modelo,
  precioUnitario,
  fechaCreacion
) values (
  2,
  'Mouse',
  'Logitech',
  'G502',
  750,
  NOW()
), (
  2,
  'Teclado',
  'Logitech',
  'G213',
  1200,
  NOW()
);

-- Creamos la venta
insert into ventas (
  fechaVenta,
  idCliente,
  idVendedor,
  fechaCreacion
)
select
  '20250325',
	c.idCliente,
  v.idVendedor,
  NOW()
from clientes c
join (
	select idVendedor
    from vendedores
  where nombre = 'Anna'
    and apellido = 'Montez'
) v
where c.nombre = 'Katia'
  and c.apellido = 'Martinez';

-- Creamos el detalle de la venta realizada
insert into detalleVentas (
  idProducto,
  cantidad,
  idVenta,
  fechaCreacion
)
select
  p.idProducto,
  1 as cantidad,
  v.idVenta,
  now()
from (
  select
    idProducto
  from productos
  where marca in ('Samsung', 'Lenovo' , 'Logitech')
    and modelo in ('24',  'IdeaPad 3', 'G502', 'G213')
) p
join (
  select
    v.idVenta
  from ventas v
  inner join vendedores vs on vs.nombre = 'Anna'
    and vs.apellido = 'Montez'
    and vs.idVendedor = v.idVendedor
  inner join clientes c on c.nombre = 'Katia'
    and c.apellido = 'Martinez'
    and c.idCliente = v.idCliente
) v;
