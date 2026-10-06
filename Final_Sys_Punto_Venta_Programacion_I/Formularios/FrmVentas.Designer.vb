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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVentas))
        Me.dgvVenta1 = New System.Windows.Forms.DataGridView()
        Me.DgvVenta2 = New System.Windows.Forms.DataGridView()
        Me.LblDolar = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvVenta1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvVenta2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvVenta1
        '
        Me.dgvVenta1.AllowUserToAddRows = False
        Me.dgvVenta1.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.dgvVenta1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVenta1.GridColor = System.Drawing.Color.RoyalBlue
        Me.dgvVenta1.Location = New System.Drawing.Point(23, 28)
        Me.dgvVenta1.Name = "dgvVenta1"
        Me.dgvVenta1.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Nirmala Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Chartreuse
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVenta1.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvVenta1.RowHeadersVisible = False
        Me.dgvVenta1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVenta1.Size = New System.Drawing.Size(713, 242)
        Me.dgvVenta1.TabIndex = 44
        '
        'DgvVenta2
        '
        Me.DgvVenta2.AllowUserToAddRows = False
        Me.DgvVenta2.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.DgvVenta2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvVenta2.GridColor = System.Drawing.Color.RoyalBlue
        Me.DgvVenta2.Location = New System.Drawing.Point(23, 309)
        Me.DgvVenta2.Name = "DgvVenta2"
        Me.DgvVenta2.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Nirmala Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Chartreuse
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvVenta2.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvVenta2.RowHeadersVisible = False
        Me.DgvVenta2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvVenta2.Size = New System.Drawing.Size(713, 242)
        Me.DgvVenta2.TabIndex = 45
        '
        'LblDolar
        '
        Me.LblDolar.AutoSize = True
        Me.LblDolar.Font = New System.Drawing.Font("Nirmala Text", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDolar.ForeColor = System.Drawing.Color.White
        Me.LblDolar.Location = New System.Drawing.Point(777, 91)
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
        Me.Label1.Location = New System.Drawing.Point(970, 309)
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
        Me.Label2.Location = New System.Drawing.Point(742, 309)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(246, 86)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "TOTAL:"
        '
        'FrmVentas
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1171, 552)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblDolar)
        Me.Controls.Add(Me.DgvVenta2)
        Me.Controls.Add(Me.dgvVenta1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmVentas"
        Me.Text = "VENTAS"
        CType(Me.dgvVenta1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvVenta2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvVenta1 As DataGridView
    Friend WithEvents DgvVenta2 As DataGridView
    Friend WithEvents LblDolar As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
