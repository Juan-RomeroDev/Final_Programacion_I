<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRubros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRubros))
        Me.TxtIDRubro = New System.Windows.Forms.TextBox()
        Me.lblIDRubro = New System.Windows.Forms.Label()
        Me.lblDescrip_rubro = New System.Windows.Forms.Label()
        Me.TxtDescripcionRubro = New System.Windows.Forms.TextBox()
        Me.btnBajaRubro = New System.Windows.Forms.Button()
        Me.btnModificaRubro = New System.Windows.Forms.Button()
        Me.btnAltaRubro = New System.Windows.Forms.Button()
        Me.dgvRubros = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnAtrasRubros = New System.Windows.Forms.Button()
        Me.BtnGestionarRubros = New System.Windows.Forms.Button()
        Me.TxtBuscarRubro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvRubros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtIDRubro
        '
        Me.TxtIDRubro.Location = New System.Drawing.Point(275, 342)
        Me.TxtIDRubro.Name = "TxtIDRubro"
        Me.TxtIDRubro.Size = New System.Drawing.Size(105, 20)
        Me.TxtIDRubro.TabIndex = 79
        '
        'lblIDRubro
        '
        Me.lblIDRubro.AutoSize = True
        Me.lblIDRubro.BackColor = System.Drawing.Color.Transparent
        Me.lblIDRubro.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDRubro.ForeColor = System.Drawing.Color.White
        Me.lblIDRubro.Location = New System.Drawing.Point(81, 341)
        Me.lblIDRubro.Name = "lblIDRubro"
        Me.lblIDRubro.Size = New System.Drawing.Size(88, 21)
        Me.lblIDRubro.TabIndex = 78
        Me.lblIDRubro.Text = "ID_RUBRO"
        '
        'lblDescrip_rubro
        '
        Me.lblDescrip_rubro.AutoSize = True
        Me.lblDescrip_rubro.BackColor = System.Drawing.Color.Transparent
        Me.lblDescrip_rubro.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrip_rubro.ForeColor = System.Drawing.Color.White
        Me.lblDescrip_rubro.Location = New System.Drawing.Point(82, 371)
        Me.lblDescrip_rubro.Name = "lblDescrip_rubro"
        Me.lblDescrip_rubro.Size = New System.Drawing.Size(173, 21)
        Me.lblDescrip_rubro.TabIndex = 72
        Me.lblDescrip_rubro.Text = "DESCRIPCION RUBRO"
        '
        'TxtDescripcionRubro
        '
        Me.TxtDescripcionRubro.Location = New System.Drawing.Point(275, 371)
        Me.TxtDescripcionRubro.Name = "TxtDescripcionRubro"
        Me.TxtDescripcionRubro.Size = New System.Drawing.Size(172, 20)
        Me.TxtDescripcionRubro.TabIndex = 70
        '
        'btnBajaRubro
        '
        Me.btnBajaRubro.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBajaRubro.Location = New System.Drawing.Point(623, 460)
        Me.btnBajaRubro.Name = "btnBajaRubro"
        Me.btnBajaRubro.Size = New System.Drawing.Size(62, 30)
        Me.btnBajaRubro.TabIndex = 69
        Me.btnBajaRubro.Text = "BAJA"
        Me.btnBajaRubro.UseVisualStyleBackColor = True
        '
        'btnModificaRubro
        '
        Me.btnModificaRubro.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificaRubro.Location = New System.Drawing.Point(349, 460)
        Me.btnModificaRubro.Name = "btnModificaRubro"
        Me.btnModificaRubro.Size = New System.Drawing.Size(93, 30)
        Me.btnModificaRubro.TabIndex = 68
        Me.btnModificaRubro.Text = "MODIFICA"
        Me.btnModificaRubro.UseVisualStyleBackColor = True
        '
        'btnAltaRubro
        '
        Me.btnAltaRubro.BackColor = System.Drawing.Color.White
        Me.btnAltaRubro.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAltaRubro.ForeColor = System.Drawing.Color.Black
        Me.btnAltaRubro.Location = New System.Drawing.Point(110, 460)
        Me.btnAltaRubro.Name = "btnAltaRubro"
        Me.btnAltaRubro.Size = New System.Drawing.Size(70, 30)
        Me.btnAltaRubro.TabIndex = 67
        Me.btnAltaRubro.Text = "ALTA"
        Me.btnAltaRubro.UseVisualStyleBackColor = False
        '
        'dgvRubros
        '
        Me.dgvRubros.AllowUserToAddRows = False
        Me.dgvRubros.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.dgvRubros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRubros.Location = New System.Drawing.Point(83, 84)
        Me.dgvRubros.Name = "dgvRubros"
        Me.dgvRubros.ReadOnly = True
        Me.dgvRubros.RowHeadersVisible = False
        Me.dgvRubros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRubros.Size = New System.Drawing.Size(651, 242)
        Me.dgvRubros.TabIndex = 66
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Final_Sys_Punto_Venta_Programacion_I.My.Resources.Resources.Pollo_Abasto_Tu_Almacen
        Me.PictureBox1.Location = New System.Drawing.Point(723, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 80
        Me.PictureBox1.TabStop = False
        '
        'BtnAtrasRubros
        '
        Me.BtnAtrasRubros.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAtrasRubros.Location = New System.Drawing.Point(1, -1)
        Me.BtnAtrasRubros.Name = "BtnAtrasRubros"
        Me.BtnAtrasRubros.Size = New System.Drawing.Size(87, 30)
        Me.BtnAtrasRubros.TabIndex = 81
        Me.BtnAtrasRubros.Text = "ATRAS"
        Me.BtnAtrasRubros.UseVisualStyleBackColor = True
        '
        'BtnGestionarRubros
        '
        Me.BtnGestionarRubros.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGestionarRubros.Location = New System.Drawing.Point(577, 371)
        Me.BtnGestionarRubros.Name = "BtnGestionarRubros"
        Me.BtnGestionarRubros.Size = New System.Drawing.Size(148, 31)
        Me.BtnGestionarRubros.TabIndex = 82
        Me.BtnGestionarRubros.Text = "Gestionar Rubros"
        Me.BtnGestionarRubros.UseVisualStyleBackColor = True
        '
        'TxtBuscarRubro
        '
        Me.TxtBuscarRubro.Location = New System.Drawing.Point(254, 35)
        Me.TxtBuscarRubro.Name = "TxtBuscarRubro"
        Me.TxtBuscarRubro.Size = New System.Drawing.Size(100, 20)
        Me.TxtBuscarRubro.TabIndex = 83
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(119, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 21)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Buscar Rubro"
        '
        'FrmRubros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(823, 518)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtBuscarRubro)
        Me.Controls.Add(Me.BtnGestionarRubros)
        Me.Controls.Add(Me.BtnAtrasRubros)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TxtIDRubro)
        Me.Controls.Add(Me.lblIDRubro)
        Me.Controls.Add(Me.lblDescrip_rubro)
        Me.Controls.Add(Me.TxtDescripcionRubro)
        Me.Controls.Add(Me.btnBajaRubro)
        Me.Controls.Add(Me.btnModificaRubro)
        Me.Controls.Add(Me.btnAltaRubro)
        Me.Controls.Add(Me.dgvRubros)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmRubros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RUBROS"
        CType(Me.dgvRubros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtIDRubro As TextBox
    Friend WithEvents lblIDRubro As Label
    Friend WithEvents lblDescrip_rubro As Label
    Friend WithEvents TxtDescripcionRubro As TextBox
    Friend WithEvents btnBajaRubro As Button
    Friend WithEvents btnModificaRubro As Button
    Friend WithEvents btnAltaRubro As Button
    Friend WithEvents dgvRubros As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnAtrasRubros As Button
    Friend WithEvents BtnGestionarRubros As Button
    Friend WithEvents TxtBuscarRubro As TextBox
    Friend WithEvents Label1 As Label
End Class
