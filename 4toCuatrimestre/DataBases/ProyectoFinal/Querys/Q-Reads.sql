/*
  !La empresa solicito lo siguinte

  * Poder ver cuantos vendedores tiene por sucursal

  * Cuantas ventas en total ha hecho

  * Que vendedor hizo ventas el dia 16 de septiembre del 2024 y que se vendio

  * Que cliente le compra mas.

*/

-- Ver cuantos vendedores tiene por sucursal
select
  count(idVendedor) as vendedoresXsucursal,
  s.nombre
from vendedores v
inner join sucursales s on s.idSucursal = v.idSucursal
group by s.nombre;

-- Ventas totales
select
  count(idVenta) as totalVentas
from ventas;

-- Quien se vendio el dia 16 y quien lo vendio
select
	concat(
    'Tipo de producto: ',
    p.tipo,
    ' - ',
    'Marca: ',
    p.marca,
    ' - Modelo: ',
    p.modelo
  ) as productoVendido,
  concat('Vendedor: ', vs.nombre, ' ', vs.apellido) as Vendedor,
  v.fechaVenta
from DetalleVentas dv
inner join ventas v on v.idVenta = dv.idVenta
	and v.fechaVenta = '20240916'
inner join vendedores vs on vs.idVendedor = v.idVendedor
inner join productos p on p.idProducto = dv.idProducto;

-- Ver que cliente compra mas
select
	count(v.idCliente) as comprasCliente,
	concat('Nombre: ', c.nombre, ' ', c.apellido) as nombreCliente
from ventas v
inner join clientes c on c.idCliente = v.idCliente
group by v.idCliente
order by comprasCliente desc
limit 1;