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
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Lbl_Precio = New System.Windows.Forms.Label()
        Me.Lbl_Descripcion = New System.Windows.Forms.Label()
        Me.BtnGestionarProducto = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Lbl_ID_Producto = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Lbl_id_rubro = New System.Windows.Forms.Label()
        Me.Lbl_Stock = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.btnBajaProducto = New System.Windows.Forms.Button()
        Me.btnModificaProducto = New System.Windows.Forms.Button()
        Me.btnAltaProducto = New System.Windows.Forms.Button()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBuscarProducto = New System.Windows.Forms.TextBox()
        Me.PictureBoxProductos = New System.Windows.Forms.PictureBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(260, 402)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(105, 20)
        Me.TextBox2.TabIndex = 120
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(260, 368)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(105, 20)
        Me.TextBox1.TabIndex = 119
        '
        'Lbl_Precio
        '
        Me.Lbl_Precio.AutoSize = True
        Me.Lbl_Precio.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Precio.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Precio.ForeColor = System.Drawing.Color.White
        Me.Lbl_Precio.Location = New System.Drawing.Point(96, 401)
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
        Me.Lbl_Descripcion.Location = New System.Drawing.Point(96, 365)
        Me.Lbl_Descripcion.Name = "Lbl_Descripcion"
        Me.Lbl_Descripcion.Size = New System.Drawing.Size(115, 21)
        Me.Lbl_Descripcion.TabIndex = 117
        Me.Lbl_Descripcion.Text = "DESCRIPCION"
        '
        'BtnGestionarProducto
        '
        Me.BtnGestionarProducto.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGestionarProducto.Location = New System.Drawing.Point(912, 391)
        Me.BtnGestionarProducto.Name = "BtnGestionarProducto"
        Me.BtnGestionarProducto.Size = New System.Drawing.Size(186, 31)
        Me.BtnGestionarProducto.TabIndex = 113
        Me.BtnGestionarProducto.Text = "Gestionar Productos"
        Me.BtnGestionarProducto.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(260, 330)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(105, 20)
        Me.TextBox4.TabIndex = 112
        '
        'Lbl_ID_Producto
        '
        Me.Lbl_ID_Producto.AutoSize = True
        Me.Lbl_ID_Producto.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_ID_Producto.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ID_Producto.ForeColor = System.Drawing.Color.White
        Me.Lbl_ID_Producto.Location = New System.Drawing.Point(96, 330)
        Me.Lbl_ID_Producto.Name = "Lbl_ID_Producto"
        Me.Lbl_ID_Producto.Size = New System.Drawing.Size(120, 21)
        Me.Lbl_ID_Producto.TabIndex = 111
        Me.Lbl_ID_Producto.Text = "ID_PRODUCTO"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.Yellow
        Me.TextBox5.Location = New System.Drawing.Point(260, 467)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(105, 20)
        Me.TextBox5.TabIndex = 110
        '
        'Lbl_id_rubro
        '
        Me.Lbl_id_rubro.AutoSize = True
        Me.Lbl_id_rubro.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_id_rubro.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_id_rubro.ForeColor = System.Drawing.Color.White
        Me.Lbl_id_rubro.Location = New System.Drawing.Point(96, 472)
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
        Me.Lbl_Stock.Location = New System.Drawing.Point(96, 435)
        Me.Lbl_Stock.Name = "Lbl_Stock"
        Me.Lbl_Stock.Size = New System.Drawing.Size(59, 21)
        Me.Lbl_Stock.TabIndex = 108
        Me.Lbl_Stock.Text = "STOCK"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(260, 435)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(105, 20)
        Me.TextBox6.TabIndex = 107
        '
        'btnBajaProducto
        '
        Me.btnBajaProducto.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBajaProducto.Location = New System.Drawing.Point(815, 495)
        Me.btnBajaProducto.Name = "btnBajaProducto"
        Me.btnBajaProducto.Size = New System.Drawing.Size(62, 30)
        Me.btnBajaProducto.TabIndex = 106
        Me.btnBajaProducto.Text = "BAJA"
        Me.btnBajaProducto.UseVisualStyleBackColor = True
        '
        'btnModificaProducto
        '
        Me.btnModificaProducto.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificaProducto.Location = New System.Drawing.Point(541, 495)
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
        Me.btnAltaProducto.Location = New System.Drawing.Point(302, 495)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(269, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 21)
        Me.Label1.TabIndex = 122
        Me.Label1.Text = "BuscarProducto"
        '
        'TxtBuscarProducto
        '
        Me.TxtBuscarProducto.Location = New System.Drawing.Point(415, 28)
        Me.TxtBuscarProducto.Name = "TxtBuscarProducto"
        Me.TxtBuscarProducto.Size = New System.Drawing.Size(105, 20)
        Me.TxtBuscarProducto.TabIndex = 123
        '
        'PictureBoxProductos
        '
        Me.PictureBoxProductos.BackgroundImage = Global.Final_Sys_Punto_Venta_Programacion_I.My.Resources.Resources.Productos
        Me.PictureBoxProductos.Location = New System.Drawing.Point(48, 12)
        Me.PictureBoxProductos.Name = "PictureBoxProductos"
        Me.PictureBoxProductos.Size = New System.Drawing.Size(147, 70)
        Me.PictureBoxProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxProductos.TabIndex = 124
        Me.PictureBoxProductos.TabStop = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(415, 56)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(105, 20)
        Me.TextBox3.TabIndex = 125
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(201, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 21)
        Me.Label2.TabIndex = 126
        Me.Label2.Text = "Buscar Rubro Por Producto"
        '
        'FrmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(1147, 528)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.PictureBoxProductos)
        Me.Controls.Add(Me.TxtBuscarProducto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvProductos)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Lbl_Precio)
        Me.Controls.Add(Me.Lbl_Descripcion)
        Me.Controls.Add(Me.BtnGestionarProducto)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Lbl_ID_Producto)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Lbl_id_rubro)
        Me.Controls.Add(Me.Lbl_Stock)
        Me.Controls.Add(Me.TextBox6)
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

    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Lbl_Precio As Label
    Friend WithEvents Lbl_Descripcion As Label
    Friend WithEvents BtnGestionarProducto As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Lbl_ID_Producto As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Lbl_id_rubro As Label
    Friend WithEvents Lbl_Stock As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents btnBajaProducto As Button
    Friend WithEvents btnModificaProducto As Button
    Friend WithEvents btnAltaProducto As Button
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBuscarProducto As TextBox
    Friend WithEvents PictureBoxProductos As PictureBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
End Class
