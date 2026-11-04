Imports System.Drawing.Imaging
Imports sys_banco_izo.clases

Public Class frmLocalidades
    'FUNCION MODO EDICION PARA ACTIVAR O DESACTIVAR BOTONES DE MODIFICACION Y ELIMINACION 
    Private modoEdicion As Boolean = False ' Variable para controlar el modo de edición
    Private Sub frmLocalidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConexion()
        llenarLocalidades()

        ' Al arrancar, bloqueo todo 
        Bloquear()
    End Sub

    ' =========================================================
    ' CELDAS DE LA GRILLA Y SUS FUNCIONES 
    ' =========================================================

    ' Este evento hace que al hacer clic en la grilla, los datos pasen a las cajas de texto solos
    Private Sub dgvLocalidades_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLocalidades.CellClick
        ' Valido que el clic sea en una fila real y no en los títulos de arriba
        If e.RowIndex >= 0 Then
            ' Paso el CP (Columna 0) y la Localidad (Columna 1) a los textboxes
            Me.TxtCp.Text = Me.dgvLocalidades.Rows(e.RowIndex).Cells(0).Value.ToString()
            Me.TxtLocalidad.Text = Me.dgvLocalidades.Rows(e.RowIndex).Cells(1).Value.ToString()

            ' 2. ¿El usuario apretó "Gestionar Localidades" antes?
            If modoEdicion = True Then
                ' Paso 4: Bloqueando Alta y desbloqueando Modifica y Baja
                Me.btnAltaLocalidad.Enabled = False
                Me.btnModificaLocalidad.Enabled = True
                Me.btnBajaLocalidad.Enabled = True

                ' REGLA DE ORO: Bloqueo el CP para que no lo cambie, 
                ' pero habilitamos la Localidad por si quiere modificar el nombre.
                Me.TxtCp.Enabled = False
                Me.TxtLocalidad.Enabled = True
            End If
            ' Si modoEdicion es False (no tocó el botón), pasa de largo y no enciende nada.
        End If
    End Sub

    ' EVENTO: DOBLE CLIC EN LA GRILLA
    Private Sub dgvLocalidades_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLocalidades.CellDoubleClick
        If wflag = 1 Then ' LO ESTOY LLAMANDO DESDE CLIENTES, ASÍ QUE ME INTERESA EL DOBLE CLIC
            wCP = Me.dgvLocalidades.CurrentRow.Cells(0).Value
            Me.Close()
        End If
    End Sub

    ' EVENTO: APRETAR LA TECLA ENTER
    Private Sub dgvLocalidades_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvLocalidades.KeyDown
        If wflag = 1 Then ' LO ESTOY LLAMANDO DESDE CLIENTES, ASÍ QUE ME INTERESA EL ENTER
            If e.KeyCode = Keys.Enter Then
                wCP = Me.dgvLocalidades.CurrentRow.Cells(0).Value
                Me.Close()
            End If
        End If
    End Sub

    ' =========================================================
    ' FUNCIONES CRUD (ALTA, BAJA, MODIFICACIÓN)
    ' =========================================================

    ' Bloquea los cuadros de texto y vuelve al modo lectura/alta inicial
    Private Sub Bloquear()
        ' Paso 5: La grilla/formulario vuelve a estar toda bloqueada
        Me.TxtCp.Enabled = False
        Me.TxtLocalidad.Enabled = False

        Me.btnAltaLocalidad.Enabled = False
        Me.btnModificaLocalidad.Enabled = False
        Me.btnBajaLocalidad.Enabled = False

        ' El botón Gestionar Localidades siempre queda habilitado desde el diseño

        ' Si modoEdicion es False (no tocó el botón), pasa de largo y no enciende nada.
        modoEdicion = False
    End Sub

    'FUNCION DAR DE ALTA UNA LOCALIDAD
    Private Sub altaLocalidades()
        Dim altaLoc As New Localidades
        altaLoc.cp = (Me.TxtCp.Text)
        altaLoc.localidad = Me.TxtLocalidad.Text.Trim()

        'Cuidado con los espacios: Dim sql As String = "exec spu_alta_localidad" & altaLoc.cp & ",'" & altaLoc.localidad & "'"
        Dim sql As String = "exec spu_alta_localidad " & altaLoc.cp & ", '" & altaLoc.localidad & "'"
        cmd.CommandText = sql
        MsgBox("SE DARA DE ALTA UNA LOCALIDAD",, "INFO")
        'Captura de error(Por si ocurre un improbable error en la BD :) ) 
        Try
            AbrirConexion()
            cmd.ExecuteNonQuery()
            MsgBox("LOCALIDAD CREADA CON EXITO",, "INFO")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    'FUNCION LLENAR Y RECARGAR COMO F5 GRILLA LOCALIDADES 
    Private Sub llenarLocalidades()
        ' Llamo al procedimiento almacenado que me devuelve todas las localidades
        Dim sql As String = "exec spu_mostrar_localidades"
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion)
        Dim ds As New DataSet

        ' Lleno la tabla temporal
        ds.Tables.Add("localidades")
        adp.Fill(ds.Tables("localidades"))

        ' Asigno los datos a la grilla
        Me.dgvLocalidades.DataSource = ds.Tables("localidades")

        ' FORMATO DE LA GRILLA 
        ' Hace que la grilla ocupe todo el ancho sin scroll horizontal
        Me.dgvLocalidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' Acá solo tengo 2 columnas (0 = CP, 1 = LOCALIDAD), así que no hace falta ocultar nada
        Me.dgvLocalidades.Columns(0).Width = 100
        Me.dgvLocalidades.Columns(1).Width = 350

        Me.dgvLocalidades.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvLocalidades.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        Bloquear() ' <--- ¡Acá cierro el ciclo del Paso 5
    End Sub

    'FUNCION PARA MODIFICAR LOS DATOS EN LA GRILLA DE LOCALIDADES
    Private Sub modificarLocalidades()
        Dim cp As String = Me.TxtCp.Text
        Dim localidad As String = Me.TxtLocalidad.Text.Trim

        Dim sql As String = "exec spu_modificar_localidad " & cp & ", '" & localidad & "'"
        cmd.CommandText = sql

        MsgBox("SE MODIFICARÁ LA LOCALIDAD", , "INFO")

        Try
            cmd.ExecuteNonQuery() ' Ejecuta la modificación en SQL
            MsgBox("LOCALIDAD MODIFICADA CON EXITO", , "INFO")

            ' llenarLocalidades() para que la grilla muestre el cambio
            llenarLocalidades()

            ' Limpiar las cajas de texto después de modificar
            Me.TxtCp.Clear()
            Me.TxtLocalidad.Clear()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Bloquear() ' <--- ¡Acá cierro el ciclo del Paso 5
    End Sub

    'FUNCION DAR DE BAJA, ELIMINAR UNA LOCALIDAD
    Private Sub bajaLocalidades()
        ' Verifico que al menos el CP no esté vacío
        If Me.TxtCp.Text.Trim() = "" Then
            MsgBox("Por favor, seleccione o ingrese un CP para eliminar.", MsgBoxStyle.Exclamation, "Datos incompletos")
            Exit Sub
        End If

        ' Le pregunto al usuario si está seguro
        Dim respuesta As DialogResult
        respuesta = MsgBox("¿Está seguro que desea eliminar la localidad con CP: " & Me.TxtCp.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmar Baja")

        ' Si el usuario dijo que SÍ, ejecuto el borrado
        If respuesta = DialogResult.Yes Then
            Dim cp As String = Me.TxtCp.Text

            ' Armo la consulta apuntando al procedimiento de baja
            Dim sql As String = "exec spu_baja_localidad " & cp
            cmd.CommandText = sql

            Try
                cmd.ExecuteNonQuery()
                MsgBox("LOCALIDAD ELIMINADA CON EXITO", MsgBoxStyle.Information, "INFO")

                ' Recargo la grilla para que desaparezca la fila borrada
                llenarLocalidades()

                ' Limpiamos las cajas
                Me.TxtCp.Clear()
                Me.TxtLocalidad.Clear()

            Catch ex As SqlClient.SqlException
                ' El código 547 es el error específico de SQL cuando hay datos enlazados
                If ex.Number = 547 Then
                    MsgBox("No se puede eliminar esta localidad porque hay clientes registrados en ella. Primero debe modificar a esos clientes.", MsgBoxStyle.Critical, "Acción denegada")
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

    'BOTON DE DAR ALTA UNA LOCALIDAD
    Private Sub btnAltaLocalidad_Click(sender As Object, e As EventArgs) Handles btnAltaLocalidad.Click
        ' Validar que no haya campos en blanco 
        If Me.TxtCp.Text.Trim() = "" Or Me.TxtLocalidad.Text.Trim() = "" Then
            MsgBox("Por favor, complete el CP y el Nombre de la Localidad.", MsgBoxStyle.Exclamation, "Datos incompletos")
            Exit Sub
        End If

        ' Si paso la validacion, guarda en SQL
        altaLocalidades()

        Try
            ' Vuelvo a llenar la grilla para que se vea la localidad recién cargada
            llenarLocalidades()

            ' Limpio los textboxes y pongo el foco en el primero
            Me.TxtCp.Clear()
            Me.TxtLocalidad.Clear()
            Me.TxtCp.Select()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    ' 1-click en el boton Gestionar Localides

    ' 2- los dos textboxes se limpian

    ' 3- el usuario decide si escribir los datos para dar de alta, Bloqueandose Modifica y abaja

    ' 4- o sino vuelve a hacer click en la grila para seleccionar alguna localidad bloqueando Alta y desbloqueandose Modifica y Baja

    ' 5- ahi decide el usario si modificar o dar de baja, una vez hecha la accion, la grila vuelve a estar toda bloqueda, menos el boton gestionar localidades 

    Private Sub BtnGestionarLocalidades_Click(sender As Object, e As EventArgs) Handles BtnGestionarLocalidades.Click
        ' ESTA ES LA LLAVE para el error de antes de apretar el boton gestionar localidades hagas click en la grilla y se activen los modifica y baja
        modoEdicion = True


        ' Paso 2: Los dos textboxes se limpian
        Me.TxtCp.Clear()
        Me.TxtLocalidad.Clear()

        ' Habilito las cajas para que se pueda escribir los datos nuevos
        Me.TxtCp.Enabled = True
        Me.TxtLocalidad.Enabled = True

        ' Paso 3: El usuario decide escribir para dar de Alta. 
        ' Desbloqueo Alta y Bloqueo Modifica y Baja.
        Me.btnAltaLocalidad.Enabled = True
        Me.btnModificaLocalidad.Enabled = False
        Me.btnBajaLocalidad.Enabled = False

        Me.TxtCp.Focus() ' Ponemos el cursor en la caja del CP
    End Sub

    ' BOTÓN BAJA, ELIMINAR UNA LOCALIDAD
    Private Sub btnBajaLocalidad_Click(sender As Object, e As EventArgs) Handles btnBajaLocalidad.Click
        bajaLocalidades()
    End Sub

    ' EVENTO DEL BOTÓN MODIFICA (Asegurate de que tu botón se llame así en el diseño)
    Private Sub btnModificaLocalidad_Click(sender As Object, e As EventArgs) Handles btnModificaLocalidad.Click
        ' Validar que haya una localidad seleccionada
        If Me.TxtCp.Text.Trim() = "" Then
            MsgBox("Debe seleccionar una localidad de la lista para modificar.", MsgBoxStyle.Exclamation, "Sin selección")
            Exit Sub
        End If

        ' Validar que no queden campos en blanco 
        If Me.TxtCp.Text.Trim() = "" Or Me.TxtLocalidad.Text.Trim() = "" Then
            MsgBox("No puede dejar campos vacíos al modificar la localidad.", MsgBoxStyle.Exclamation, "Datos incompletos")
            Exit Sub
        End If

        ' Si pasó los controles, ejecuta la modificación


        modificarLocalidades()
    End Sub

    Private Sub BtnAtrasLocalidades_Click(sender As Object, e As EventArgs) Handles BtnAtrasLocalidades.Click
        Me.Close()
    End Sub
    Private Sub TxtFiltrarCp_TextChanged(sender As Object, e As EventArgs) Handles TxtFiltrarCp.TextChanged
        'Si borran el texto y queda vacío, se muestra todas las localidades de nuevo (SIN MsgBox)
        If Me.TxtFiltrarCp.Text.Trim() <> "" Then
            Me.TxtFiltrarLocalidad.Enabled = False
        Else
            Me.TxtFiltrarLocalidad.Enabled = True
            llenarLocalidades()
            Exit Sub
        End If

        'Consulta llamando al procedimiento almacenado que filtra por CP
        Dim cp As String = Me.TxtFiltrarCp.Text.Trim()
        Dim sql As String = "exec spu_buscar_localidad_X_cp " & cp

        Try
            'DataAdapter para ejecutar la búsqueda y refrescar la grilla en tiempo real
            Dim adp As New SqlClient.SqlDataAdapter(sql, conexion)
            Dim ds As New DataSet

            ds.Tables.Add("localidadesFiltradas")
            adp.Fill(ds.Tables("localidadesFiltradas"))

            'Asigno el resultado a la grilla
            Me.dgvLocalidades.DataSource = ds.Tables("localidadesFiltradas")

        Catch ex As Exception
            MsgBox("Error al buscar CP: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub TxtFiltrarLocalidad_TextChanged(sender As Object, e As EventArgs) Handles TxtFiltrarLocalidad.TextChanged
        ' Si la caja tiene texto, deshabilitamos la de CP. Si queda vacía, la volvemos a habilitar.
        If Me.TxtFiltrarLocalidad.Text.Trim() <> "" Then
            Me.TxtFiltrarCp.Enabled = False
        Else
            Me.TxtFiltrarCp.Enabled = True
            llenarLocalidades()
            Exit Sub
        End If

        'Consulta llamando al procedimiento almacenado que filtra por CP
        Dim localidad As String = Me.TxtFiltrarLocalidad.Text.Trim()
        Dim sql As String = "exec spu_buscar_localidad_X_localidad '" & localidad & "'"

        Try
            'DataAdapter para ejecutar la búsqueda y refrescar la grilla en tiempo real
            Dim adp As New SqlClient.SqlDataAdapter(sql, conexion)
            Dim ds As New DataSet

            ds.Tables.Add("localidadesFiltradas")
            adp.Fill(ds.Tables("localidadesFiltradas"))

            'Asigno el resultado a la grilla
            Me.dgvLocalidades.DataSource = ds.Tables("localidadesFiltradas")

        Catch ex As Exception
            MsgBox("Error al buscar localidad: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    ' =========================================================
    ' VALIDACIONES DE SOLO NUMEROS EN CAMPOS 
    ' =========================================================

    Private Sub TxtCp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCp.KeyPress
        ' Permite únicamente dígitos y teclas de control (Backspace, Supr)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Cancela la pulsación de la tecla
            MsgBox("Atención: El campo CP solo acepta números.", MsgBoxStyle.Exclamation, "Dato inválido")
        End If
    End Sub

End Class