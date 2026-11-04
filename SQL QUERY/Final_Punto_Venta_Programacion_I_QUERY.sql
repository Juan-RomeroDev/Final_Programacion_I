-- ============================================
-- BASE DE DATOS PUNTO DE VENTA  
-- ============================================
GO
--CREATE DATABASE Final_Punto_Venta_Programacion_I
GO
-- ============================================
-- USAR BASE DE DATOS PUNTO DE VENTA  
-- ============================================
GO
USE Final_Punto_Venta_Programacion_I
GO
-- ============================================
-- TABLAS PUNTO VENTA "PADRE"  (TODOS LOS ABM DE LAS TABLAS (EXC usuarios))
-- ============================================

/*CREATE TABLE forma_de_pago (
	id_forma_pago INT PRIMARY KEY,  
	descrip_forma_pago NVARCHAR (60) NOT NULL
);*/

/*CREATE TABLE localidades (
	cp INT PRIMARY KEY, 
	localidad NVARCHAR (60) NOT NULL
);*/

/*CREATE TABLE rubros (
	id_rubro INT PRIMARY KEY,  
	descrip_rubro NVARCHAR (60) NOT NULL
);*/

/*CREATE TABLE usuarios ( 
	id_usuario INT PRIMARY KEY, 
	usuario NVARCHAR (60) NOT NULL,
	psw NVARCHAR (60) NOT NULL
);*/ 

-- ============================================
-- TABLAS PUNTO VENTA "HIJOS"
-- ============================================

/*CREATE TABLE clientes (
	id_cliente INT PRIMARY KEY,
	razon_social NVARCHAR (60) NOT NULL,
	cp INT NOT NULL FOREIGN KEY REFERENCES localidades(cp),
	mail NVARCHAR (60),
	telefono NVARCHAR (60)
);*/ 

/*CREATE TABLE productos ( 
	id_producto INT PRIMARY KEY, 
	descripcion NVARCHAR (60) NOT NULL,
	precio DECIMAL(10,2) NOT NULL,
	stock DECIMAL(10,3) NOT NULL, 
	id_rubro INT NOT NULL FOREIGN KEY REFERENCES rubros(id_rubro)
);*/

-- ============================================
-- TABLAS PUNTO VENTA QUE DEPENDE DE PADRE E HIJOS
-- ============================================

/*CREATE TABLE ventas (
	id_venta INT  PRIMARY KEY, 
	fecha DATE NOT NULL,
	id_forma_pago INT NOT NULL FOREIGN KEY REFERENCES forma_de_pago(id_forma_pago),
	id_cliente INT NOT NULL FOREIGN KEY REFERENCES clientes(id_cliente),
	id_usuario INT NOT NULL FOREIGN KEY REFERENCES usuarios(id_usuario),
	total DECIMAL(10,2) NOT NULL
);  */

/*CREATE TABLE detalle_venta (
	id_venta INT, 
	id_producto INT,
	id_fila INT, --ID FILA 
	precio DECIMAL(10,2) NOT NULL,
	cantidad DECIMAL(10,3) NOT NULL, 
	precio_r DECIMAL(10,2) NOT NULL, --PRECIO DE RENGLON
	-- EL PRECIO DE RENGLON PODES MULTIPLICARLO PRECIO X CANTIDAD = PRECIO RENGLON, ENTONCES POR ACA O POR CODIGO SE PUEDE HACER 

	 PRIMARY KEY (id_venta, id_producto, id_fila),
	 FOREIGN KEY (id_venta) REFERENCES ventas(id_venta),
     FOREIGN KEY (id_producto) REFERENCES productos(id_producto)
);
GO*/
-- ============================================
-- PROCEDIMIENTOS ALMACENADOS FORMA PAGO 
-- ============================================

--MOSTRAR FORMAS PAGO 
GO
CREATE PROCEDURE spu_mostrar_forma_pago
AS
BEGIN
     SELECT id_forma_pago AS ID_FORMA_PAGO, descrip_forma_pago AS DESCRIPCION_FORMA_PAGO FROM forma_de_pago
END; 
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
GO

--MODIFICAR FORMAS PAGO 
GO
CREATE PROCEDURE spu_modificar_forma_de_pago
   @id_forma_pago INT ,
   @descrip_forma_pago NVARCHAR(60)
AS
BEGIN 
  UPDATE forma_de_pago SET descrip_forma_pago = @descrip_forma_pago 
  WHERE id_forma_pago = @id_forma_pago;
END;
GO

--ELIMINAR FORMAS PAGO
Go
CREATE PROCEDURE spu_baja_forma_de_pago
     @id_forma_pago INT 
AS
BEGIN
   DELETE FROM forma_de_pago 
   WHERE id_forma_pago = @id_forma_pago;
END;
GO

-- GENERAR +1 AL FORMA PAGO
GO
CREATE PROCEDURE spu_generar_id_forma_de_pago
AS 
BEGIN 
     SELECT ISNULL(MAX(id_forma_pago), 0) + 1 AS Nuevo_ID FROM forma_de_pago; 
END;
GO

-- ============================================
-- PROCEDIMIENTOS ALMACENADOS LOCALIDADES
-- ============================================

--MOSTRAR LOCALIDADES
GO
CREATE PROCEDURE spu_mostrar_localidades
AS
BEGIN
     SELECT cp CP, localidad LOCALIDAD FROM localidades
END; 
GO 

--ALTA LOCALIDADES
GO
CREATE PROCEDURE spu_alta_localidad
   @cp INT ,
   @localidad NVARCHAR(60)
AS
BEGIN
    INSERT INTO localidades (cp, localidad) VALUES (@cp, @localidad);
END;
GO

--MODIFICAR LOCALIDADES
GO
CREATE PROCEDURE spu_modificar_localidad
   @cp INT ,
   @localidad NVARCHAR(60)
AS
BEGIN 
  UPDATE localidades SET localidad = @localidad WHERE cp = @cp;
END;
GO

--ELIMINAR LOCALIDADES
GO
CREATE PROCEDURE spu_baja_localidad
    @cp INT 
AS
BEGIN
   DELETE FROM localidades WHERE cp = @cp;
END;
GO

-- ============================================
-- PROCEDIMIENTOS ALMACENADOS BUSCAR
-- ============================================


-- ============================================
-- BUSCAR VENTAS TODO JUNTO 
-- ============================================

CREATE PROCEDURE spu_buscar_ventas_cruzado
    @usuario VARCHAR(50),
    @rubro VARCHAR(50),
    @producto VARCHAR(100),
    @cliente VARCHAR(100),
    @detalle VARCHAR(100),
    @localidad VARCHAR(100),
    @formaPago VARCHAR(50),
    @fechaDesde DATE,
    @fechaHasta DATE
AS
BEGIN
    SELECT 
        ventas.id_venta AS ID_VENTA,
        ventas.fecha AS FECHA,
        clientes.razon_social AS CLIENTE,
        productos.descripcion AS PRODUCTOS,
        rubros.descrip_rubro AS RUBRO,
        detalle_venta.cantidad AS CANTIDAD,
        detalle_venta.precio AS PRECIO,
        detalle_venta.precio_r AS SUBTOTAL, 
        forma_de_pago.descrip_forma_pago AS FORMA_PAGO,
        localidades.localidad AS LOCALIDAD,
        usuarios.usuario AS USUARIO 
    FROM ventas
    
    INNER JOIN clientes ON ventas.id_cliente = clientes.id_cliente
	
    INNER JOIN detalle_venta ON ventas.id_venta = detalle_venta.id_venta
	
    INNER JOIN productos ON detalle_venta.id_producto = productos.id_producto
	
    INNER JOIN rubros ON productos.id_rubro = rubros.id_rubro
	
    INNER JOIN localidades ON clientes.cp = localidades.cp
	
    INNER JOIN forma_de_pago ON ventas.id_forma_pago = forma_de_pago.id_forma_pago
	
    INNER JOIN usuarios ON ventas.id_usuario = usuarios.id_usuario
    
    WHERE (@usuario = '' OR usuarios.usuario LIKE '%' + @usuario + '%')
      AND (@rubro = '' OR rubros.descrip_rubro LIKE '%' + @rubro + '%')
      AND (@producto = '' OR productos.descripcion LIKE '%' + @producto + '%')
      AND (@cliente = '' OR clientes.razon_social LIKE '%' + @cliente + '%')
      AND (@detalle = '' OR detalle_venta.id_fila LIKE '%' + @detalle + '%')
      AND (@localidad = '' OR localidades.localidad LIKE '%' + @localidad + '%')
      AND (@formaPago = '' OR forma_de_pago.descrip_forma_pago LIKE '%' + @formaPago + '%')
      AND (ventas.fecha BETWEEN @fechaDesde AND @fechaHasta)
END;

-- ============================================
-- PROCEDIMIENTOS ALMACENADOS LOCALIDADES BUSCAR X CP - LOCALIDADES 
-- ============================================

--BUSCAR CP LOCALIDADES
GO
CREATE PROCEDURE spu_buscar_localidad_X_cp
    @cp INT 
AS
BEGIN
    SELECT cp CP, localidad LOCALIDAD FROM localidades 
    WHERE cp = @cp;
END;
GO

--BUSCAR LOCALIDAD LOCALIDADES
GO
CREATE PROCEDURE spu_buscar_localidad_X_localidad
   @localidad NVARCHAR(60)
AS
BEGIN 
    SELECT cp CP, localidad LOCALIDAD FROM localidades 
    WHERE localidad LIKE '%' + @localidad + '%'; 
END;
GO

-- ============================================
-- PROCEDIMIENTOS ALMACENADOS BUSCAR 
-- ============================================

-- ============================================
-- BUSCAR CLIENTE X VENTA  -- PANTALLA 21/10/26 
-- ============================================
GO
CREATE PROCEDURE spu_buscar_cliente_X_venta
	@razon_social NVARCHAR (60)
AS 
BEGIN 	
	SELECT
		clientes.id_cliente AS ID_CLIENTE,
		clientes.razon_social AS RAZON_SOCIAL,
		localidades.localidad AS LOCALIDAD,
		clientes.mail AS MAIL, 
		clientes.telefono AS TELEFONO
	FROM clientes  
	INNER JOIN localidades ON clientes.cp = localidades.cp
	WHERE razon_social LIKE '%' + @razon_social + '%';
END;
GO	

-- ============================================
-- BUSCAR FORMA PAGO --PANTALLA 20/10/26
-- ============================================
GO
CREATE PROCEDURE spu_buscar_forma_pago
	@descrip_forma_pago NVARCHAR (60)
AS 
BEGIN 
	SELECT 
		id_forma_pago AS ID_FORMA_PAGO,
		descrip_forma_pago AS FORMA_PAGO 
	FROM forma_de_pago	
	WHERE descrip_forma_pago LIKE '%' + @descrip_forma_pago + '%';
END;
GO
-- ============================================
-- BUSCAR FORMA PAGO X VENTA  21/10/26
-- ============================================
GO
CREATE PROCEDURE spu_buscar_forma_pago_X_venta
	@descrip_forma_pago NVARCHAR (60) 
AS 
BEGIN 
	SELECT 
		ventas.id_venta AS NRO_VENTA, 
		ventas.fecha AS FECHA,
		forma_de_pago.descrip_forma_pago AS FORMA_PAGO 
	FROM ventas	
	INNER JOIN forma_de_pago ON forma_de_pago.id_forma_pago = ventas.id_forma_pago
	WHERE forma_de_pago.descrip_forma_pago LIKE '%' + @descrip_forma_pago + '%';
END;
GO
-- ============================================
-- BUSCAR PRODUCTO X PRODUCTO --PANTALLA 20/10/26
-- ============================================
GO
CREATE PROCEDURE spu_buscar_producto_X_producto 
	@descripcion NVARCHAR (60)
AS 
BEGIN 
	SELECT 
		productos.id_producto AS ID_PRODUCTO,
		productos.descripcion AS PRODUCTO,
		productos.precio AS PRECIO, 
		productos.stock AS STOCK,
		rubros.id_rubro AS ID_RUBRO,
		rubros.descrip_rubro AS RUBRO
	FROM productos 
	INNER JOIN rubros ON productos.id_rubro = rubros.id_rubro
	WHERE productos.descripcion LIKE '%' + @descripcion + '%';
	
END;
GO

-- ============================================
-- BUSCAR PRODUCTO X DETALLE VENTA --  PANTALLA 21/10/26 
-- ============================================
GO
CREATE PROCEDURE spu_buscar_producto_X_detalle_venta
	@descripcion NVARCHAR (60)
AS
BEGIN 
	SELECT
		detalle_venta.id_venta AS ID_VENTA,
		detalle_venta.id_producto AS ID_PRODUCTO,
		productos.descripcion AS PRODUCTO	
	FROM detalle_venta
	INNER JOIN productos ON detalle_venta.id_producto = productos.id_producto
	WHERE productos.descripcion LIKE '%' + @descripcion + '%';
END;
GO
-- ============================================
-- BUSCAR RUBRO  -- PANTALLA 20/10/26
-- ============================================
GO
CREATE PROCEDURE spu_buscar_rubro
	@descrip_rubro NVARCHAR (60)
AS
BEGIN 
	SELECT 
		id_rubro AS ID_RUBRO,
		descrip_rubro AS RUBRO
	FROM rubros
	WHERE rubros.descrip_rubro LIKE '%' + @descrip_rubro + '%';
END;
GO
-- ============================================
-- BUSCAR RUBRO x PRODUCTO -- PANTALLA 20/10/26
-- ============================================
GO
CREATE PROCEDURE spu_buscar_rubro_X_producto
	@descrip_rubro NVARCHAR (60)
AS 
BEGIN 
	SELECT 
		productos.id_producto AS ID_PRODUCTO,
        productos.descripcion AS DESCRIPCION,
        productos.precio AS PRECIO,
        productos.stock AS STOCK,
        rubros.id_rubro AS ID_RUBRO,
        rubros.descrip_rubro AS DESCRIPCION_RUBRO
	FROM productos --A
	INNER JOIN rubros /*B*/ ON productos.id_rubro = rubros.id_rubro
	WHERE rubros.descrip_rubro LIKE '%' + @descrip_rubro + '%';	
END;
GO
-- ============================================
-- BUSCAR USUARIO x VENTA --PANTALLAS 20/10/26
-- ============================================
GO
CREATE PROCEDURE spu_buscar_usuario_X_venta 
	@usuario NVARCHAR (60)
AS 
BEGIN 
	SELECT 
		usuarios.id_usuario AS ID_USUARIO,
		usuarios.usuario AS USUARIO,
		ventas.id_venta AS ID_VENTA 
	FROM ventas 
	INNER JOIN usuarios ON ventas.id_usuario = usuarios.id_usuario
	WHERE usuarios.usuario LIKE '%' + @usuario + '%';
END;
GO
-- ============================================
-- BUSCAR VENTAS x FECHA -- PANTALLA 20/10/26
-- ============================================
GO
CREATE PROCEDURE spu_buscar_ventas_X_fecha
	@fecha DATE
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
	WHERE ventas.fecha = @fecha 
	ORDER BY fecha ASC;
END; 
GO
-- ============================================
-- BUSCAR VENTAS x RUBRO -- PANTALLA 20/10/26
-- ============================================
GO
CREATE PROCEDURE spu_buscar_ventas_X_rubro
    @descrip_rubro NVARCHAR(60)
AS
BEGIN
    SELECT 
        ventas.id_venta AS NRO_VENTA,
        ventas.fecha AS FECHA,
        rubros.descrip_rubro AS RUBRO,
        productos.descripcion AS PRODUCTO,
        detalle_venta.precio AS PRECIO_UNITARIO,
        detalle_venta.cantidad AS CANTIDAD,
        detalle_venta.precio_r AS PRECIO_RENGLON
    FROM ventas
    INNER JOIN detalle_venta ON ventas.id_venta = detalle_venta.id_venta
    INNER JOIN productos ON detalle_venta.id_producto = productos.id_producto
    INNER JOIN rubros ON productos.id_rubro = rubros.id_rubro
    WHERE rubros.descrip_rubro LIKE '%' + @descrip_rubro + '%'
    ORDER BY ventas.fecha DESC;
END;
GO


-- ============================================
-- PROCEDIMIENTOS ALMACENADOS RUBROS
-- ============================================

--MOSTRAR RUBROS 
GO
CREATE PROCEDURE spu_mostrar_rubros
AS
BEGIN
     SELECT id_rubro ID_RUBRO, descrip_rubro DESCRIPCION_RUBRO FROM rubros;
END; 
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
GO

--MODIFICAR RUBROS
CREATE PROCEDURE spu_modificar_rubro
   @id_rubro INT ,
   @descrip_rubro NVARCHAR(60)
AS
BEGIN 
  UPDATE rubros SET descrip_rubro = @descrip_rubro 
  WHERE id_rubro = @id_rubro;
END;
GO

--ELIMINAR RUBROS
GO
CREATE PROCEDURE spu_baja_rubro
    @id_rubro INT 
AS
BEGIN
   DELETE FROM rubros WHERE id_rubro = @id_rubro;
END;
GO

-- GENERAR +1 AL RUBRO
CREATE PROCEDURE spu_generar_id_rubro
AS 
BEGIN 
     SELECT ISNULL(MAX(id_rubro), 0) + 1 AS Nuevo_ID FROM rubros;
END;
GO
-- ============================================
-- PROCEDIMIENTOS ALMACENADOS USUARIOS
-- ============================================

-- MOSTRAR USUARIOS
GO
CREATE PROCEDURE spu_mostrar_usuarios
AS 
BEGIN 
	SELECT id_usuario AS ID_USUARIO, usuario AS USUARIO, psw AS PSW 
	FROM usuarios;
END;
GO

-- VALIDAR USUARIOS LOGIN
GO
CREATE PROCEDURE spu_validar_usuario
	@usuario NVARCHAR(60),
	@psw NVARCHAR(60)
AS
BEGIN
	SELECT id_usuario AS ID_USUARIO, usuario AS USUARIO
	FROM usuarios
	WHERE usuario = @usuario AND psw = @psw;
END;
GO

-- ============================================
-- PROCEDIMIENTOS ALMACENADOS CLIENTES
-- ============================================

--MOSTRAR CLIENTES
GO
CREATE PROCEDURE spu_mostrar_clientes
AS
BEGIN
     SELECT 
			clientes.id_cliente AS ID_CLIENTE, 
			clientes.razon_social AS RAZON_SOCIAL,  
			clientes.cp AS CP,
			localidades.localidad AS LOCALIDAD,
			clientes.mail AS MAIL, 
			clientes.telefono AS TELEFONO
	 FROM clientes
	 INNER JOIN localidades ON clientes.cp = localidades.cp;
END; 
GO

--ALTA CLIENTES
GO
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
GO

--MODIFICAR CLIENTES
GO
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
GO

--ELIMINAR CLIENTES
GO
CREATE PROCEDURE spu_baja_clientes
    @id_cliente INT
AS
BEGIN
   DELETE FROM clientes WHERE id_cliente = @id_cliente;
END;
GO

-- GENERAR +1 AL ID_CLIENTE
GO
CREATE PROCEDURE spu_generar_id_cliente
AS 
BEGIN 
     SELECT ISNULL(MAX(id_cliente), 0) + 1 AS Nuevo_ID FROM clientes;
END;
GO
-- ============================================
-- PROCEDIMIENTOS ALMACENADOS PRODUCTOS 
-- ============================================

--MOSTRAR PRODUCTOS
GO
CREATE PROCEDURE spu_mostrar_productos
AS
BEGIN
     SELECT 
			productos.id_producto AS ID_PRODUCTO,
			productos.descripcion AS DESCRIPCION, 
			productos.precio AS PRECIO,
			productos.stock AS STOCK,
			productos.id_rubro AS ID_RUBRO,
			rubros.descrip_rubro AS DESCRIPCION_RUBRO
	 FROM productos
	 INNER JOIN rubros ON productos.id_rubro = rubros.id_rubro;
END; 
GO

--ALTA PRODUCTOS
GO
CREATE PROCEDURE spu_alta_producto
   @id_producto INT,
   @descripcion NVARCHAR(60), 
   @precio DECIMAL(10,2),
   @stock DECIMAL(10,3),
   @id_rubro INT  
AS
BEGIN
    INSERT INTO productos (id_producto, descripcion, precio, stock, id_rubro) 
		VALUES (@id_producto, @descripcion, @precio, @stock, @id_rubro);
END;
GO
--MODIFICAR PRODUCTOS
GO
CREATE PROCEDURE spu_modificar_producto
	@id_producto INT,
	@descripcion NVARCHAR(60), 
	@precio DECIMAL(10,2),
	@stock DECIMAL(10,3),
	@id_rubro INT  
AS
BEGIN 
	UPDATE productos
	SET descripcion = @descripcion, precio = @precio, stock = @stock, id_rubro = @id_rubro
	WHERE id_producto = @id_producto;
END;
GO
--ELIMINAR PRODUCTOS
GO
CREATE PROCEDURE spu_baja_producto
    @id_producto INT 
AS
BEGIN
   DELETE FROM productos WHERE id_producto = @id_producto;
END;
GO

-- GENERAR +1 AL ID_PRODUCTO
GO
CREATE PROCEDURE spu_generar_id_producto
AS 
BEGIN 
     SELECT ISNULL(MAX(id_producto), 0) + 1 AS Nuevo_ID FROM productos;
END;
GO

-- ============================================
-- PROCEDIMIENTOS ALMACENADOS VENTAS
-- ============================================

--MOSTRAR VENTAS
GO
CREATE PROCEDURE spu_mostrar_ventas
AS
BEGIN
     SELECT 
			ventas.id_venta AS ID_VENTA,
			ventas.fecha AS FECHA, 
			ventas.id_forma_pago AS ID_FORMA_PAGO, 
			forma_de_pago.descrip_forma_pago AS DESCRIPCION_FORMA_PAGO,
			ventas.id_cliente AS ID_CLIENTE,
			clientes.razon_social AS RAZON_SOCIAL,
			ventas.id_usuario AS ID_USUARIO,
			usuarios.usuario AS USUARIO,
			ventas.total AS TOTAL 
	 FROM ventas
	 INNER JOIN forma_de_pago ON ventas.id_forma_pago = forma_de_pago.id_forma_pago
	 INNER JOIN clientes ON ventas.id_cliente = clientes.id_cliente
	 INNER JOIN usuarios ON ventas.id_usuario = usuarios.id_usuario;
END; 
Go

--ALTA VENTAS
GO
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
GO

--MODIFICAR VENTAS
GO
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
GO

--ELIMINAR VENTAS
GO
CREATE PROCEDURE spu_baja_ventas
    @id_venta INT 
AS
BEGIN
  -- 1° devuelvo al stock lo que se había vendido (sumado por producto)
   UPDATE productos
   SET stock = stock + vendido.total
   FROM productos
   INNER JOIN (
        SELECT id_producto, SUM(cantidad) AS total
        FROM detalle_venta
        WHERE id_venta = @id_venta
        GROUP BY id_producto
   ) AS vendido ON productos.id_producto = vendido.id_producto;

   -- 2° borro los renglones y 3° la cabecera
   DELETE FROM detalle_venta WHERE id_venta = @id_venta;
   DELETE FROM ventas WHERE id_venta = @id_venta;
END;
Go

-- GENERAR +1 AL ID_VENTA
GO
CREATE PROCEDURE spu_generar_id_venta
AS 
BEGIN 
     SELECT ISNULL(MAX(id_venta), 0) + 1 AS Nuevo_ID FROM ventas;
END;
GO
-- ============================================
-- PROCEDIMIENTOS ALMACENADOS DETALLE_VENTA
-- ============================================

--MOSTRAR DETALLE_VENTAS
GO
CREATE PROCEDURE spu_mostrar_detalle_venta
	@_id_venta INT
AS
BEGIN
     SELECT 
			detalle_venta.id_venta AS ID_VENTA,
			detalle_venta.id_producto AS ID_PRODUCTO, 
			productos.descripcion AS DESCRIPCION_PRODUCTO,
			detalle_venta.id_fila AS ID_FILA, 
			detalle_venta.precio AS PRECIO,
			detalle_venta.cantidad AS CANTIDAD,
			detalle_venta.precio_r AS PRECIO_RENGLON
	 FROM detalle_venta
	 INNER JOIN productos ON detalle_venta.id_producto = productos.id_producto
	 WHERE detalle_venta.id_venta = @_id_venta;
END; 
GO

--ALTA DETALLE_VENTAS
GO
CREATE PROCEDURE spu_alta_detalle_venta
			@id_venta INT,
			@id_producto INT, 
			@id_fila INT, 
			@precio DECIMAL(10,2),
			@cantidad DECIMAL(10,3),
			@precio_r DECIMAL(10,2)  -- no lo uso: precio_r se calcula abajo (precio * cantidad)
AS
BEGIN
    INSERT INTO detalle_venta (id_venta, id_producto, id_fila, precio, cantidad, precio_r) 
		VALUES (@id_venta, @id_producto, @id_fila, @precio, @cantidad, @precio * @cantidad);
		
	-- Descuento del stock lo vendido
    UPDATE productos 
    SET stock = stock - @cantidad 
    WHERE id_producto = @id_producto;
END;
GO

--MODIFICAR DETALLE_VENTAS
GO
CREATE PROCEDURE spu_modificar_detalle_venta
			@id_venta INT,
			@id_producto INT, 
			@id_fila INT, 
			@precio DECIMAL(10,2),
			@cantidad DECIMAL(10,3),
			@precio_r DECIMAL(10,2)  -- no lo uso: precio_r se calcula abajo (precio * cantidad)
AS
BEGIN 
	-- 1° guardo la cantidad que tenía antes el renglón
	DECLARE @cantidad_anterior DECIMAL(10,3);

	SELECT @cantidad_anterior = cantidad
	FROM detalle_venta
	WHERE id_venta = @id_venta AND id_producto = @id_producto AND id_fila = @id_fila;
	
	-- 2° actualizo el renglón
	UPDATE detalle_venta
	-- NO ACTUALIZO LAS CLAVES PRIMARIAS SOLO LOS DATOS QUE YA TIENE LA TABLA PORQUE SON CLAVES PRIMARIAS COMPUESTAS DE OTRAS TABLAS 
	SET precio = @precio, cantidad = @cantidad, precio_r = @precio * @cantidad
	WHERE id_venta = @id_venta AND id_producto = @id_producto AND id_fila = @id_fila;
	-- ACORDATE QUE PARA LAS CLAVES PRIMARIAS COMPUESTAS DEBES USAR AND PARA CONCATENAR LAS CLAVES DECLARADAS NECESARIAS
	
	-- 3° ajusto el stock con la diferencia (devuelvo la vieja, resto la nueva)
	UPDATE productos
	SET stock = stock + @cantidad_anterior - @cantidad
	WHERE id_producto = @id_producto;
END;
GO

--ELIMINAR DETALLE VENTAS
CREATE PROCEDURE spu_baja_detalle_venta
--TRES CLAVES PRIMARIAS SE TIENEN QUE SELECCIONAR PARA ELIMINAR 
	@id_venta INT,
	@id_producto INT,
	@id_fila INT 
AS
BEGIN 
	-- 1° guardo la cantidad del renglón antes de borrarlo
    DECLARE @cantidad DECIMAL(10,3);

    SELECT @cantidad = cantidad 
    FROM detalle_venta
    WHERE id_venta = @id_venta AND id_producto = @id_producto AND id_fila = @id_fila;

    -- 2° devuelvo esa cantidad al stock
    UPDATE productos 
    SET stock = stock + @cantidad 
    WHERE id_producto = @id_producto;

    -- 3° recién ahí borro el renglón
   DELETE FROM detalle_venta 
   WHERE id_venta = @id_venta AND id_producto = @id_producto AND id_fila = @id_fila;
   --LO MISMO PARA ESTE WHERE, NECESITA ENCONTRAR LAS TRES CLAVES PRIMARIAS
END;
GO

-- GENERAR +1 AL ID_FILA (POR CADA VENTA)
GO
CREATE PROCEDURE spu_generar_id_fila
		@id_venta INT 
AS 
BEGIN 
     SELECT ISNULL(MAX(id_fila), 0) + 1 AS Nuevo_ID 
	 FROM detalle_venta
	 WHERE id_venta = @id_venta;
END;
GO
-- ============================================
--  TODOS LOS ABM DE LAS TABLAS (EXC usuarios)  
-- ============================================

-- ============================================
-- PROCEDIMIENTO SPU MOSTRAR COMPROBANTE VENTA (IMPRIMIR EL COMPROBANTE DE LA VENTA) INICIO
-- ============================================
GO
CREATE PROCEDURE spu_imprimir_comprobante_venta
    @id_venta INT
AS
BEGIN
    SELECT
			-- DATOS DE LA CABECERA DE LA VENTA
			ventas.id_venta AS NRO_COMPROBANTE,
			ventas.fecha AS FECHA,
			forma_de_pago.descrip_forma_pago AS FORMA_DE_PAGO,
			usuarios.usuario AS USUARIO,

			-- DATOS DEL CLIENTE
			clientes.razon_social AS RAZON_SOCIAL,

			-- DATOS DEL DETALLE DE LA VENTA (RENGLONES DE LA FACTURA) 
			detalle_venta.id_fila AS RENGLON,
			rubros.descrip_rubro AS RUBRO,
			productos.descripcion AS PRODUCTO,
			detalle_venta.precio AS PRECIO_UNITARIO,
			detalle_venta.cantidad AS CANTIDAD,
			detalle_venta.precio_r AS PRECIO_RENGLON,

			-- TOTAL FINAL DE LA VENTA 
			ventas.total AS TOTAL_VENTA 
			
			FROM ventas

			-- UNIR LA CABECERA CON EL DETALLE DE LA VENTA
			INNER JOIN detalle_venta ON ventas.id_venta = detalle_venta.id_venta

			-- UNIR EL DETALLLE DE VENTA CON LOS PRODUCTOS PARA SABER LOS NOMBRES 
			INNER JOIN productos ON detalle_venta.id_producto = productos.id_producto
			
			-- UNIR EL RUBRO CON EL PRODUCTO 
			INNER JOIN rubros ON productos.id_rubro = rubros.id_rubro

			-- UNIR LA CABECERA VENTA CON EL CLIENTE,  
			INNER JOIN clientes ON ventas.id_cliente = clientes.id_cliente

			-- FORMA DE PAGO
			INNER JOIN forma_de_pago ON ventas.id_forma_pago = forma_de_pago.id_forma_pago

			-- Y USUARIO PARA SABER LOS DATOS DE LA VENTA
			INNER JOIN usuarios ON ventas.id_usuario = usuarios.id_usuario 

			WHERE ventas.id_venta = @id_venta
			ORDER BY detalle_venta.id_fila ASC 
END;
GO
-- ============================================
-- PROCEDIMIENTO SPU MOSTRAR COMPROBANTE VENTA (IMPRIMIR EL COMPROBANTE DE LA VENTA) FIN 
-- ============================================

-- ============================================
-- REPORTE: LISTA DE PRECIOS (LISTA DE PRECIOS)
-- ============================================
GO
CREATE PROCEDURE spu_reporte_lista_precios
AS
BEGIN
    SELECT 
        rubros.descrip_rubro AS RUBRO,
        productos.descripcion AS PRODUCTO,
        productos.precio AS PRECIO
    FROM productos
    INNER JOIN rubros ON productos.id_rubro = rubros.id_rubro
    ORDER BY rubros.descrip_rubro, productos.descripcion;
END;
GO

-- ============================================
-- REPORTE DE VENTAS x FECHA
-- ============================================
GO
CREATE PROCEDURE spu_reporte_ventas_por_fecha
	@fecha_desde DATE,
	@fecha_hasta DATE
AS
BEGIN 
	 SELECT 
		   ventas.id_venta AS NRO_VENTA,
		   ventas.fecha AS FECHA,
		   clientes.razon_social AS CLIENTE,
		   forma_de_pago.descrip_forma_pago AS FORMA_DE_PAGO,
		   ventas.total AS TOTAL_VENTA
		FROM ventas

		INNER JOIN clientes ON ventas.id_cliente = clientes.id_cliente

		INNER JOIN forma_de_pago ON ventas.id_forma_pago = forma_de_pago.id_forma_pago

		WHERE ventas.fecha BETWEEN @fecha_desde AND @fecha_hasta

		ORDER BY ventas.fecha DESC;
END;
GO
-- ============================================
-- REPORTE DE VENTAS x RUBRO
-- ============================================
GO
CREATE PROCEDURE spu_reporte_ventas_por_rubro
	@id_rubro INT
AS
BEGIN 
	 SELECT 
		rubros.id_rubro AS ID_RUBRO, 
		rubros.descrip_rubro AS RUBRO,
		ventas.fecha AS FECHA, 
		ventas.id_venta AS NRO_VENTA,
		productos.descripcion AS PRODUCTO,
		detalle_venta.cantidad AS CANTIDAD_VENDIDA,
		detalle_venta.precio_r AS SUBTOTAL
	FROM ventas 
	-- Primero uno la cabecera con sus renglones (detalle)
	INNER JOIN detalle_venta ON ventas.id_venta = detalle_venta.id_venta

	-- Ahora que estoy en el renglón, busco que producto es
	INNER JOIN productos ON detalle_venta.id_producto = productos.id_producto

	-- Y con el producto busco a qué rubro debe estar 
	INNER JOIN rubros ON productos.id_rubro = rubros.id_rubro

	WHERE productos.id_rubro = @id_rubro
	ORDER BY ventas.fecha DESC;
END;
GO

-- ============================================
-- PROCEDIMIENTO ALMACENADO BACKUP Final_Punto_Venta_Programacion_I 
-- ============================================

--BACKUP DE BASE DE DATOS
GO
CREATE PROCEDURE spu_backup_full
AS
BEGIN
    DECLARE @MyFileName VARCHAR(1000)
    SELECT @MyFileName = 'C:\Proyectos_Izo\TI\BD\Backup\Final_Punto_Venta\Punto_Venta_Final.bak'
    BACKUP DATABASE Final_Punto_Venta_Programacion_I 
    TO DISK = @MyFileName
END;
GO

-- ============================================
-- INSERT PARA PROBAR  Final_Punto_Venta_Programacion_I 
-- ============================================

-- Primero las tablas "padre" y después las que las referencian (por las FK)

-- TABLA LOCALIDADES 
INSERT INTO localidades (cp, localidad) VALUES (1000, 'CABA'), (1704, 'Ramos Mejía'), (1708, 'Morón');

-- TABLA RUBROS
INSERT INTO rubros (id_rubro, descrip_rubro) VALUES (1, 'Almacén'), (2, 'Bebidas'), (3, 'Limpieza');

-- TABLA FORMA DE PAGO 
INSERT INTO forma_de_pago (id_forma_pago, descrip_forma_pago) VALUES (1, 'Efectivo'), (2, 'Tarjeta'), (3, 'Transferencia');

-- TABLA USUARIOS
INSERT INTO usuarios (id_usuario, usuario, psw) VALUES (1, 'admin', '1234');

-- TABLA CLIENTES 
INSERT INTO clientes (id_cliente, razon_social, cp, mail, telefono) VALUES 
(1, 'Consumidor Final', 1000, NULL, NULL),
(2, 'Juan Pérez', 1704, 'juan@mail.com', '1155551234');

-- TABLA PRODUCTOS
INSERT INTO productos (id_producto, descripcion, precio, stock, id_rubro) VALUES 
(1, 'Fideos 500g', 1500, 50, 1),
(2, 'Arroz 1kg', 1800, 40, 1),
(3, 'Gaseosa 1.5L', 2200, 30, 2),
(4, 'Agua 2L', 1200, 60, 2),
(5, 'Lavandina 1L', 1000, 25, 3);

INSERT INTO usuarios (id_usuario, usuario, psw) VALUES (2, 'Juan', '4567'), (3, 'Marcelo', '8901');


-- Nuevos productos en Almacén (Rubro 1)
EXEC spu_alta_producto 6, 'Yerba Mate 1kg', 3500.00, 100.000, 1;
EXEC spu_alta_producto 7, 'Aceite de Girasol 1.5L', 2800.00, 80.000, 1;

-- Nuevos productos en Bebidas (Rubro 2)
EXEC spu_alta_producto 8, 'Cerveza Lata 473ml', 1800.00, 150.000, 2;
EXEC spu_alta_producto 9, 'Jugo en Polvo', 450.00, 200.000, 2;

-- Nuevos productos en Limpieza (Rubro 3)
EXEC spu_alta_producto 10, 'Detergente 500ml', 1600.00, 90.000, 3;
EXEC spu_alta_producto 11, 'Esponja Multiuso', 600.00, 150.000, 3;

UPDATE productos SET stock = stock + 50.000 WHERE id_producto = 1; -- Fideos 500g
UPDATE productos SET stock = stock + 40.000 WHERE id_producto = 2; -- Arroz 1kg
UPDATE productos SET stock = stock + 30.000 WHERE id_producto = 3; -- Gaseosa 1.5L
UPDATE productos SET stock = stock + 60.000 WHERE id_producto = 4; -- Agua 2L
UPDATE productos SET stock = stock + 25.000 WHERE id_producto = 5; -- Lavandina 1L