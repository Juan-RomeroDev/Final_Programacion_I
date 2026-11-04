<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLocalidades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLocalidades))
        Me.BtnGestionarLocalidades = New System.Windows.Forms.Button()
        Me.BtnAtrasLocalidades = New System.Windows.Forms.Button()
        Me.lblBuscarXLocalidad = New System.Windows.Forms.Label()
        Me.lblBuscarXCp = New System.Windows.Forms.Label()
        Me.TxtFiltrarLocalidad = New System.Windows.Forms.TextBox()
        Me.TxtFiltrarCp = New System.Windows.Forms.TextBox()
        Me.btnBajaLocalidad = New System.Windows.Forms.Button()
        Me.btnModificaLocalidad = New System.Windows.Forms.Button()
        Me.dgvLocalidades = New System.Windows.Forms.DataGridView()
        Me.btnAltaLocalidad = New System.Windows.Forms.Button()
        Me.LblLocalidad = New System.Windows.Forms.Label()
        Me.lblCp = New System.Windows.Forms.Label()
        Me.TxtLocalidad = New System.Windows.Forms.TextBox()
        Me.TxtCp = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblLocalidades = New System.Windows.Forms.Label()
        CType(Me.dgvLocalidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnGestionarLocalidades
        '
        Me.BtnGestionarLocalidades.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGestionarLocalidades.Location = New System.Drawing.Point(390, 299)
        Me.BtnGestionarLocalidades.Name = "BtnGestionarLocalidades"
        Me.BtnGestionarLocalidades.Size = New System.Drawing.Size(206, 28)
        Me.BtnGestionarLocalidades.TabIndex = 27
        Me.BtnGestionarLocalidades.Text = "Gestionar Localidades"
        Me.BtnGestionarLocalidades.UseVisualStyleBackColor = True
        '
        'BtnAtrasLocalidades
        '
        Me.BtnAtrasLocalidades.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAtrasLocalidades.Location = New System.Drawing.Point(-1, 0)
        Me.BtnAtrasLocalidades.Name = "BtnAtrasLocalidades"
        Me.BtnAtrasLocalidades.Size = New System.Drawing.Size(73, 30)
        Me.BtnAtrasLocalidades.TabIndex = 26
        Me.BtnAtrasLocalidades.Text = "ATRAS"
        Me.BtnAtrasLocalidades.UseVisualStyleBackColor = True
        '
        'lblBuscarXLocalidad
        '
        Me.lblBuscarXLocalidad.AutoSize = True
        Me.lblBuscarXLocalidad.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarXLocalidad.ForeColor = System.Drawing.Color.White
        Me.lblBuscarXLocalidad.Location = New System.Drawing.Point(256, 63)
        Me.lblBuscarXLocalidad.Name = "lblBuscarXLocalidad"
        Me.lblBuscarXLocalidad.Size = New System.Drawing.Size(167, 21)
        Me.lblBuscarXLocalidad.TabIndex = 25
        Me.lblBuscarXLocalidad.Text = "Buscar Por Localidad"
        '
        'lblBuscarXCp
        '
        Me.lblBuscarXCp.AutoSize = True
        Me.lblBuscarXCp.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarXCp.ForeColor = System.Drawing.Color.White
        Me.lblBuscarXCp.Location = New System.Drawing.Point(54, 63)
        Me.lblBuscarXCp.Name = "lblBuscarXCp"
        Me.lblBuscarXCp.Size = New System.Drawing.Size(113, 21)
        Me.lblBuscarXCp.TabIndex = 24
        Me.lblBuscarXCp.Text = "Buscar Por Cp"
        '
        'TxtFiltrarLocalidad
        '
        Me.TxtFiltrarLocalidad.Location = New System.Drawing.Point(260, 87)
        Me.TxtFiltrarLocalidad.Name = "TxtFiltrarLocalidad"
        Me.TxtFiltrarLocalidad.Size = New System.Drawing.Size(161, 20)
        Me.TxtFiltrarLocalidad.TabIndex = 23
        '
        'TxtFiltrarCp
        '
        Me.TxtFiltrarCp.Location = New System.Drawing.Point(58, 87)
        Me.TxtFiltrarCp.Name = "TxtFiltrarCp"
        Me.TxtFiltrarCp.Size = New System.Drawing.Size(135, 20)
        Me.TxtFiltrarCp.TabIndex = 22
        '
        'btnBajaLocalidad
        '
        Me.btnBajaLocalidad.Enabled = False
        Me.btnBajaLocalidad.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBajaLocalidad.Location = New System.Drawing.Point(529, 390)
        Me.btnBajaLocalidad.Name = "btnBajaLocalidad"
        Me.btnBajaLocalidad.Size = New System.Drawing.Size(67, 30)
        Me.btnBajaLocalidad.TabIndex = 21
        Me.btnBajaLocalidad.Text = "BAJA"
        Me.btnBajaLocalidad.UseVisualStyleBackColor = True
        '
        'btnModificaLocalidad
        '
        Me.btnModificaLocalidad.Enabled = False
        Me.btnModificaLocalidad.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificaLocalidad.Location = New System.Drawing.Point(293, 390)
        Me.btnModificaLocalidad.Name = "btnModificaLocalidad"
        Me.btnModificaLocalidad.Size = New System.Drawing.Size(97, 30)
        Me.btnModificaLocalidad.TabIndex = 20
        Me.btnModificaLocalidad.Text = "MODIFICA"
        Me.btnModificaLocalidad.UseVisualStyleBackColor = True
        '
        'dgvLocalidades
        '
        Me.dgvLocalidades.AllowUserToAddRows = False
        Me.dgvLocalidades.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.dgvLocalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLocalidades.Location = New System.Drawing.Point(58, 117)
        Me.dgvLocalidades.Name = "dgvLocalidades"
        Me.dgvLocalidades.ReadOnly = True
        Me.dgvLocalidades.RowHeadersVisible = False
        Me.dgvLocalidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLocalidades.Size = New System.Drawing.Size(524, 150)
        Me.dgvLocalidades.TabIndex = 19
        '
        'btnAltaLocalidad
        '
        Me.btnAltaLocalidad.Enabled = False
        Me.btnAltaLocalidad.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAltaLocalidad.Location = New System.Drawing.Point(48, 390)
        Me.btnAltaLocalidad.Name = "btnAltaLocalidad"
        Me.btnAltaLocalidad.Size = New System.Drawing.Size(82, 30)
        Me.btnAltaLocalidad.TabIndex = 18
        Me.btnAltaLocalidad.Text = "ALTA"
        Me.btnAltaLocalidad.UseVisualStyleBackColor = True
        '
        'LblLocalidad
        '
        Me.LblLocalidad.AutoSize = True
        Me.LblLocalidad.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLocalidad.ForeColor = System.Drawing.Color.White
        Me.LblLocalidad.Location = New System.Drawing.Point(59, 337)
        Me.LblLocalidad.Name = "LblLocalidad"
        Me.LblLocalidad.Size = New System.Drawing.Size(98, 21)
        Me.LblLocalidad.TabIndex = 17
        Me.LblLocalidad.Text = "LOCALIDAD"
        '
        'lblCp
        '
        Me.lblCp.AutoSize = True
        Me.lblCp.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCp.ForeColor = System.Drawing.Color.White
        Me.lblCp.Location = New System.Drawing.Point(59, 301)
        Me.lblCp.Name = "lblCp"
        Me.lblCp.Size = New System.Drawing.Size(30, 21)
        Me.lblCp.TabIndex = 16
        Me.lblCp.Text = "CP"
        '
        'TxtLocalidad
        '
        Me.TxtLocalidad.Location = New System.Drawing.Point(172, 338)
        Me.TxtLocalidad.Name = "TxtLocalidad"
        Me.TxtLocalidad.Size = New System.Drawing.Size(211, 20)
        Me.TxtLocalidad.TabIndex = 15
        '
        'TxtCp
        '
        Me.TxtCp.BackColor = System.Drawing.Color.Yellow
        Me.TxtCp.Location = New System.Drawing.Point(172, 299)
        Me.TxtCp.MaxLength = 4
        Me.TxtCp.Name = "TxtCp"
        Me.TxtCp.Size = New System.Drawing.Size(100, 20)
        Me.TxtCp.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Final_Sys_Punto_Venta_Programacion_I.My.Resources.Resources.Pollo_Abasto_Tu_Almacen
        Me.PictureBox1.Location = New System.Drawing.Point(583, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 67
        Me.PictureBox1.TabStop = False
        '
        'LblLocalidades
        '
        Me.LblLocalidades.AutoSize = True
        Me.LblLocalidades.BackColor = System.Drawing.Color.Transparent
        Me.LblLocalidades.Font = New System.Drawing.Font("Nirmala Text", 24.0!, System.Drawing.FontStyle.Bold)
        Me.LblLocalidades.ForeColor = System.Drawing.Color.White
        Me.LblLocalidades.Location = New System.Drawing.Point(213, 9)
        Me.LblLocalidades.Name = "LblLocalidades"
        Me.LblLocalidades.Size = New System.Drawing.Size(233, 45)
        Me.LblLocalidades.TabIndex = 137
        Me.LblLocalidades.Text = "LOCALIDADES"
        '
        'frmLocalidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(650, 440)
        Me.Controls.Add(Me.LblLocalidades)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnGestionarLocalidades)
        Me.Controls.Add(Me.BtnAtrasLocalidades)
        Me.Controls.Add(Me.lblBuscarXLocalidad)
        Me.Controls.Add(Me.lblBuscarXCp)
        Me.Controls.Add(Me.TxtFiltrarLocalidad)
        Me.Controls.Add(Me.TxtFiltrarCp)
        Me.Controls.Add(Me.btnBajaLocalidad)
        Me.Controls.Add(Me.btnModificaLocalidad)
        Me.Controls.Add(Me.dgvLocalidades)
        Me.Controls.Add(Me.btnAltaLocalidad)
        Me.Controls.Add(Me.LblLocalidad)
        Me.Controls.Add(Me.lblCp)
        Me.Controls.Add(Me.TxtLocalidad)
        Me.Controls.Add(Me.TxtCp)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLocalidades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmLocalidades"
        CType(Me.dgvLocalidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnGestionarLocalidades As Button
    Friend WithEvents BtnAtrasLocalidades As Button
    Friend WithEvents lblBuscarXLocalidad As Label
    Friend WithEvents lblBuscarXCp As Label
    Friend WithEvents TxtFiltrarLocalidad As TextBox
    Friend WithEvents TxtFiltrarCp As TextBox
    Friend WithEvents btnBajaLocalidad As Button
    Friend WithEvents btnModificaLocalidad As Button
    Friend WithEvents dgvLocalidades As DataGridView
    Friend WithEvents btnAltaLocalidad As Button
    Friend WithEvents LblLocalidad As Label
    Friend WithEvents lblCp As Label
    Friend WithEvents TxtLocalidad As TextBox
    Friend WithEvents TxtCp As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblLocalidades As Label
End Class
