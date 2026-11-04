<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPOS
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
        Me.Lbl_Venta_N = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.LblSubtotal = New System.Windows.Forms.Label()
        Me.LblCantidad = New System.Windows.Forms.Label()
        Me.LblProductos = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.BtnAtrasPOS = New System.Windows.Forms.Button()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblCantidad_Ingresar = New System.Windows.Forms.Label()
        Me.LblModificarCantidadCarrito = New System.Windows.Forms.Label()
        Me.TxtCantidad_A_Cambiar = New System.Windows.Forms.TextBox()
        CType(Me.dgvBusquedaProductosPOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvCarritoProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBusquedaProductosPOS
        '
        Me.dgvBusquedaProductosPOS.AllowUserToAddRows = False
        Me.dgvBusquedaProductosPOS.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.dgvBusquedaProductosPOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBusquedaProductosPOS.GridColor = System.Drawing.Color.RoyalBlue
        Me.dgvBusquedaProductosPOS.Location = New System.Drawing.Point(35, 146)
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
        Me.dgvBusquedaProductosPOS.Size = New System.Drawing.Size(782, 272)
        Me.dgvBusquedaProductosPOS.TabIndex = 44
        '
        'DgvCarritoProductos
        '
        Me.DgvCarritoProductos.AllowUserToAddRows = False
        Me.DgvCarritoProductos.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.DgvCarritoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCarritoProductos.GridColor = System.Drawing.Color.RoyalBlue
        Me.DgvCarritoProductos.Location = New System.Drawing.Point(35, 445)
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
        Me.DgvCarritoProductos.Size = New System.Drawing.Size(782, 280)
        Me.DgvCarritoProductos.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala Text", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(873, 335)
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
        Me.Label2.Location = New System.Drawing.Point(866, 290)
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
        Me.Label4.Location = New System.Drawing.Point(866, 181)
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
        Me.Label6.Location = New System.Drawing.Point(873, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 45)
        Me.Label6.TabIndex = 101
        Me.Label6.Text = "$"
        '
        'TxtBuscarProducto
        '
        Me.TxtBuscarProducto.Location = New System.Drawing.Point(112, 87)
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
        Me.Label8.Location = New System.Drawing.Point(108, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 21)
        Me.Label8.TabIndex = 115
        Me.Label8.Text = "Buscar Producto:"
        '
        'BtnQuitarRenglon
        '
        Me.BtnQuitarRenglon.BackColor = System.Drawing.Color.Khaki
        Me.BtnQuitarRenglon.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuitarRenglon.Location = New System.Drawing.Point(927, 643)
        Me.BtnQuitarRenglon.Name = "BtnQuitarRenglon"
        Me.BtnQuitarRenglon.Size = New System.Drawing.Size(128, 31)
        Me.BtnQuitarRenglon.TabIndex = 117
        Me.BtnQuitarRenglon.Text = "Quitar Renglon"
        Me.BtnQuitarRenglon.UseVisualStyleBackColor = False
        '
        'BtnFinalizarVenta
        '
        Me.BtnFinalizarVenta.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.BtnFinalizarVenta.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFinalizarVenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnFinalizarVenta.Location = New System.Drawing.Point(874, 488)
        Me.BtnFinalizarVenta.Name = "BtnFinalizarVenta"
        Me.BtnFinalizarVenta.Size = New System.Drawing.Size(242, 55)
        Me.BtnFinalizarVenta.TabIndex = 118
        Me.BtnFinalizarVenta.Text = "Finalizar Venta"
        Me.BtnFinalizarVenta.UseVisualStyleBackColor = False
        '
        'CB_Clientes
        '
        Me.CB_Clientes.FormattingEnabled = True
        Me.CB_Clientes.Location = New System.Drawing.Point(704, 47)
        Me.CB_Clientes.Name = "CB_Clientes"
        Me.CB_Clientes.Size = New System.Drawing.Size(175, 21)
        Me.CB_Clientes.TabIndex = 119
        '
        'CB_FormaPago
        '
        Me.CB_FormaPago.FormattingEnabled = True
        Me.CB_FormaPago.Location = New System.Drawing.Point(704, 101)
        Me.CB_FormaPago.Name = "CB_FormaPago"
        Me.CB_FormaPago.Size = New System.Drawing.Size(175, 21)
        Me.CB_FormaPago.TabIndex = 120
        '
        'BtnCancelarVenta
        '
        Me.BtnCancelarVenta.BackColor = System.Drawing.Color.Crimson
        Me.BtnCancelarVenta.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelarVenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnCancelarVenta.Location = New System.Drawing.Point(874, 563)
        Me.BtnCancelarVenta.Name = "BtnCancelarVenta"
        Me.BtnCancelarVenta.Size = New System.Drawing.Size(242, 58)
        Me.BtnCancelarVenta.TabIndex = 124
        Me.BtnCancelarVenta.Text = "Cancelar Venta"
        Me.BtnCancelarVenta.UseVisualStyleBackColor = False
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.BackColor = System.Drawing.Color.Transparent
        Me.LblUsuario.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.ForeColor = System.Drawing.Color.White
        Me.LblUsuario.Location = New System.Drawing.Point(907, 47)
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
        Me.LblFecha.Location = New System.Drawing.Point(108, 38)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(58, 21)
        Me.LblFecha.TabIndex = 126
        Me.LblFecha.Text = "Fecha:"
        '
        'Lbl_Venta_N
        '
        Me.Lbl_Venta_N.AutoSize = True
        Me.Lbl_Venta_N.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Venta_N.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Venta_N.ForeColor = System.Drawing.Color.White
        Me.Lbl_Venta_N.Location = New System.Drawing.Point(108, 10)
        Me.Lbl_Venta_N.Name = "Lbl_Venta_N"
        Me.Lbl_Venta_N.Size = New System.Drawing.Size(81, 21)
        Me.Lbl_Venta_N.TabIndex = 127
        Me.Lbl_Venta_N.Text = "Venta N°:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(700, 23)
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
        Me.Label11.Location = New System.Drawing.Point(700, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(187, 21)
        Me.Label11.TabIndex = 132
        Me.Label11.Text = "Forma De Pago Cliente:"
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.ForeColor = System.Drawing.Color.White
        Me.LblTotal.Location = New System.Drawing.Point(907, 349)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(18, 20)
        Me.LblTotal.TabIndex = 133
        Me.LblTotal.Text = "#"
        '
        'LblSubtotal
        '
        Me.LblSubtotal.AutoSize = True
        Me.LblSubtotal.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubtotal.ForeColor = System.Drawing.Color.White
        Me.LblSubtotal.Location = New System.Drawing.Point(907, 245)
        Me.LblSubtotal.Name = "LblSubtotal"
        Me.LblSubtotal.Size = New System.Drawing.Size(18, 20)
        Me.LblSubtotal.TabIndex = 134
        Me.LblSubtotal.Text = "#"
        '
        'LblCantidad
        '
        Me.LblCantidad.AutoSize = True
        Me.LblCantidad.BackColor = System.Drawing.Color.Transparent
        Me.LblCantidad.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCantidad.ForeColor = System.Drawing.Color.White
        Me.LblCantidad.Location = New System.Drawing.Point(318, 10)
        Me.LblCantidad.Name = "LblCantidad"
        Me.LblCantidad.Size = New System.Drawing.Size(121, 21)
        Me.LblCantidad.TabIndex = 137
        Me.LblCantidad.Text = "Cantidad Filas:"
        '
        'LblProductos
        '
        Me.LblProductos.AutoSize = True
        Me.LblProductos.BackColor = System.Drawing.Color.Transparent
        Me.LblProductos.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProductos.ForeColor = System.Drawing.Color.White
        Me.LblProductos.Location = New System.Drawing.Point(31, 119)
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
        Me.Label16.Location = New System.Drawing.Point(31, 421)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(158, 21)
        Me.Label16.TabIndex = 140
        Me.Label16.Text = "Detalle de la Venta:"
        '
        'BtnAtrasPOS
        '
        Me.BtnAtrasPOS.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAtrasPOS.Location = New System.Drawing.Point(-4, -2)
        Me.BtnAtrasPOS.Name = "BtnAtrasPOS"
        Me.BtnAtrasPOS.Size = New System.Drawing.Size(82, 33)
        Me.BtnAtrasPOS.TabIndex = 142
        Me.BtnAtrasPOS.Text = "ATRAS"
        Me.BtnAtrasPOS.UseVisualStyleBackColor = True
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Font = New System.Drawing.Font("Nirmala Text", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantidad.Location = New System.Drawing.Point(322, 71)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(159, 28)
        Me.TxtCantidad.TabIndex = 144
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Final_Sys_Punto_Venta_Programacion_I.My.Resources.Resources.Pollo_Abasto_Tu_Almacen
        Me.PictureBox1.Location = New System.Drawing.Point(1101, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 141
        Me.PictureBox1.TabStop = False
        '
        'LblCantidad_Ingresar
        '
        Me.LblCantidad_Ingresar.AutoSize = True
        Me.LblCantidad_Ingresar.BackColor = System.Drawing.Color.Transparent
        Me.LblCantidad_Ingresar.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCantidad_Ingresar.ForeColor = System.Drawing.Color.White
        Me.LblCantidad_Ingresar.Location = New System.Drawing.Point(318, 47)
        Me.LblCantidad_Ingresar.Name = "LblCantidad_Ingresar"
        Me.LblCantidad_Ingresar.Size = New System.Drawing.Size(163, 21)
        Me.LblCantidad_Ingresar.TabIndex = 145
        Me.LblCantidad_Ingresar.Text = "Cantidad a Ingresar:"
        '
        'LblModificarCantidadCarrito
        '
        Me.LblModificarCantidadCarrito.AutoSize = True
        Me.LblModificarCantidadCarrito.BackColor = System.Drawing.Color.Transparent
        Me.LblModificarCantidadCarrito.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblModificarCantidadCarrito.ForeColor = System.Drawing.Color.White
        Me.LblModificarCantidadCarrito.Location = New System.Drawing.Point(503, 47)
        Me.LblModificarCantidadCarrito.Name = "LblModificarCantidadCarrito"
        Me.LblModificarCantidadCarrito.Size = New System.Drawing.Size(165, 21)
        Me.LblModificarCantidadCarrito.TabIndex = 146
        Me.LblModificarCantidadCarrito.Text = "Cantidad a Cambiar:"
        '
        'TxtCantidad_A_Cambiar
        '
        Me.TxtCantidad_A_Cambiar.Font = New System.Drawing.Font("Nirmala Text", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantidad_A_Cambiar.Location = New System.Drawing.Point(507, 71)
        Me.TxtCantidad_A_Cambiar.Name = "TxtCantidad_A_Cambiar"
        Me.TxtCantidad_A_Cambiar.Size = New System.Drawing.Size(159, 28)
        Me.TxtCantidad_A_Cambiar.TabIndex = 147
        '
        'FrmPOS
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1170, 749)
        Me.Controls.Add(Me.TxtCantidad_A_Cambiar)
        Me.Controls.Add(Me.LblModificarCantidadCarrito)
        Me.Controls.Add(Me.LblCantidad_Ingresar)
        Me.Controls.Add(Me.TxtCantidad)
        Me.Controls.Add(Me.BtnAtrasPOS)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.LblProductos)
        Me.Controls.Add(Me.LblCantidad)
        Me.Controls.Add(Me.LblSubtotal)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Lbl_Venta_N)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PUNTO DE VENTAS"
        CType(Me.dgvBusquedaProductosPOS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvCarritoProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Lbl_Venta_N As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LblTotal As Label
    Friend WithEvents LblSubtotal As Label
    Friend WithEvents LblCantidad As Label
    Friend WithEvents LblProductos As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnAtrasPOS As Button
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents LblCantidad_Ingresar As Label
    Friend WithEvents LblModificarCantidadCarrito As Label
    Friend WithEvents TxtCantidad_A_Cambiar As TextBox
End Class
