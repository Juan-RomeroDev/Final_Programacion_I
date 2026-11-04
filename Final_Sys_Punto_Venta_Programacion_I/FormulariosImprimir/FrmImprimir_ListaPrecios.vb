Public Class FrmImprimirListaPrecios
    Private Sub FrmImprimirListaPrecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Final_Punto_Venta_Programacion_IDataSet.spu_reporte_lista_precios' Puede moverla o quitarla según sea necesario.
        Me.Spu_reporte_lista_preciosTableAdapter.Fill(Me.Final_Punto_Venta_Programacion_IDataSet.spu_reporte_lista_precios)
        Try
            ' Rellenamos el TableAdapter del reporte de lista de precios
            Me.Spu_reporte_lista_preciosTableAdapter.Fill(Me.Final_Punto_Venta_Programacion_IDataSet.spu_reporte_lista_precios)

            ' Refrescamos el ReportViewer
            Me.ReportViewer1.RefreshReport()

        Catch ex As Exception
            MsgBox("Error al cargar la lista de precios: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class