<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFormaDePago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFormaDePago))
        Me.dgvFormaDePago = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lbl_ID_Forma_Pago = New System.Windows.Forms.Label()
        Me.Lbl_Forma_Pago = New System.Windows.Forms.Label()
        Me.TxtIDFormaPago = New System.Windows.Forms.TextBox()
        Me.TxtDescripcionFormaPago = New System.Windows.Forms.TextBox()
        Me.BtnGestionarLocalidades = New System.Windows.Forms.Button()
        Me.btnBajaFormaPago = New System.Windows.Forms.Button()
        Me.btnModificaFormaPago = New System.Windows.Forms.Button()
        Me.btnAltaFormaPago = New System.Windows.Forms.Button()
        Me.BtnAtrasFormaPago = New System.Windows.Forms.Button()
        Me.TxtBuscarFormaPago = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblFormaDePago = New System.Windows.Forms.Label()
        CType(Me.dgvFormaDePago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvFormaDePago
        '
        Me.dgvFormaDePago.AllowUserToAddRows = False
        Me.dgvFormaDePago.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.dgvFormaDePago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFormaDePago.GridColor = System.Drawing.Color.RoyalBlue
        Me.dgvFormaDePago.Location = New System.Drawing.Point(88, 108)
        Me.dgvFormaDePago.Name = "dgvFormaDePago"
        Me.dgvFormaDePago.ReadOnly = True
        Me.dgvFormaDePago.RowHeadersVisible = False
        Me.dgvFormaDePago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFormaDePago.Size = New System.Drawing.Size(654, 178)
        Me.dgvFormaDePago.TabIndex = 90
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Final_Sys_Punto_Venta_Programacion_I.My.Resources.Resources.Pollo_Abasto_Tu_Almacen
        Me.PictureBox1.Location = New System.Drawing.Point(734, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 67
        Me.PictureBox1.TabStop = False
        '
        'Lbl_ID_Forma_Pago
        '
        Me.Lbl_ID_Forma_Pago.AutoSize = True
        Me.Lbl_ID_Forma_Pago.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_ID_Forma_Pago.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ID_Forma_Pago.ForeColor = System.Drawing.Color.White
        Me.Lbl_ID_Forma_Pago.Location = New System.Drawing.Point(162, 324)
        Me.Lbl_ID_Forma_Pago.Name = "Lbl_ID_Forma_Pago"
        Me.Lbl_ID_Forma_Pago.Size = New System.Drawing.Size(134, 21)
        Me.Lbl_ID_Forma_Pago.TabIndex = 103
        Me.Lbl_ID_Forma_Pago.Text = "ID FORMA PAGO"
        '
        'Lbl_Forma_Pago
        '
        Me.Lbl_Forma_Pago.AutoSize = True
        Me.Lbl_Forma_Pago.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Forma_Pago.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Forma_Pago.ForeColor = System.Drawing.Color.White
        Me.Lbl_Forma_Pago.Location = New System.Drawing.Point(74, 356)
        Me.Lbl_Forma_Pago.Name = "Lbl_Forma_Pago"
        Me.Lbl_Forma_Pago.Size = New System.Drawing.Size(222, 21)
        Me.Lbl_Forma_Pago.TabIndex = 102
        Me.Lbl_Forma_Pago.Text = "DESCRIPCION FORMA PAGO"
        '
        'TxtIDFormaPago
        '
        Me.TxtIDFormaPago.Location = New System.Drawing.Point(307, 327)
        Me.TxtIDFormaPago.Name = "TxtIDFormaPago"
        Me.TxtIDFormaPago.Size = New System.Drawing.Size(105, 20)
        Me.TxtIDFormaPago.TabIndex = 104
        '
        'TxtDescripcionFormaPago
        '
        Me.TxtDescripcionFormaPago.Location = New System.Drawing.Point(307, 359)
        Me.TxtDescripcionFormaPago.Name = "TxtDescripcionFormaPago"
        Me.TxtDescripcionFormaPago.Size = New System.Drawing.Size(141, 20)
        Me.TxtDescripcionFormaPago.TabIndex = 105
        '
        'BtnGestionarLocalidades
        '
        Me.BtnGestionarLocalidades.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGestionarLocalidades.Location = New System.Drawing.Point(487, 324)
        Me.BtnGestionarLocalidades.Name = "BtnGestionarLocalidades"
        Me.BtnGestionarLocalidades.Size = New System.Drawing.Size(194, 32)
        Me.BtnGestionarLocalidades.TabIndex = 106
        Me.BtnGestionarLocalidades.Text = "Gestionar Forma Pago"
        Me.BtnGestionarLocalidades.UseVisualStyleBackColor = True
        '
        'btnBajaFormaPago
        '
        Me.btnBajaFormaPago.Enabled = False
        Me.btnBajaFormaPago.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBajaFormaPago.Location = New System.Drawing.Point(623, 403)
        Me.btnBajaFormaPago.Name = "btnBajaFormaPago"
        Me.btnBajaFormaPago.Size = New System.Drawing.Size(67, 30)
        Me.btnBajaFormaPago.TabIndex = 109
        Me.btnBajaFormaPago.Text = "BAJA"
        Me.btnBajaFormaPago.UseVisualStyleBackColor = True
        '
        'btnModificaFormaPago
        '
        Me.btnModificaFormaPago.Enabled = False
        Me.btnModificaFormaPago.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificaFormaPago.Location = New System.Drawing.Point(351, 403)
        Me.btnModificaFormaPago.Name = "btnModificaFormaPago"
        Me.btnModificaFormaPago.Size = New System.Drawing.Size(97, 30)
        Me.btnModificaFormaPago.TabIndex = 108
        Me.btnModificaFormaPago.Text = "MODIFICA"
        Me.btnModificaFormaPago.UseVisualStyleBackColor = True
        '
        'btnAltaFormaPago
        '
        Me.btnAltaFormaPago.Enabled = False
        Me.btnAltaFormaPago.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAltaFormaPago.Location = New System.Drawing.Point(106, 403)
        Me.btnAltaFormaPago.Name = "btnAltaFormaPago"
        Me.btnAltaFormaPago.Size = New System.Drawing.Size(82, 30)
        Me.btnAltaFormaPago.TabIndex = 107
        Me.btnAltaFormaPago.Text = "ALTA"
        Me.btnAltaFormaPago.UseVisualStyleBackColor = True
        '
        'BtnAtrasFormaPago
        '
        Me.BtnAtrasFormaPago.Font = New System.Drawing.Font("Nirmala Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAtrasFormaPago.Location = New System.Drawing.Point(-4, -1)
        Me.BtnAtrasFormaPago.Name = "BtnAtrasFormaPago"
        Me.BtnAtrasFormaPago.Size = New System.Drawing.Size(82, 33)
        Me.BtnAtrasFormaPago.TabIndex = 110
        Me.BtnAtrasFormaPago.Text = "ATRAS"
        Me.BtnAtrasFormaPago.UseVisualStyleBackColor = True
        '
        'TxtBuscarFormaPago
        '
        Me.TxtBuscarFormaPago.Location = New System.Drawing.Point(88, 83)
        Me.TxtBuscarFormaPago.Name = "TxtBuscarFormaPago"
        Me.TxtBuscarFormaPago.Size = New System.Drawing.Size(105, 20)
        Me.TxtBuscarFormaPago.TabIndex = 111
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(84, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 21)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "Buscar Forma De Pago"
        '
        'LblFormaDePago
        '
        Me.LblFormaDePago.AutoSize = True
        Me.LblFormaDePago.BackColor = System.Drawing.Color.Transparent
        Me.LblFormaDePago.Font = New System.Drawing.Font("Nirmala Text", 24.0!, System.Drawing.FontStyle.Bold)
        Me.LblFormaDePago.ForeColor = System.Drawing.Color.White
        Me.LblFormaDePago.Location = New System.Drawing.Point(271, 9)
        Me.LblFormaDePago.Name = "LblFormaDePago"
        Me.LblFormaDePago.Size = New System.Drawing.Size(283, 45)
        Me.LblFormaDePago.TabIndex = 137
        Me.LblFormaDePago.Text = "FORMA DE PAGO"
        '
        'FrmFormaDePago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(804, 460)
        Me.Controls.Add(Me.LblFormaDePago)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtBuscarFormaPago)
        Me.Controls.Add(Me.BtnAtrasFormaPago)
        Me.Controls.Add(Me.btnBajaFormaPago)
        Me.Controls.Add(Me.btnModificaFormaPago)
        Me.Controls.Add(Me.btnAltaFormaPago)
        Me.Controls.Add(Me.BtnGestionarLocalidades)
        Me.Controls.Add(Me.TxtDescripcionFormaPago)
        Me.Controls.Add(Me.TxtIDFormaPago)
        Me.Controls.Add(Me.Lbl_ID_Forma_Pago)
        Me.Controls.Add(Me.Lbl_Forma_Pago)
        Me.Controls.Add(Me.dgvFormaDePago)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmFormaDePago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FORMA DE PAGO "
        CType(Me.dgvFormaDePago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgvFormaDePago As DataGridView
    Friend WithEvents Lbl_ID_Forma_Pago As Label
    Friend WithEvents Lbl_Forma_Pago As Label
    Friend WithEvents TxtIDFormaPago As TextBox
    Friend WithEvents TxtDescripcionFormaPago As TextBox
    Friend WithEvents BtnGestionarLocalidades As Button
    Friend WithEvents btnBajaFormaPago As Button
    Friend WithEvents btnModificaFormaPago As Button
    Friend WithEvents btnAltaFormaPago As Button
    Friend WithEvents BtnAtrasFormaPago As Button
    Friend WithEvents TxtBuscarFormaPago As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LblFormaDePago As Label
End Class
