<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventas))
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePickerHasta = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lbl_ID_Venta = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DgvVentasRealizadas = New System.Windows.Forms.DataGridView()
        CType(Me.DgvVentasRealizadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(218, 43)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 114
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(12, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(200, 21)
        Me.Label8.TabIndex = 113
        Me.Label8.Text = "Buscar Venta Por Usuario"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(1039, 15)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 112
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(836, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(187, 21)
        Me.Label7.TabIndex = 111
        Me.Label7.Text = "Buscar Venta Por Rubro"
        '
        'DateTimePickerHasta
        '
        Me.DateTimePickerHasta.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerHasta.Location = New System.Drawing.Point(696, 4)
        Me.DateTimePickerHasta.Name = "DateTimePickerHasta"
        Me.DateTimePickerHasta.Size = New System.Drawing.Size(124, 35)
        Me.DateTimePickerHasta.TabIndex = 110
        Me.DateTimePickerHasta.Value = New Date(2026, 10, 20, 0, 0, 0, 0)
        '
        'DateTimePickerDesde
        '
        Me.DateTimePickerDesde.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerDesde.Location = New System.Drawing.Point(548, 4)
        Me.DateTimePickerDesde.Name = "DateTimePickerDesde"
        Me.DateTimePickerDesde.Size = New System.Drawing.Size(130, 35)
        Me.DateTimePickerDesde.TabIndex = 109
        Me.DateTimePickerDesde.Value = New Date(2026, 10, 20, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(338, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 21)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "Buscar Venta Por Fechas"
        '
        'Lbl_ID_Venta
        '
        Me.Lbl_ID_Venta.AutoSize = True
        Me.Lbl_ID_Venta.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_ID_Venta.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ID_Venta.ForeColor = System.Drawing.Color.White
        Me.Lbl_ID_Venta.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_ID_Venta.Name = "Lbl_ID_Venta"
        Me.Lbl_ID_Venta.Size = New System.Drawing.Size(200, 21)
        Me.Lbl_ID_Venta.TabIndex = 107
        Me.Lbl_ID_Venta.Text = "Buscar Venta Por Usuario"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(218, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 106
        '
        'DgvVentasRealizadas
        '
        Me.DgvVentasRealizadas.AllowUserToAddRows = False
        Me.DgvVentasRealizadas.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.DgvVentasRealizadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvVentasRealizadas.GridColor = System.Drawing.Color.RoyalBlue
        Me.DgvVentasRealizadas.Location = New System.Drawing.Point(81, 125)
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
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(1170, 450)
        Me.Controls.Add(Me.DgvVentasRealizadas)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DateTimePickerHasta)
        Me.Controls.Add(Me.DateTimePickerDesde)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Lbl_ID_Venta)
        Me.Controls.Add(Me.TextBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Ventas"
        Me.Text = "Ventas"
        CType(Me.DgvVentasRealizadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePickerHasta As DateTimePicker
    Friend WithEvents DateTimePickerDesde As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Lbl_ID_Venta As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DgvVentasRealizadas As DataGridView
End Class
