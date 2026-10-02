<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLocalidades
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
        CType(Me.dgvLocalidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnGestionarLocalidades
        '
        Me.BtnGestionarLocalidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGestionarLocalidades.Location = New System.Drawing.Point(370, 260)
        Me.BtnGestionarLocalidades.Name = "BtnGestionarLocalidades"
        Me.BtnGestionarLocalidades.Size = New System.Drawing.Size(150, 23)
        Me.BtnGestionarLocalidades.TabIndex = 27
        Me.BtnGestionarLocalidades.Text = "Gestionar Localidades"
        Me.BtnGestionarLocalidades.UseVisualStyleBackColor = True
        '
        'BtnAtrasLocalidades
        '
        Me.BtnAtrasLocalidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAtrasLocalidades.Location = New System.Drawing.Point(0, -1)
        Me.BtnAtrasLocalidades.Name = "BtnAtrasLocalidades"
        Me.BtnAtrasLocalidades.Size = New System.Drawing.Size(75, 23)
        Me.BtnAtrasLocalidades.TabIndex = 26
        Me.BtnAtrasLocalidades.Text = "ATRAS"
        Me.BtnAtrasLocalidades.UseVisualStyleBackColor = True
        '
        'lblBuscarXLocalidad
        '
        Me.lblBuscarXLocalidad.AutoSize = True
        Me.lblBuscarXLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarXLocalidad.Location = New System.Drawing.Point(184, 27)
        Me.lblBuscarXLocalidad.Name = "lblBuscarXLocalidad"
        Me.lblBuscarXLocalidad.Size = New System.Drawing.Size(115, 13)
        Me.lblBuscarXLocalidad.TabIndex = 25
        Me.lblBuscarXLocalidad.Text = "Buscar x Localidad"
        '
        'lblBuscarXCp
        '
        Me.lblBuscarXCp.AutoSize = True
        Me.lblBuscarXCp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarXCp.Location = New System.Drawing.Point(8, 27)
        Me.lblBuscarXCp.Name = "lblBuscarXCp"
        Me.lblBuscarXCp.Size = New System.Drawing.Size(75, 13)
        Me.lblBuscarXCp.TabIndex = 24
        Me.lblBuscarXCp.Text = "Buscar x Cp"
        '
        'TxtFiltrarLocalidad
        '
        Me.TxtFiltrarLocalidad.Location = New System.Drawing.Point(187, 46)
        Me.TxtFiltrarLocalidad.Name = "TxtFiltrarLocalidad"
        Me.TxtFiltrarLocalidad.Size = New System.Drawing.Size(161, 20)
        Me.TxtFiltrarLocalidad.TabIndex = 23
        '
        'TxtFiltrarCp
        '
        Me.TxtFiltrarCp.Location = New System.Drawing.Point(11, 46)
        Me.TxtFiltrarCp.Name = "TxtFiltrarCp"
        Me.TxtFiltrarCp.Size = New System.Drawing.Size(135, 20)
        Me.TxtFiltrarCp.TabIndex = 22
        '
        'btnBajaLocalidad
        '
        Me.btnBajaLocalidad.Enabled = False
        Me.btnBajaLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBajaLocalidad.Location = New System.Drawing.Point(535, 367)
        Me.btnBajaLocalidad.Name = "btnBajaLocalidad"
        Me.btnBajaLocalidad.Size = New System.Drawing.Size(75, 23)
        Me.btnBajaLocalidad.TabIndex = 21
        Me.btnBajaLocalidad.Text = "BAJA"
        Me.btnBajaLocalidad.UseVisualStyleBackColor = True
        '
        'btnModificaLocalidad
        '
        Me.btnModificaLocalidad.Enabled = False
        Me.btnModificaLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificaLocalidad.Location = New System.Drawing.Point(273, 367)
        Me.btnModificaLocalidad.Name = "btnModificaLocalidad"
        Me.btnModificaLocalidad.Size = New System.Drawing.Size(75, 23)
        Me.btnModificaLocalidad.TabIndex = 20
        Me.btnModificaLocalidad.Text = "MODIFICA"
        Me.btnModificaLocalidad.UseVisualStyleBackColor = True
        '
        'dgvLocalidades
        '
        Me.dgvLocalidades.AllowUserToAddRows = False
        Me.dgvLocalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLocalidades.Location = New System.Drawing.Point(63, 82)
        Me.dgvLocalidades.Name = "dgvLocalidades"
        Me.dgvLocalidades.ReadOnly = True
        Me.dgvLocalidades.RowHeadersVisible = False
        Me.dgvLocalidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLocalidades.Size = New System.Drawing.Size(457, 150)
        Me.dgvLocalidades.TabIndex = 19
        '
        'btnAltaLocalidad
        '
        Me.btnAltaLocalidad.Enabled = False
        Me.btnAltaLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAltaLocalidad.Location = New System.Drawing.Point(28, 367)
        Me.btnAltaLocalidad.Name = "btnAltaLocalidad"
        Me.btnAltaLocalidad.Size = New System.Drawing.Size(75, 23)
        Me.btnAltaLocalidad.TabIndex = 18
        Me.btnAltaLocalidad.Text = "ALTA"
        Me.btnAltaLocalidad.UseVisualStyleBackColor = True
        '
        'LblLocalidad
        '
        Me.LblLocalidad.AutoSize = True
        Me.LblLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLocalidad.Location = New System.Drawing.Point(141, 321)
        Me.LblLocalidad.Name = "LblLocalidad"
        Me.LblLocalidad.Size = New System.Drawing.Size(76, 13)
        Me.LblLocalidad.TabIndex = 17
        Me.LblLocalidad.Text = "LOCALIDAD"
        '
        'lblCp
        '
        Me.lblCp.AutoSize = True
        Me.lblCp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCp.Location = New System.Drawing.Point(141, 266)
        Me.lblCp.Name = "lblCp"
        Me.lblCp.Size = New System.Drawing.Size(23, 13)
        Me.lblCp.TabIndex = 16
        Me.lblCp.Text = "CP"
        '
        'TxtLocalidad
        '
        Me.TxtLocalidad.Location = New System.Drawing.Point(248, 318)
        Me.TxtLocalidad.Name = "TxtLocalidad"
        Me.TxtLocalidad.Size = New System.Drawing.Size(288, 20)
        Me.TxtLocalidad.TabIndex = 15
        '
        'TxtCp
        '
        Me.TxtCp.BackColor = System.Drawing.Color.Yellow
        Me.TxtCp.Location = New System.Drawing.Point(248, 260)
        Me.TxtCp.Name = "TxtCp"
        Me.TxtCp.Size = New System.Drawing.Size(100, 20)
        Me.TxtCp.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Final_Sys_Punto_Venta_Programacion_I.My.Resources.Resources.Pollo_Abasto_Tu_Almacen
        Me.PictureBox1.Location = New System.Drawing.Point(539, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 67
        Me.PictureBox1.TabStop = False
        '
        'FrmLocalidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 428)
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
        Me.Name = "FrmLocalidades"
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
End Class
