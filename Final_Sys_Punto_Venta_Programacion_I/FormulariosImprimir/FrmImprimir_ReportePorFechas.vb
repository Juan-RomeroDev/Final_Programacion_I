Public Class FrmImprimir_ReportePorFechas
    Private Sub FrmImprimir_ReporteFechas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Rellenamos el TableAdapter del reporte por fechas pasándole las variables globales
        Me.Spu_reporte_ventas_por_fechaTableAdapter.Fill(Me.Final_Punto_Venta_Programacion_IDataSet.spu_reporte_ventas_por_fecha, wFechaDesde, wFechaHasta)

        ' Refrescamos el ReportViewer para que dibuje el reporte filtrado por el rango de fechas
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class