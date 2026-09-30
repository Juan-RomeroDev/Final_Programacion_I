-- ============================================
-- BASE DE DATOS PUNTO DE VENTA  
-- ============================================

CREATE DATABASE Final_Punto_Venta_Programacion_I

-- ============================================
-- USAR BASE DE DATOS PUNTO DE VENTA  
-- ============================================

USE Final_Punto_Venta_Programacion_I

-- ============================================
-- TABLAS PUNTO VENTA "PADRE"
-- ============================================

CREATE TABLE forma_de_pago (
	id_forma_pago INT  PRIMARY KEY,  
	descrip_forma_pago NVARCHAR (60)
);

CREATE TABLE localidades (
	cp INT  PRIMARY KEY, 
	localidad NVARCHAR (60)
);

CREATE TABLE rubros (
	id_rubro INT  PRIMARY KEY,  
	descrip_rubro NVARCHAR (60)
);

CREATE TABLE usuarios ( 
	id_usuario INT  PRIMARY KEY, 
	usuario NVARCHAR (60),
	psw NVARCHAR (60)
); 

-- ============================================
-- TABLAS PUNTO VENTA "HIJOS"
-- ============================================

CREATE TABLE clientes (
	id_cliente INT  PRIMARY KEY,
	razon_social NVARCHAR (60),
	cp INT  FOREIGN KEY REFERENCES localidades(cp),
	mail NVARCHAR (60),
	telefono NVARCHAR (60)
); 

CREATE TABLE productos ( 
	id_producto INT  PRIMARY KEY, 
	descripcion NVARCHAR (60),
	precio DECIMAL(10,2),
	stock INT , 
	id_rubro INT  FOREIGN KEY REFERENCES rubros(id_rubro)
);

-- ============================================
-- TABLAS PUNTO VENTA QUE DEPENDE DE PADRE E HIJOS
-- ============================================

CREATE TABLE ventas (
	id_venta INT  PRIMARY KEY, 
	fecha DATE,
	id_forma_pago INT  FOREIGN KEY REFERENCES forma_de_pago(id_forma_pago),
	id_cliente INT  FOREIGN KEY REFERENCES clientes(id_cliente),
	id_usuario INT  FOREIGN KEY REFERENCES usuarios(id_usuario),
	total DECIMAL(10,2) 
);

CREATE TABLE detalle_venta (
	id_venta INT , 
	id_producto INT ,
	id_fila INT , --ID FILA 
	precio DECIMAL(10,2),
	cantidad INT , 
	precio_r DECIMAL(10,2), --PRECIO DE RENGLON

	 PRIMARY KEY (id_venta, id_producto, id_fila),
	 FOREIGN KEY (id_venta) REFERENCES ventas(id_venta),
     FOREIGN KEY (id_producto) REFERENCES productos(id_producto)
);

-- ============================================
-- PROCEDIMIENTOS ALMACENADOS FORMA PAGO 
-- ============================================

--MOSTRAR FORMAS PAGO 
GO
CREATE PROCEDURE spu_mostrar_forma_pago
AS
BEGIN
     SELECT id_forma_pago AS ID_FORMA_PAGO, descrip_forma_pago AS DESCRIPCION_FORMA_PAGO FROM forma_de_pago
END 
GO 

--ALTA FORMAS PAGO
GO 
CREATE PROCEDURE spu_alta_forma_de_pago
   @id_forma_pago INT ,
   @descrip_forma_pago NVARCHAR(60)
AS
BEGIN
    INSERT INTO forma_de_pago (id_forma_pago, descrip_forma_pago) VALUES (@id_forma_pago, @descrip_forma_pago);
END;


--MODIFICAR FORMAS PAGO 
CREATE PROCEDURE spu_modificar_forma_de_pago
   @id_forma_pago INT ,
   @descrip_forma_pago NVARCHAR(60)
AS
BEGIN 
  UPDATE forma_de_pago SET descrip_forma_pago = @descrip_forma_pago 
  WHERE id_forma_pago = @id_forma_pago;
END;

--ELIMINAR FORMAS PAGO 
CREATE PROCEDURE spu_baja_forma_de_pago
     @id_forma_pago INT 
AS
BEGIN
   DELETE FROM forma_de_pago 
   WHERE id_forma_pago = @id_forma_pago;
END;

-- GENERAR +1 AL FORMA PAGO 
CREATE PROCEDURE spu_generar_id_forma_de_pago
AS 
BEGIN 
     SELECT MAX(id_forma_pago) + 1 AS Nuevo_ID FROM forma_de_pago; 
END;

-- ============================================
-- PROCEDIMIENTOS ALMACENADOS LOCALIDADES
-- ============================================

--MOSTRAR LOCALIDADES
GO
CREATE PROCEDURE spu_mostrar_localidades
AS
BEGIN
     SELECT cp CP, localidad LOCALIDAD FROM localidades
END 
GO 

--ALTA LOCALIDADES
CREATE PROCEDURE spu_alta_localidad
   @cp INT ,
   @localidad NVARCHAR(60)
AS
BEGIN
    INSERT INTO localidades (cp, localidad) VALUES (@cp, @localidad);
END;

--MODIFICAR LOCALIDADES
CREATE PROCEDURE spu_modificar_localidad
   @cp INT ,
   @localidad NVARCHAR(60)
AS
BEGIN 
  UPDATE localidades SET localidad = @localidad WHERE cp = @cp;
END;


--ELIMINAR LOCALIDADES
CREATE PROCEDURE spu_baja_localidad
    @cp INT 
AS
BEGIN
   DELETE FROM localidades WHERE cp = @cp;
END;


-- ============================================
-- PROCEDIMIENTOS ALMACENADOS LOCALIDADES BUSCAR X CP - LOCALIDADES 
-- ============================================

--BUSCAR CP LOCALIDADES
CREATE PROCEDURE spu_buscar_localidad_X_cp
    @cp INT 
AS
BEGIN
    SELECT cp CP, localidad LOCALIDAD FROM localidades 
    WHERE cp = @cp;
END;


--BUSCAR LOCALIDAD LOCALIDADES
CREATE PROCEDURE spu_buscar_localidad_X_localidad
   @localidad NVARCHAR(60)
AS
BEGIN 
    SELECT cp CP, localidad LOCALIDAD FROM localidades 
    WHERE localidad LIKE '%' + @localidad + '%'; 
END;

-- ============================================
-- PROCEDIMIENTOS ALMACENADOS RUBROS
-- ============================================

--MOSTRAR RUBROS 
GO
CREATE PROCEDURE spu_mostrar_rubros
AS
BEGIN
     SELECT id_rubro ID_RUBRO, descrip_rubro DESCRIPCION_RUBRO FROM rubros
END 
GO 

--ALTA RUBROS
CREATE PROCEDURE spu_alta_rubro
   @id_rubro INT ,
   @descrip_rubro NVARCHAR(60)
AS
BEGIN
    INSERT INTO rubros (id_rubro, descrip_rubro) 
	VALUES (@id_rubro, @descrip_rubro);
END;

--MODIFICAR RUBROS
CREATE PROCEDURE spu_modificar_rubro
   @id_rubro INT ,
   @descrip_rubro NVARCHAR(60)
AS
BEGIN 
  UPDATE rubros SET descrip_rubro = @descrip_rubro 
  WHERE id_rubro = @id_rubro;
END;

--ELIMINAR RUBROS
CREATE PROCEDURE spu_baja_rubro
    @id_rubro INT 
AS
BEGIN
   DELETE FROM rubros WHERE id_rubro = @id_rubro;
END;

-- GENERAR +1 AL RUBRO
CREATE PROCEDURE spu_generar_id_rubro
AS 
BEGIN 
     SELECT MAX(id_rubro) + 1 AS Nuevo_ID FROM rubros;
END;

-- ============================================
-- PROCEDIMIENTOS ALMACENADOS CLIENTES
-- ============================================

--MOSTRAR CLIENTES
CREATE PROCEDURE spu_mostrar_clientes
AS
BEGIN
     SELECT 
			id_cliente AS ID_CLIENTE, 
			razon_social AS RAZON_SOCIAL,  
			cp AS CP,
			mail AS MAIL, 
			telefono AS TELEFONO
	 FROM clientes
END; 


--ALTA CLIENTES
CREATE PROCEDURE spu_alta_clientes
   @id_cliente INT ,
   @razon_social NVARCHAR(60),
   @cp INT ,
   @mail NVARCHAR(60),
   @telefono NVARCHAR(60)
AS
BEGIN
    INSERT INTO clientes (id_cliente, razon_social, cp, mail, telefono) 
		VALUES (@id_cliente, @razon_social, @cp, @mail, @telefono);
END;

--MODIFICAR CLIENTES
CREATE PROCEDURE spu_modificar_clientes
   @id_cliente INT,
   @razon_social NVARCHAR(60),
   @cp INT,
   @mail NVARCHAR(60),
   @telefono NVARCHAR(60)
AS
BEGIN 
		UPDATE clientes 
		SET razon_social = @razon_social, cp = @cp, mail = @mail, telefono = @telefono
		WHERE id_cliente = @id_cliente;
END;

--ELIMINAR CLIENTES
CREATE PROCEDURE spu_baja_cliente
    @id_cliente INT
AS
BEGIN
   DELETE FROM clientes WHERE id_cliente = @id_cliente;
END;

-- GENERAR +1 AL ID_CLIENTE
CREATE PROCEDURE spu_generar_id_cliente
AS 
BEGIN 
     SELECT MAX(id_cliente) + 1 AS Nuevo_ID FROM clientes;
END;

-- ============================================
-- PROCEDIMIENTOS ALMACENADOS PRODUCTOS 
-- ============================================

--MOSTRAR PRODUCTOS
CREATE PROCEDURE spu_mostrar_productos
AS
BEGIN
     SELECT 
			id_producto AS ID_PRODUCTO,
			descripcion AS DESCRIPCION, 
			precio AS PRECIO,
			stock AS STOCK,
			id_rubro AS ID_RUBRO 
	 FROM productos
END; 


--ALTA PRODUCTOS
CREATE PROCEDURE spu_alta_producto
   @id_producto INT,
   @descripcion NVARCHAR(60), 
   @precio DECIMAL(10,2),
   @stock INT,
   @id_rubro INT  
AS
BEGIN
    INSERT INTO productos (id_producto, descripcion, precio, stock, id_rubro) 
		VALUES (@id_producto, @descripcion, @precio, @stock, @id_rubro);
END;

--MODIFICAR PRODUCTOS
CREATE PROCEDURE spu_modificar_producto
	@id_producto INT,
	@descripcion NVARCHAR(60), 
	@precio DECIMAL(10,2),
	@stock INT,
	@id_rubro INT  
AS
BEGIN 
	UPDATE productos
	SET descripcion = @descripcion, precio = @precio, stock = @stock, id_rubro = @id_rubro
	WHERE id_producto = @id_producto;
END;

--ELIMINAR PRODUCTOS
CREATE PROCEDURE spu_baja_producto
    @id_producto INT 
AS
BEGIN
   DELETE FROM productos WHERE id_producto = @id_producto;
END;

-- GENERAR +1 AL ID_PRODUCTO
CREATE PROCEDURE spu_generar_id_producto
AS 
BEGIN 
     SELECT MAX(id_producto) + 1 AS Nuevo_ID FROM productos;
END;

-- ============================================
-- PROCEDIMIENTOS ALMACENADOS VENTAS
-- ============================================

--MOSTRAR VENTAS
CREATE PROCEDURE spu_mostrar_ventas
AS
BEGIN
     SELECT 
			id_venta AS ID_VENTA,
			fecha AS FECHA, 
			id_forma_pago AS ID_FORMA_PAGO, 
			id_cliente AS ID_CLIENTE,
			id_usuario AS ID_USUARIO,
			total AS TOTAL 
	 FROM ventas
END; 


--ALTA VENTAS
CREATE PROCEDURE spu_alta_ventas
			@id_venta INT,
			@id_forma_pago INT, 
			@id_cliente INT,
			@id_usuario INT,
			@total DECIMAL(10,2)   
AS
BEGIN
    INSERT INTO ventas (id_venta, fecha, id_forma_pago, id_cliente, id_usuario, total) 
		VALUES (@id_venta, GETDATE(), @id_forma_pago, @id_cliente, @id_usuario, @total);
END;

--MODIFICAR VENTAS
CREATE PROCEDURE spu_modificar_ventas
			@id_venta INT,
			@id_forma_pago INT, 
			@id_cliente INT,
			@id_usuario INT,
			@total DECIMAL(10,2) 
AS
BEGIN 
	UPDATE ventas
	SET id_forma_pago = @id_forma_pago, id_cliente = @id_cliente, id_usuario = @id_usuario, total = @total
	WHERE id_venta = @id_venta;
END;

--ELIMINAR VENTAS
CREATE PROCEDURE spu_baja_ventas
    @id_venta INT 
AS
BEGIN
   DELETE FROM ventas WHERE id_venta = @id_venta;
END;

-- GENERAR +1 AL ID_VENTA
CREATE PROCEDURE spu_generar_id_venta
AS 
BEGIN 
     SELECT MAX(id_venta) + 1 AS Nuevo_ID FROM ventas;
END;

-- ============================================
-- PROCEDIMIENTOS ALMACENADOS DETALLE_VENTA
-- ============================================

--MOSTRAR DETALLE_VENTAS
CREATE PROCEDURE spu_mostrar_detalle_venta
AS
BEGIN
     SELECT 
			id_venta AS ID_VENTA,
			id_producto AS ID_PRODUCTO, 
			id_fila AS ID_FILA, 
			precio AS PRECIO,
			cantidad AS CANTIDAD,
			precio_r AS PRECIO_RENGLON 
	 FROM detalle_venta
END; 


--ALTA DETALLE_VENTAS
CREATE PROCEDURE spu_alta_detalle_venta
			@id_venta INT,
			@id_producto INT, 
			@id_fila INT, 
			@precio DECIMAL(10,2),
			@cantidad INT,
			@precio_r DECIMAL(10,2)  
AS
BEGIN
    INSERT INTO detalle_venta (id_venta, id_producto, id_fila, precio, cantidad, precio_r) 
		VALUES (@id_venta, @id_producto, @id_fila, @precio, @cantidad, @precio_r);
END;

--MODIFICAR DETALLE_VENTAS
CREATE PROCEDURE spu_modificar_detalle_venta
			@id_venta INT,
			@id_producto INT, 
			@id_fila INT, 
			@precio DECIMAL(10,2),
			@cantidad INT,
			@precio_r DECIMAL(10,2) 
AS
BEGIN 
	UPDATE detalle_venta
	-- NO ACTUALIZO LAS CLAVES PRIMARIAS SOLO LOS DATOS QUE YA TIENE LA TABLA PORQUE SON CLAVES PRIMARIAS COMPUESTAS DE OTRAS TABLAS 
	SET precio = @precio, cantidad = @cantidad, precio_r = @precio_r
	WHERE id_venta = @id_venta AND id_producto = @id_producto AND id_fila = @id_fila;
	-- ACORDATE QUE PARA LAS CLAVES PRIMARIAS COMPUESTAS DEBES USAR AND PARA CONCATENAR LAS CLAVES DECLARADAS NECESARIAS
END;

--ELIMINAR VENTAS
CREATE PROCEDURE spu_baja_detalle_venta
--TRES CLAVES PRIMARIAS SE TIENEN QUE SELECCIONAR PARA ELIMINAR 
	@id_venta INT,
	@id_producto INT,
	@id_fila INT 
AS
BEGIN
   DELETE FROM detalle_venta 
   WHERE id_venta = @id_venta AND id_producto = @id_producto AND id_fila = @id_fila;
   --LO MISMO PARA ESTE WHERE, NECESITA ENCONTRAR LAS TRES CLAVES PRIMARIAS
END;

-- GENERAR +1 AL ID_FILA (POR CADA VENTA)
CREATE PROCEDURE spu_generar_id_fila
		@id_venta INT 
AS 
BEGIN 
     SELECT ISNULL(MAX(id_fila), 0) + 1 AS Nuevo_ID 
	 FROM detalle_venta
	 WHERE id_venta = @id_venta;
END;

-- ============================================
-- PROCEDIMIENTO ALMACENADO BACKUP Final_Punto_Venta_Programacion_I
-- ============================================

--BACKUP DE BASE DE DATOS 
CREATE PROCEDURE spu_backup_full
AS
BEGIN
    DECLARE @MyFileName VARCHAR(1000)
    SELECT @MyFileName = 'C:\Proyectos_Izo\TI\BD\Backup\Final_Punto_Venta\Punto_Venta_Final.bak'
    BACKUP DATABASE Final_Punto_Venta_Programacion_I 
    TO DISK = @MyFileName
END;
GO

