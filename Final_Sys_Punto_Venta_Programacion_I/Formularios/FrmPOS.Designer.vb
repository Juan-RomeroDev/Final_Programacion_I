<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPOS
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPOS))
        Me.dgvBusquedaProductosPOS = New System.Windows.Forms.DataGridView()
        Me.DgvCarritoProductos = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtBuscarProducto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnQuitarRenglon = New System.Windows.Forms.Button()
        Me.BtnFinalizarVenta = New System.Windows.Forms.Button()
        Me.CB_Clientes = New System.Windows.Forms.ComboBox()
        Me.CB_FormaPago = New System.Windows.Forms.ComboBox()
        Me.BtnCancelarVenta = New System.Windows.Forms.Button()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LblCantidad = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LblProductos = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.dgvBusquedaProductosPOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvCarritoProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBusquedaProductosPOS
        '
        Me.dgvBusquedaProductosPOS.AllowUserToAddRows = False
        Me.dgvBusquedaProductosPOS.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.dgvBusquedaProductosPOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBusquedaProductosPOS.GridColor = System.Drawing.Color.RoyalBlue
        Me.dgvBusquedaProductosPOS.Location = New System.Drawing.Point(21, 119)
        Me.dgvBusquedaProductosPOS.Name = "dgvBusquedaProductosPOS"
        Me.dgvBusquedaProductosPOS.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Nirmala Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Chartreuse
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBusquedaProductosPOS.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBusquedaProductosPOS.RowHeadersVisible = False
        Me.dgvBusquedaProductosPOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBusquedaProductosPOS.Size = New System.Drawing.Size(646, 225)
        Me.dgvBusquedaProductosPOS.TabIndex = 44
        '
        'DgvCarritoProductos
        '
        Me.DgvCarritoProductos.AllowUserToAddRows = False
        Me.DgvCarritoProductos.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.DgvCarritoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCarritoProductos.GridColor = System.Drawing.Color.RoyalBlue
        Me.DgvCarritoProductos.Location = New System.Drawing.Point(21, 383)
        Me.DgvCarritoProductos.Name = "DgvCarritoProductos"
        Me.DgvCarritoProductos.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Nirmala Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Chartreuse
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvCarritoProductos.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvCarritoProductos.RowHeadersVisible = False
        Me.DgvCarritoProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCarritoProductos.Size = New System.Drawing.Size(646, 193)
        Me.DgvCarritoProductos.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala Text", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(703, 310)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 45)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "$"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala Text", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(696, 265)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 45)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "TOTAL:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nirmala Text", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(696, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(187, 45)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "SUBTOTAL:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Nirmala Text", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(703, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 45)
        Me.Label6.TabIndex = 101
        Me.Label6.Text = "$"
        '
        'TxtBuscarProducto
        '
        Me.TxtBuscarProducto.Location = New System.Drawing.Point(25, 62)
        Me.TxtBuscarProducto.Name = "TxtBuscarProducto"
        Me.TxtBuscarProducto.Size = New System.Drawing.Size(170, 20)
        Me.TxtBuscarProducto.TabIndex = 116
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(21, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 21)
        Me.Label8.TabIndex = 115
        Me.Label8.Text = "Buscar Producto:"
        '
        'BtnQuitarRenglon
        '
        Me.BtnQuitarRenglon.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuitarRenglon.Location = New System.Drawing.Point(736, 549)
        Me.BtnQuitarRenglon.Name = "BtnQuitarRenglon"
        Me.BtnQuitarRenglon.Size = New System.Drawing.Size(128, 31)
        Me.BtnQuitarRenglon.TabIndex = 117
        Me.BtnQuitarRenglon.Text = "Quitar Renglon"
        Me.BtnQuitarRenglon.UseVisualStyleBackColor = True
        '
        'BtnFinalizarVenta
        '
        Me.BtnFinalizarVenta.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFinalizarVenta.Location = New System.Drawing.Point(684, 407)
        Me.BtnFinalizarVenta.Name = "BtnFinalizarVenta"
        Me.BtnFinalizarVenta.Size = New System.Drawing.Size(242, 55)
        Me.BtnFinalizarVenta.TabIndex = 118
        Me.BtnFinalizarVenta.Text = "Finalizar Venta"
        Me.BtnFinalizarVenta.UseVisualStyleBackColor = True
        '
        'CB_Clientes
        '
        Me.CB_Clientes.FormattingEnabled = True
        Me.CB_Clientes.Location = New System.Drawing.Point(456, 35)
        Me.CB_Clientes.Name = "CB_Clientes"
        Me.CB_Clientes.Size = New System.Drawing.Size(242, 21)
        Me.CB_Clientes.TabIndex = 119
        '
        'CB_FormaPago
        '
        Me.CB_FormaPago.FormattingEnabled = True
        Me.CB_FormaPago.Location = New System.Drawing.Point(456, 86)
        Me.CB_FormaPago.Name = "CB_FormaPago"
        Me.CB_FormaPago.Size = New System.Drawing.Size(242, 21)
        Me.CB_FormaPago.TabIndex = 120
        '
        'BtnCancelarVenta
        '
        Me.BtnCancelarVenta.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelarVenta.Location = New System.Drawing.Point(684, 485)
        Me.BtnCancelarVenta.Name = "BtnCancelarVenta"
        Me.BtnCancelarVenta.Size = New System.Drawing.Size(242, 58)
        Me.BtnCancelarVenta.TabIndex = 124
        Me.BtnCancelarVenta.Text = "Cancelar Venta"
        Me.BtnCancelarVenta.UseVisualStyleBackColor = True
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.BackColor = System.Drawing.Color.Transparent
        Me.LblUsuario.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.ForeColor = System.Drawing.Color.White
        Me.LblUsuario.Location = New System.Drawing.Point(829, 9)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(73, 21)
        Me.LblUsuario.TabIndex = 125
        Me.LblUsuario.Text = "Usuario:"
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.BackColor = System.Drawing.Color.Transparent
        Me.LblFecha.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha.ForeColor = System.Drawing.Color.White
        Me.LblFecha.Location = New System.Drawing.Point(352, 10)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(58, 21)
        Me.LblFecha.TabIndex = 126
        Me.LblFecha.Text = "Fecha:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(21, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 21)
        Me.Label7.TabIndex = 127
        Me.Label7.Text = "Venta N°:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(908, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 20)
        Me.Label3.TabIndex = 128
        Me.Label3.Text = "#"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(416, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 20)
        Me.Label9.TabIndex = 129
        Me.Label9.Text = "#"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(108, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 20)
        Me.Label10.TabIndex = 130
        Me.Label10.Text = "#"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(452, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 21)
        Me.Label5.TabIndex = 131
        Me.Label5.Text = "Cliente:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(452, 62)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(187, 21)
        Me.Label11.TabIndex = 132
        Me.Label11.Text = "Forma De Pago Cliente:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(737, 324)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(18, 20)
        Me.Label12.TabIndex = 133
        Me.Label12.Text = "#"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(737, 220)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(18, 20)
        Me.Label13.TabIndex = 134
        Me.Label13.Text = "#"
        '
        'LblCantidad
        '
        Me.LblCantidad.AutoSize = True
        Me.LblCantidad.BackColor = System.Drawing.Color.Transparent
        Me.LblCantidad.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCantidad.ForeColor = System.Drawing.Color.White
        Me.LblCantidad.Location = New System.Drawing.Point(352, 38)
        Me.LblCantidad.Name = "LblCantidad"
        Me.LblCantidad.Size = New System.Drawing.Size(83, 21)
        Me.LblCantidad.TabIndex = 137
        Me.LblCantidad.Text = "Cantidad:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(358, 62)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(18, 20)
        Me.Label15.TabIndex = 138
        Me.Label15.Text = "#"
        '
        'LblProductos
        '
        Me.LblProductos.AutoSize = True
        Me.LblProductos.BackColor = System.Drawing.Color.Transparent
        Me.LblProductos.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProductos.ForeColor = System.Drawing.Color.White
        Me.LblProductos.Location = New System.Drawing.Point(21, 96)
        Me.LblProductos.Name = "LblProductos"
        Me.LblProductos.Size = New System.Drawing.Size(91, 21)
        Me.LblProductos.TabIndex = 139
        Me.LblProductos.Text = "Productos:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(21, 359)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(158, 21)
        Me.Label16.TabIndex = 140
        Me.Label16.Text = "Detalle de la Venta:"
        '
        'FrmPOS
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(957, 593)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.LblProductos)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.LblCantidad)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LblFecha)
        Me.Controls.Add(Me.LblUsuario)
        Me.Controls.Add(Me.BtnCancelarVenta)
        Me.Controls.Add(Me.CB_FormaPago)
        Me.Controls.Add(Me.CB_Clientes)
        Me.Controls.Add(Me.BtnFinalizarVenta)
        Me.Controls.Add(Me.BtnQuitarRenglon)
        Me.Controls.Add(Me.TxtBuscarProducto)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgvCarritoProductos)
        Me.Controls.Add(Me.dgvBusquedaProductosPOS)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPOS"
        Me.Text = "VENTAS"
        CType(Me.dgvBusquedaProductosPOS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvCarritoProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvBusquedaProductosPOS As DataGridView
    Friend WithEvents DgvCarritoProductos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtBuscarProducto As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnQuitarRenglon As Button
    Friend WithEvents BtnFinalizarVenta As Button
    Friend WithEvents CB_Clientes As ComboBox
    Friend WithEvents CB_FormaPago As ComboBox
    Friend WithEvents BtnCancelarVenta As Button
    Friend WithEvents LblUsuario As Label
    Friend WithEvents LblFecha As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents LblCantidad As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents LblProductos As Label
    Friend WithEvents Label16 As Label
End Class
