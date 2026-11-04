Imports System.Runtime.InteropServices.WindowsRuntime
Imports System.Runtime.Remoting.Messaging
Imports System.Security.Cryptography.X509Certificates

Module Clases

    ' =========================================================
    ' CLASE CLIENTES 
    ' =========================================================

    'Clase para almacenar los datos de los clientes Publicamente, para poder acceder a ellos desde cualquier formulario
    Class Clientes
        Public id_cliente As Integer
        Public razonSocial As String
        Public cp As Integer
        Public email As String
        Public telefono As String
    End Class

    ' =========================================================
    ' CLASE DETALLE VENTAS 
    ' =========================================================

    Class DetalleVentas
        Public id_venta As Integer
        Public id_producto As Integer
        Public id_fila As Integer
        Public precio As Decimal
        Public cantidad As Decimal
        Public precio_r As Decimal
    End Class

    ' =========================================================
    ' CLASE FORMA DE PAGOS  
    ' =========================================================

    Class FormaPagos
        Public idFormaPago As Integer
        Public descripcionFormaPago As String
    End Class


    ' =========================================================
    ' CLASE LOCALIDADES 
    ' =========================================================

    'Clase para almacenar los datos de las localidades Publicamente, para poder acceder a ellos desde cualquier formulario
    Class Localidades
        Public cp As Integer
        Public localidad As String
    End Class

    ' =========================================================
    ' CLASE PRODUCTOS
    ' =========================================================
    Public Class Productos
        Public id_producto As String
        Public descripcion As String
        Public precio As String
        Public stock As String
        Public id_rubro As String
    End Class

    ' =========================================================
    ' CLASE RUBROS
    ' =========================================================
    Class Rubros
        Public idRubro As Integer
        Public descripcionRubro As String
    End Class

    ' =========================================================
    ' VARIABLES PARA COMPROBANTE TICKET 
    ' =========================================================
    Public wID_Venta As Integer = 0

    ' =========================================================
    ' BANDERA DE ESTADO (Controla qué formulario hizo la llamada)
    ' =========================================================
    Public wflag As Integer = 0

    ' =========================================================
    ' RECEPTORAS DE DATOS (Guardan los IDs seleccionados en las grillas)
    ' Todas deben ser Integer porque en SQL Server son tipo INT
    ' =========================================================
    Public wCP As Integer = 0

    ' Clase Clientes 
    Public wID_Cliente As Integer = 0
    Public wNombre_Cliente As String = ""

    ' Clase Productos - Rubros 
    Public wID_Rubro As Integer = 0
    Public wNombre_Rubro As String = ""

    ' =========================================================
    ' RECEPTORA DE USUARIO SELECCIONADO
    ' =========================================================
    Public wID_UsuarioLogueado As Integer = 0
    Public wNombre_UsuarioLogueado As String = ""

    Public wNombre_Localidad As String = ""

    ' =========================================================
    ' VARIABLES PARA EL REPORTE DE VENTAS POR FECHA
    ' =========================================================

    ' Variables globales para el reporte de ventas por fecha
    Public wFechaDesde As String = ""
    Public wFechaHasta As String = ""

End Module
