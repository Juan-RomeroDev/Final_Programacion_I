Public Class FrmPOS

    ' 1. Declara el DataTable del carrito a nivel de clase (fuera de cualquier Sub)
    Private dtCarrito As New DataTable()

    Private Sub FrmPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConexion()
        llenarProductos()
        CargarCombosBoxClientesFormaPago()

        ' Llamamos a la función que inicializa las columnas del carrito
        InicializarCarrito()

        ' CARGAR DATOS INFORMATIVOS EN LOS LABELS
        Me.LblFecha.Text = "Fecha: " & DateTime.Now.ToString("dd/MM/yyyy")
        Me.LblUsuario.Text = "Usuario: " & wNombre_UsuarioLogueado
        Me.Lbl_Venta_N.Text = "Venta N°: " & generarIdVenta().ToString()
        Me.LblCantidad.Text = "Cantidad Filas: " & dtCarrito.Rows.Count

        ' FORZAMOS EL FOCO A LA GRILLA
        Me.dgvBusquedaProductosPOS.Focus()
    End Sub

    ' =========================================================
    ' VARIABLES Y FUNCION PARA CARRITO 
    ' =========================================================

    ' 2. La subrutina de inicialización va independiente
    Private Sub InicializarCarrito()
        dtCarrito.Columns.Add("ID_PRODUCTO", GetType(Integer))
        dtCarrito.Columns.Add("PRODUCTO", GetType(String))
        dtCarrito.Columns.Add("PRECIO", GetType(Decimal))
        dtCarrito.Columns.Add("CANTIDAD", GetType(Integer))
        ' El subtotal se calcula solo multiplicando precio por cantidad
        dtCarrito.Columns.Add("SUBTOTAL", GetType(Decimal), "PRECIO * CANTIDAD")

        ' Vinculamos la tabla a la grilla inferior del carrito
        Me.DgvCarritoProductos.DataSource = dtCarrito
        Me.DgvCarritoProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub




    ' =========================================================
    ' FUNCIONES 
    ' =========================================================

    Private Sub llenarProductos()
        ' Llamo al procedimiento almacenado que me devuelve todos los clientes
        Dim sql As String = "exec spu_mostrar_productos"
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion)
        Dim ds As New DataSet

        ' Lleno la tabla temporal
        ds.Tables.Add("BuscarProductos")
        adp.Fill(ds.Tables("BuscarProductos"))

        ' Asigno los datos a la grilla
        Me.dgvBusquedaProductosPOS.DataSource = ds.Tables("BuscarProductos")

        ' FORMATO DE LA GRILLA 
        ' Acá solo tengo 6 columnas, así que no hace falta ocultar nada

        ' Hace que la grilla ocupe todo el ancho sin scroll horizontal
        Me.dgvBusquedaProductosPOS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' ORDEN ESTRICTO DE SQL
        Me.dgvBusquedaProductosPOS.Columns(0).FillWeight = 40   ' ID_PRODUCTO
        Me.dgvBusquedaProductosPOS.Columns(1).FillWeight = 160  ' DESCRIPCION
        Me.dgvBusquedaProductosPOS.Columns(2).FillWeight = 50   ' PRECIO
        Me.dgvBusquedaProductosPOS.Columns(3).FillWeight = 120  ' STOCK 

        Me.dgvBusquedaProductosPOS.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvBusquedaProductosPOS.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvBusquedaProductosPOS.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvBusquedaProductosPOS.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    ' FUNCIÓN PARA GENERAR + 1 ID DE VENTA (DEBE SER FUNCTION, NO SUB)
    Private Function generarIdVenta() As Integer
        Dim idVenta As Integer = 1
        Try
            AbrirConexion()
            cmd.CommandText = "exec spu_generar_id_venta"

            Dim nuevoID As Object = cmd.ExecuteScalar()

            If nuevoID IsNot Nothing AndAlso Not IsDBNull(nuevoID) Then
                idVenta = Convert.ToInt32(nuevoID)
            End If

        Catch ex As Exception
            MsgBox("Error al generar ID: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        Return idVenta ' <--- Esto es lo que devuelve el número hacia afuera
    End Function

    ' =========================================================
    ' CONVERSION DE VARIABLE PARA INSERTAR EN EL CARRITO 
    ' =========================================================

    Private Sub dgvBusquedaProductosPOS_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBusquedaProductosPOS.CellDoubleClick
        If e.RowIndex >= 0 Then
            ' 1. Extraemos los datos de la fila seleccionada arriba
            Dim idProducto As Integer = Convert.ToInt32(Me.dgvBusquedaProductosPOS.Rows(e.RowIndex).Cells(0).Value)
            Dim descripcion As String = Me.dgvBusquedaProductosPOS.Rows(e.RowIndex).Cells(1).Value.ToString()
            Dim precio As Decimal = Convert.ToDecimal(Me.dgvBusquedaProductosPOS.Rows(e.RowIndex).Cells(2).Value)
            Dim stock As Decimal = Convert.ToDecimal(Me.dgvBusquedaProductosPOS.Rows(e.RowIndex).Cells(3).Value)

            ' 2. Validación rápida de stock general
            If stock <= 0 Then
                MsgBox("Atención: El producto seleccionado no cuenta con stock disponible.", MsgBoxStyle.Exclamation, "Sin Stock")
                Exit Sub
            End If

            ' 3. Leemos la cantidad escrita en el TextBox (si está vacío o no es número, por defecto asignamos 1)
            Dim cantidad As Integer = 1
            If Me.TxtCantidad.Text.Trim() <> "" AndAlso IsNumeric(Me.TxtCantidad.Text.Trim()) Then
                cantidad = Convert.ToInt32(Me.TxtCantidad.Text.Trim())
            End If

            ' 4. Validar que la cantidad sea mayor a 0
            If cantidad <= 0 Then
                MsgBox("La cantidad ingresada debe ser mayor a 0.", MsgBoxStyle.Exclamation, "Dato inválido")
                Exit Sub
            End If

            ' 5. Validar que la cantidad ingresada no supere el stock disponible
            If cantidad > stock Then
                MsgBox("Atención: La cantidad ingresada (" & cantidad & ") supera el stock disponible (" & stock & ").", MsgBoxStyle.Exclamation, "Stock Insuficiente")
                Exit Sub
            End If

            ' 6. Inyectamos los datos en la tabla temporal del carrito con la cantidad especificada
            dtCarrito.Rows.Add(idProducto, descripcion, precio, cantidad)

            ' 7. Recalculamos los totales generales al instante
            CalcularTotalGeneral()

            ' 8. Opcional: Reseteamos la caja de cantidad a 1 y devolvemos el foco para seguir vendiendo rápido
            Me.TxtCantidad.Text = "1"
            Me.TxtCantidad.Focus()
            Me.TxtCantidad.SelectAll()
        End If
    End Sub

    ' CALCULAR TOTAL DEL CARRITO 
    Private Sub CalcularTotalGeneral()
        Dim totalGeneral As Decimal = 0

        For Each fila As DataRow In dtCarrito.Rows
            totalGeneral += Convert.ToDecimal(fila("SUBTOTAL"))
        Next

        ' Mostramos el resultado en las etiquetas de subtotal y total
        Me.LblSubtotal.Text = "$ " & totalGeneral.ToString("N2")
        Me.LblTotal.Text = "$ " & totalGeneral.ToString("N2")

        ' Actualizamos la cantidad de renglones en el carrito
        Me.LblCantidad.Text = "Cantidad Filas: " & dtCarrito.Rows.Count.ToString()
    End Sub

    ' =========================================================
    ' BOTONES
    ' =========================================================
    Private Sub BtnAtrasPOS_Click(sender As Object, e As EventArgs) Handles BtnAtrasPOS.Click
        Me.Close()
    End Sub

    Private Sub BtnFinalizarVenta_Click(sender As Object, e As EventArgs) Handles BtnFinalizarVenta.Click
        ' Validaciones previas
        If dtCarrito.Rows.Count = 0 Then
            MsgBox("El carrito está vacío. Agregue productos antes de finalizar la venta.", MsgBoxStyle.Exclamation, "Carrito Vacío")
            Exit Sub
        End If

        If Me.CB_Clientes.SelectedValue Is Nothing OrElse Me.CB_FormaPago.SelectedValue Is Nothing Then
            MsgBox("Debe seleccionar un cliente y una forma de pago.", MsgBoxStyle.Exclamation, "Datos incompletos")
            Exit Sub
        End If

        Try
            AbrirConexion()

            ' A. Obtenemos el ID de venta nuevo
            Dim idVenta As Integer = generarIdVenta()

            ' B. Calculamos el total general del carrito
            Dim totalVenta As Decimal = 0
            For Each fila As DataRow In dtCarrito.Rows
                totalVenta += Convert.ToDecimal(fila("SUBTOTAL"))
            Next

            ' C. Obtenemos los IDs seleccionados en los combos y usuario actual
            Dim idCliente As Integer = Convert.ToInt32(Me.CB_Clientes.SelectedValue)
            Dim idFormaPago As Integer = Convert.ToInt32(Me.CB_FormaPago.SelectedValue)
            Dim idUsuario As Integer = 1 ' O la variable global de usuario logueado en tu sistema

            ' D. Ejecutamos el alta de la cabecera de venta
            Dim sqlVenta As String = "exec spu_alta_ventas " & idVenta & ", " & idFormaPago & ", " & idCliente & ", " & idUsuario & ", " & totalVenta.ToString(System.Globalization.CultureInfo.InvariantCulture)
            cmd.CommandText = sqlVenta
            cmd.ExecuteNonQuery()

            ' E. Recorremos el carrito para dar de alta cada renglón en detalle_venta
            Dim idFila As Integer = 1
            For Each fila As DataRow In dtCarrito.Rows
                Dim idProducto As Integer = Convert.ToInt32(fila("ID_PRODUCTO"))
                Dim precio As Decimal = Convert.ToDecimal(fila("PRECIO"))
                Dim cantidad As Decimal = Convert.ToDecimal(fila("CANTIDAD"))
                Dim precioR As Decimal = precio * cantidad ' Precio renglón

                ' VALIDACION DE NUMEROS
                ' Usamos los puntos en el formato decimal por seguridad en SQL
                Dim pStr As String = precio.ToString(System.Globalization.CultureInfo.InvariantCulture)
                Dim cantStr As String = cantidad.ToString(System.Globalization.CultureInfo.InvariantCulture)
                Dim prStr As String = precioR.ToString(System.Globalization.CultureInfo.InvariantCulture)

                Dim sqlDetalle As String = "exec spu_alta_detalle_venta " & idVenta & ", " & idProducto & ", " & idFila & ", " & pStr & ", " & cantStr & ", " & prStr
                cmd.CommandText = sqlDetalle
                cmd.ExecuteNonQuery()

                idFila += 1
            Next

            MsgBox("¡Venta registrada con éxito! Nro de Venta: " & idVenta, MsgBoxStyle.Information, "Éxito")

            ' F. Limpiamos el carrito y actualizamos la pantalla
            LimpiarCarritoYLabels()
            llenarProductos() ' Recarga el stock actualizado en la grilla superior

        Catch ex As Exception
            MsgBox("Error al registrar la venta: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    ' =========================================================
    ' CANCELAR VENTA - Limpia todo el carrito sin guardar nada
    ' =========================================================
    Private Sub BtnCancelarVenta_Click(sender As Object, e As EventArgs) Handles BtnCancelarVenta.Click
        ' Si el carrito ya está vacío, no hay nada que cancelar
        If dtCarrito.Rows.Count = 0 Then
            MsgBox("No hay ninguna venta en curso para cancelar.", MsgBoxStyle.Exclamation, "Carrito Vacío")
            Exit Sub
        End If

        ' Preguntamos al usuario si está seguro (mismo patrón que bajaClientes)
        Dim respuesta As DialogResult
        respuesta = MsgBox("¿Está seguro que desea CANCELAR la venta actual?" & vbCrLf & "Se eliminarán todos los productos del carrito.",
                           MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmar Cancelación")

        ' Si el usuario dijo que SÍ, vaciamos todo
        If respuesta = DialogResult.Yes Then
            LimpiarCarritoYLabels()
            MsgBox("Venta cancelada correctamente.", MsgBoxStyle.Information, "Cancelado")
        End If
    End Sub

    ' =========================================================
    ' QUITAR RENGLÓN - Elimina la fila seleccionada del carrito
    ' =========================================================
    Private Sub BtnQuitarRenglon_Click(sender As Object, e As EventArgs) Handles BtnQuitarRenglon.Click
        ' Validamos que haya filas en el carrito
        If dtCarrito.Rows.Count = 0 Then
            MsgBox("El carrito está vacío. No hay renglones para quitar.", MsgBoxStyle.Exclamation, "Carrito Vacío")
            Exit Sub
        End If

        ' Validamos que haya una fila seleccionada en la grilla del carrito
        If Me.DgvCarritoProductos.CurrentRow Is Nothing Then
            MsgBox("Debe seleccionar un renglón del carrito para quitar.", MsgBoxStyle.Exclamation, "Sin selección")
            Exit Sub
        End If

        ' Obtenemos el índice de la fila seleccionada
        Dim indice As Integer = Me.DgvCarritoProductos.CurrentRow.Index

        ' Eliminamos la fila del DataTable (no de la grilla directamente)
        dtCarrito.Rows(indice).Delete()
        dtCarrito.AcceptChanges()

        ' Recalculamos el total
        CalcularTotalGeneral()
    End Sub

    ' =========================================================
    ' FUNCIÓN AUXILIAR - Limpia el carrito y resetea todos los labels
    ' =========================================================
    Private Sub LimpiarCarritoYLabels()
        dtCarrito.Clear()
        Me.LblSubtotal.Text = "$ 0,00"
        Me.LblTotal.Text = "$ 0,00"
        Me.LblCantidad.Text = "Cantidad: 0"

        ' Regeneramos el próximo N° de venta
        Me.Lbl_Venta_N.Text = "Venta N°: " & generarIdVenta().ToString()
    End Sub

    ' =========================================================
    ' BUSCAR TXT  
    ' =========================================================
    Private Sub TxtBuscarProducto_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarProducto.TextChanged
        Dim descpBuscado As String = Me.TxtBuscarProducto.Text.Trim()

        ' Si borra el texto y queda vacío, mostramos la lista completa
        If descpBuscado = "" Then
            llenarProductos()
            Exit Sub
        End If

        ' Consulta llamando al procedimiento almacenado
        Dim sql As String = "exec spu_buscar_producto_X_producto '" & descpBuscado & "'"

        Try
            Dim adp As New SqlClient.SqlDataAdapter(sql, conexion)
            Dim ds As New DataSet

            ds.Tables.Add("ProductosFiltrados")
            adp.Fill(ds.Tables("ProductosFiltrados"))

            ' Asigna los datos filtrados a la grilla
            Me.dgvBusquedaProductosPOS.DataSource = ds.Tables("ProductosFiltrados")
            ' Al asignar el formato responsivo (Fill y FillWeight) dentro de llenarTiposCuentas(), las propiedades quedan guardadas en el control y no hace falta repetirlas en las búsquedas.

        Catch ex As Exception
            MsgBox("Error al buscar: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    ' =========================================================
    ' COMBO BOX FUNCIONES 
    ' =========================================================

    Private Sub CargarCombosBoxClientesFormaPago()
        ' 1. Cargar Clientes
        Dim adpCli As New SqlClient.SqlDataAdapter("exec spu_mostrar_clientes", conexion)
        Dim dsCli As New DataSet
        dsCli.Tables.Add("Clientes")
        adpCli.Fill(dsCli.Tables("Clientes"))

        ' Suponiendo que tu ComboBox de cliente se llama ComboBoxCliente
        Me.CB_Clientes.DataSource = dsCli.Tables("Clientes")
        Me.CB_Clientes.DisplayMember = "razon_social"
        Me.CB_Clientes.ValueMember = "id_cliente"

        ' 2. Cargar Formas de Pago
        Dim adpFP As New SqlClient.SqlDataAdapter("exec spu_mostrar_forma_pago", conexion)
        Dim dsFP As New DataSet
        dsFP.Tables.Add("FormaPago")
        adpFP.Fill(dsFP.Tables("FormaPago"))

        ' Suponiendo que tu ComboBox de pago se llama ComboBoxFormaPago
        Me.CB_FormaPago.DataSource = dsFP.Tables("FormaPago")
        Me.CB_FormaPago.DisplayMember = "DESCRIPCION_FORMA_PAGO"
        Me.CB_FormaPago.ValueMember = "id_forma_pago"

    End Sub

    Private Sub BtnGenerarComprobante_Click(sender As Object, e As EventArgs) Handles BtnGenerarComprobante.Click
        ' 1. Obtenemos el ID de la venta actual desde la etiqueta de la interfaz
        Dim idVenta As Integer

        ' Limpiamos el texto del label para quedarnos solo con el número entero
        Dim textoLabel As String = Me.Lbl_Venta_N.Text.Replace("Venta N°:", "").Trim()

        If Integer.TryParse(textoLabel, idVenta) Then
            Try
                AbrirConexion()

                ' 2. Ejecutamos el procedimiento almacenado que recopila todos los datos del ticket
                Dim sql As String = "exec spu_imprimir_comprobante_venta " & idVenta
                Dim adp As New SqlClient.SqlDataAdapter(sql, conexion)
                Dim ds As New DataSet

                ds.Tables.Add("ComprobanteVenta")
                adp.Fill(ds.Tables("ComprobanteVenta"))

                ' 3. Validamos que la venta tenga registros asociados
                If ds.Tables("ComprobanteVenta").Rows.Count > 0 Then
                    MsgBox("Comprobante listo para la venta Nro: " & idVenta, MsgBoxStyle.Information, "Éxito")

                    ' AQUÍ ABRES TU FORMULARIO DE IMPRESIÓN/REPORTE Y LE PASAS EL DATASOURCE
                    ' Ejemplo:
                    ' Dim frmReporte As New FrmReporteTicket()
                    ' frmReporte.DsComprobante = ds
                    ' frmReporte.ShowDialog()

                Else
                    MsgBox("No se encontraron registros para esta venta.", MsgBoxStyle.Exclamation, "Aviso")
                End If

            Catch ex As Exception
                MsgBox("Error al generar el comprobante: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        Else
            MsgBox("No hay un número de venta válido seleccionado.", MsgBoxStyle.Exclamation, "Atención")
        End If
    End Sub
End Class