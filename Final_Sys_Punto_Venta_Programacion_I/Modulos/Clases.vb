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
    ' CLASE LOCALIDADES 
    ' =========================================================

    'Clase para almacenar los datos de las localidades Publicamente, para poder acceder a ellos desde cualquier formulario
    Class Localidades
        Public cp As Integer
        Public localidad As String
    End Class

    ' =========================================================
    ' CLASE RUBROS
    ' =========================================================

    Class Rubros
        Public idRubro As Integer
        Public descripcionRubro As String
    End Class

    ' =========================================================
    ' CLASE FORMA DE PAGOS  
    ' =========================================================

    Class FormaPagos
        Public idFormaPago As Integer
        Public descripcionFormaPago As String
    End Class



    ' =========================================================
    ' BANDERA DE ESTADO (Controla qué formulario hizo la llamada)
    ' =========================================================
    Public wflag As Integer = 0

    ' =========================================================
    ' RECEPTORAS DE DATOS (Guardan los IDs seleccionados en las grillas)
    ' Todas deben ser Integer porque en SQL Server son tipo INT
    ' =========================================================
    Public wCP As Integer = 0
    Public wID_Cliente As Integer = 0
    Public wNombre_Cliente As String = ""
End Module
