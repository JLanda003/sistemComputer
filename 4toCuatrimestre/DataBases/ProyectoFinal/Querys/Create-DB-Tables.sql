DROP database if exists TecnologiaMundo_DB;
-- CREAMOS LA BASE DE DATOS
CREATE SCHEMA IF NOT EXISTS `TecnologiaMundo_DB` DEFAULT CHARACTER SET UTF8MB4;

-- CREAMOS LA TABLA DE CLIENTES
CREATE TABLE IF NOT EXISTS `TecnologiaMundo_DB`.`Clientes` (
  `idCliente` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `apellido` VARCHAR(45) NULL,
  `correo` VARCHAR(45) NOT NULL,
  `fechaCreacion` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`idCliente`),
  UNIQUE INDEX `correo_UNIQUE` (`correo` ASC) VISIBLE
);

-- CREAMOS LA TABLA DE SUCURSALES
CREATE TABLE IF NOT EXISTS `TecnologiaMundo_DB`.`Sucursales` (
  `idSucursal` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `ciudad` VARCHAR(45) NOT NULL,
  `fechaCreacion` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`idSucursal`),
  UNIQUE INDEX `nombre_UNIQUE` (`nombre` ASC) VISIBLE
);

-- CREAMOS LA TABLA DE VENDEDORES **DEBE SER CREADA DESPUES DE LA TABLA DE SUCURSALES
CREATE TABLE IF NOT EXISTS `TecnologiaMundo_DB`.`Vendedores` (
  `idVendedor` INT NOT NULL AUTO_INCREMENT,
  `idSucursal` INT NOT NULL,
  `nombre` VARCHAR(45) NOT NULL,
  `apellido` VARCHAR(45) NULL,
  `fechaCreacion` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`idVendedor`),
  INDEX `idSucursal_idx` (`idSucursal` ASC) VISIBLE,
  CONSTRAINT `idSucursal`
    FOREIGN KEY (`idSucursal`)
    REFERENCES `TecnologiaMundo_DB`.`Sucursales` (`idSucursal`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
);

-- CREAMOS LA TABLA DE VENTAS **DEBE SER CREADA DESPUES DE LOS VENDEDORES Y LOS CLIENTES
CREATE TABLE IF NOT EXISTS `TecnologiaMundo_DB`.`Ventas` (
  `idVenta` INT NOT NULL AUTO_INCREMENT,
  `fechaVenta` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `idCliente` INT NOT NULL,
  `idVendedor` INT NOT NULL,
  `fechaCreacion` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`idVenta`),
  INDEX `idCliente_idx` (`idCliente` ASC) VISIBLE,
  INDEX `idVendedor_idx` (`idVendedor` ASC) VISIBLE,
  CONSTRAINT `idCliente`
    FOREIGN KEY (`idCliente`)
    REFERENCES `TecnologiaMundo_DB`.`Clientes` (`idCliente`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `idVendedor`
    FOREIGN KEY (`idVendedor`)
    REFERENCES `TecnologiaMundo_DB`.`Vendedores` (`idVendedor`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
);

-- CREAMOS LA TABLA DE CATEGORIAS
CREATE TABLE IF NOT EXISTS `TecnologiaMundo_DB`.`Categorias` (
  `idCategoria` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NOT NULL,
  `fechaCreacion` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`idCategoria`),
  UNIQUE INDEX `nombre_UNIQUE` (`nombre` ASC) VISIBLE
);

-- CREAMOS LA TABLA DE PRODUCTO **DEBE SER CREADA DESPUES DE LA TABLA DE CATEGORIAS
CREATE TABLE IF NOT EXISTS `TecnologiaMundo_DB`.`Productos` (
  `idProducto` INT NOT NULL AUTO_INCREMENT,
  `idCategoria` INT NOT NULL,
  `tipo` VARCHAR(45) NOT NULL,
  `marca` VARCHAR(45) NOT NULL,
  `modelo` VARCHAR(45) NOT NULL,
  `precioUnitario` INT NOT NULL,
  `fechaCreacion` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`idProducto`),
  UNIQUE INDEX `modelo_UNIQUE` (`modelo` ASC) VISIBLE,
  INDEX `idCategoria_idx` (`idCategoria` ASC) VISIBLE,
  CONSTRAINT `idCategoria`
    FOREIGN KEY (`idCategoria`)
    REFERENCES `TecnologiaMundo_DB`.`Categorias` (`idCategoria`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
);

-- CREAMOS LA TABLA DE DETALLEVENTAS ** DEBE SER CREADA HASTA EL FINAL
CREATE TABLE IF NOT EXISTS `TecnologiaMundo_DB`.`DetalleVentas` (
  `idDetalleVenta` INT NOT NULL AUTO_INCREMENT,
  `idProducto` INT NOT NULL,
  `cantidad` INT NOT NULL,
  `idVenta` INT NOT NULL,
  `fechaCreacion` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`idDetalleVenta`),
  INDEX `idProducto_idx` (`idProducto` ASC) VISIBLE,
  INDEX `idVenta_idx` (`idVenta` ASC) VISIBLE,
  CONSTRAINT `idProducto`
    FOREIGN KEY (`idProducto`)
    REFERENCES `TecnologiaMundo_DB`.`Productos` (`idProducto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `idVenta`
    FOREIGN KEY (`idVenta`)
    REFERENCES `TecnologiaMundo_DB`.`Ventas` (`idVenta`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
);