<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDetalleVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDetalleVenta))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnDetalleVentaBaja = New System.Windows.Forms.Button()
        Me.btnModificaDetalleVenta = New System.Windows.Forms.Button()
        Me.btnAltaDetalleVenta = New System.Windows.Forms.Button()
        Me.BtnAtrasClientes = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Lbl_ID_Fila = New System.Windows.Forms.Label()
        Me.Lbl_ID_Producto = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Lbl_Precio_Renglon = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Lbl_ID_Venta = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Lbl_Cantidad = New System.Windows.Forms.Label()
        Me.Lbl_Precio = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.dgvDetalleVenta = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalleVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Final_Sys_Punto_Venta_Programacion_I.My.Resources.Resources.Pollo_Abasto_Tu_Almacen
        Me.PictureBox1.Location = New System.Drawing.Point(1068, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 67
        Me.PictureBox1.TabStop = False
        '
        'btnDetalleVentaBaja
        '
        Me.btnDetalleVentaBaja.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetalleVentaBaja.Location = New System.Drawing.Point(786, 554)
        Me.btnDetalleVentaBaja.Name = "btnDetalleVentaBaja"
        Me.btnDetalleVentaBaja.Size = New System.Drawing.Size(62, 30)
        Me.btnDetalleVentaBaja.TabIndex = 71
        Me.btnDetalleVentaBaja.Text = "BAJA"
        Me.btnDetalleVentaBaja.UseVisualStyleBackColor = True
        '
        'btnModificaDetalleVenta
        '
        Me.btnModificaDetalleVenta.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificaDetalleVenta.Location = New System.Drawing.Point(512, 554)
        Me.btnModificaDetalleVenta.Name = "btnModificaDetalleVenta"
        Me.btnModificaDetalleVenta.Size = New System.Drawing.Size(93, 30)
        Me.btnModificaDetalleVenta.TabIndex = 70
        Me.btnModificaDetalleVenta.Text = "MODIFICA"
        Me.btnModificaDetalleVenta.UseVisualStyleBackColor = True
        '
        'btnAltaDetalleVenta
        '
        Me.btnAltaDetalleVenta.BackColor = System.Drawing.Color.White
        Me.btnAltaDetalleVenta.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAltaDetalleVenta.Location = New System.Drawing.Point(273, 554)
        Me.btnAltaDetalleVenta.Name = "btnAltaDetalleVenta"
        Me.btnAltaDetalleVenta.Size = New System.Drawing.Size(70, 30)
        Me.btnAltaDetalleVenta.TabIndex = 69
        Me.btnAltaDetalleVenta.Text = "ALTA"
        Me.btnAltaDetalleVenta.UseVisualStyleBackColor = False
        '
        'BtnAtrasClientes
        '
        Me.BtnAtrasClientes.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAtrasClientes.Location = New System.Drawing.Point(1, 1)
        Me.BtnAtrasClientes.Name = "BtnAtrasClientes"
        Me.BtnAtrasClientes.Size = New System.Drawing.Size(82, 33)
        Me.BtnAtrasClientes.TabIndex = 86
        Me.BtnAtrasClientes.Text = "ATRAS"
        Me.BtnAtrasClientes.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(177, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 21)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "DETALLE VENTA"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = Global.Final_Sys_Punto_Venta_Programacion_I.My.Resources.Resources.DetalleVenta
        Me.PictureBox2.Location = New System.Drawing.Point(89, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(82, 79)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 87
        Me.PictureBox2.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(221, 420)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(105, 20)
        Me.TextBox2.TabIndex = 103
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(221, 386)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(105, 20)
        Me.TextBox1.TabIndex = 102
        '
        'Lbl_ID_Fila
        '
        Me.Lbl_ID_Fila.AutoSize = True
        Me.Lbl_ID_Fila.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_ID_Fila.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ID_Fila.ForeColor = System.Drawing.Color.White
        Me.Lbl_ID_Fila.Location = New System.Drawing.Point(57, 419)
        Me.Lbl_ID_Fila.Name = "Lbl_ID_Fila"
        Me.Lbl_ID_Fila.Size = New System.Drawing.Size(66, 21)
        Me.Lbl_ID_Fila.TabIndex = 101
        Me.Lbl_ID_Fila.Text = "ID_FILA"
        '
        'Lbl_ID_Producto
        '
        Me.Lbl_ID_Producto.AutoSize = True
        Me.Lbl_ID_Producto.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_ID_Producto.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ID_Producto.ForeColor = System.Drawing.Color.White
        Me.Lbl_ID_Producto.Location = New System.Drawing.Point(57, 383)
        Me.Lbl_ID_Producto.Name = "Lbl_ID_Producto"
        Me.Lbl_ID_Producto.Size = New System.Drawing.Size(120, 21)
        Me.Lbl_ID_Producto.TabIndex = 100
        Me.Lbl_ID_Producto.Text = "ID_PRODUCTO"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(221, 522)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(105, 20)
        Me.TextBox3.TabIndex = 99
        '
        'Lbl_Precio_Renglon
        '
        Me.Lbl_Precio_Renglon.AutoSize = True
        Me.Lbl_Precio_Renglon.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Precio_Renglon.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Precio_Renglon.ForeColor = System.Drawing.Color.White
        Me.Lbl_Precio_Renglon.Location = New System.Drawing.Point(57, 521)
        Me.Lbl_Precio_Renglon.Name = "Lbl_Precio_Renglon"
        Me.Lbl_Precio_Renglon.Size = New System.Drawing.Size(145, 21)
        Me.Lbl_Precio_Renglon.TabIndex = 98
        Me.Lbl_Precio_Renglon.Text = "PRECIO RENGLON"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(841, 453)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(246, 28)
        Me.Button1.TabIndex = 97
        Me.Button1.Text = "Generar Credencial Detalle Venta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(873, 409)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(186, 31)
        Me.Button2.TabIndex = 96
        Me.Button2.Text = "Gestionar DetalleVenta"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(221, 348)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(105, 20)
        Me.TextBox4.TabIndex = 95
        '
        'Lbl_ID_Venta
        '
        Me.Lbl_ID_Venta.AutoSize = True
        Me.Lbl_ID_Venta.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_ID_Venta.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ID_Venta.ForeColor = System.Drawing.Color.White
        Me.Lbl_ID_Venta.Location = New System.Drawing.Point(57, 348)
        Me.Lbl_ID_Venta.Name = "Lbl_ID_Venta"
        Me.Lbl_ID_Venta.Size = New System.Drawing.Size(86, 21)
        Me.Lbl_ID_Venta.TabIndex = 94
        Me.Lbl_ID_Venta.Text = "ID_VENTA"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.Yellow
        Me.TextBox5.Location = New System.Drawing.Point(221, 485)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(105, 20)
        Me.TextBox5.TabIndex = 93
        '
        'Lbl_Cantidad
        '
        Me.Lbl_Cantidad.AutoSize = True
        Me.Lbl_Cantidad.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Cantidad.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Cantidad.ForeColor = System.Drawing.Color.White
        Me.Lbl_Cantidad.Location = New System.Drawing.Point(57, 490)
        Me.Lbl_Cantidad.Name = "Lbl_Cantidad"
        Me.Lbl_Cantidad.Size = New System.Drawing.Size(93, 21)
        Me.Lbl_Cantidad.TabIndex = 92
        Me.Lbl_Cantidad.Text = "CANTIDAD"
        '
        'Lbl_Precio
        '
        Me.Lbl_Precio.AutoSize = True
        Me.Lbl_Precio.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Precio.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Precio.ForeColor = System.Drawing.Color.White
        Me.Lbl_Precio.Location = New System.Drawing.Point(57, 453)
        Me.Lbl_Precio.Name = "Lbl_Precio"
        Me.Lbl_Precio.Size = New System.Drawing.Size(70, 21)
        Me.Lbl_Precio.TabIndex = 91
        Me.Lbl_Precio.Text = "PRECIO "
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(221, 453)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(105, 20)
        Me.TextBox6.TabIndex = 90
        '
        'dgvDetalleVenta
        '
        Me.dgvDetalleVenta.AllowUserToAddRows = False
        Me.dgvDetalleVenta.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleVenta.GridColor = System.Drawing.Color.RoyalBlue
        Me.dgvDetalleVenta.Location = New System.Drawing.Point(28, 86)
        Me.dgvDetalleVenta.Name = "dgvDetalleVenta"
        Me.dgvDetalleVenta.ReadOnly = True
        Me.dgvDetalleVenta.RowHeadersVisible = False
        Me.dgvDetalleVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalleVenta.Size = New System.Drawing.Size(1080, 242)
        Me.dgvDetalleVenta.TabIndex = 89
        '
        'FrmDetalleVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(1140, 596)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Lbl_ID_Fila)
        Me.Controls.Add(Me.Lbl_ID_Producto)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Lbl_Precio_Renglon)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Lbl_ID_Venta)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Lbl_Cantidad)
        Me.Controls.Add(Me.Lbl_Precio)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.dgvDetalleVenta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BtnAtrasClientes)
        Me.Controls.Add(Me.btnDetalleVentaBaja)
        Me.Controls.Add(Me.btnModificaDetalleVenta)
        Me.Controls.Add(Me.btnAltaDetalleVenta)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmDetalleVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DETALLE VENTA "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalleVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDetalleVentaBaja As Button
    Friend WithEvents btnModificaDetalleVenta As Button
    Friend WithEvents btnAltaDetalleVenta As Button
    Friend WithEvents BtnAtrasClientes As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Lbl_ID_Fila As Label
    Friend WithEvents Lbl_ID_Producto As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Lbl_Precio_Renglon As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Lbl_ID_Venta As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Lbl_Cantidad As Label
    Friend WithEvents Lbl_Precio As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents dgvDetalleVenta As DataGridView
End Class
