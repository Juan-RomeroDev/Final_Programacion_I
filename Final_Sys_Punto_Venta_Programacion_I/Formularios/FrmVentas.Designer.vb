<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVentas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVentas))
        Me.TxtVentaPorCliente = New System.Windows.Forms.TextBox()
        Me.LblBuscarVentaPorCliente = New System.Windows.Forms.Label()
        Me.TxtVentaPorRubro = New System.Windows.Forms.TextBox()
        Me.LblBuscarVentaPorRubro = New System.Windows.Forms.Label()
        Me.DateTimePickerHasta = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerDesde = New System.Windows.Forms.DateTimePicker()
        Me.LblBuscarVentaPorFechas = New System.Windows.Forms.Label()
        Me.LblBuscarVentaPorUsuario = New System.Windows.Forms.Label()
        Me.TxtVentaPorUsuario = New System.Windows.Forms.TextBox()
        Me.DgvVentasRealizadas = New System.Windows.Forms.DataGridView()
        Me.LblBuscarPorFormaDePago = New System.Windows.Forms.Label()
        Me.TxtBuscarVentaPorFormaPago = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBuscarVentaPorDetalleVenta = New System.Windows.Forms.TextBox()
        CType(Me.DgvVentasRealizadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtVentaPorCliente
        '
        Me.TxtVentaPorCliente.Location = New System.Drawing.Point(218, 43)
        Me.TxtVentaPorCliente.Name = "TxtVentaPorCliente"
        Me.TxtVentaPorCliente.Size = New System.Drawing.Size(100, 20)
        Me.TxtVentaPorCliente.TabIndex = 114
        '
        'LblBuscarVentaPorCliente
        '
        Me.LblBuscarVentaPorCliente.AutoSize = True
        Me.LblBuscarVentaPorCliente.BackColor = System.Drawing.Color.Transparent
        Me.LblBuscarVentaPorCliente.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscarVentaPorCliente.ForeColor = System.Drawing.Color.White
        Me.LblBuscarVentaPorCliente.Location = New System.Drawing.Point(12, 42)
        Me.LblBuscarVentaPorCliente.Name = "LblBuscarVentaPorCliente"
        Me.LblBuscarVentaPorCliente.Size = New System.Drawing.Size(195, 21)
        Me.LblBuscarVentaPorCliente.TabIndex = 113
        Me.LblBuscarVentaPorCliente.Text = "Buscar Venta Por Cliente"
        '
        'TxtVentaPorRubro
        '
        Me.TxtVentaPorRubro.Location = New System.Drawing.Point(600, 43)
        Me.TxtVentaPorRubro.Name = "TxtVentaPorRubro"
        Me.TxtVentaPorRubro.Size = New System.Drawing.Size(100, 20)
        Me.TxtVentaPorRubro.TabIndex = 112
        '
        'LblBuscarVentaPorRubro
        '
        Me.LblBuscarVentaPorRubro.AutoSize = True
        Me.LblBuscarVentaPorRubro.BackColor = System.Drawing.Color.Transparent
        Me.LblBuscarVentaPorRubro.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscarVentaPorRubro.ForeColor = System.Drawing.Color.White
        Me.LblBuscarVentaPorRubro.Location = New System.Drawing.Point(397, 43)
        Me.LblBuscarVentaPorRubro.Name = "LblBuscarVentaPorRubro"
        Me.LblBuscarVentaPorRubro.Size = New System.Drawing.Size(187, 21)
        Me.LblBuscarVentaPorRubro.TabIndex = 111
        Me.LblBuscarVentaPorRubro.Text = "Buscar Venta Por Rubro"
        '
        'DateTimePickerHasta
        '
        Me.DateTimePickerHasta.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerHasta.Location = New System.Drawing.Point(755, 4)
        Me.DateTimePickerHasta.Name = "DateTimePickerHasta"
        Me.DateTimePickerHasta.Size = New System.Drawing.Size(124, 35)
        Me.DateTimePickerHasta.TabIndex = 110
        Me.DateTimePickerHasta.Value = New Date(2026, 10, 20, 0, 0, 0, 0)
        '
        'DateTimePickerDesde
        '
        Me.DateTimePickerDesde.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerDesde.Location = New System.Drawing.Point(607, 4)
        Me.DateTimePickerDesde.Name = "DateTimePickerDesde"
        Me.DateTimePickerDesde.Size = New System.Drawing.Size(130, 35)
        Me.DateTimePickerDesde.TabIndex = 109
        Me.DateTimePickerDesde.Value = New Date(2026, 10, 20, 0, 0, 0, 0)
        '
        'LblBuscarVentaPorFechas
        '
        Me.LblBuscarVentaPorFechas.AutoSize = True
        Me.LblBuscarVentaPorFechas.BackColor = System.Drawing.Color.Transparent
        Me.LblBuscarVentaPorFechas.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscarVentaPorFechas.ForeColor = System.Drawing.Color.White
        Me.LblBuscarVentaPorFechas.Location = New System.Drawing.Point(397, 12)
        Me.LblBuscarVentaPorFechas.Name = "LblBuscarVentaPorFechas"
        Me.LblBuscarVentaPorFechas.Size = New System.Drawing.Size(192, 21)
        Me.LblBuscarVentaPorFechas.TabIndex = 108
        Me.LblBuscarVentaPorFechas.Text = "Buscar Venta Por Fechas"
        '
        'LblBuscarVentaPorUsuario
        '
        Me.LblBuscarVentaPorUsuario.AutoSize = True
        Me.LblBuscarVentaPorUsuario.BackColor = System.Drawing.Color.Transparent
        Me.LblBuscarVentaPorUsuario.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscarVentaPorUsuario.ForeColor = System.Drawing.Color.White
        Me.LblBuscarVentaPorUsuario.Location = New System.Drawing.Point(12, 9)
        Me.LblBuscarVentaPorUsuario.Name = "LblBuscarVentaPorUsuario"
        Me.LblBuscarVentaPorUsuario.Size = New System.Drawing.Size(200, 21)
        Me.LblBuscarVentaPorUsuario.TabIndex = 107
        Me.LblBuscarVentaPorUsuario.Text = "Buscar Venta Por Usuario"
        '
        'TxtVentaPorUsuario
        '
        Me.TxtVentaPorUsuario.Location = New System.Drawing.Point(218, 12)
        Me.TxtVentaPorUsuario.Name = "TxtVentaPorUsuario"
        Me.TxtVentaPorUsuario.Size = New System.Drawing.Size(100, 20)
        Me.TxtVentaPorUsuario.TabIndex = 106
        '
        'DgvVentasRealizadas
        '
        Me.DgvVentasRealizadas.AllowUserToAddRows = False
        Me.DgvVentasRealizadas.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.DgvVentasRealizadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvVentasRealizadas.GridColor = System.Drawing.Color.RoyalBlue
        Me.DgvVentasRealizadas.Location = New System.Drawing.Point(259, 271)
        Me.DgvVentasRealizadas.Name = "DgvVentasRealizadas"
        Me.DgvVentasRealizadas.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Nirmala Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Chartreuse
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvVentasRealizadas.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvVentasRealizadas.RowHeadersVisible = False
        Me.DgvVentasRealizadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvVentasRealizadas.Size = New System.Drawing.Size(673, 270)
        Me.DgvVentasRealizadas.TabIndex = 115
        '
        'LblBuscarPorFormaDePago
        '
        Me.LblBuscarPorFormaDePago.AutoSize = True
        Me.LblBuscarPorFormaDePago.BackColor = System.Drawing.Color.Transparent
        Me.LblBuscarPorFormaDePago.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscarPorFormaDePago.ForeColor = System.Drawing.Color.White
        Me.LblBuscarPorFormaDePago.Location = New System.Drawing.Point(12, 79)
        Me.LblBuscarPorFormaDePago.Name = "LblBuscarPorFormaDePago"
        Me.LblBuscarPorFormaDePago.Size = New System.Drawing.Size(256, 21)
        Me.LblBuscarPorFormaDePago.TabIndex = 116
        Me.LblBuscarPorFormaDePago.Text = "Buscar Venta Por Forma De Pago"
        '
        'TxtBuscarVentaPorFormaPago
        '
        Me.TxtBuscarVentaPorFormaPago.Location = New System.Drawing.Point(274, 82)
        Me.TxtBuscarVentaPorFormaPago.Name = "TxtBuscarVentaPorFormaPago"
        Me.TxtBuscarVentaPorFormaPago.Size = New System.Drawing.Size(100, 20)
        Me.TxtBuscarVentaPorFormaPago.TabIndex = 117
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(397, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 21)
        Me.Label1.TabIndex = 118
        Me.Label1.Text = "Buscar Venta Por Detalle Venta"
        '
        'TxtBuscarVentaPorDetalleVenta
        '
        Me.TxtBuscarVentaPorDetalleVenta.Location = New System.Drawing.Point(647, 82)
        Me.TxtBuscarVentaPorDetalleVenta.Name = "TxtBuscarVentaPorDetalleVenta"
        Me.TxtBuscarVentaPorDetalleVenta.Size = New System.Drawing.Size(100, 20)
        Me.TxtBuscarVentaPorDetalleVenta.TabIndex = 119
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(1220, 592)
        Me.Controls.Add(Me.TxtBuscarVentaPorDetalleVenta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtBuscarVentaPorFormaPago)
        Me.Controls.Add(Me.LblBuscarPorFormaDePago)
        Me.Controls.Add(Me.DgvVentasRealizadas)
        Me.Controls.Add(Me.TxtVentaPorCliente)
        Me.Controls.Add(Me.LblBuscarVentaPorCliente)
        Me.Controls.Add(Me.TxtVentaPorRubro)
        Me.Controls.Add(Me.LblBuscarVentaPorRubro)
        Me.Controls.Add(Me.DateTimePickerHasta)
        Me.Controls.Add(Me.DateTimePickerDesde)
        Me.Controls.Add(Me.LblBuscarVentaPorFechas)
        Me.Controls.Add(Me.LblBuscarVentaPorUsuario)
        Me.Controls.Add(Me.TxtVentaPorUsuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Ventas"
        Me.Text = "Ventas"
        CType(Me.DgvVentasRealizadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtVentaPorCliente As TextBox
    Friend WithEvents LblBuscarVentaPorCliente As Label
    Friend WithEvents TxtVentaPorRubro As TextBox
    Friend WithEvents LblBuscarVentaPorRubro As Label
    Friend WithEvents DateTimePickerHasta As DateTimePicker
    Friend WithEvents DateTimePickerDesde As DateTimePicker
    Friend WithEvents LblBuscarVentaPorFechas As Label
    Friend WithEvents LblBuscarVentaPorUsuario As Label
    Friend WithEvents TxtVentaPorUsuario As TextBox
    Friend WithEvents DgvVentasRealizadas As DataGridView
    Friend WithEvents LblBuscarPorFormaDePago As Label
    Friend WithEvents TxtBuscarVentaPorFormaPago As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBuscarVentaPorDetalleVenta As TextBox
End Class
