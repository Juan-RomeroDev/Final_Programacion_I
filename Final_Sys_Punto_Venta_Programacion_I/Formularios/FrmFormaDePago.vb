Imports System.Drawing.Imaging
Imports sys_banco_izo.clases

Public Class FrmFormaDePago
    'FUNCION MODO EDICION PARA ACTIVAR O DESACTIVAR BOTONES DE MODIFICACION Y ELIMINACION 
    Private modoEdicion As Boolean = False ' Variable para controlar el modo de edición
    Private Sub FrmFormaDePago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConexion()
        llenarFormaPago()

        ' Al arrancar, bloqueo todo 
        Bloquear()
    End Sub

    ' =========================================================
    ' CELDAS DE LA GRILLA Y SUS FUNCIONES 
    ' =========================================================

    ' Este evento hace que al hacer clic en la grilla, los datos pasen a las cajas de texto solos
    Private Sub dgvFormaDePago_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFormaDePago.CellClick
        ' Valido que el clic sea en una fila real y no en los títulos de arriba
        If e.RowIndex >= 0 Then
            ' Paso el CP (Columna 0) y la Localidad (Columna 1) a los textboxes
            Me.TxtIDFormaPago.Text = Me.dgvFormaDePago.Rows(e.RowIndex).Cells(0).Value.ToString()
            Me.TxtDescripcionFormaPago.Text = Me.dgvFormaDePago.Rows(e.RowIndex).Cells(1).Value.ToString()

            ' 2. ¿El usuario apretó "Gestionar Localidades" antes?
            If modoEdicion = True Then
                ' Paso 4: Bloqueando Alta y desbloqueando Modifica y Baja
                Me.btnAltaFormaPago.Enabled = False
                Me.btnModificaFormaPago.Enabled = True
                Me.btnBajaFormaPago.Enabled = True

                ' REGLA DE ORO: Bloqueo el CP para que no lo cambie, 
                ' pero habilitamos la Localidad por si quiere modificar el nombre.
                Me.TxtIDFormaPago.Enabled = False
                Me.TxtDescripcionFormaPago.Enabled = True
            End If
            ' Si modoEdicion es False (no tocó el botón), pasa de largo y no enciende nada.
        End If
    End Sub

    ' EVENTO: DOBLE CLIC EN LA GRILLA
    Private Sub dgvFormaDePago_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFormaDePago.CellDoubleClick
        If wflag = 1 Then ' LO ESTOY LLAMANDO DESDE CLIENTES, ASÍ QUE ME INTERESA EL DOBLE CLIC
            wCP = Me.dgvFormaDePago.CurrentRow.Cells(0).Value
            Me.Close()
        End If
    End Sub

    ' EVENTO: APRETAR LA TECLA ENTER
    Private Sub dgvFormaDePago_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvFormaDePago.KeyDown
        If wflag = 1 Then ' LO ESTOY LLAMANDO DESDE CLIENTES, ASÍ QUE ME INTERESA EL ENTER
            If e.KeyCode = Keys.Enter Then
                wCP = Me.dgvFormaDePago.CurrentRow.Cells(0).Value
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
        Me.TxtIDFormaPago.Enabled = False
        Me.TxtDescripcionFormaPago.Enabled = False

        Me.btnAltaFormaPago.Enabled = False
        Me.btnModificaFormaPago.Enabled = False
        Me.btnBajaFormaPago.Enabled = False

        ' El botón Gestionar Localidades siempre queda habilitado desde el diseño

        ' Si modoEdicion es False (no tocó el botón), pasa de largo y no enciende nada.
        modoEdicion = False
    End Sub

    'FUNCION DAR DE ALTA UNA FORMA DE PAGO
    Private Sub altaFormaPago()
        Dim altaFormaPago As New FormaPagos
        altaFormaPago.idFormaPago = (Me.TxtIDFormaPago.Text)
        altaFormaPago.descripcionFormaPago = Me.TxtDescripcionFormaPago.Text.Trim()

        'Cuidado con los espacios: Dim sql As String = "exec spu_alta_localidad" & altaLoc.cp & ",'" & altaLoc.localidad & "'"
        Dim sql As String = "exec spu_alta_forma_de_pago" & altaFormaPago.idFormaPago & ", '" & altaFormaPago.descripcionFormaPago & "'"
        cmd.CommandText = sql
        MsgBox("SE DARA DE ALTA UNA FORMA DE PAGO",, "INFO")
        'Captura de error(Por si ocurre un improbable error en la BD :) ) 
        Try
            AbrirConexion()
            cmd.ExecuteNonQuery()
            MsgBox("FORMA DE PAGO CREADA CON EXITO",, "INFO")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    'FUNCION LLENAR Y RECARGAR COMO F5 GRILLA LOCALIDADES 
    Private Sub llenarFormaPago()
        ' Llamo al procedimiento almacenado que me devuelve todas las localidades
        Dim sql As String = "exec spu_mostrar_forma_pago"
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion)
        Dim ds As New DataSet

        ' Lleno la tabla temporal
        ds.Tables.Add("FormaPago")
        adp.Fill(ds.Tables("FormaPago"))

        ' Asigno los datos a la grilla
        Me.dgvFormaDePago.DataSource = ds.Tables("FormaPago")
        ' FORMATO DE LA GRILLA 
        ' Hace que la grilla ocupe todo el ancho sin scroll horizontal
        Me.dgvFormaDePago.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' Acá solo tengo 2 columnas (0 = ID FORMA DE PAGO, 1 = DESCRIPCION FORMA DE PAGO), así que no hace falta ocultar nada
        Me.dgvFormaDePago.Columns(0).Width = 100
        Me.dgvFormaDePago.Columns(1).Width = 350

        Me.dgvFormaDePago.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvFormaDePago.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        Bloquear() ' <--- ¡Acá cierro el ciclo del Paso 5
    End Sub

    'FUNCION PARA GENERAR + 1 ID DE CLIENTE
    Private Sub generarIdFormaDePago()
        Try
            AbrirConexion()
            cmd.CommandText = "exec spu_generar_id_forma_de_pago"

            Dim nuevoID As Object = cmd.ExecuteScalar() 'Lo mejor para escalar ID, devuelve un objeto que puede ser DBNull si no hay datos 

            If nuevoID IsNot Nothing AndAlso Not IsDBNull(nuevoID) Then
                Me.TxtIDFormaPago.Text = nuevoID.ToString()
            Else
                Me.TxtIDFormaPago.Text = "1"
            End If

        Catch ex As Exception
            MsgBox("Error al generar ID: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    'FUNCION PARA MODIFICAR LOS DATOS EN LA GRILLA DE FORMAS DE PAGO
    Private Sub modificarFormaPago()
        Dim idFormaPago As String = Me.TxtIDFormaPago.Text
        Dim descripcionFormaPago As String = Me.TxtDescripcionFormaPago.Text.Trim

        Dim sql As String = "exec spu_modificar_forma_de_pago " & idFormaPago & ", '" & descripcionFormaPago & "'"
        cmd.CommandText = sql

        MsgBox("SE MODIFICARÁ LA FORMA DE PAGO", , "INFO")

        Try
            cmd.ExecuteNonQuery() ' Ejecuta la modificación en SQL
            MsgBox("FORMA DE PAGO MODIFICADA CON EXITO", , "INFO")

            ' llenarFormaPago() para que la grilla muestre el cambio
            llenarFormaPago()

            ' Limpiar las cajas de texto después de modificar
            Me.TxtIDFormaPago.Clear()
            Me.TxtDescripcionFormaPago.Clear()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Bloquear() ' <--- ¡Acá cierro el ciclo del Paso 5
    End Sub

    'FUNCION DAR DE BAJA, ELIMINAR UNA LOCALIDAD
    Private Sub bajaFormaPago()
        ' Verifico que al menos el ID no esté vacío
        If Me.TxtIDFormaPago.Text.Trim() = "" Then
            MsgBox("Por favor, seleccione o ingrese un ID de forma de pago para eliminar.", MsgBoxStyle.Exclamation, "Datos incompletos")
            Exit Sub
        End If

        ' Le pregunto al usuario si está seguro
        Dim respuesta As DialogResult
        respuesta = MsgBox("¿Está seguro que desea eliminar la forma de pago con ID: " & Me.TxtIDFormaPago.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmar Baja")

        ' Si el usuario dijo que SÍ, ejecuto el borrado
        If respuesta = DialogResult.Yes Then
            Dim idFormaPago As String = Me.TxtIDFormaPago.Text
            ' Armo la consulta apuntando al procedimiento de baja
            Dim sql As String = "exec spu_baja_forma_de_pago " & idFormaPago
            cmd.CommandText = sql

            Try
                cmd.ExecuteNonQuery()
                MsgBox("FORMA DE PAGO ELIMINADA CON EXITO", MsgBoxStyle.Information, "INFO")

                ' Recargo la grilla para que desaparezca la fila borrada
                llenarFormaPago()

                ' Limpiamos las cajas
                Me.TxtIDFormaPago.Clear()
                Me.TxtDescripcionFormaPago.Clear()

            Catch ex As SqlClient.SqlException
                ' El código 547 es el error específico de SQL cuando hay datos enlazados
                If ex.Number = 547 Then
                    MsgBox("No se puede eliminar esta forma de pago porque hay clientes registrados en ella. Primero debe modificar a esos clientes.", MsgBoxStyle.Critical, "Acción denegada")
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
    Private Sub btnAltaFormaPago_Click(sender As Object, e As EventArgs) Handles btnAltaFormaPago.Click
        altaFormaPago()
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
        Me.TxtIDFormaPago.Clear()
        Me.TxtDescripcionFormaPago.Clear()

        ' Generar el nuevo ID (después de limpiar)
        generarIdFormaDePago()

        ' Habilito las cajas para que se pueda escribir los datos nuevos
        Me.TxtIDFormaPago.Enabled = True
        Me.TxtIDFormaPago.ReadOnly = True ' El ID se genera automáticamente, así que lo dejo en solo lectura
        Me.TxtDescripcionFormaPago.Enabled = True

        ' Paso 3: El usuario decide escribir para dar de Alta. 
        ' Desbloqueo Alta y Bloqueo Modifica y Baja.
        Me.btnAltaFormaPago.Enabled = True
        Me.btnModificaFormaPago.Enabled = False
        Me.btnBajaFormaPago.Enabled = False

        Me.TxtDescripcionFormaPago.Focus() ' Ponemos el cursor en la caja de la descripcion para que el usuario pueda escribir directamente
    End Sub

    ' BOTÓN BAJA, ELIMINAR UNA FORMA DE PAGO
    Private Sub btnBajaLocalidad_Click(sender As Object, e As EventArgs) Handles btnBajaFormaPago.Click
        bajaFormaPago()
    End Sub

    ' EVENTO DEL BOTÓN MODIFICA 
    Private Sub btnModificaFormaPago_Click(sender As Object, e As EventArgs) Handles btnModificaFormaPago.Click
        modificarFormaPago()
    End Sub

    Private Sub BtnAtrasFormaPago_Click(sender As Object, e As EventArgs) Handles BtnAtrasFormaPago.Click
        Me.Close()
    End Sub

End Class