Public Class FrmImprimir_Localidades
    Private Sub FrmImprimir_Localidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Final_Punto_Venta_Programacion_IDataSet.spu_mostrar_localidades' Puede moverla o quitarla según sea necesario.
        Me.Spu_mostrar_localidadesTableAdapter.Fill(Me.Final_Punto_Venta_Programacion_IDataSet.spu_mostrar_localidades)

        Me.ReportViewer2.RefreshReport()
    End Sub
End Class