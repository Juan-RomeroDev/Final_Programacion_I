Public Class FrmImprimir_Clientes
    Private Sub FrmImprimir_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' 1. Llenamos los datos con el TableAdapter
            Me.Spu_mostrar_clientesTableAdapter.Fill(Me.Final_Punto_Venta_Programacion_IDataSet.spu_mostrar_clientes)

            ' 3. Refrescamos para que se dibuje en pantalla
            Me.ReportViewer1.RefreshReport()

        Catch ex As Exception
            MsgBox("Error al cargar el reporte de clientes: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class