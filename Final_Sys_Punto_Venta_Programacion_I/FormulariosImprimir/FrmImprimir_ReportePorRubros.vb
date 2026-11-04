Public Class FrmImprimir_ReportePorRubros
    Private Sub FrmImprimir_ReportePorRubros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Rellenamos el TableAdapter pasándole la variable global del ID del rubro
            Me.Spu_reporte_ventas_por_rubroTableAdapter.Fill(Me.Final_Punto_Venta_Programacion_IDataSet.spu_reporte_ventas_por_rubro, wID_Rubro)

            ' Refrescamos el reporte para dibujar los datos filtrados
            Me.ReportViewer1.RefreshReport()

        Catch ex As Exception
            MsgBox("Error al cargar el reporte por rubro: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class