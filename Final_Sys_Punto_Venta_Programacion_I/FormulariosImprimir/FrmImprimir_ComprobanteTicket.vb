Public Class FrmImprimir_ComprobanteTicket
    Private Sub FrmImprimir_ComprobanteTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Rellenamos el TableAdapter del reporte pasándole la variable global wID_Venta
        Me.Spu_imprimir_comprobante_ventaTableAdapter.Fill(Me.Final_Punto_Venta_Programacion_IDataSet.spu_imprimir_comprobante_venta, wID_Venta)

        ' Refrescamos el ReportViewer para que muestre el ticket actualizado
        Me.ReportViewerImprimirComprobante.RefreshReport()
    End Sub

End Class