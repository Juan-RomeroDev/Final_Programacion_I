Public Class FrmProductos
'FUNCION MODO EDICION PARA ACTIVAR O DESACTIVAR BOTONES DE MODIFICACION Y ELIMINACION
Private modoEdicion As Boolean = False ' Variable para controlar el modo de edición

    ' Listado completo de productos (spu_mostrar_productos). Los buscadores muestran otros resultados
    ' en la grilla, pero al hacer clic en una fila siempre completo las cajas desde este listado.
    Private dtProductos As DataTable

    Private Sub FrmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConexion()
        llenarProductos()

        ' Al arrancar, bloqueo todo para que solo se pueda dar de Alta o Buscar
        Bloquear()

        ' FORZAMOS EL FOCO A LA GRILLA
        Me.dgvProductos.Focus()
    End Sub

    ' =========================================================
    ' CELDAS DE LA GRILLA Y SUS FUNCIONES
    ' =========================================================

    Private Sub dgvProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellContentClick
        ' Valido que el clic sea en una fila real y no en los títulos de arriba
        If e.RowIndex >= 0 Then
            ' Asigno CADA columna a su caja correspondiente respetando el orden de la BD
            Me.TxtID_Producto.Text = Me.dgvProductos.Rows(e.RowIndex).Cells(0).Value.ToString()
            Me.TxtDescripcion.Text = Me.dgvProductos.Rows(e.RowIndex).Cells(1).Value.ToString()
            Me.TxtPrecio.Text = Me.dgvProductos.Rows(e.RowIndex).Cells(2).Value.ToString()
            Me.TxtStock.Text = Me.dgvProductos.Rows(e.RowIndex).Cells(3).Value.ToString()
            Me.TxtID_Rubro.Text = Me.dgvProductos.Rows(e.RowIndex).Cells(4).Value.ToString()

            ' ¿El usuario apretó "Gestionar Productos" antes?
            If modoEdicion = True Then
                ' Bloqueando Alta y desbloqueando Modifica y Baja
                Me.btnAltaProducto.Enabled = False
                Me.btnModificaProducto.Enabled = True
                Me.btnBajaProducto.Enabled = True

                ' REGLA DE ORO: Bloqueo el ID (no se toca)
                Me.TxtID_Producto.Enabled = False

                ' Habilito el resto para modificar
                Me.TxtDescripcion.Enabled = True
                Me.TxtPrecio.Enabled = True
                Me.TxtStock.Enabled = True

                ' El Rubro queda habilitado pero ReadOnly: se elige con ENTER (abre Rubros)
                Me.TxtID_Rubro.Enabled = True
                Me.TxtID_Rubro.ReadOnly = True
            End If
        End If
    End Sub

    ' =========================================================
    ' EVENTOS KEYDOWN (ENTER) PARA ABRIR BÚSQUEDAS Y BOTONES
    ' =========================================================

    Private Sub dgvProductos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellDoubleClick
        If wflag = 5 Then ' 5 ES LA SEÑAL DE CLIENTES
            wID_Rubro = Me.dgvProductos.CurrentRow.Cells(0).Value
            wNombre_Rubro = Me.dgvProductos.CurrentRow.Cells(1).Value.ToString()
            Me.Close()
        End If
    End Sub

    ' EVENTO: APRETAR LA TECLA ENTER
    Private Sub dgvProductos_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvProductos.KeyDown
        If wflag = 5 And e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            wID_Rubro = Me.dgvProductos.CurrentRow.Cells(0).Value
            wNombre_Rubro = Me.dgvProductos.CurrentRow.Cells(1).Value.ToString()
            Me.Close()
        End If
    End Sub

    Private Sub TxtID_Rubro_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtID_Rubro.KeyDown
        ' Verificacion si apreto Enter para abrir la pantalla de Rubros
        If e.KeyCode = Keys.Enter Then

            ' Esto evita que suene el "Tilin" de error de Windows al apretar Enter
            e.SuppressKeyPress = True

            ' Indica que se está buscando un Rubro para el Producto
            ' (ajustá el número al que use tu frmRubros para devolver el valor)
            wflag = 5

            ' Abro la pantalla de Rubros
            Dim frm As New FrmRubros()
            frm.ShowDialog()

            If wID_Rubro <> 0 Then
                Me.TxtID_Rubro.Text = wID_Rubro
            End If

            ' Reset a las variables de control
            wflag = 0
            wID_Rubro = 0
        End If
    End Sub

    Private Sub BtnBuscarRubro_Click(sender As Object, e As EventArgs) Handles BtnBuscarRubro.Click
        wflag = 5
        Dim frm As New FrmRubros()
        frm.ShowDialog()

        If wID_Rubro <> 0 Then
            Me.TxtID_Rubro.Text = wID_Rubro
        End If

        wflag = 0
        wID_Rubro = 0
    End Sub

    ' =========================================================
    ' BUSCADORES
    ' =========================================================

    Private Sub TxtBuscarProducto_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarProducto.TextChanged
        'Consulta llamando al procedimiento almacenado que filtra por descripcion producto
        Dim descrpcion As String = Me.TxtBuscarProducto.Text.Trim()
        Dim sql As String = "exec spu_buscar_producto_X_producto '" & descrpcion & "'"

        Try
            'DataAdapter para ejecutar la búsqueda y refrescar la grilla en tiempo real
            Dim adp As New SqlClient.SqlDataAdapter(sql, conexion)
            Dim ds As New DataSet

            ds.Tables.Add("ProductosFiltrados")
            adp.Fill(ds.Tables("ProductosFiltrados"))

            'Asigno el resultado a la grilla
            Me.dgvProductos.DataSource = ds.Tables("ProductosFiltrados")

        Catch ex As Exception
            MsgBox("Error al buscar producto: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    ' TextBox3 es el buscador de "Buscar Rubro Por Producto" (conviene renombrarlo a TxtBuscarRubroPorProducto)
    Private Sub TexBuscarRubroPorProducto_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarRubroPorProducto.TextChanged
        'Consulta llamando al procedimiento almacenado que filtra por rubro en producto
        Dim rubro_producto As String = Me.TxtBuscarRubroPorProducto.Text.Trim()
        Dim sql As String = "exec spu_buscar_rubro_X_producto '" & rubro_producto & "'"

        Try
            'DataAdapter para ejecutar la búsqueda y refrescar la grilla en tiempo real
            Dim adp As New SqlClient.SqlDataAdapter(sql, conexion)
            Dim ds As New DataSet

            ds.Tables.Add("RubrosFiltrados")
            adp.Fill(ds.Tables("RubrosFiltrados"))

            'Asigno el resultado a la grilla
            Me.dgvProductos.DataSource = ds.Tables("RubrosFiltrados")

        Catch ex As Exception
            MsgBox("Error al buscar Rubro Por Producto: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    ' =========================================================
    ' FUNCIONES CRUD (ALTA, BAJA, MODIFICACIÓN)
    ' =========================================================

    Private Sub Bloquear()
        modoEdicion = False

        ' La grilla/formulario vuelve a estar toda bloqueada
        Me.TxtID_Producto.Enabled = False
        Me.TxtDescripcion.Enabled = False
        Me.TxtPrecio.Enabled = False
        Me.TxtStock.Enabled = False
        Me.TxtID_Rubro.Enabled = False

        Me.TxtID_Rubro.BackColor = ColorTranslator.FromOle(&HFFFF) 'Color Amarillo

        ' BLOQUEAMOS TODOS LOS BOTONES
        Me.btnAltaProducto.Enabled = False
        Me.btnModificaProducto.Enabled = False
        Me.btnBajaProducto.Enabled = False
    End Sub

    Private Sub LimpiarCajas()
        Me.TxtID_Producto.Clear()
        Me.TxtDescripcion.Clear()
        Me.TxtPrecio.Clear()
        Me.TxtStock.Clear()
        Me.TxtID_Rubro.Clear()
    End Sub

    Private Sub llenarProductos()
        ' Llamo al procedimiento almacenado que me devuelve todos los productos
        Dim sql As String = "exec spu_mostrar_productos"
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion)
        Dim ds As New DataSet

        ' Lleno la tabla temporal
        ds.Tables.Add("Productos")
        adp.Fill(ds.Tables("Productos"))

        ' Asigno los datos a la grilla
        Me.dgvProductos.DataSource = ds.Tables("Productos")

        ' FORMATO DE LA GRILLA
        ' Acá solo tengo 6 columnas, así que no hace falta ocultar nada

        ' Hace que la grilla ocupe todo el ancho sin scroll horizontal
        Me.dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' ORDEN ESTRICTO DE SQL
        Me.dgvProductos.Columns(0).FillWeight = 40   ' ID_CLIENTE
        Me.dgvProductos.Columns(1).FillWeight = 160  ' DESCRIPCION
        Me.dgvProductos.Columns(2).FillWeight = 50   ' PRECIO
        Me.dgvProductos.Columns(3).FillWeight = 120  ' STOCK
        Me.dgvProductos.Columns(4).FillWeight = 40   ' ID_RUBRO


        Me.dgvProductos.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvProductos.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvProductos.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvProductos.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvProductos.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Bloquear()
    End Sub

    'FUNCION PARA GENERAR + 1 ID DE PRODUCTO
    Private Sub generarIdProducto()
        Try
            AbrirConexion()
            cmd.CommandText = "exec spu_generar_id_producto"

            Dim nuevoID As Object = cmd.ExecuteScalar() 'Lo mejor para escalar ID, devuelve un objeto que puede ser DBNull si no hay datos

            If nuevoID IsNot Nothing AndAlso Not IsDBNull(nuevoID) Then
                Me.TxtID_Producto.Text = nuevoID.ToString()
            Else
                Me.TxtID_Producto.Text = "1"
            End If

        Catch ex As Exception
            MsgBox("Error al generar ID: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    'FUNCION DAR DE ALTA UN PRODUCTO
    Private Sub altaProductos()
        Dim altaProd As New Clases.Productos
        altaProd.id_producto = Me.TxtID_Producto.Text.Trim()
        altaProd.descripcion = Esc(Me.TxtDescripcion.Text.Trim())
        altaProd.precio = NumeroParaSql(Me.TxtPrecio.Text)
        altaProd.stock = NumeroParaSql(Me.TxtStock.Text)
        altaProd.id_rubro = Me.TxtID_Rubro.Text.Trim()

        'Cuidado con los espacios después del nombre del spu. ID, precio, stock y rubro van SIN comillas; la descripción CON comillas simples
        'Orden de los parámetros de spu_alta_producto: id_producto, descripcion, precio, stock, id_rubro
        Dim sql As String = "exec spu_alta_producto " & altaProd.id_producto & ", '" & altaProd.descripcion & "', " & altaProd.precio & ", " & altaProd.stock & ", " & altaProd.id_rubro
        cmd.CommandText = sql
        MsgBox("SE DARA DE ALTA UN PRODUCTO",, "INFO")
        'Captura de error(Por si ocurre un improbable error en la BD :) )
        Try
            AbrirConexion()
            cmd.ExecuteNonQuery()
            MsgBox("PRODUCTO CREADO CON EXITO",, "INFO")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    'FUNCION PARA MODIFICAR LOS DATOS EN LA GRILLA DE PRODUCTOS
    Private Sub modificarProductos()
        'Lee los 5 datos de los textboxes (ID, Descripcion, Precio, Stock, ID Rubro)
        Dim id As String = Me.TxtID_Producto.Text.Trim()
        Dim descripcion As String = Esc(Me.TxtDescripcion.Text.Trim())
        Dim precio As String = NumeroParaSql(Me.TxtPrecio.Text)
        Dim stock As String = NumeroParaSql(Me.TxtStock.Text)
        Dim idRubro As String = Me.TxtID_Rubro.Text.Trim()

        'SQL Store Procedure para modificar el producto (mismo orden de parámetros que el alta).
        'CUIDADO: ID, precio, stock y rubro van SIN comillas simples (son numéricos). La descripción va CON comillas simples.
        Dim sql As String = "exec spu_modificar_producto " & id & ", '" & descripcion & "', " & precio & ", " & stock & ", " & idRubro
        cmd.CommandText = sql

        MsgBox("SE MODIFICARÁ EL PRODUCTO", , "INFO")

        Try
            cmd.ExecuteNonQuery() ' Ejecuta la modificación en SQL
            MsgBox("PRODUCTO MODIFICADO CON EXITO", , "INFO")
            ' llenarProductos() para que la grilla muestre el cambio
            llenarProductos()

            ' Limpiar las cajas de texto después de modificar
            LimpiarCajas()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Bloquear()
    End Sub

    'FUNCION DAR DE BAJA, ELIMINAR UN PRODUCTO
    Private Sub bajaProductos()
        ' Verifico que haya un producto seleccionado
        If Me.TxtID_Producto.Text.Trim() = "" Then
            MsgBox("Por favor, seleccione un producto de la lista para eliminar.", MsgBoxStyle.Exclamation, "Datos incompletos")
            Exit Sub
        End If

        ' Le pregunto al usuario si está seguro
        Dim respuesta As DialogResult
        respuesta = MsgBox("¿Está seguro que desea eliminar el producto con ID: " & Me.TxtID_Producto.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmar Baja")

        ' Si el usuario dijo que SÍ, ejecuto el borrado
        If respuesta = DialogResult.Yes Then
            Dim id As String = Me.TxtID_Producto.Text
            ' Armo la consulta apuntando al procedimiento de baja (usa el ID)
            Dim sql As String = "exec spu_baja_producto " & id
            cmd.CommandText = sql

            Try
                cmd.ExecuteNonQuery()
                MsgBox("PRODUCTO ELIMINADO CON EXITO", MsgBoxStyle.Information, "INFO")

                ' Recargo la grilla para que desaparezca la fila borrada
                llenarProductos()

                ' Limpiamos las cajas
                LimpiarCajas()
            Catch ex As Exception
                ' Si el producto ya está en alguna venta (detalle_venta), SQL lo rechaza por la clave foránea
                MsgBox("No se pudo eliminar el producto (puede estar usado en una venta): " & ex.Message, MsgBoxStyle.Exclamation, "Error")
            End Try
        End If

        Bloquear()
    End Sub

    ' =========================================================
    ' BOTONES, TXT Y SUS FUNCIONES (EVENTOS)
    ' =========================================================

    'BOTON DE DAR ALTA UN PRODUCTO
    Private Sub btnAltaProducto_Click(sender As Object, e As EventArgs) Handles btnAltaProducto.Click

        ' Valida que no haya nada en blanco y que precio y stock sean números
        If Me.TxtID_Producto.Text.Trim() = "" Or Me.TxtDescripcion.Text.Trim() = "" Or Me.TxtPrecio.Text.Trim() = "" Or Me.TxtStock.Text.Trim() = "" Or Me.TxtID_Rubro.Text.Trim() = "" Then
            MsgBox("Por favor, complete todos los campos obligatorios.", MsgBoxStyle.Exclamation, "Datos incompletos")
            Exit Sub
        End If


        ' Valida que el precio sea numérico
        If Not IsNumeric(Me.TxtPrecio.Text.Trim()) Then
            MsgBox("El precio debe ser un número válido.", MsgBoxStyle.Exclamation, "Dato inválido")
            Exit Sub
        End If

        ' Valida que el stock sea numérico
        If Not IsNumeric(Me.TxtStock.Text.Trim()) Then
            MsgBox("El stock debe ser un número válido.", MsgBoxStyle.Exclamation, "Dato inválido")
            Exit Sub
        End If

        ' Vuelvo a llenar la grilla para que se vea el producto recién cargado
        altaProductos()
        llenarProductos()

        ' Limpio los textboxes
        LimpiarCajas()
    End Sub

    ' EVENTO DEL BOTÓN MODIFICA
    Private Sub btnModificaProducto_Click(sender As Object, e As EventArgs) Handles btnModificaProducto.Click
        ' Validar que haya un ID seleccionado
        If Me.TxtID_Producto.Text.Trim() = "" Then
            MsgBox("Debe seleccionar un producto de la lista para modificar.", MsgBoxStyle.Exclamation, "Sin selección")
            Exit Sub
        End If

        ' Valida que no haya nada en blanco y que precio y stock sean números
        If Me.TxtID_Producto.Text.Trim() = "" Or Me.TxtDescripcion.Text.Trim() = "" Or Me.TxtPrecio.Text.Trim() = "" Or Me.TxtStock.Text.Trim() = "" Or Me.TxtID_Rubro.Text.Trim() = "" Then
            MsgBox("Por favor, complete todos los campos obligatorios.", MsgBoxStyle.Exclamation, "Datos incompletos")
            Exit Sub
        End If

        ' Valida que el precio sea numérico
        If Not IsNumeric(Me.TxtPrecio.Text.Trim()) Then
            MsgBox("El precio debe ser un número válido.", MsgBoxStyle.Exclamation, "Dato inválido")
            Exit Sub
        End If

        ' Valida que el stock sea numérico
        If Not IsNumeric(Me.TxtStock.Text.Trim()) Then
            MsgBox("El stock debe ser un número válido.", MsgBoxStyle.Exclamation, "Dato inválido")
            Exit Sub
        End If

        ' Si pasó los controles, ejecuta la modificación
        modificarProductos()
    End Sub

    Private Sub btnBajaProducto_Click(sender As Object, e As EventArgs) Handles btnBajaProducto.Click
        bajaProductos()
    End Sub

    Private Sub BtnAtrasProductos_Click(sender As Object, e As EventArgs) Handles BtnAtrasProductos.Click
        Me.Close()
    End Sub

    Private Sub BtnGestionarProducto_Click(sender As Object, e As EventArgs) Handles BtnGestionarProducto.Click
        ' ESTA ES LA LLAVE: antes de apretar "Gestionar Productos", hacer click en la grilla no activa Modifica y Baja
        modoEdicion = True

        ' Se limpian las cajas
        LimpiarCajas()

        ' limpiar  el LblRubroFiltrado
        Me.LblRubroFiltrado.Text = ""

        ' Generar el nuevo ID (después de limpiar)
        generarIdProducto()

        ' Habilito las cajas para que se pueda escribir los datos nuevos
        Me.TxtID_Producto.Enabled = False ' ID se genera solo, no se puede escribir
        Me.TxtDescripcion.Enabled = True
        Me.TxtPrecio.Enabled = True
        Me.TxtStock.Enabled = True

        ' Primero la habilito y despues le doy el ReadOnly para poder seleccionar el Txt (ENTER abre Rubros)
        Me.TxtID_Rubro.Enabled = True
        Me.TxtID_Rubro.ReadOnly = True

        'HABLITO LOS BTN BUSCAR PARA FILTRAR LOCALIDAD
        Me.BtnBuscarRubro.Enabled = True

        ' El usuario decide escribir para dar de Alta.
        ' Desbloqueo Alta y Bloqueo Modifica y Baja.
        Me.btnAltaProducto.Enabled = True
        Me.btnModificaProducto.Enabled = False
        Me.btnBajaProducto.Enabled = False

        Me.TxtDescripcion.Focus() ' El foco va directo a Descripción
    End Sub

    ' =========================================================
    ' VALIDACIONES
    ' =========================================================

    ' Precio y Stock son DECIMAL en la BD: permito dígitos, teclas de control y UN solo separador decimal (coma o punto)
    Private Sub TxtDecimales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPrecio.KeyPress, TxtStock.KeyPress
        Dim txt As TextBox = DirectCast(sender, TextBox)

        If Char.IsControl(e.KeyChar) OrElse Char.IsDigit(e.KeyChar) Then Exit Sub

        If (e.KeyChar = "," OrElse e.KeyChar = ".") AndAlso Not (txt.Text.Contains(",") OrElse txt.Text.Contains(".")) Then Exit Sub

        e.Handled = True
        MsgBox("Atención: este campo solo acepta números.", MsgBoxStyle.Exclamation, "Dato inválido")
    End Sub

    ' Precio y stock son DECIMAL: van a SQL con PUNTO decimal (si el usuario escribe "12,5" lo convierto a "12.5")
    Private Function NumeroParaSql(texto As String) As String
        Return Decimal.Parse(texto.Trim()).ToString(System.Globalization.CultureInfo.InvariantCulture)
    End Function

    ' Duplica las comillas simples para que un texto como "Pan d'oro" no rompa el exec
    Private Function Esc(texto As String) As String
        Return texto.Replace("'", "''")
    End Function

End Class
