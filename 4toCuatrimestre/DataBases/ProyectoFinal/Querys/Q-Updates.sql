/*
  !La empresa solicito lo siguinte

  * La sucursal de la ciudad de Monterrey pasara a de ser Central a ser Este

  * El cliente con correo juanperez@mail.com cambiara su correo por perez40@email.com

  * El costo de los productos de tipo Laptop se le subira el precio un 10%
  * los de tipo Mouse y teclado se les subira el precio un 3%
  * y a los de marca Samsung tendran un descuento de 4%

*/

-- Actualizacion de la sucursal de Monterry se cambia el nombre
update sucursales
  set nombre = 'Este'
where ciudad = 'Monterrey';

-- Actualizacion de correo electronico de cliente
update clientes
  set correo = 'perez40@email.com'
where correo = 'juanperez@mail.com';

-- **NOTA: ESTAS ACTUALIZACIONES PUEDEN LLEGAR A FALLAR POR LAS RESTRICCIONES DE MYSQL ** --
-- * RECOMENDACION ANTE ESTO, USAR UNA SUBCONSULTA PARA OPTENER EL ID, Y CAMBIAR EL WHERE POR idProducto Y COLOCAR EL ID
-- Actualizacion para aumento de precio de producto
update productos
  set precioUnitario = precioUnitario + (precioUnitario * 0.1)
where tipo = 'Laptop';

-- Actualizacion para aumento de precio de producto
update productos
  set precioUnitario = precioUnitario + (precioUnitario * 0.03)
where tipo = 'Mouse';

-- Actualizacion para descuento de precio de producto
update productos
  set precioUnitario = precioUnitario - (precioUnitario * 0.04)
where tipo = 'Samsung';