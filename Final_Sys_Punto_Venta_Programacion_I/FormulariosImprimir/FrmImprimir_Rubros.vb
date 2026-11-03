Public Class FrmImprimir_Rubros
    Private Sub FrmImprimir_Rubros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Final_Punto_Venta_Programacion_IDataSet.spu_mostrar_rubros' Puede moverla o quitarla según sea necesario.
        Me.Spu_mostrar_rubrosTableAdapter.Fill(Me.Final_Punto_Venta_Programacion_IDataSet.spu_mostrar_rubros)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class