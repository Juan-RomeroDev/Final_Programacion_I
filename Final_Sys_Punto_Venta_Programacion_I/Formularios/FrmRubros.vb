Public Class FrmRubros
    'FUNCION MODO EDICION PARA ACTIVAR O DESACTIVAR BOTONES DE MODIFICACION Y ELIMINACION 
    Private modoEdicion As Boolean = False ' Variable para controlar el modo de edición
    Private Sub FrmRubros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConexion()
        llenarRubros()

        ' Al arrancar, bloqueo todo 
        Bloquear()
    End Sub

    ' =========================================================
    ' CELDAS DE LA GRILLA Y SUS FUNCIONES 
    ' =========================================================

    Private Sub dgvRubros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRubros.CellContentClick
        ' Valido que el clic sea en una fila real y no en los títulos de arriba
        If e.RowIndex >= 0 Then
            ' Paso el CP (Columna 0) y la Localidad (Columna 1) a los textboxes
            Me.TxtIDRubro.Text = Me.dgvRubros.Rows(e.RowIndex).Cells(0).Value.ToString()
            Me.TxtDescripcionRubro.Text = Me.dgvRubros.Rows(e.RowIndex).Cells(1).Value.ToString()

            ' 2. ¿El usuario apretó "Gestionar Rubros" antes?
            If modoEdicion = True Then
                ' Paso 4: Bloqueando Alta y desbloqueando Modifica y Baja
                Me.btnAltaRubro.Enabled = False
                Me.btnModificaRubro.Enabled = True
                Me.btnBajaRubro.Enabled = True

                ' REGLA DE ORO: Bloqueo el CP para que no lo cambie, 
                ' pero habilitamos la Localidad por si quiere modificar el nombre.
                Me.TxtIDRubro.Enabled = False
                Me.TxtDescripcionRubro.Enabled = True
            End If
            ' Si modoEdicion es False (no tocó el botón), pasa de largo y no enciende nada.
        End If
    End Sub

    ' EVENTO: DOBLE CLIC EN LA GRILLA DE RUBROS
    Private Sub dgvRubros_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRubros.CellDoubleClick
        If wflag = 6 OrElse wflag = 5 Then ' wflag 6 = Reporte, wflag 5 = Selección desde Productos
            wID_Rubro = Convert.ToInt32(Me.dgvRubros.CurrentRow.Cells(0).Value)
            wNombre_Rubro = Me.dgvRubros.CurrentRow.Cells(1).Value.ToString()
            Me.Close()
        End If
    End Sub

    ' EVENTO: APRETAR LA TECLA ENTER EN LA GRILLA DE RUBROS
    Private Sub dgvRubros_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvRubros.KeyDown
        If (wflag = 6 OrElse wflag = 5) AndAlso e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            wID_Rubro = Convert.ToInt32(Me.dgvRubros.CurrentRow.Cells(0).Value)
            wNombre_Rubro = Me.dgvRubros.CurrentRow.Cells(1).Value.ToString()
            Me.Close()
        End If
    End Sub

    ' =========================================================
    ' FUNCIONES CRUD (ALTA, BAJA, MODIFICACIÓN)
    ' =========================================================

    ' Bloquea los cuadros de texto y vuelve al modo lectura/alta inicial
    Private Sub Bloquear()
        ' Paso 5: La grilla/formulario vuelve a estar toda bloqueada
        Me.TxtIDRubro.Enabled = False
        Me.TxtDescripcionRubro.Enabled = False

        Me.btnAltaRubro.Enabled = False
        Me.btnModificaRubro.Enabled = False
        Me.btnBajaRubro.Enabled = False

        ' El botón Gestionar Rubros siempre queda habilitado desde el diseño

        ' Si modoEdicion es False (no tocó el botón), pasa de largo y no enciende nada.
        modoEdicion = False
    End Sub

    'FUNCION DAR DE ALTA UN RUBRO
    Private Sub altaRubros()
        Dim altaRubro As New Rubros
        altaRubro.idRubro = (Me.TxtIDRubro.Text)
        altaRubro.descripcionRubro = Me.TxtDescripcionRubro.Text.Trim()

        'Cuidado con los espacios: Dim sql As String = "exec spu_alta_rubro" & altaRubro.idRubro & ",'" & altaRubro.descripcionRubro & "'"
        Dim sql As String = "exec spu_alta_rubro " & altaRubro.idRubro & ", '" & altaRubro.descripcionRubro & "'"
        cmd.CommandText = sql
        MsgBox("SE DARA DE ALTA UN RUBRO",, "INFO")
        'Captura de error(Por si ocurre un improbable error en la BD :) ) 
        Try
            AbrirConexion()
            cmd.ExecuteNonQuery()
            MsgBox("RUBRO CREADO CON EXITO",, "INFO")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    'FUNCION LLENAR Y RECARGAR COMO F5 GRILLA RUBROS 
    Private Sub llenarRubros()
        ' Llamo al procedimiento almacenado que me devuelve todos los rubros
        Dim sql As String = "exec spu_mostrar_rubros"
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion)
        Dim ds As New DataSet

        ' Lleno la tabla temporal
        ds.Tables.Add("rubros")
        adp.Fill(ds.Tables("rubros"))

        ' Asigno los datos a la grilla
        Me.dgvRubros.DataSource = ds.Tables("rubros")
        ' FORMATO DE LA GRILLA 
        ' Hace que la grilla ocupe todo el ancho sin scroll horizontal
        Me.dgvRubros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' Acá solo tengo 2 columnas (0 = CP, 1 = LOCALIDAD), así que no hace falta ocultar nada
        Me.dgvRubros.Columns(0).Width = 50
        Me.dgvRubros.Columns(1).Width = 350

        Me.dgvRubros.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvRubros.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Bloquear() ' <--- ¡Acá cierro el ciclo del Paso 5
    End Sub

    Private Sub generarIdRubro()
        Try
            AbrirConexion()
            cmd.CommandText = "exec spu_generar_id_rubro"

            Dim nuevoID As Object = cmd.ExecuteScalar() 'Lo mejor para escalar ID, devuelve un objeto que puede ser DBNull si no hay datos 

            If nuevoID IsNot Nothing AndAlso Not IsDBNull(nuevoID) Then
                Me.TxtIDRubro.Text = nuevoID.ToString()
            Else
                Me.TxtIDRubro.Text = "1"
            End If

        Catch ex As Exception
            MsgBox("Error al generar ID: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    'FUNCION PARA MODIFICAR LOS DATOS EN LA GRILLA DE RUBROS
    Private Sub modificarRubros()
        Dim idRubro As String = Me.TxtIDRubro.Text
        Dim descripcionRubro As String = Me.TxtDescripcionRubro.Text.Trim

        Dim sql As String = "exec spu_modificar_rubro " & idRubro & ", '" & descripcionRubro & "'"
        cmd.CommandText = sql

        MsgBox("SE MODIFICARÁ EL RUBRO", , "INFO")

        Try
            cmd.ExecuteNonQuery() ' Ejecuta la modificación en SQL
            MsgBox("RUBRO MODIFICADO CON EXITO", , "INFO")
            ' llenarRubros() para que la grilla muestre el cambio
            llenarRubros()

            ' Limpiar las cajas de texto después de modificar
            Me.TxtIDRubro.Clear()
            Me.TxtDescripcionRubro.Clear()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Bloquear() ' <--- ¡Acá cierro el ciclo del Paso 5
    End Sub

    'FUNCION DAR DE BAJA, ELIMINAR UN RUBRO
    Private Sub bajaRubros()
        ' Verifico que al menos el ID no esté vacío
        If Me.TxtIDRubro.Text.Trim() = "" Then
            MsgBox("Por favor, seleccione o ingrese un ID de rubro para eliminar.", MsgBoxStyle.Exclamation, "Datos incompletos")
            Exit Sub
        End If

        ' Le pregunto al usuario si está seguro
        Dim respuesta As DialogResult
        respuesta = MsgBox("¿Está seguro que desea eliminar el rubro con ID: " & Me.TxtIDRubro.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmar Baja")

        ' Si el usuario dijo que SÍ, ejecuto el borrado
        If respuesta = DialogResult.Yes Then
            Dim idRubro As String = Me.TxtIDRubro.Text

            ' Armo la consulta apuntando al procedimiento de baja
            Dim sql As String = "exec spu_baja_rubro " & idRubro
            cmd.CommandText = sql

            Try
                cmd.ExecuteNonQuery()
                MsgBox("RUBRO ELIMINADO CON EXITO", MsgBoxStyle.Information, "INFO")

                ' Recargo la grilla para que desaparezca la fila borrada
                llenarRubros()

                ' Limpiamos las cajas
                Me.TxtIDRubro.Clear()
                Me.TxtDescripcionRubro.Clear()

            Catch ex As SqlClient.SqlException
                ' El código 547 es el error específico de SQL cuando hay datos enlazados
                If ex.Number = 547 Then
                    MsgBox("No se puede eliminar este rubro porque hay clientes registrados en él. Primero debe modificar a esos clientes.", MsgBoxStyle.Critical, "Acción denegada")
                Else
                    MsgBox("Error de base de datos: " & ex.Message)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        Bloquear() ' <--- ¡Acá cierro el ciclo del Paso 5
    End Sub

    ' =========================================================
    ' BOTONES, TXT Y SUS FUNCIONES (EVENTOS)
    ' =========================================================

    'BOTON DE DAR ALTA UN RUBRO
    Private Sub btnAltaRubro_Click(sender As Object, e As EventArgs) Handles btnAltaRubro.Click
        ' Validar que no haya campos en blanco 
        If Me.TxtIDRubro.Text.Trim() = "" Or Me.TxtDescripcionRubro.Text.Trim() = "" Then
            MsgBox("Por favor, complete el ID y la Descripción del Rubro.", MsgBoxStyle.Exclamation, "Datos incompletos")
            Exit Sub
        End If

        ' Si paso la validacion, guarda en SQL
        altaRubros()

        Try
            ' Vuelvo a llenar la grilla para que se vea el rubro recién cargado
            llenarRubros()

            ' Limpio los textboxes y pongo el foco en el primero
            Me.TxtIDRubro.Clear()
            Me.TxtDescripcionRubro.Clear()
            Me.TxtIDRubro.Select()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnGestionarRubros_Click(sender As Object, e As EventArgs) Handles BtnGestionarRubros.Click
        ' ESTA ES LA LLAVE para el error de antes de apretar el boton gestionar rubros hagas click en la grilla y se activen los modifica y baja
        modoEdicion = True


        ' Paso 2: Los dos textboxes se limpian
        Me.TxtIDRubro.Clear()
        Me.TxtDescripcionRubro.Clear()

        ' Generar el nuevo ID (después de limpiar)
        generarIdRubro()

        Me.TxtIDRubro.Enabled = False

        ' Habilito las cajas para que se pueda escribir los datos nuevos
        Me.TxtDescripcionRubro.Enabled = True

        ' Paso 3: El usuario decide escribir para dar de Alta. 
        ' Desbloqueo Alta y Bloqueo Modifica y Baja.
        Me.btnAltaRubro.Enabled = True
        Me.btnModificaRubro.Enabled = False
        Me.btnBajaRubro.Enabled = False

        Me.TxtIDRubro.Focus() ' Ponemos el cursor en la caja del ID Rubro
    End Sub

    ' BOTÓN BAJA, ELIMINAR UN RUBRO
    Private Sub btnBajaRubro_Click(sender As Object, e As EventArgs) Handles btnBajaRubro.Click
        bajaRubros()
    End Sub

    ' EVENTO DEL BOTÓN MODIFICA (Asegurate de que tu botón se llame así en el diseño)
    Private Sub btnModificaRubro_Click(sender As Object, e As EventArgs) Handles btnModificaRubro.Click
        ' Validar que haya un rubro seleccionado
        If Me.TxtIDRubro.Text.Trim() = "" Then
            MsgBox("Debe seleccionar un rubro de la lista para modificar.", MsgBoxStyle.Exclamation, "Sin selección")
            Exit Sub
        End If

        ' Validar que no queden campos en blanco 
        If Me.TxtIDRubro.Text.Trim() = "" Or Me.TxtDescripcionRubro.Text.Trim() = "" Then
            MsgBox("No puede dejar campos vacíos al modificar el rubro.", MsgBoxStyle.Exclamation, "Datos incompletos")
            Exit Sub
        End If

        ' Si pasó los controles, ejecuta la modificación


        modificarRubros()
    End Sub

    Private Sub BtnAtrasRubros_Click(sender As Object, e As EventArgs) Handles BtnAtrasRubros.Click
        Me.Close()
    End Sub

    Private Sub BtnGenerarComprobante_Click(sender As Object, e As EventArgs) Handles BtnGenerarComprobante.Click
        Dim frmImprimirRubros As New FrmImprimir_Rubros
        frmImprimirRubros.ShowDialog()
    End Sub

    Private Sub TxtBuscarRubro_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarRubro.TextChanged
        Dim rubroBuscado As String = Me.TxtBuscarRubro.Text.Trim()

        If rubroBuscado = "" Then
            llenarRubros()
            Exit Sub
        End If

        ' Consulta llamando al procedimiento almacenado de búsqueda
        Dim sql As String = "exec spu_buscar_rubro '" & rubroBuscado & "'"

        Try
            Dim adp As New SqlClient.SqlDataAdapter(sql, conexion)
            Dim ds As New DataSet

            ds.Tables.Add("RubrosFiltrados")
            adp.Fill(ds.Tables("RubrosFiltrados"))

            ' Asignamos los datos filtrados a la grilla
            Me.dgvRubros.DataSource = ds.Tables("RubrosFiltrados")

            ' Aplicamos el formato prolijo a las columnas
            Me.dgvRubros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            If Me.dgvRubros.Columns.Count >= 2 Then
                Me.dgvRubros.Columns(0).Width = 50
                Me.dgvRubros.Columns(1).Width = 350
                Me.dgvRubros.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.dgvRubros.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End If

        Catch ex As Exception
            MsgBox("Error al buscar rubro: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class