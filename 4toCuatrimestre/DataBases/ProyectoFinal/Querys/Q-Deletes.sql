/*
  !La empresa solicito lo siguinte

  * ELiminar todos los detalles de las ventas realizadas en las fechas
  * 12, 14, 17 del mes de septiembre del año 2024

*/

-- Permite eliminar los registros de detalle de ventas de las fechas 12, 14, 17/septiembre/2024
delete
  dv
from detalleVentas dv
inner join ventas v on fechaVenta IN ('20240912', '20240914', '20240917')
  and v.idVenta = dv.idVenta;