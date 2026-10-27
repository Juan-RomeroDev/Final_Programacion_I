Public Class FrmPOS

    ' 1. Declara el DataTable del carrito a nivel de clase (fuera de cualquier Sub)
    Private dtCarrito As New DataTable()

    Private Sub FrmPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConexion()
        llenarProductos()
        CargarCombosBoxClientesFormaPago()

        ' Llamamos a la función que inicializa las columnas del carrito
        InicializarCarrito()

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
        Dim sql As String = "exec spu_buscar_producto_X_producto"
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

    'FUNCION PARA GENERAR + 1 ID DE VENTA
    Private Sub generarIdCliente()
        Try
            AbrirConexion()
            cmd.CommandText = "exec spu_generar_id_cliente"

            Dim nuevoID As Object = cmd.ExecuteScalar() 'Lo mejor para escalar ID, devuelve un objeto que puede ser DBNull si no hay datos

            If nuevoID IsNot Nothing AndAlso Not IsDBNull(nuevoID) Then
                'Me.TxtIDCliente.Text = nuevoID.ToString()
            Else
                'Me.TxtIDCliente.Text = "1"
            End If

        Catch ex As Exception
            MsgBox("Error al generar ID: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

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

            ' 2. Validación rápida de stock
            If stock <= 0 Then
                MsgBox("Atención: El producto seleccionado no cuenta con stock disponible.", MsgBoxStyle.Exclamation, "Sin Stock")
                Exit Sub
            End If

            ' 3. Cantidad por defecto al agregar
            Dim cantidad As Integer = 1

            ' 4. Inyectamos los datos en la tabla temporal del carrito
            dtCarrito.Rows.Add(idProducto, descripcion, precio, cantidad)
        End If
    End Sub

    'CALCULAR TOTAL DEL CARRITO
    Private Sub CalcularTotalGeneral()
        Dim totalGeneral As Decimal = 0

        For Each fila As DataRow In dtCarrito.Rows
            totalGeneral += Convert.ToDecimal(fila("SUBTOTAL"))
        Next

        ' Mostramos el resultado en tu etiqueta de total (ajusta el nombre al que tenga tu diseño)
        ' Me.LblTotal.Text = "$ " & totalGeneral.ToString("N2")
    End Sub

    Private Sub BtnFinalizarVenta_Click(sender As Object, e As EventArgs) Handles BtnFinalizarVenta.Click

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
        Me.CB_FormaPago.DisplayMember = "descripcion"
        Me.CB_FormaPago.ValueMember = "id_forma_pago"

    End Sub

End Class
