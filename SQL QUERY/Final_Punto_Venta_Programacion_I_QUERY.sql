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
	id_forma_pago INT PRIMARY KEY,  
	descrip_forma_pago NVARCHAR (60)
);

CREATE TABLE localidades (
	cp INT PRIMARY KEY, 
	localidad NVARCHAR (60)
);

CREATE TABLE rubros (
	id_rubro INT PRIMARY KEY,  
	descrip_rubro NVARCHAR (60)
);

CREATE TABLE usuarios ( 
	id_usuario INT PRIMARY KEY, 
	usuario NVARCHAR (60),
	psw NVARCHAR (60)
); 

-- ============================================
-- TABLAS PUNTO VENTA "HIJOS"
-- ============================================

CREATE TABLE clientes (
	id_cliente INT PRIMARY KEY,
	razon_social NVARCHAR (60),
	cp INT FOREIGN KEY REFERENCES localidades(cp),
	mail NVARCHAR (60),
	telefono NVARCHAR (60)
); 

CREATE TABLE productos ( 
	id_producto INT PRIMARY KEY, 
	descripcion NVARCHAR (60),
	precio DECIMAL(10,2),
	stock INT, 
	id_rubro INT FOREIGN KEY REFERENCES rubros(id_rubro)
);

-- ============================================
-- TABLAS PUNTO VENTA QUE DEPENDE DE PADRE E HIJOS
-- ============================================

CREATE TABLE ventas (
	id_venta INT PRIMARY KEY, 
	fecha DATE,
	id_forma_pago INT FOREIGN KEY REFERENCES forma_de_pago(id_forma_pago),
	id_cliente INT FOREIGN KEY REFERENCES clientes(id_cliente),
	id_usuario INT FOREIGN KEY REFERENCES usuarios(id_usuario),
	total DECIMAL(10,2) 
);

CREATE TABLE detalle_venta (
	id_venta INT, 
	id_producto INT,
	id_fila INT, --ID FILA 
	precio DECIMAL(10,2),
	cantidad INT, 
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
   @id_forma_pago int,
   @descrip_forma_pago nvarchar(60)
AS
BEGIN
    INSERT INTO forma_de_pago (id_forma_pago, descrip_forma_pago) VALUES (@id_forma_pago, @descrip_forma_pago);
END;


--MODIFICAR FORMAS PAGO 
CREATE PROCEDURE spu_modificar_forma_de_pago
   @id_forma_pago int,
   @descrip_forma_pago nvarchar(60)
AS
BEGIN 
  UPDATE forma_de_pago SET descrip_forma_pago = @descrip_forma_pago 
  WHERE id_forma_pago = @id_forma_pago;
END;

--ELIMINAR FORMAS PAGO 
CREATE PROCEDURE spu_baja_forma_de_pago
     @id_forma_pago int
AS
BEGIN
   DELETE FROM forma_de_pago 
   WHERE id_forma_pago = @id_forma_pago;
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
   @cp int,
   @localidad nvarchar(60)
AS
BEGIN
    INSERT INTO localidades (cp, localidad) VALUES (@cp, @localidad);
END;

--MODIFICAR LOCALIDADES
CREATE PROCEDURE spu_modificar_localidad
   @cp int,
   @localidad nvarchar(60)
AS
BEGIN 
  UPDATE localidades SET localidad = @localidad WHERE cp = @cp;
END;


--ELIMINAR LOCALIDADES
CREATE PROCEDURE spu_baja_localidad
    @cp int
AS
BEGIN
   DELETE FROM localidades WHERE cp = @cp;
END;


-- ============================================
-- PROCEDIMIENTOS ALMACENADOS LOCALIDADES BUSCAR X CP - LOCALIDADES 
-- ============================================

--BUSCAR CP LOCALIDADES
CREATE PROCEDURE spu_buscar_localidad_X_cp
    @cp int
AS
BEGIN
    SELECT cp CP, localidad LOCALIDAD FROM localidades 
    WHERE cp = @cp;
END;


--BUSCAR LOCALIDAD LOCALIDADES
CREATE PROCEDURE spu_buscar_localidad_X_localidad
   @localidad nvarchar(60)
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
   @id_rubro int,
   @descrip_rubro nvarchar(60)
AS
BEGIN
    INSERT INTO rubros (id_rubro, descrip_rubro) 
	VALUES (@id_rubro, @descrip_rubro);
END;

--MODIFICAR RUBROS
CREATE PROCEDURE spu_modificar_rubro
   @id_rubro int,
   @descrip_rubro nvarchar(60)
AS
BEGIN 
  UPDATE rubros SET descrip_rubro = @descrip_rubro 
  WHERE id_rubro = @id_rubro;
END;

--ELIMINAR RUBROS
CREATE PROCEDURE spu_baja_rubro
    @id_rubro int
AS
BEGIN
   DELETE FROM rubros WHERE id_rubro = @id_rubro;
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

