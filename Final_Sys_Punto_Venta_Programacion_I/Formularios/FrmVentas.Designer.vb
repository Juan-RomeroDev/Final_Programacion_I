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
        Me.BtnAtrasVentas = New System.Windows.Forms.Button()
        Me.LblVentaPorProducto = New System.Windows.Forms.Label()
        Me.TxtBuscarVentaPorProducto = New System.Windows.Forms.TextBox()
        Me.TxtBoxVentaPorLocalidad = New System.Windows.Forms.TextBox()
        Me.BtnBuscarVentaPorLocalidad = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnImprimirVenta = New System.Windows.Forms.Button()
        Me.LblVentas = New System.Windows.Forms.Label()
        Me.LblDesdeFecha = New System.Windows.Forms.Label()
        Me.LblHastaFecha = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DgvVentasRealizadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtVentaPorCliente
        '
        Me.TxtVentaPorCliente.Location = New System.Drawing.Point(49, 149)
        Me.TxtVentaPorCliente.Name = "TxtVentaPorCliente"
        Me.TxtVentaPorCliente.Size = New System.Drawing.Size(135, 20)
        Me.TxtVentaPorCliente.TabIndex = 114
        '
        'LblBuscarVentaPorCliente
        '
        Me.LblBuscarVentaPorCliente.AutoSize = True
        Me.LblBuscarVentaPorCliente.BackColor = System.Drawing.Color.Transparent
        Me.LblBuscarVentaPorCliente.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscarVentaPorCliente.ForeColor = System.Drawing.Color.White
        Me.LblBuscarVentaPorCliente.Location = New System.Drawing.Point(45, 125)
        Me.LblBuscarVentaPorCliente.Name = "LblBuscarVentaPorCliente"
        Me.LblBuscarVentaPorCliente.Size = New System.Drawing.Size(195, 21)
        Me.LblBuscarVentaPorCliente.TabIndex = 113
        Me.LblBuscarVentaPorCliente.Text = "Buscar Venta Por Cliente"
        '
        'TxtVentaPorRubro
        '
        Me.TxtVentaPorRubro.Location = New System.Drawing.Point(393, 92)
        Me.TxtVentaPorRubro.Name = "TxtVentaPorRubro"
        Me.TxtVentaPorRubro.Size = New System.Drawing.Size(130, 20)
        Me.TxtVentaPorRubro.TabIndex = 112
        '
        'LblBuscarVentaPorRubro
        '
        Me.LblBuscarVentaPorRubro.AutoSize = True
        Me.LblBuscarVentaPorRubro.BackColor = System.Drawing.Color.Transparent
        Me.LblBuscarVentaPorRubro.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscarVentaPorRubro.ForeColor = System.Drawing.Color.White
        Me.LblBuscarVentaPorRubro.Location = New System.Drawing.Point(389, 68)
        Me.LblBuscarVentaPorRubro.Name = "LblBuscarVentaPorRubro"
        Me.LblBuscarVentaPorRubro.Size = New System.Drawing.Size(187, 21)
        Me.LblBuscarVentaPorRubro.TabIndex = 111
        Me.LblBuscarVentaPorRubro.Text = "Buscar Venta Por Rubro"
        '
        'DateTimePickerHasta
        '
        Me.DateTimePickerHasta.Font = New System.Drawing.Font("Nirmala Text", 8.25!, System.Drawing.FontStyle.Bold)
        Me.DateTimePickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerHasta.Location = New System.Drawing.Point(654, 206)
        Me.DateTimePickerHasta.Name = "DateTimePickerHasta"
        Me.DateTimePickerHasta.Size = New System.Drawing.Size(130, 28)
        Me.DateTimePickerHasta.TabIndex = 110
        Me.DateTimePickerHasta.Value = New Date(2026, 10, 20, 0, 0, 0, 0)
        '
        'DateTimePickerDesde
        '
        Me.DateTimePickerDesde.Font = New System.Drawing.Font("Nirmala Text", 8.25!, System.Drawing.FontStyle.Bold)
        Me.DateTimePickerDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerDesde.Location = New System.Drawing.Point(460, 206)
        Me.DateTimePickerDesde.Name = "DateTimePickerDesde"
        Me.DateTimePickerDesde.Size = New System.Drawing.Size(130, 28)
        Me.DateTimePickerDesde.TabIndex = 109
        Me.DateTimePickerDesde.Value = New Date(2026, 10, 20, 0, 0, 0, 0)
        '
        'LblBuscarVentaPorFechas
        '
        Me.LblBuscarVentaPorFechas.AutoSize = True
        Me.LblBuscarVentaPorFechas.BackColor = System.Drawing.Color.Transparent
        Me.LblBuscarVentaPorFechas.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscarVentaPorFechas.ForeColor = System.Drawing.Color.White
        Me.LblBuscarVentaPorFechas.Location = New System.Drawing.Point(389, 182)
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
        Me.LblBuscarVentaPorUsuario.Location = New System.Drawing.Point(45, 68)
        Me.LblBuscarVentaPorUsuario.Name = "LblBuscarVentaPorUsuario"
        Me.LblBuscarVentaPorUsuario.Size = New System.Drawing.Size(200, 21)
        Me.LblBuscarVentaPorUsuario.TabIndex = 107
        Me.LblBuscarVentaPorUsuario.Text = "Buscar Venta Por Usuario"
        '
        'TxtVentaPorUsuario
        '
        Me.TxtVentaPorUsuario.Location = New System.Drawing.Point(49, 92)
        Me.TxtVentaPorUsuario.Name = "TxtVentaPorUsuario"
        Me.TxtVentaPorUsuario.Size = New System.Drawing.Size(135, 20)
        Me.TxtVentaPorUsuario.TabIndex = 106
        '
        'DgvVentasRealizadas
        '
        Me.DgvVentasRealizadas.AllowUserToAddRows = False
        Me.DgvVentasRealizadas.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.DgvVentasRealizadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvVentasRealizadas.GridColor = System.Drawing.Color.RoyalBlue
        Me.DgvVentasRealizadas.Location = New System.Drawing.Point(49, 246)
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
        Me.DgvVentasRealizadas.Size = New System.Drawing.Size(1014, 270)
        Me.DgvVentasRealizadas.TabIndex = 115
        '
        'LblBuscarPorFormaDePago
        '
        Me.LblBuscarPorFormaDePago.AutoSize = True
        Me.LblBuscarPorFormaDePago.BackColor = System.Drawing.Color.Transparent
        Me.LblBuscarPorFormaDePago.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscarPorFormaDePago.ForeColor = System.Drawing.Color.White
        Me.LblBuscarPorFormaDePago.Location = New System.Drawing.Point(45, 182)
        Me.LblBuscarPorFormaDePago.Name = "LblBuscarPorFormaDePago"
        Me.LblBuscarPorFormaDePago.Size = New System.Drawing.Size(256, 21)
        Me.LblBuscarPorFormaDePago.TabIndex = 116
        Me.LblBuscarPorFormaDePago.Text = "Buscar Venta Por Forma De Pago"
        '
        'TxtBuscarVentaPorFormaPago
        '
        Me.TxtBuscarVentaPorFormaPago.Location = New System.Drawing.Point(49, 206)
        Me.TxtBuscarVentaPorFormaPago.Name = "TxtBuscarVentaPorFormaPago"
        Me.TxtBuscarVentaPorFormaPago.Size = New System.Drawing.Size(135, 20)
        Me.TxtBuscarVentaPorFormaPago.TabIndex = 117
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(389, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 21)
        Me.Label1.TabIndex = 118
        Me.Label1.Text = "Buscar Venta Por Detalle Venta"
        '
        'TxtBuscarVentaPorDetalleVenta
        '
        Me.TxtBuscarVentaPorDetalleVenta.Location = New System.Drawing.Point(393, 149)
        Me.TxtBuscarVentaPorDetalleVenta.Name = "TxtBuscarVentaPorDetalleVenta"
        Me.TxtBuscarVentaPorDetalleVenta.Size = New System.Drawing.Size(130, 20)
        Me.TxtBuscarVentaPorDetalleVenta.TabIndex = 119
        '
        'BtnAtrasVentas
        '
        Me.BtnAtrasVentas.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAtrasVentas.Location = New System.Drawing.Point(-2, -1)
        Me.BtnAtrasVentas.Name = "BtnAtrasVentas"
        Me.BtnAtrasVentas.Size = New System.Drawing.Size(82, 33)
        Me.BtnAtrasVentas.TabIndex = 129
        Me.BtnAtrasVentas.Text = "ATRAS"
        Me.BtnAtrasVentas.UseVisualStyleBackColor = True
        '
        'LblVentaPorProducto
        '
        Me.LblVentaPorProducto.AutoSize = True
        Me.LblVentaPorProducto.BackColor = System.Drawing.Color.Transparent
        Me.LblVentaPorProducto.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVentaPorProducto.ForeColor = System.Drawing.Color.White
        Me.LblVentaPorProducto.Location = New System.Drawing.Point(736, 68)
        Me.LblVentaPorProducto.Name = "LblVentaPorProducto"
        Me.LblVentaPorProducto.Size = New System.Drawing.Size(211, 21)
        Me.LblVentaPorProducto.TabIndex = 130
        Me.LblVentaPorProducto.Text = "Buscar Venta Por Producto"
        '
        'TxtBuscarVentaPorProducto
        '
        Me.TxtBuscarVentaPorProducto.Location = New System.Drawing.Point(740, 92)
        Me.TxtBuscarVentaPorProducto.Name = "TxtBuscarVentaPorProducto"
        Me.TxtBuscarVentaPorProducto.Size = New System.Drawing.Size(133, 20)
        Me.TxtBuscarVentaPorProducto.TabIndex = 131
        '
        'TxtBoxVentaPorLocalidad
        '
        Me.TxtBoxVentaPorLocalidad.Location = New System.Drawing.Point(740, 163)
        Me.TxtBoxVentaPorLocalidad.Name = "TxtBoxVentaPorLocalidad"
        Me.TxtBoxVentaPorLocalidad.Size = New System.Drawing.Size(133, 20)
        Me.TxtBoxVentaPorLocalidad.TabIndex = 133
        '
        'BtnBuscarVentaPorLocalidad
        '
        Me.BtnBuscarVentaPorLocalidad.AutoSize = True
        Me.BtnBuscarVentaPorLocalidad.BackColor = System.Drawing.Color.Transparent
        Me.BtnBuscarVentaPorLocalidad.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarVentaPorLocalidad.ForeColor = System.Drawing.Color.White
        Me.BtnBuscarVentaPorLocalidad.Location = New System.Drawing.Point(736, 139)
        Me.BtnBuscarVentaPorLocalidad.Name = "BtnBuscarVentaPorLocalidad"
        Me.BtnBuscarVentaPorLocalidad.Size = New System.Drawing.Size(215, 21)
        Me.BtnBuscarVentaPorLocalidad.TabIndex = 132
        Me.BtnBuscarVentaPorLocalidad.Text = "Buscar Venta Por Localidad"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Final_Sys_Punto_Venta_Programacion_I.My.Resources.Resources.Pollo_Abasto_Tu_Almacen
        Me.PictureBox1.Location = New System.Drawing.Point(1038, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 134
        Me.PictureBox1.TabStop = False
        '
        'BtnImprimirVenta
        '
        Me.BtnImprimirVenta.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImprimirVenta.Location = New System.Drawing.Point(49, 534)
        Me.BtnImprimirVenta.Name = "BtnImprimirVenta"
        Me.BtnImprimirVenta.Size = New System.Drawing.Size(183, 28)
        Me.BtnImprimirVenta.TabIndex = 135
        Me.BtnImprimirVenta.Text = "Imprimir Comprobante"
        Me.BtnImprimirVenta.UseVisualStyleBackColor = True
        '
        'LblVentas
        '
        Me.LblVentas.AutoSize = True
        Me.LblVentas.BackColor = System.Drawing.Color.Transparent
        Me.LblVentas.Font = New System.Drawing.Font("Nirmala Text", 24.0!, System.Drawing.FontStyle.Bold)
        Me.LblVentas.ForeColor = System.Drawing.Color.White
        Me.LblVentas.Location = New System.Drawing.Point(494, 9)
        Me.LblVentas.Name = "LblVentas"
        Me.LblVentas.Size = New System.Drawing.Size(141, 45)
        Me.LblVentas.TabIndex = 136
        Me.LblVentas.Text = "VENTAS"
        '
        'LblDesdeFecha
        '
        Me.LblDesdeFecha.AutoSize = True
        Me.LblDesdeFecha.BackColor = System.Drawing.Color.Transparent
        Me.LblDesdeFecha.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDesdeFecha.ForeColor = System.Drawing.Color.White
        Me.LblDesdeFecha.Location = New System.Drawing.Point(393, 210)
        Me.LblDesdeFecha.Name = "LblDesdeFecha"
        Me.LblDesdeFecha.Size = New System.Drawing.Size(61, 21)
        Me.LblDesdeFecha.TabIndex = 137
        Me.LblDesdeFecha.Text = "Desde:"
        '
        'LblHastaFecha
        '
        Me.LblHastaFecha.AutoSize = True
        Me.LblHastaFecha.BackColor = System.Drawing.Color.Transparent
        Me.LblHastaFecha.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHastaFecha.ForeColor = System.Drawing.Color.White
        Me.LblHastaFecha.Location = New System.Drawing.Point(596, 210)
        Me.LblHastaFecha.Name = "LblHastaFecha"
        Me.LblHastaFecha.Size = New System.Drawing.Size(57, 21)
        Me.LblHastaFecha.TabIndex = 138
        Me.LblHastaFecha.Text = "Hasta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(389, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 21)
        Me.Label2.TabIndex = 137
        Me.Label2.Text = "Desde:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(592, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 21)
        Me.Label3.TabIndex = 138
        Me.Label3.Text = "Hasta:"
        '
        'FrmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(1106, 592)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblHastaFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblDesdeFecha)
        Me.Controls.Add(Me.LblVentas)
        Me.Controls.Add(Me.BtnImprimirVenta)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TxtBoxVentaPorLocalidad)
        Me.Controls.Add(Me.BtnBuscarVentaPorLocalidad)
        Me.Controls.Add(Me.TxtBuscarVentaPorProducto)
        Me.Controls.Add(Me.LblVentaPorProducto)
        Me.Controls.Add(Me.BtnAtrasVentas)
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
        Me.Name = "FrmVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        CType(Me.DgvVentasRealizadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BtnAtrasVentas As Button
    Friend WithEvents LblVentaPorProducto As Label
    Friend WithEvents TxtBuscarVentaPorProducto As TextBox
    Friend WithEvents TxtBoxVentaPorLocalidad As TextBox
    Friend WithEvents BtnBuscarVentaPorLocalidad As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnImprimirVenta As Button
    Friend WithEvents LblVentas As Label
    Friend WithEvents LblDesdeFecha As Label
    Friend WithEvents LblHastaFecha As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
