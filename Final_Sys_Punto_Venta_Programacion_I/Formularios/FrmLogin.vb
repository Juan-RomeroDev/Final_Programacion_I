Imports System.Globalization

Public Class FrmLogin
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConexion()
        llenarUsuarios()
    End Sub

    Private Sub llenarUsuarios()
        Dim sql As String = "exec spu_mostrar_usuarios"
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion)
        Dim ds As New DataSet
        ds.Tables.Add("usuarios")
        adp.Fill(ds.Tables("usuarios"))
        Me.dgvUsuarios.DataSource = ds.Tables("usuarios")
        'FORMATO DE LA GRILLA 

        ' Hace que la grilla ocupe todo el ancho sin scroll horizontal
        Me.dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Me.dgvUsuarios.Columns(0).Width = 100
        Me.dgvUsuarios.Columns(1).Width = 200
        Me.dgvUsuarios.Columns(2).Visible = False
        Me.dgvUsuarios.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvUsuarios.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        If Me.dgvUsuarios.CurrentRow IsNot Nothing Then
            ' Validamos si la contraseña escrita coincide con la celda oculta de la contraseña (Cells(2))
            If Me.TxtPassword.Text.Trim() = Me.dgvUsuarios.CurrentRow.Cells(2).Value.ToString() Then

                ' CAPTURAMOS EL ID Y EL NOMBRE DE LA GRILLA ANTES DE ENTRAR
                wID_UsuarioLogueado = Convert.ToInt32(Me.dgvUsuarios.CurrentRow.Cells(0).Value)
                wNombre_UsuarioLogueado = Me.dgvUsuarios.CurrentRow.Cells(1).Value.ToString()

                ' Abrimos el menú principal y ocultamos el login
                Dim frm As New FrmMain
                frm.Show()
                Me.Hide()
            Else
                MsgBox("Contraseña incorrecta",, "INFO")
                Me.TxtPassword.Clear()
                Me.TxtPassword.Select()
            End If
        End If
    End Sub

    ' EVENTO: DOBLE CLIC EN LA GRILLA DE USUARIOS
    Private Sub dgvUsuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellDoubleClick
        If wflag = 3 Then ' Usá el número de bandera que prefieras para identificar que estás buscando un usuario
            wID_UsuarioLogueado = Convert.ToInt32(Me.dgvUsuarios.CurrentRow.Cells(0).Value)
            wNombre_UsuarioLogueado = Me.dgvUsuarios.CurrentRow.Cells(1).Value.ToString()
            Me.Close()
        End If
    End Sub

    ' EVENTO: APRETAR LA TECLA ENTER EN LA GRILLA
    Private Sub dgvUsuarios_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvUsuarios.KeyDown
        If wflag = 3 AndAlso e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Evita el sonido de error de Windows
            wID_UsuarioLogueado = Convert.ToInt32(Me.dgvUsuarios.CurrentRow.Cells(0).Value)
            wNombre_UsuarioLogueado = Me.dgvUsuarios.CurrentRow.Cells(1).Value.ToString()
            Me.Close()
        End If
    End Sub
End Class