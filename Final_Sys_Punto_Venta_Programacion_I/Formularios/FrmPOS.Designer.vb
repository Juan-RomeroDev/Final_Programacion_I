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
        Me.dgvCargarProductosPOS = New System.Windows.Forms.DataGridView()
        Me.DgvCarritoProductos = New System.Windows.Forms.DataGridView()
        Me.LblDolar = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnGestionarProducto = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvCargarProductosPOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvCarritoProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCargarProductosPOS
        '
        Me.dgvCargarProductosPOS.AllowUserToAddRows = False
        Me.dgvCargarProductosPOS.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.dgvCargarProductosPOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCargarProductosPOS.GridColor = System.Drawing.Color.RoyalBlue
        Me.dgvCargarProductosPOS.Location = New System.Drawing.Point(25, 62)
        Me.dgvCargarProductosPOS.Name = "dgvCargarProductosPOS"
        Me.dgvCargarProductosPOS.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Nirmala Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Chartreuse
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCargarProductosPOS.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCargarProductosPOS.RowHeadersVisible = False
        Me.dgvCargarProductosPOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCargarProductosPOS.Size = New System.Drawing.Size(646, 225)
        Me.dgvCargarProductosPOS.TabIndex = 44
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
        Me.Label1.Location = New System.Drawing.Point(937, 436)
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
        Me.Label2.Location = New System.Drawing.Point(695, 436)
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
        Me.Label4.Location = New System.Drawing.Point(695, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(366, 86)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "SUBTOTAL:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Nirmala Text", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(954, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 86)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "$"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Nirmala Text", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(1050, 201)
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
        'BtnGestionarProducto
        '
        Me.BtnGestionarProducto.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGestionarProducto.Location = New System.Drawing.Point(825, 329)
        Me.BtnGestionarProducto.Name = "BtnGestionarProducto"
        Me.BtnGestionarProducto.Size = New System.Drawing.Size(186, 31)
        Me.BtnGestionarProducto.TabIndex = 117
        Me.BtnGestionarProducto.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(825, 383)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(186, 31)
        Me.Button1.TabIndex = 118
        Me.Button1.Text = "Gestionar Productos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmPOS
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1187, 557)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnGestionarProducto)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblDolar)
        Me.Controls.Add(Me.DgvCarritoProductos)
        Me.Controls.Add(Me.dgvCargarProductosPOS)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPOS"
        Me.Text = "VENTAS"
        CType(Me.dgvCargarProductosPOS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvCarritoProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvCargarProductosPOS As DataGridView
    Friend WithEvents DgvCarritoProductos As DataGridView
    Friend WithEvents LblDolar As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnGestionarProducto As Button
    Friend WithEvents Button1 As Button
End Class
