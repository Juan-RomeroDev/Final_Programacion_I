<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImprimir_Localidades
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImprimir_Localidades))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Final_Punto_Venta_Programacion_IDataSet = New Final_Sys_Punto_Venta_Programacion_I.Final_Punto_Venta_Programacion_IDataSet()
        Me.SpumostrarlocalidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Spu_mostrar_localidadesTableAdapter = New Final_Sys_Punto_Venta_Programacion_I.Final_Punto_Venta_Programacion_IDataSetTableAdapters.spu_mostrar_localidadesTableAdapter()
        CType(Me.Final_Punto_Venta_Programacion_IDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpumostrarlocalidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(396, 246)
        Me.ReportViewer1.TabIndex = 0
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetComprobanteTicket"
        ReportDataSource1.Value = Me.SpumostrarlocalidadesBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "Final_Sys_Punto_Venta_Programacion_I.RptComprobanteTicket.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.ServerReport.BearerToken = Nothing
        Me.ReportViewer2.ShowBackButton = False
        Me.ReportViewer2.ShowExportButton = False
        Me.ReportViewer2.ShowFindControls = False
        Me.ReportViewer2.ShowPageNavigationControls = False
        Me.ReportViewer2.ShowRefreshButton = False
        Me.ReportViewer2.ShowStopButton = False
        Me.ReportViewer2.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer2.TabIndex = 0
        '
        'Final_Punto_Venta_Programacion_IDataSet
        '
        Me.Final_Punto_Venta_Programacion_IDataSet.DataSetName = "Final_Punto_Venta_Programacion_IDataSet"
        Me.Final_Punto_Venta_Programacion_IDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SpumostrarlocalidadesBindingSource
        '
        Me.SpumostrarlocalidadesBindingSource.DataMember = "spu_mostrar_localidades"
        Me.SpumostrarlocalidadesBindingSource.DataSource = Me.Final_Punto_Venta_Programacion_IDataSet
        '
        'Spu_mostrar_localidadesTableAdapter
        '
        Me.Spu_mostrar_localidadesTableAdapter.ClearBeforeFill = True
        '
        'FrmImprimir_Localidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmImprimir_Localidades"
        Me.Text = "IMPRIMIR LOCALIDADES"
        CType(Me.Final_Punto_Venta_Programacion_IDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpumostrarlocalidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Final_Punto_Venta_Programacion_IDataSet As Final_Punto_Venta_Programacion_IDataSet
    Friend WithEvents SpumostrarlocalidadesBindingSource As BindingSource
    Friend WithEvents Spu_mostrar_localidadesTableAdapter As Final_Punto_Venta_Programacion_IDataSetTableAdapters.spu_mostrar_localidadesTableAdapter
End Class
