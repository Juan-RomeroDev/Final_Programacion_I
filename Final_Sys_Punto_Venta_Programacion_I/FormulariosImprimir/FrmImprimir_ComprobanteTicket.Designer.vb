<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmImprimir_ComprobanteTicket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImprimir_ComprobanteTicket))
        Me.SpuimprimircomprobanteventaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Final_Punto_Venta_Programacion_IDataSet = New Final_Sys_Punto_Venta_Programacion_I.Final_Punto_Venta_Programacion_IDataSet()
        Me.ReportViewerImprimirComprobante = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Spu_imprimir_comprobante_ventaTableAdapter = New Final_Sys_Punto_Venta_Programacion_I.Final_Punto_Venta_Programacion_IDataSetTableAdapters.spu_imprimir_comprobante_ventaTableAdapter()
        CType(Me.SpuimprimircomprobanteventaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Final_Punto_Venta_Programacion_IDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SpuimprimircomprobanteventaBindingSource
        '
        Me.SpuimprimircomprobanteventaBindingSource.DataMember = "spu_imprimir_comprobante_venta"
        Me.SpuimprimircomprobanteventaBindingSource.DataSource = Me.Final_Punto_Venta_Programacion_IDataSet
        '
        'Final_Punto_Venta_Programacion_IDataSet
        '
        Me.Final_Punto_Venta_Programacion_IDataSet.DataSetName = "Final_Punto_Venta_Programacion_IDataSet"
        Me.Final_Punto_Venta_Programacion_IDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewerImprimirComprobante
        '
        Me.ReportViewerImprimirComprobante.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetComprobanteTicket"
        ReportDataSource1.Value = Me.SpuimprimircomprobanteventaBindingSource
        Me.ReportViewerImprimirComprobante.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewerImprimirComprobante.LocalReport.ReportEmbeddedResource = "Final_Sys_Punto_Venta_Programacion_I.RptComprobanteTicket.rdlc"
        Me.ReportViewerImprimirComprobante.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewerImprimirComprobante.Name = "ReportViewerImprimirComprobante"
        Me.ReportViewerImprimirComprobante.ServerReport.BearerToken = Nothing
        Me.ReportViewerImprimirComprobante.ShowBackButton = False
        Me.ReportViewerImprimirComprobante.ShowExportButton = False
        Me.ReportViewerImprimirComprobante.ShowFindControls = False
        Me.ReportViewerImprimirComprobante.ShowPageNavigationControls = False
        Me.ReportViewerImprimirComprobante.ShowRefreshButton = False
        Me.ReportViewerImprimirComprobante.ShowStopButton = False
        Me.ReportViewerImprimirComprobante.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewerImprimirComprobante.TabIndex = 0
        '
        'Spu_imprimir_comprobante_ventaTableAdapter
        '
        Me.Spu_imprimir_comprobante_ventaTableAdapter.ClearBeforeFill = True
        '
        'FrmImprimir_ComprobanteTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewerImprimirComprobante)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmImprimir_ComprobanteTicket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IMPRIMIR COMPROBANTE TICKET"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.SpuimprimircomprobanteventaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Final_Punto_Venta_Programacion_IDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewerImprimirComprobante As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SpuimprimircomprobanteventaBindingSource As BindingSource
    Friend WithEvents Final_Punto_Venta_Programacion_IDataSet As Final_Punto_Venta_Programacion_IDataSet
    Friend WithEvents Spu_imprimir_comprobante_ventaTableAdapter As Final_Punto_Venta_Programacion_IDataSetTableAdapters.spu_imprimir_comprobante_ventaTableAdapter
End Class
