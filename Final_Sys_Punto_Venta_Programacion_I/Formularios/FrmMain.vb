Public Class FrmMain
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AbrirConexion()
    End Sub

    ' =========================================================
    ' ARCHIVOS 
    ' =========================================================

    Private Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click
        Dim FrmClientes As New FrmClientes()
        FrmClientes.Show()
    End Sub

    Private Sub BtnDetalleVentas_Click(sender As Object, e As EventArgs) Handles BtnDetalleVentas.Click
        Dim FrmDetalleVentas As New FrmDetalleVenta()
        FrmDetalleVenta.Show()
    End Sub

    Private Sub BtnFormaDePago_Click(sender As Object, e As EventArgs) Handles BtnFormaDePago.Click
        Dim FrmFormaDePago As New FrmFormaDePago()
        FrmFormaDePago.Show()
    End Sub

    Private Sub BtnLocalidades_Click(sender As Object, e As EventArgs) Handles BtnLocalidades.Click
        Dim FrmLocalidades As New FrmLocalidades()
        FrmLocalidades.Show()
    End Sub

    Private Sub BtnProductos_Click(sender As Object, e As EventArgs) Handles BtnProductos.Click
        Dim FrmProductos As New FrmProductos()
        FrmProductos.Show()
    End Sub

    Private Sub BtnRubros_Click(sender As Object, e As EventArgs) Handles BtnRubros.Click
        Dim FrmRubros As New FrmRubros()
        FrmRubros.Show()
    End Sub

    Private Sub BtnPuntoVenta_Click(sender As Object, e As EventArgs) Handles BtnPuntoVenta.Click
        Dim FrmPOS As New FrmPOS()
        FrmPOS.Show()
    End Sub

    ' =========================================================
    ' INFORMES 
    ' =========================================================

    ' =========================================================
    ' SALIR  
    ' =========================================================

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    ' =========================================================
    ' TIMER - RELOJ 
    ' =========================================================

    Private Sub Tiempo_Tick(sender As Object, e As EventArgs) Handles Tiempo.Tick
        'Codigo para mostrar la hora actual en el label
        lblhora.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy | HH:mm:ss")
    End Sub

    ' =========================================================
    ' BACKUP DE LA BASE DE DATOS
    ' =========================================================

    Private Sub Backup_Click(sender As Object, e As EventArgs) Handles Backup.Click
        ' Pregunto al usuario si está seguro para evitar clics por error
        Dim respuesta As DialogResult
        respuesta = MsgBox("¿Desea generar una copia de seguridad de la base de datos en este momento?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmar Backup")

        ' Si dice que sí, ejecuto el procedimiento almacenado Backup
        If respuesta = DialogResult.Yes Then
            Try
                AbrirConexion()
                cmd.CommandText = "exec spu_backup_full"

                ' Mostramos un aviso de espera porque el backup puede demorar un par de segundos
                MsgBox("Generando backup, por favor espere...", MsgBoxStyle.Information, "Procesando")

                cmd.ExecuteNonQuery()

                MsgBox("Copia de seguridad generada con éxito.", MsgBoxStyle.Information, "Backup Completado")
            Catch ex As Exception
                MsgBox("Error al generar el backup: " & ex.Message, MsgBoxStyle.Critical, "Error SQL")
            End Try
        End If
    End Sub


End Class
