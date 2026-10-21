<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProductos))
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Lbl_Precio = New System.Windows.Forms.Label()
        Me.Lbl_Descripcion = New System.Windows.Forms.Label()
        Me.BtnGestionarProducto = New System.Windows.Forms.Button()
        Me.TxtID_Producto = New System.Windows.Forms.TextBox()
        Me.Lbl_ID_Producto = New System.Windows.Forms.Label()
        Me.TxtID_Rubro = New System.Windows.Forms.TextBox()
        Me.Lbl_id_rubro = New System.Windows.Forms.Label()
        Me.Lbl_Stock = New System.Windows.Forms.Label()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.btnBajaProducto = New System.Windows.Forms.Button()
        Me.btnModificaProducto = New System.Windows.Forms.Button()
        Me.btnAltaProducto = New System.Windows.Forms.Button()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.LblBuscarProducto = New System.Windows.Forms.Label()
        Me.TxtBuscarProducto = New System.Windows.Forms.TextBox()
        Me.PictureBoxProductos = New System.Windows.Forms.PictureBox()
        Me.TxtBuscarRubroPorProducto = New System.Windows.Forms.TextBox()
        Me.LblBuscarRubroPorProducto = New System.Windows.Forms.Label()
        Me.BtnAtrasProductos = New System.Windows.Forms.Button()
        Me.LblRubroFiltrado = New System.Windows.Forms.Label()
        Me.BtnBuscarRubro = New System.Windows.Forms.Button()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(263, 412)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(105, 20)
        Me.TxtPrecio.TabIndex = 120
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(263, 378)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(105, 20)
        Me.TxtDescripcion.TabIndex = 119
        '
        'Lbl_Precio
        '
        Me.Lbl_Precio.AutoSize = True
        Me.Lbl_Precio.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Precio.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Precio.ForeColor = System.Drawing.Color.White
        Me.Lbl_Precio.Location = New System.Drawing.Point(99, 411)
        Me.Lbl_Precio.Name = "Lbl_Precio"
        Me.Lbl_Precio.Size = New System.Drawing.Size(66, 21)
        Me.Lbl_Precio.TabIndex = 118
        Me.Lbl_Precio.Text = "PRECIO"
        '
        'Lbl_Descripcion
        '
        Me.Lbl_Descripcion.AutoSize = True
        Me.Lbl_Descripcion.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Descripcion.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Descripcion.ForeColor = System.Drawing.Color.White
        Me.Lbl_Descripcion.Location = New System.Drawing.Point(99, 375)
        Me.Lbl_Descripcion.Name = "Lbl_Descripcion"
        Me.Lbl_Descripcion.Size = New System.Drawing.Size(115, 21)
        Me.Lbl_Descripcion.TabIndex = 117
        Me.Lbl_Descripcion.Text = "DESCRIPCION"
        '
        'BtnGestionarProducto
        '
        Me.BtnGestionarProducto.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGestionarProducto.Location = New System.Drawing.Point(909, 405)
        Me.BtnGestionarProducto.Name = "BtnGestionarProducto"
        Me.BtnGestionarProducto.Size = New System.Drawing.Size(186, 31)
        Me.BtnGestionarProducto.TabIndex = 113
        Me.BtnGestionarProducto.Text = "Gestionar Productos"
        Me.BtnGestionarProducto.UseVisualStyleBackColor = True
        '
        'TxtID_Producto
        '
        Me.TxtID_Producto.Location = New System.Drawing.Point(263, 340)
        Me.TxtID_Producto.Name = "TxtID_Producto"
        Me.TxtID_Producto.Size = New System.Drawing.Size(105, 20)
        Me.TxtID_Producto.TabIndex = 112
        '
        'Lbl_ID_Producto
        '
        Me.Lbl_ID_Producto.AutoSize = True
        Me.Lbl_ID_Producto.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_ID_Producto.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ID_Producto.ForeColor = System.Drawing.Color.White
        Me.Lbl_ID_Producto.Location = New System.Drawing.Point(99, 340)
        Me.Lbl_ID_Producto.Name = "Lbl_ID_Producto"
        Me.Lbl_ID_Producto.Size = New System.Drawing.Size(120, 21)
        Me.Lbl_ID_Producto.TabIndex = 111
        Me.Lbl_ID_Producto.Text = "ID_PRODUCTO"
        '
        'TxtID_Rubro
        '
        Me.TxtID_Rubro.BackColor = System.Drawing.Color.Yellow
        Me.TxtID_Rubro.Location = New System.Drawing.Point(263, 477)
        Me.TxtID_Rubro.Name = "TxtID_Rubro"
        Me.TxtID_Rubro.Size = New System.Drawing.Size(105, 20)
        Me.TxtID_Rubro.TabIndex = 110
        '
        'Lbl_id_rubro
        '
        Me.Lbl_id_rubro.AutoSize = True
        Me.Lbl_id_rubro.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_id_rubro.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_id_rubro.ForeColor = System.Drawing.Color.White
        Me.Lbl_id_rubro.Location = New System.Drawing.Point(99, 482)
        Me.Lbl_id_rubro.Name = "Lbl_id_rubro"
        Me.Lbl_id_rubro.Size = New System.Drawing.Size(88, 21)
        Me.Lbl_id_rubro.TabIndex = 109
        Me.Lbl_id_rubro.Text = "ID_RUBRO"
        '
        'Lbl_Stock
        '
        Me.Lbl_Stock.AutoSize = True
        Me.Lbl_Stock.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Stock.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Stock.ForeColor = System.Drawing.Color.White
        Me.Lbl_Stock.Location = New System.Drawing.Point(99, 445)
        Me.Lbl_Stock.Name = "Lbl_Stock"
        Me.Lbl_Stock.Size = New System.Drawing.Size(59, 21)
        Me.Lbl_Stock.TabIndex = 108
        Me.Lbl_Stock.Text = "STOCK"
        '
        'TxtStock
        '
        Me.TxtStock.Location = New System.Drawing.Point(263, 445)
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.Size = New System.Drawing.Size(105, 20)
        Me.TxtStock.TabIndex = 107
        '
        'btnBajaProducto
        '
        Me.btnBajaProducto.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBajaProducto.Location = New System.Drawing.Point(841, 511)
        Me.btnBajaProducto.Name = "btnBajaProducto"
        Me.btnBajaProducto.Size = New System.Drawing.Size(62, 30)
        Me.btnBajaProducto.TabIndex = 106
        Me.btnBajaProducto.Text = "BAJA"
        Me.btnBajaProducto.UseVisualStyleBackColor = True
        '
        'btnModificaProducto
        '
        Me.btnModificaProducto.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificaProducto.Location = New System.Drawing.Point(567, 511)
        Me.btnModificaProducto.Name = "btnModificaProducto"
        Me.btnModificaProducto.Size = New System.Drawing.Size(93, 30)
        Me.btnModificaProducto.TabIndex = 105
        Me.btnModificaProducto.Text = "MODIFICA"
        Me.btnModificaProducto.UseVisualStyleBackColor = True
        '
        'btnAltaProducto
        '
        Me.btnAltaProducto.BackColor = System.Drawing.Color.White
        Me.btnAltaProducto.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAltaProducto.Location = New System.Drawing.Point(328, 511)
        Me.btnAltaProducto.Name = "btnAltaProducto"
        Me.btnAltaProducto.Size = New System.Drawing.Size(70, 30)
        Me.btnAltaProducto.TabIndex = 104
        Me.btnAltaProducto.Text = "ALTA"
        Me.btnAltaProducto.UseVisualStyleBackColor = False
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.GridColor = System.Drawing.Color.RoyalBlue
        Me.dgvProductos.Location = New System.Drawing.Point(217, 82)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Nirmala Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Chartreuse
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductos.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProductos.RowHeadersVisible = False
        Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductos.Size = New System.Drawing.Size(786, 242)
        Me.dgvProductos.TabIndex = 121
        '
        'LblBuscarProducto
        '
        Me.LblBuscarProducto.AutoSize = True
        Me.LblBuscarProducto.BackColor = System.Drawing.Color.Transparent
        Me.LblBuscarProducto.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscarProducto.ForeColor = System.Drawing.Color.White
        Me.LblBuscarProducto.Location = New System.Drawing.Point(375, 23)
        Me.LblBuscarProducto.Name = "LblBuscarProducto"
        Me.LblBuscarProducto.Size = New System.Drawing.Size(134, 21)
        Me.LblBuscarProducto.TabIndex = 122
        Me.LblBuscarProducto.Text = "Buscar Producto"
        '
        'TxtBuscarProducto
        '
        Me.TxtBuscarProducto.Location = New System.Drawing.Point(510, 23)
        Me.TxtBuscarProducto.Name = "TxtBuscarProducto"
        Me.TxtBuscarProducto.Size = New System.Drawing.Size(105, 20)
        Me.TxtBuscarProducto.TabIndex = 123
        '
        'PictureBoxProductos
        '
        Me.PictureBoxProductos.BackgroundImage = Global.Final_Sys_Punto_Venta_Programacion_I.My.Resources.Resources.Productos
        Me.PictureBoxProductos.Location = New System.Drawing.Point(143, 6)
        Me.PictureBoxProductos.Name = "PictureBoxProductos"
        Me.PictureBoxProductos.Size = New System.Drawing.Size(147, 70)
        Me.PictureBoxProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxProductos.TabIndex = 124
        Me.PictureBoxProductos.TabStop = False
        '
        'TxtBuscarRubroPorProducto
        '
        Me.TxtBuscarRubroPorProducto.Location = New System.Drawing.Point(510, 51)
        Me.TxtBuscarRubroPorProducto.Name = "TxtBuscarRubroPorProducto"
        Me.TxtBuscarRubroPorProducto.Size = New System.Drawing.Size(105, 20)
        Me.TxtBuscarRubroPorProducto.TabIndex = 125
        '
        'LblBuscarRubroPorProducto
        '
        Me.LblBuscarRubroPorProducto.AutoSize = True
        Me.LblBuscarRubroPorProducto.BackColor = System.Drawing.Color.Transparent
        Me.LblBuscarRubroPorProducto.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscarRubroPorProducto.ForeColor = System.Drawing.Color.White
        Me.LblBuscarRubroPorProducto.Location = New System.Drawing.Point(296, 50)
        Me.LblBuscarRubroPorProducto.Name = "LblBuscarRubroPorProducto"
        Me.LblBuscarRubroPorProducto.Size = New System.Drawing.Size(213, 21)
        Me.LblBuscarRubroPorProducto.TabIndex = 126
        Me.LblBuscarRubroPorProducto.Text = "Buscar Rubro Por Producto"
        '
        'BtnAtrasProductos
        '
        Me.BtnAtrasProductos.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAtrasProductos.Location = New System.Drawing.Point(-1, -4)
        Me.BtnAtrasProductos.Name = "BtnAtrasProductos"
        Me.BtnAtrasProductos.Size = New System.Drawing.Size(82, 33)
        Me.BtnAtrasProductos.TabIndex = 128
        Me.BtnAtrasProductos.Text = "ATRAS"
        Me.BtnAtrasProductos.UseVisualStyleBackColor = True
        '
        'LblRubroFiltrado
        '
        Me.LblRubroFiltrado.AutoSize = True
        Me.LblRubroFiltrado.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.LblRubroFiltrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRubroFiltrado.Location = New System.Drawing.Point(433, 485)
        Me.LblRubroFiltrado.Name = "LblRubroFiltrado"
        Me.LblRubroFiltrado.Size = New System.Drawing.Size(15, 13)
        Me.LblRubroFiltrado.TabIndex = 130
        Me.LblRubroFiltrado.Text = "--"
        '
        'BtnBuscarRubro
        '
        Me.BtnBuscarRubro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarRubro.Location = New System.Drawing.Point(379, 475)
        Me.BtnBuscarRubro.Name = "BtnBuscarRubro"
        Me.BtnBuscarRubro.Size = New System.Drawing.Size(48, 23)
        Me.BtnBuscarRubro.TabIndex = 129
        Me.BtnBuscarRubro.Text = "..."
        Me.BtnBuscarRubro.UseVisualStyleBackColor = True
        '
        'FrmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(1147, 553)
        Me.Controls.Add(Me.LblRubroFiltrado)
        Me.Controls.Add(Me.BtnBuscarRubro)
        Me.Controls.Add(Me.BtnAtrasProductos)
        Me.Controls.Add(Me.LblBuscarRubroPorProducto)
        Me.Controls.Add(Me.TxtBuscarRubroPorProducto)
        Me.Controls.Add(Me.PictureBoxProductos)
        Me.Controls.Add(Me.TxtBuscarProducto)
        Me.Controls.Add(Me.LblBuscarProducto)
        Me.Controls.Add(Me.dgvProductos)
        Me.Controls.Add(Me.TxtPrecio)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.Lbl_Precio)
        Me.Controls.Add(Me.Lbl_Descripcion)
        Me.Controls.Add(Me.BtnGestionarProducto)
        Me.Controls.Add(Me.TxtID_Producto)
        Me.Controls.Add(Me.Lbl_ID_Producto)
        Me.Controls.Add(Me.TxtID_Rubro)
        Me.Controls.Add(Me.Lbl_id_rubro)
        Me.Controls.Add(Me.Lbl_Stock)
        Me.Controls.Add(Me.TxtStock)
        Me.Controls.Add(Me.btnBajaProducto)
        Me.Controls.Add(Me.btnModificaProducto)
        Me.Controls.Add(Me.btnAltaProducto)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmProductos"
        Me.Text = "PRODUCTOS"
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents Lbl_Precio As Label
    Friend WithEvents Lbl_Descripcion As Label
    Friend WithEvents BtnGestionarProducto As Button
    Friend WithEvents TxtID_Producto As TextBox
    Friend WithEvents Lbl_ID_Producto As Label
    Friend WithEvents TxtID_Rubro As TextBox
    Friend WithEvents Lbl_id_rubro As Label
    Friend WithEvents Lbl_Stock As Label
    Friend WithEvents TxtStock As TextBox
    Friend WithEvents btnBajaProducto As Button
    Friend WithEvents btnModificaProducto As Button
    Friend WithEvents btnAltaProducto As Button
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents LblBuscarProducto As Label
    Friend WithEvents TxtBuscarProducto As TextBox
    Friend WithEvents PictureBoxProductos As PictureBox
    Friend WithEvents TxtBuscarRubroPorProducto As TextBox
    Friend WithEvents LblBuscarRubroPorProducto As Label
    Friend WithEvents BtnAtrasProductos As Button
    Friend WithEvents LblRubroFiltrado As Label
    Friend WithEvents BtnBuscarRubro As Button
End Class
