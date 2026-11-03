Public Class FrmVentas

    Private Sub FrmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConexion()

        ' Ejecutamos la búsqueda por primera vez para llenar la grilla
        FiltrarVentas()

        ' FORZAMOS EL FOCO A LA GRILLA
        Me.dgvVentasRealizadas.Focus()
    End Sub



    ' =========================================================
    ' CELDAS DE LA GRILLA Y SUS FUNCIONES 
    ' =========================================================

    ' Evento único que se dispara cuando escribes en CUALQUIER TextBox de búsqueda
    Private Sub TextBoxesBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtVentaPorUsuario.TextChanged,
                                                                                  TxtVentaPorRubro.TextChanged,
                                                                                  TxtBuscarVentaPorProducto.TextChanged,
                                                                                  TxtVentaPorCliente.TextChanged,
                                                                                  TxtBuscarVentaPorDetalleVenta.TextChanged,
                                                                                  TxtBuscarVentaPorLocalidad.TextChanged,
                                                                                  TxtBuscarVentaPorFormaPago.TextChanged
        FiltrarVentas()
    End Sub

    ' Evento que se dispara cuando cambias las fechas en los selectores
    Private Sub Fechas_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaDesde.ValueChanged, dtpFechaHasta.ValueChanged
        FiltrarVentas()
    End Sub

    ' =========================================================
    ' BUSCADORES
    ' =========================================================
    Private Sub FiltrarVentas()
        ' 1. Recogemos los valores de cada caja de texto de búsqueda (con Trim para limpiar espacios)
        Dim usuario As String = Me.TxtVentaPorUsuario.Text.Trim()
        Dim rubro As String = Me.TxtVentaPorRubro.Text.Trim()
        Dim producto As String = Me.TxtBuscarVentaPorProducto.Text.Trim()
        Dim cliente As String = Me.TxtVentaPorCliente.Text.Trim()
        Dim detalle As String = Me.TxtBuscarVentaPorDetalleVenta.Text.Trim()
        Dim localidad As String = Me.TxtBuscarVentaPorLocalidad.Text.Trim()
        Dim formaPago As String = Me.TxtBuscarVentaPorFormaPago.Text.Trim()

        ' 2. Extraemos las fechas de los DateTimePicker dándoles el formato compatible con SQL (yyyy-MM-dd)
        Dim fechaDesde As String = Me.dtpFechaDesde.Value.ToString("yyyy-MM-dd")
        Dim fechaHasta As String = Me.dtpFechaHasta.Value.ToString("yyyy-MM-dd")

        ' 3. Armamos la consulta ejecutando tu nuevo procedimiento almacenado
        Dim sql As String = "exec spu_buscar_ventas_cruzado '" & usuario & "', '" & rubro & "', '" & producto & "', '" & cliente & "', '" & detalle & "', '" & localidad & "', '" & formaPago & "', '" & fechaDesde & "', '" & fechaHasta & "'"

        Try
            ' 4. Conectamos con la base de datos usando el objeto 'conexion' de tu sistema
            Dim adp As New SqlClient.SqlDataAdapter(sql, conexion)
            Dim ds As New DataSet

            ds.Tables.Add("VentasCruzadas")
            adp.Fill(ds.Tables("VentasCruzadas"))

            ' 5. Asignamos el resultado a la grilla principal
            Me.dgvVentasRealizadas.DataSource = ds.Tables("VentasCruzadas")

            ' Opcional: Ajustamos las columnas para que ocupen todo el ancho sin scroll horizontal
            Me.dgvVentasRealizadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MsgBox("Error al filtrar las ventas: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

End Class