<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmImprimir_Ventas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImprimir_Ventas))
        Me.SpumostrarventasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Final_Punto_Venta_Programacion_IDataSet = New Final_Sys_Punto_Venta_Programacion_I.Final_Punto_Venta_Programacion_IDataSet()
        Me.ReportViewerVentas = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentasTableAdapter = New Final_Sys_Punto_Venta_Programacion_I.Final_Punto_Venta_Programacion_IDataSetTableAdapters.ventasTableAdapter()
        Me.Spu_mostrar_ventasTableAdapter = New Final_Sys_Punto_Venta_Programacion_I.Final_Punto_Venta_Programacion_IDataSetTableAdapters.spu_mostrar_ventasTableAdapter()
        CType(Me.SpumostrarventasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Final_Punto_Venta_Programacion_IDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SpumostrarventasBindingSource
        '
        Me.SpumostrarventasBindingSource.DataMember = "spu_mostrar_ventas"
        Me.SpumostrarventasBindingSource.DataSource = Me.Final_Punto_Venta_Programacion_IDataSet
        '
        'Final_Punto_Venta_Programacion_IDataSet
        '
        Me.Final_Punto_Venta_Programacion_IDataSet.DataSetName = "Final_Punto_Venta_Programacion_IDataSet"
        Me.Final_Punto_Venta_Programacion_IDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewerVentas
        '
        Me.ReportViewerVentas.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetComprobanteTicket"
        ReportDataSource1.Value = Me.SpumostrarventasBindingSource
        Me.ReportViewerVentas.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewerVentas.LocalReport.ReportEmbeddedResource = "Final_Sys_Punto_Venta_Programacion_I.RptComprobanteTicket.rdlc"
        Me.ReportViewerVentas.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewerVentas.Name = "ReportViewerVentas"
        Me.ReportViewerVentas.ServerReport.BearerToken = Nothing
        Me.ReportViewerVentas.ShowBackButton = False
        Me.ReportViewerVentas.ShowExportButton = False
        Me.ReportViewerVentas.ShowFindControls = False
        Me.ReportViewerVentas.ShowPageNavigationControls = False
        Me.ReportViewerVentas.ShowRefreshButton = False
        Me.ReportViewerVentas.ShowStopButton = False
        Me.ReportViewerVentas.Size = New System.Drawing.Size(872, 553)
        Me.ReportViewerVentas.TabIndex = 0
        '
        'VentasBindingSource
        '
        Me.VentasBindingSource.DataMember = "ventas"
        Me.VentasBindingSource.DataSource = Me.Final_Punto_Venta_Programacion_IDataSet
        '
        'VentasTableAdapter
        '
        Me.VentasTableAdapter.ClearBeforeFill = True
        '
        'Spu_mostrar_ventasTableAdapter
        '
        Me.Spu_mostrar_ventasTableAdapter.ClearBeforeFill = True
        '
        'FrmImprimir_Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 553)
        Me.Controls.Add(Me.ReportViewerVentas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmImprimir_Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IMPRIMIR VENTAS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.SpumostrarventasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Final_Punto_Venta_Programacion_IDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewerVentas As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Final_Punto_Venta_Programacion_IDataSet As Final_Punto_Venta_Programacion_IDataSet
    Friend WithEvents VentasBindingSource As BindingSource
    Friend WithEvents VentasTableAdapter As Final_Punto_Venta_Programacion_IDataSetTableAdapters.ventasTableAdapter
    Friend WithEvents SpumostrarventasBindingSource As BindingSource
    Friend WithEvents Spu_mostrar_ventasTableAdapter As Final_Punto_Venta_Programacion_IDataSetTableAdapters.spu_mostrar_ventasTableAdapter
End Class
