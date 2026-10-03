Module Conectar
    Public cmd As New SqlClient.SqlCommand
    Public dr As SqlClient.SqlDataReader
    Public conexion As New SqlClient.SqlConnection("Data Source=localhost;Initial Catalog=Final_Punto_Venta_Programacion_I;Integrated Security=True")
    Public Sub AbrirConexion() 'Funcion para abrir la conexion 
        Try
            ' ¿La conexión está cerrada?
            If conexion.State = ConnectionState.Closed Then
                ' Solo si está cerrada, la abro
                conexion.Open()
            End If

            cmd.Connection = conexion

        Catch ex As Exception
            ' "ex.Message" para que si falla de verdad, me diga POR QUÉ falló
            MsgBox("Error al conectar con el servidor: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Module



