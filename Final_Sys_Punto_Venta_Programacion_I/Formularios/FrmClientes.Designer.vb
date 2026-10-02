<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmClientes))
        Me.BtnGenerarCredencialClientes = New System.Windows.Forms.Button()
        Me.BtnGestionarClientes = New System.Windows.Forms.Button()
        Me.BtnAtrasClientes = New System.Windows.Forms.Button()
        Me.TxtIDCliente = New System.Windows.Forms.TextBox()
        Me.lblIDCliente = New System.Windows.Forms.Label()
        Me.LblCPFiltrado = New System.Windows.Forms.Label()
        Me.BtnBuscarLocalidad = New System.Windows.Forms.Button()
        Me.TxtCPCLiente = New System.Windows.Forms.TextBox()
        Me.CPCliente = New System.Windows.Forms.Label()
        Me.LblTelefonoCliente = New System.Windows.Forms.Label()
        Me.lblRazonSocialCliente = New System.Windows.Forms.Label()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtRazonSocial = New System.Windows.Forms.TextBox()
        Me.btnBajaCliente = New System.Windows.Forms.Button()
        Me.btnModificaCliente = New System.Windows.Forms.Button()
        Me.btnAltaCliente = New System.Windows.Forms.Button()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnGenerarCredencialClientes
        '
        Me.BtnGenerarCredencialClientes.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGenerarCredencialClientes.Location = New System.Drawing.Point(712, 375)
        Me.BtnGenerarCredencialClientes.Name = "BtnGenerarCredencialClientes"
        Me.BtnGenerarCredencialClientes.Size = New System.Drawing.Size(151, 28)
        Me.BtnGenerarCredencialClientes.TabIndex = 63
        Me.BtnGenerarCredencialClientes.Text = "Generar Credencial"
        Me.BtnGenerarCredencialClientes.UseVisualStyleBackColor = True
        '
        'BtnGestionarClientes
        '
        Me.BtnGestionarClientes.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGestionarClientes.Location = New System.Drawing.Point(712, 338)
        Me.BtnGestionarClientes.Name = "BtnGestionarClientes"
        Me.BtnGestionarClientes.Size = New System.Drawing.Size(148, 31)
        Me.BtnGestionarClientes.TabIndex = 62
        Me.BtnGestionarClientes.Text = "Gestionar Clientes"
        Me.BtnGestionarClientes.UseVisualStyleBackColor = True
        '
        'BtnAtrasClientes
        '
        Me.BtnAtrasClientes.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAtrasClientes.Location = New System.Drawing.Point(-1, -1)
        Me.BtnAtrasClientes.Name = "BtnAtrasClientes"
        Me.BtnAtrasClientes.Size = New System.Drawing.Size(82, 33)
        Me.BtnAtrasClientes.TabIndex = 59
        Me.BtnAtrasClientes.Text = "ATRAS"
        Me.BtnAtrasClientes.UseVisualStyleBackColor = True
        '
        'TxtIDCliente
        '
        Me.TxtIDCliente.Location = New System.Drawing.Point(313, 321)
        Me.TxtIDCliente.Name = "TxtIDCliente"
        Me.TxtIDCliente.Size = New System.Drawing.Size(105, 20)
        Me.TxtIDCliente.TabIndex = 58
        '
        'lblIDCliente
        '
        Me.lblIDCliente.AutoSize = True
        Me.lblIDCliente.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDCliente.ForeColor = System.Drawing.Color.White
        Me.lblIDCliente.Location = New System.Drawing.Point(153, 321)
        Me.lblIDCliente.Name = "lblIDCliente"
        Me.lblIDCliente.Size = New System.Drawing.Size(97, 21)
        Me.lblIDCliente.TabIndex = 57
        Me.lblIDCliente.Text = "ID_CLIENTE"
        '
        'LblCPFiltrado
        '
        Me.LblCPFiltrado.AutoSize = True
        Me.LblCPFiltrado.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.LblCPFiltrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCPFiltrado.Location = New System.Drawing.Point(491, 393)
        Me.LblCPFiltrado.Name = "LblCPFiltrado"
        Me.LblCPFiltrado.Size = New System.Drawing.Size(15, 13)
        Me.LblCPFiltrado.TabIndex = 56
        Me.LblCPFiltrado.Text = "--"
        '
        'BtnBuscarLocalidad
        '
        Me.BtnBuscarLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarLocalidad.Location = New System.Drawing.Point(437, 383)
        Me.BtnBuscarLocalidad.Name = "BtnBuscarLocalidad"
        Me.BtnBuscarLocalidad.Size = New System.Drawing.Size(48, 23)
        Me.BtnBuscarLocalidad.TabIndex = 55
        Me.BtnBuscarLocalidad.Text = "..."
        Me.BtnBuscarLocalidad.UseVisualStyleBackColor = True
        '
        'TxtCPCLiente
        '
        Me.TxtCPCLiente.BackColor = System.Drawing.Color.Yellow
        Me.TxtCPCLiente.Location = New System.Drawing.Point(313, 382)
        Me.TxtCPCLiente.Name = "TxtCPCLiente"
        Me.TxtCPCLiente.Size = New System.Drawing.Size(105, 20)
        Me.TxtCPCLiente.TabIndex = 54
        '
        'CPCliente
        '
        Me.CPCliente.AutoSize = True
        Me.CPCliente.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPCliente.ForeColor = System.Drawing.Color.White
        Me.CPCliente.Location = New System.Drawing.Point(153, 382)
        Me.CPCliente.Name = "CPCliente"
        Me.CPCliente.Size = New System.Drawing.Size(30, 21)
        Me.CPCliente.TabIndex = 53
        Me.CPCliente.Text = "CP"
        '
        'LblTelefonoCliente
        '
        Me.LblTelefonoCliente.AutoSize = True
        Me.LblTelefonoCliente.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTelefonoCliente.ForeColor = System.Drawing.Color.White
        Me.LblTelefonoCliente.Location = New System.Drawing.Point(153, 451)
        Me.LblTelefonoCliente.Name = "LblTelefonoCliente"
        Me.LblTelefonoCliente.Size = New System.Drawing.Size(90, 21)
        Me.LblTelefonoCliente.TabIndex = 50
        Me.LblTelefonoCliente.Text = "TELEFONO"
        '
        'lblRazonSocialCliente
        '
        Me.lblRazonSocialCliente.AutoSize = True
        Me.lblRazonSocialCliente.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRazonSocialCliente.ForeColor = System.Drawing.Color.White
        Me.lblRazonSocialCliente.Location = New System.Drawing.Point(153, 353)
        Me.lblRazonSocialCliente.Name = "lblRazonSocialCliente"
        Me.lblRazonSocialCliente.Size = New System.Drawing.Size(125, 21)
        Me.lblRazonSocialCliente.TabIndex = 49
        Me.lblRazonSocialCliente.Text = "RAZON SOCIAL"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(313, 451)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(172, 20)
        Me.TxtTelefono.TabIndex = 48
        '
        'TxtRazonSocial
        '
        Me.TxtRazonSocial.Location = New System.Drawing.Point(313, 350)
        Me.TxtRazonSocial.Name = "TxtRazonSocial"
        Me.TxtRazonSocial.Size = New System.Drawing.Size(172, 20)
        Me.TxtRazonSocial.TabIndex = 47
        '
        'btnBajaCliente
        '
        Me.btnBajaCliente.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBajaCliente.Location = New System.Drawing.Point(748, 490)
        Me.btnBajaCliente.Name = "btnBajaCliente"
        Me.btnBajaCliente.Size = New System.Drawing.Size(62, 30)
        Me.btnBajaCliente.TabIndex = 46
        Me.btnBajaCliente.Text = "BAJA"
        Me.btnBajaCliente.UseVisualStyleBackColor = True
        '
        'btnModificaCliente
        '
        Me.btnModificaCliente.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificaCliente.Location = New System.Drawing.Point(474, 490)
        Me.btnModificaCliente.Name = "btnModificaCliente"
        Me.btnModificaCliente.Size = New System.Drawing.Size(93, 30)
        Me.btnModificaCliente.TabIndex = 45
        Me.btnModificaCliente.Text = "MODIFICA"
        Me.btnModificaCliente.UseVisualStyleBackColor = True
        '
        'btnAltaCliente
        '
        Me.btnAltaCliente.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAltaCliente.Location = New System.Drawing.Point(235, 490)
        Me.btnAltaCliente.Name = "btnAltaCliente"
        Me.btnAltaCliente.Size = New System.Drawing.Size(70, 30)
        Me.btnAltaCliente.TabIndex = 44
        Me.btnAltaCliente.Text = "ALTA"
        Me.btnAltaCliente.UseVisualStyleBackColor = False
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Location = New System.Drawing.Point(128, 91)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        Me.dgvClientes.RowHeadersVisible = False
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClientes.Size = New System.Drawing.Size(751, 208)
        Me.dgvClientes.TabIndex = 43
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmail.ForeColor = System.Drawing.Color.White
        Me.LblEmail.Location = New System.Drawing.Point(153, 416)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(58, 21)
        Me.LblEmail.TabIndex = 64
        Me.LblEmail.Text = "EMAIL"
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(313, 419)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(172, 20)
        Me.TxtEmail.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(175, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 21)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "CLIENTES"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Final_Sys_Punto_Venta_Programacion_I.My.Resources.Resources.Clientes
        Me.PictureBox2.Location = New System.Drawing.Point(87, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(82, 79)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 67
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Final_Sys_Punto_Venta_Programacion_I.My.Resources.Resources.Pollo_Abasto_Tu_Almacen
        Me.PictureBox1.Location = New System.Drawing.Point(918, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 66
        Me.PictureBox1.TabStop = False
        '
        'FrmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(987, 553)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.LblEmail)
        Me.Controls.Add(Me.BtnGenerarCredencialClientes)
        Me.Controls.Add(Me.BtnGestionarClientes)
        Me.Controls.Add(Me.BtnAtrasClientes)
        Me.Controls.Add(Me.TxtIDCliente)
        Me.Controls.Add(Me.lblIDCliente)
        Me.Controls.Add(Me.LblCPFiltrado)
        Me.Controls.Add(Me.BtnBuscarLocalidad)
        Me.Controls.Add(Me.TxtCPCLiente)
        Me.Controls.Add(Me.CPCliente)
        Me.Controls.Add(Me.LblTelefonoCliente)
        Me.Controls.Add(Me.lblRazonSocialCliente)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.TxtRazonSocial)
        Me.Controls.Add(Me.btnBajaCliente)
        Me.Controls.Add(Me.btnModificaCliente)
        Me.Controls.Add(Me.btnAltaCliente)
        Me.Controls.Add(Me.dgvClientes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CLIENTES"
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnGenerarCredencialClientes As Button
    Friend WithEvents BtnGestionarClientes As Button
    Friend WithEvents BtnAtrasClientes As Button
    Friend WithEvents TxtIDCliente As TextBox
    Friend WithEvents lblIDCliente As Label
    Friend WithEvents LblCPFiltrado As Label
    Friend WithEvents BtnBuscarLocalidad As Button
    Friend WithEvents TxtCPCLiente As TextBox
    Friend WithEvents CPCliente As Label
    Friend WithEvents LblTelefonoCliente As Label
    Friend WithEvents lblRazonSocialCliente As Label
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtRazonSocial As TextBox
    Friend WithEvents btnBajaCliente As Button
    Friend WithEvents btnModificaCliente As Button
    Friend WithEvents btnAltaCliente As Button
    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents LblEmail As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
End Class
