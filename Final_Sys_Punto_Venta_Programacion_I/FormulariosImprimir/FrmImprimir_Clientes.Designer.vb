<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImprimir_Clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImprimir_Clientes))
        Me.SpumostrarclientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Final_Punto_Venta_Programacion_IDataSet = New Final_Sys_Punto_Venta_Programacion_I.Final_Punto_Venta_Programacion_IDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Spu_mostrar_clientesTableAdapter = New Final_Sys_Punto_Venta_Programacion_I.Final_Punto_Venta_Programacion_IDataSetTableAdapters.spu_mostrar_clientesTableAdapter()
        Me.spu_mostrar_clientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.SpumostrarclientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Final_Punto_Venta_Programacion_IDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spu_mostrar_clientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SpumostrarclientesBindingSource
        '
        Me.SpumostrarclientesBindingSource.DataMember = "spu_mostrar_clientes"
        Me.SpumostrarclientesBindingSource.DataSource = Me.Final_Punto_Venta_Programacion_IDataSet
        '
        'Final_Punto_Venta_Programacion_IDataSet
        '
        Me.Final_Punto_Venta_Programacion_IDataSet.DataSetName = "Final_Punto_Venta_Programacion_IDataSet"
        Me.Final_Punto_Venta_Programacion_IDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetClientes"
        ReportDataSource1.Value = Me.spu_mostrar_clientesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Final_Sys_Punto_Venta_Programacion_I.RptClientes.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.ShowBackButton = False
        Me.ReportViewer1.ShowExportButton = False
        Me.ReportViewer1.ShowFindControls = False
        Me.ReportViewer1.ShowPageNavigationControls = False
        Me.ReportViewer1.ShowRefreshButton = False
        Me.ReportViewer1.ShowStopButton = False
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 1
        '
        'Spu_mostrar_clientesTableAdapter
        '
        Me.Spu_mostrar_clientesTableAdapter.ClearBeforeFill = True
        '
        'spu_mostrar_clientesBindingSource
        '
        Me.spu_mostrar_clientesBindingSource.DataMember = "spu_mostrar_clientes"
        Me.spu_mostrar_clientesBindingSource.DataSource = Me.Final_Punto_Venta_Programacion_IDataSet
        '
        'FrmImprimir_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmImprimir_Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IMPRIMIR CLIENTES"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.SpumostrarclientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Final_Punto_Venta_Programacion_IDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spu_mostrar_clientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Final_Punto_Venta_Programacion_IDataSet As Final_Punto_Venta_Programacion_IDataSet
    Friend WithEvents SpumostrarclientesBindingSource As BindingSource
    Friend WithEvents Spu_mostrar_clientesTableAdapter As Final_Punto_Venta_Programacion_IDataSetTableAdapters.spu_mostrar_clientesTableAdapter
    Friend WithEvents spu_mostrar_clientesBindingSource As BindingSource
End Class
