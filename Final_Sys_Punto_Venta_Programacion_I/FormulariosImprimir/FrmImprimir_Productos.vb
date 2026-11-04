Public Class FrmImprimir_Productos
    Private Sub FrmImprimir_Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Final_Punto_Venta_Programacion_IDataSet.spu_mostrar_productos' Puede moverla o quitarla según sea necesario.
        Me.Spu_mostrar_productosTableAdapter.Fill(Me.Final_Punto_Venta_Programacion_IDataSet.spu_mostrar_productos)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class