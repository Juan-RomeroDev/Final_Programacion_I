<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Backup = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblNombre_Negocio = New System.Windows.Forms.Label()
        Me.BtnRubros = New System.Windows.Forms.Button()
        Me.BtnProductos = New System.Windows.Forms.Button()
        Me.BtnLocalidades = New System.Windows.Forms.Button()
        Me.BtnFormaDePago = New System.Windows.Forms.Button()
        Me.BtnDetalleVentas = New System.Windows.Forms.Button()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.lblhora = New System.Windows.Forms.Label()
        Me.Tiempo = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.MidnightBlue
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Backup, Me.SalirToolStripMenuItem, Me.InformesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(832, 25)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Backup
        '
        Me.Backup.Font = New System.Drawing.Font("Nirmala Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Backup.ForeColor = System.Drawing.Color.White
        Me.Backup.Name = "Backup"
        Me.Backup.Size = New System.Drawing.Size(64, 21)
        Me.Backup.Text = "Backup"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SalirToolStripMenuItem.Font = New System.Drawing.Font("Nirmala Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SalirToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(47, 21)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'InformesToolStripMenuItem
        '
        Me.InformesToolStripMenuItem.Font = New System.Drawing.Font("Nirmala Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InformesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.InformesToolStripMenuItem.Name = "InformesToolStripMenuItem"
        Me.InformesToolStripMenuItem.Size = New System.Drawing.Size(75, 21)
        Me.InformesToolStripMenuItem.Text = "Informes"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.BtnRubros)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.BtnProductos)
        Me.Panel1.Controls.Add(Me.BtnClientes)
        Me.Panel1.Controls.Add(Me.BtnDetalleVentas)
        Me.Panel1.Controls.Add(Me.BtnLocalidades)
        Me.Panel1.Controls.Add(Me.BtnFormaDePago)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 492)
        Me.Panel1.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.Final_Sys_Punto_Venta_Programacion_I.My.Resources.Resources.Pollo_Abasto_Tu_Almacen
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 142)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LblNombre_Negocio
        '
        Me.LblNombre_Negocio.AutoSize = True
        Me.LblNombre_Negocio.BackColor = System.Drawing.Color.Black
        Me.LblNombre_Negocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre_Negocio.ForeColor = System.Drawing.Color.White
        Me.LblNombre_Negocio.Location = New System.Drawing.Point(563, 492)
        Me.LblNombre_Negocio.Name = "LblNombre_Negocio"
        Me.LblNombre_Negocio.Size = New System.Drawing.Size(269, 25)
        Me.LblNombre_Negocio.TabIndex = 7
        Me.LblNombre_Negocio.Text = "Pollo Abasto: Tu Almacen "
        Me.LblNombre_Negocio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnRubros
        '
        Me.BtnRubros.FlatAppearance.BorderSize = 0
        Me.BtnRubros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRubros.Font = New System.Drawing.Font("Nirmala Text", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRubros.ForeColor = System.Drawing.Color.White
        Me.BtnRubros.Location = New System.Drawing.Point(0, 421)
        Me.BtnRubros.Name = "BtnRubros"
        Me.BtnRubros.Size = New System.Drawing.Size(200, 62)
        Me.BtnRubros.TabIndex = 6
        Me.BtnRubros.Text = "Rubros"
        Me.BtnRubros.UseVisualStyleBackColor = False
        '
        'BtnProductos
        '
        Me.BtnProductos.FlatAppearance.BorderSize = 0
        Me.BtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProductos.Font = New System.Drawing.Font("Nirmala Text", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProductos.ForeColor = System.Drawing.Color.White
        Me.BtnProductos.Location = New System.Drawing.Point(0, 365)
        Me.BtnProductos.Name = "BtnProductos"
        Me.BtnProductos.Size = New System.Drawing.Size(200, 56)
        Me.BtnProductos.TabIndex = 5
        Me.BtnProductos.Text = "Productos"
        Me.BtnProductos.UseVisualStyleBackColor = False
        '
        'BtnLocalidades
        '
        Me.BtnLocalidades.FlatAppearance.BorderSize = 0
        Me.BtnLocalidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLocalidades.Font = New System.Drawing.Font("Nirmala Text", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLocalidades.ForeColor = System.Drawing.Color.White
        Me.BtnLocalidades.Location = New System.Drawing.Point(0, 309)
        Me.BtnLocalidades.Name = "BtnLocalidades"
        Me.BtnLocalidades.Size = New System.Drawing.Size(200, 56)
        Me.BtnLocalidades.TabIndex = 4
        Me.BtnLocalidades.Text = "Localidades"
        Me.BtnLocalidades.UseVisualStyleBackColor = False
        '
        'BtnFormaDePago
        '
        Me.BtnFormaDePago.FlatAppearance.BorderSize = 0
        Me.BtnFormaDePago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFormaDePago.Font = New System.Drawing.Font("Nirmala Text", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFormaDePago.ForeColor = System.Drawing.Color.White
        Me.BtnFormaDePago.Location = New System.Drawing.Point(0, 252)
        Me.BtnFormaDePago.Name = "BtnFormaDePago"
        Me.BtnFormaDePago.Size = New System.Drawing.Size(200, 57)
        Me.BtnFormaDePago.TabIndex = 3
        Me.BtnFormaDePago.Text = "Forma de Pago"
        Me.BtnFormaDePago.UseVisualStyleBackColor = False
        '
        'BtnDetalleVentas
        '
        Me.BtnDetalleVentas.FlatAppearance.BorderSize = 0
        Me.BtnDetalleVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDetalleVentas.Font = New System.Drawing.Font("Nirmala Text", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDetalleVentas.ForeColor = System.Drawing.Color.White
        Me.BtnDetalleVentas.Location = New System.Drawing.Point(0, 197)
        Me.BtnDetalleVentas.Name = "BtnDetalleVentas"
        Me.BtnDetalleVentas.Size = New System.Drawing.Size(200, 55)
        Me.BtnDetalleVentas.TabIndex = 2
        Me.BtnDetalleVentas.Text = "Detalle Ventas"
        Me.BtnDetalleVentas.UseVisualStyleBackColor = False
        '
        'BtnClientes
        '
        Me.BtnClientes.FlatAppearance.BorderSize = 0
        Me.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClientes.Font = New System.Drawing.Font("Nirmala Text", 15.75!, System.Drawing.FontStyle.Bold)
        Me.BtnClientes.ForeColor = System.Drawing.Color.White
        Me.BtnClientes.Location = New System.Drawing.Point(0, 146)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(200, 51)
        Me.BtnClientes.TabIndex = 1
        Me.BtnClientes.Text = "Clientes"
        Me.BtnClientes.UseVisualStyleBackColor = False
        '
        'lblhora
        '
        Me.lblhora.BackColor = System.Drawing.Color.MediumBlue
        Me.lblhora.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblhora.Font = New System.Drawing.Font("Nirmala Text", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhora.ForeColor = System.Drawing.Color.White
        Me.lblhora.Location = New System.Drawing.Point(200, 25)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(632, 45)
        Me.lblhora.TabIndex = 5
        Me.lblhora.Text = "Tiempo"
        Me.lblhora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tiempo
        '
        Me.Tiempo.Enabled = True
        Me.Tiempo.Interval = 1000
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 517)
        Me.Controls.Add(Me.LblNombre_Negocio)
        Me.Controls.Add(Me.lblhora)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MENU PRINCIPAL - POLLO ABASTO: TU ALMACEN"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Backup As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnDetalleVentas As Button
    Friend WithEvents BtnClientes As Button
    Friend WithEvents BtnRubros As Button
    Friend WithEvents BtnProductos As Button
    Friend WithEvents BtnLocalidades As Button
    Friend WithEvents BtnFormaDePago As Button
    Friend WithEvents InformesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblhora As Label
    Friend WithEvents Tiempo As Timer
    Friend WithEvents LblNombre_Negocio As Label
End Class
