Public Class FrmImprimir_Ventas
    Private Sub FrmImprimir_Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Final_Punto_Venta_Programacion_IDataSet.spu_mostrar_ventas' Puede moverla o quitarla según sea necesario.
        Me.Spu_mostrar_ventasTableAdapter.Fill(Me.Final_Punto_Venta_Programacion_IDataSet.spu_mostrar_ventas)
        'TODO: esta línea de código carga datos en la tabla 'Final_Punto_Venta_Programacion_IDataSet.ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.Final_Punto_Venta_Programacion_IDataSet.ventas)

        Me.ReportViewerVentas.RefreshReport
    End Sub
End Class