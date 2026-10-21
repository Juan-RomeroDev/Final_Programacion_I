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
        Me.LblDolar = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnQuitarRenglon = New System.Windows.Forms.Button()
        Me.BtnFinalizarVenta = New System.Windows.Forms.Button()
        Me.CB_Clientes = New System.Windows.Forms.ComboBox()
        Me.CB_FormaPago = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.BtnCancelarVenta = New System.Windows.Forms.Button()
        CType(Me.dgvBusquedaProductosPOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvCarritoProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBusquedaProductosPOS
        '
        Me.dgvBusquedaProductosPOS.AllowUserToAddRows = False
        Me.dgvBusquedaProductosPOS.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.dgvBusquedaProductosPOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBusquedaProductosPOS.GridColor = System.Drawing.Color.RoyalBlue
        Me.dgvBusquedaProductosPOS.Location = New System.Drawing.Point(25, 62)
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
        Me.DgvCarritoProductos.Location = New System.Drawing.Point(25, 329)
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
        'LblDolar
        '
        Me.LblDolar.AutoSize = True
        Me.LblDolar.Font = New System.Drawing.Font("Nirmala Text", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDolar.ForeColor = System.Drawing.Color.White
        Me.LblDolar.Location = New System.Drawing.Point(705, 93)
        Me.LblDolar.Name = "LblDolar"
        Me.LblDolar.Size = New System.Drawing.Size(74, 86)
        Me.LblDolar.TabIndex = 46
        Me.LblDolar.Text = "$"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala Text", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(918, 436)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 86)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "$"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala Text", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(677, 436)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(246, 86)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "TOTAL:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nirmala Text", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(677, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(366, 86)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "SUBTOTAL:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Nirmala Text", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(1038, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 86)
        Me.Label6.TabIndex = 101
        Me.Label6.Text = "$"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(195, 24)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 116
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(55, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 21)
        Me.Label8.TabIndex = 115
        Me.Label8.Text = "Buscar Producto"
        '
        'BtnQuitarRenglon
        '
        Me.BtnQuitarRenglon.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuitarRenglon.Location = New System.Drawing.Point(1013, 347)
        Me.BtnQuitarRenglon.Name = "BtnQuitarRenglon"
        Me.BtnQuitarRenglon.Size = New System.Drawing.Size(128, 31)
        Me.BtnQuitarRenglon.TabIndex = 117
        Me.BtnQuitarRenglon.Text = "Quitar Renglon"
        Me.BtnQuitarRenglon.UseVisualStyleBackColor = True
        '
        'BtnFinalizarVenta
        '
        Me.BtnFinalizarVenta.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFinalizarVenta.Location = New System.Drawing.Point(1013, 454)
        Me.BtnFinalizarVenta.Name = "BtnFinalizarVenta"
        Me.BtnFinalizarVenta.Size = New System.Drawing.Size(128, 31)
        Me.BtnFinalizarVenta.TabIndex = 118
        Me.BtnFinalizarVenta.Text = "Finalizar Venta"
        Me.BtnFinalizarVenta.UseVisualStyleBackColor = True
        '
        'CB_Clientes
        '
        Me.CB_Clientes.FormattingEnabled = True
        Me.CB_Clientes.Location = New System.Drawing.Point(25, 546)
        Me.CB_Clientes.Name = "CB_Clientes"
        Me.CB_Clientes.Size = New System.Drawing.Size(121, 21)
        Me.CB_Clientes.TabIndex = 119
        '
        'CB_FormaPago
        '
        Me.CB_FormaPago.FormattingEnabled = True
        Me.CB_FormaPago.Location = New System.Drawing.Point(308, 546)
        Me.CB_FormaPago.Name = "CB_FormaPago"
        Me.CB_FormaPago.Size = New System.Drawing.Size(121, 21)
        Me.CB_FormaPago.TabIndex = 120
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(901, 564)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 20)
        Me.Label3.TabIndex = 121
        Me.Label3.Text = "Usuario Realizando Venta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(1123, 564)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 20)
        Me.Label5.TabIndex = 122
        Me.Label5.Text = "#"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(677, 394)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(61, 20)
        Me.NumericUpDown1.TabIndex = 123
        '
        'BtnCancelarVenta
        '
        Me.BtnCancelarVenta.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelarVenta.Location = New System.Drawing.Point(1013, 403)
        Me.BtnCancelarVenta.Name = "BtnCancelarVenta"
        Me.BtnCancelarVenta.Size = New System.Drawing.Size(128, 31)
        Me.BtnCancelarVenta.TabIndex = 124
        Me.BtnCancelarVenta.Text = "Cancelar Venta"
        Me.BtnCancelarVenta.UseVisualStyleBackColor = True
        '
        'FrmPOS
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1187, 593)
        Me.Controls.Add(Me.BtnCancelarVenta)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CB_FormaPago)
        Me.Controls.Add(Me.CB_Clientes)
        Me.Controls.Add(Me.BtnFinalizarVenta)
        Me.Controls.Add(Me.BtnQuitarRenglon)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblDolar)
        Me.Controls.Add(Me.DgvCarritoProductos)
        Me.Controls.Add(Me.dgvBusquedaProductosPOS)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPOS"
        Me.Text = "VENTAS"
        CType(Me.dgvBusquedaProductosPOS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvCarritoProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvBusquedaProductosPOS As DataGridView
    Friend WithEvents DgvCarritoProductos As DataGridView
    Friend WithEvents LblDolar As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnQuitarRenglon As Button
    Friend WithEvents BtnFinalizarVenta As Button
    Friend WithEvents CB_Clientes As ComboBox
    Friend WithEvents CB_FormaPago As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents BtnCancelarVenta As Button
End Class
